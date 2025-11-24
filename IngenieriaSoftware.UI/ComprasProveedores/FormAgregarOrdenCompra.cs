using IngenieriaSoftware.BEL.Constantes;
using IngenieriaSoftware.BEL.OrdenDeCompra;
using IngenieriaSoftware.BEL.OrdenDeCompra.Models;
using IngenieriaSoftware.BEL.OrdenDeCompra.ViewModels;
using IngenieriaSoftware.BLL.Gestion_Compras_Insumos;
using IngenieriaSoftware.BLL.ListSimpleBussiness;
using IngenieriaSoftware.Servicios;
using IngenieriaSoftware.Servicios.DTOs;
using IngenieriaSoftware.Servicios.DTOs.ListSimple;
using IngenieriaSoftware.UI.Common;
using IngenieriaSoftware.UI.Interfaces;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace IngenieriaSoftware.UI.ComprasProveedores
{
    public partial class FormAgregarOrdenCompra : Form, IActualizable
    {
        private List<ProductoSelectionModel> _ProductosOrdenCompra { get; set; }
        private OrdenCompraWithDetalles _OrdenDeCompra { get; set; }

        private ProveedorListSimpleModel _ProveedorSeleccionado { get; set; }

        private bool isEdit = false;
        public FormAgregarOrdenCompra(string numOrdenCompra)
        {
            InitializeComponent();
            try
            {
                InicializarVistaAutorizacionOrden(numOrdenCompra);
                isEdit = true;
            }
            catch(Exception ex)
            {
                this.Close();
                throw new Exception(ex.Message);
            }
        }


        private void InicializarVistaAutorizacionOrden(string numOrdenCompra)
        {
            BuscarOrdenSeleccionada(numOrdenCompra);


            // Ponemos los datos de la orden de compra dentro de los componentes
        }
        private void BuscarOrdenSeleccionada(string numOrdenCompra)
        {
            var filtro = new OrdenCompraQuery
            {
                NumOrdenCompra = numOrdenCompra,
                IdEstado = (int)OrdenCompraEstadoEnum.Pendiente,
            };
            _OrdenDeCompra = new OrdenCompraBussiness().GetOrdenCompraByNumero(numOrdenCompra);

        }

        /// <summary>
        /// Esta funcion se encarga de cargar los datos de la orden de compra en los controles del formulario
        /// </summary>
        /// <param name="orden"></param>
        private void PrepararVistaAutorizacionOrden(OrdenCompraWithDetalles orden)
        {
            txtAreaObservaciones.Text = orden.Observaciones;
            txtCondicionesPago.Text = orden.CondicionesPago;
            txtMoneda.Text = orden.Moneda;
            txtNumericTipoCambio.Text = orden.TipoCambio.ToString();
            txtNumericTotalEsperado.Text = orden.TotalEsperado.ToString();
            txtNumeroOrdenCompra.Text = orden.NumOrdenCompra;
            dtpFechaEmision.Value = orden.Fecha;
            if (orden.FechaEntregaEsperada.HasValue)
            {
                dtpFechaEntregaEsperada.Value = orden.FechaEntregaEsperada.Value;
                dtpFechaEntregaEsperada.Checked = true;
            }
            else
                dtpFechaEntregaEsperada.Checked = false;
            // Seleccionamos el proveedor en el comboBox
            ListarProveedores();
            if (orden is not null && orden.NumOrdenCompra != null)
            {
                var proveedorSeleccionado = ((List<ProveedorListSimpleModel>)cbProveedor.DataSource)
                                            .FirstOrDefault(p => p.RazonSocial == orden.RazonSocialProveedor);
                if (proveedorSeleccionado != null)
                    cbProveedor.SelectedItem = proveedorSeleccionado;
            }
            // Cargamos los productos de la orden de compra en el DataGridView
            dgvProductosOrdenCompra.CargarDatos(_OrdenDeCompra.Detalles);

        }

        private void DeshabilitarControles()
        {
            txtNumeroOrdenCompra.Enabled = false;
            dtpFechaEmision.Enabled = false;
            dtpFechaEntregaEsperada.Enabled = false;
            cbProveedor.Enabled = false;
            txtAreaObservaciones.Enabled = false;
            txtNumericTotalEsperado.Enabled = false;
            txtMoneda.Enabled = false;
            txtNumericTipoCambio.Enabled = false;
            txtCondicionesPago.Enabled = false;

            btnSeleccionarProductos.Visible = false;
            btnGenerarOrdenCompra.Visible = false;

            btnAceptarOrden.Visible = true;
            btnRechazarOrden.Visible = true;
        }

        private void HabilitarControles()
        {
            txtNumeroOrdenCompra.Enabled = true;
            dtpFechaEmision.Enabled = true;
            dtpFechaEntregaEsperada.Enabled = true;
            cbProveedor.Enabled = true;
            txtAreaObservaciones.Enabled = true;
            txtNumericTotalEsperado.Enabled = true;
            txtMoneda.Enabled = true;
            txtNumericTipoCambio.Enabled = true;
            txtCondicionesPago.Enabled = true;

            btnSeleccionarProductos.Visible = true;
            btnGenerarOrdenCompra.Visible = true;
            btnAceptarOrden.Visible = false;
            btnRechazarOrden.Visible = false;
        }

        public FormAgregarOrdenCompra()
        {
            isEdit = false;
            InitializeComponent();
            Incializar();
        }

        public void Incializar()
        {
            _ProductosOrdenCompra = new List<ProductoSelectionModel>();
            Actualizar();
        }
        public void Actualizar()
        {
            ListarProductos();
            ListarProveedores();
        }

        private void ListarProveedores()
        {
            var proveedores = new ListSimpleBussiness().GetProveedoresListSimple();

            cbProveedor.DataSource = proveedores;

            cbProveedor.DisplayMember = "RazonSocial";
            cbProveedor.ValueMember = "IdProveedor";
            GetProveedorSeleccionado(proveedores);

        }

        private void GetProveedorSeleccionado(List<ProveedorListSimpleModel> proveedores)
        {
            if (_ProveedorSeleccionado is not null)
            {
                var p = proveedores.First(p => p.IdProveedor == _ProveedorSeleccionado.IdProveedor);

                if (p is not null)
                    cbProveedor.SelectedItem = p;

                Console.WriteLine("proveedor: " + ((ProveedorListSimpleModel)cbProveedor.SelectedItem).RazonSocial);
            }


        }

        private void ListarProductos()
        {
            //Aca se van a ir cargando los productos que se van agregando a la orden de compra
            dgvProductosOrdenCompra.CargarDatos(_ProductosOrdenCompra);

            if (_ProductosOrdenCompra is null || _ProductosOrdenCompra.Count == 0)
                return;

            dgvProductosOrdenCompra.OcultarColumnas("IdProducto");
            AgregarColumnaCantidad();
            AgregarColumnaPrecioUnitarioEsperado();
            dgvProductosOrdenCompra.PermitirEdicionSoloEn("Cantidad", "PrecioUnitarioEsperado");
            // Cambiar color de fondo y fuente solo a la columna "Cantidad"
            dgvProductosOrdenCompra.AddButtonQuitarColumna(QuitarProductoSeleccionado);
        }

        private void AgregarColumnaCantidad()
        {
            dgvProductosOrdenCompra.AddNumericCantidadColumna((elemento) =>
            {
                var prod = elemento as ProductoSelectionModel;
                if (prod != null && int.TryParse(prod.Cantidad.ToString(), out int nuevoValor))
                    prod.Cantidad = nuevoValor;

            });

        }

        private void AgregarColumnaPrecioUnitarioEsperado()
        {
            dgvProductosOrdenCompra.AddNumericPrecioUnitarioColumna((elemento) =>
            {
                var prod = elemento as ProductoSelectionModel;
                if (prod != null && int.TryParse(prod.PrecioUnitarioEsperado.ToString(), out int nuevoValor))
                    prod.PrecioUnitarioEsperado = nuevoValor;

            });

        }

        private void QuitarProductoSeleccionado()
        {
            var productoAEliminar = (ProductoSelectionModel)dgvProductosOrdenCompra.ElementoSeleccionado;
            if (productoAEliminar != null)
            {
                _ProductosOrdenCompra.Remove(productoAEliminar);
                Actualizar();
            }
        }

        public string GuardarOrdenDeCompra()
        {
            var ordenCompra = new OrdenDeCompraModel
            {
                NumOrdenCompra = txtNumeroOrdenCompra.Text,
                IdProveedor = cbProveedor.SelectedItem == null
                              ? 0
                              : ((ProveedorListSimpleModel)cbProveedor.SelectedItem).IdProveedor,
                Fecha = dtpFechaEmision.Value,
                FechaEntregaEsperada = dtpFechaEntregaEsperada.Checked
                                        ? dtpFechaEntregaEsperada.Value
                                        : null,
                CondicionesPago = txtCondicionesPago.Text,
                Moneda = txtMoneda.Text,
                TipoCambio = ObtenerValorDeInputNumerico(txtNumericTipoCambio.Text),
                Estado = OrdenCompraEstadoEnum.Pendiente,
                TotalEsperado = ObtenerValorDeInputNumerico(txtNumericTotalEsperado.Text),
                Observaciones = txtAreaObservaciones.Text,


                Detalles = (from producto in _ProductosOrdenCompra
                            select new ConvertirDetallesAprobacionDataSet
                            {
                                IdProducto = producto.IdProducto,
                                Cantidad = producto.Cantidad,
                                PrecioUnitarioEsperado = producto.PrecioUnitarioEsperado,
                                NotasLinea = txtAreaObservaciones.Text,

                            }).ToList()
            };
            new OrdenCompraBussiness().Guardar(ordenCompra);

            return ordenCompra.NumOrdenCompra;
        }

        private decimal ObtenerValorDeInputNumerico(string totalEsperado)
        {
            decimal.TryParse(totalEsperado, out decimal total);
            return total;
        }


        private void btnSeleccionarProductos_Click(object sender, EventArgs e)
        {
            //  Guardamos le proveeodor seleccionado para que cuando se renderice le formulario se vuelva a oclocar el mismo
            GuardarProveedorSeleccionado();

            new ModalSeleccionProdutosOrdenCompra(_ProductosOrdenCompra).AbrirFormModal(new Size(954, 722));

            Actualizar();
        }

        private void GuardarProveedorSeleccionado()
        {
            if (cbProveedor.SelectedItem is not null && cbProveedor.SelectedItem is ProveedorListSimpleModel p)
                _ProveedorSeleccionado = p;
        }

        private void btnGenerarOrdenCompra_Click(object sender, EventArgs e)
        {
            try
            {
                var numOrdenCompra = GuardarOrdenDeCompra();

                CommonForms.MensajeInformativo($"Orden de compra {numOrdenCompra} generada correctamente");

                this.Redireccionar(new FormListaOrdenCompra(OrdenCompraEstadoEnum.Aprobada));
            }
            catch (Exception ex)
            {
                ex.Message.MensajeInformativo();
            }
        }

        private void FormAgregarOrdenCompra_Load(object sender, EventArgs e)
        {
            if (isEdit)
            {
                PrepararVistaAutorizacionOrden(_OrdenDeCompra);
                // Deshabilitamos todos los controles para que no se puedan editar
                DeshabilitarControles();
                dgvProductosOrdenCompra.OcultarColumnas("IdDetalle", "IdProducto", "IdOrdenCompra");
            }
            else
            {
                HabilitarControles();
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

            var formMDI = this.MdiParent as FormMDI;
            if (isEdit)
                this.Close();
            else
                formMDI.AbrirFormHijo(new FormListaOrdenCompra());
        }

        private void btnRechazarOrden_Click(object sender, EventArgs e)
        {
            //Se cancelara la orden de compra generada, por lo cual se pasará al estado de rechazada y se pondrá quien la rechazó
            var dialog = MessageBox.Show("¿Está seguro que desea rechazar la orden de compra?", "Confirmar Rechazo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialog == DialogResult.Yes)
            {
                new OrdenCompraBussiness().SetOrdenCompraRechazada(_OrdenDeCompra.IdOrdenCompra);


                CommonForms.MensajeInformativo("Orden de compra rechazada correctamente.");
                this.Close();
            }


        }

        private void btnAceptarOrden_Click(object sender, EventArgs e)
        {
            //Se pasara el estado de la orden de compra a aceptada, y se pondrá quien la aceptó
            var dialog = MessageBox.Show("¿Está seguro que desea aceptar la orden de compra?", "Confirmar Aceptación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {
                new OrdenCompraBussiness().SetOrdenCompraAceptada(_OrdenDeCompra.IdOrdenCompra);
                CommonForms.MensajeInformativo("Orden de compra aceptada correctamente.");
                this.Close();
            }
        }

        private void FormAgregarOrdenCompra_Shown(object sender, EventArgs e)
        {
            this.AutoScrollPosition = new Point(0, 0);
        }
    }
}
