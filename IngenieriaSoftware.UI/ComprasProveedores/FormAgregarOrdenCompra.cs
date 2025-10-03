using IngenieriaSoftware.BEL;
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
using System.Windows.Controls;
using System.Windows.Forms;

namespace IngenieriaSoftware.UI.ComprasProveedores
{
    public partial class FormAgregarOrdenCompra : Form, IActualizable
    {
        private List<ProductoOrdenCompraViewModel> _ProductosOrdenCompra { get; set; }
        private OrdenCompraGetDetalles _OrdenDeCompra { get; set; }

        private bool isEdit=false;
        public FormAgregarOrdenCompra(string numOrdenCompra)
        {
            InitializeComponent();
            InicializarVistaAutorizacionOrden(numOrdenCompra);
            isEdit = true;
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
        private void PrepararVistaAutorizacionOrden(OrdenCompraGetDetalles orden)
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
            foreach (System.Windows.Forms.Control control in this.Controls)
            {
                if (control.ForeColor == Color.Red)
                    control.Visible = false;
                else
                    control.Enabled = false;
            }
        }

        public FormAgregarOrdenCompra()
        {
            InitializeComponent();
            Incializar();
        }

        public void Incializar()
        {
            _ProductosOrdenCompra = new List<ProductoOrdenCompraViewModel>();
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

        }

        private void ListarProductos()
        {
            //Aca se van a ir cargando los productos que se van agregando a la orden de compra
            dgvProductosOrdenCompra.CargarDatos(_ProductosOrdenCompra);

            if (_ProductosOrdenCompra is null || _ProductosOrdenCompra.Count == 0)
                return;

            // Supongamos que la columna se llama "IdProducto"
            //dgvProductosOrdenCompra.OcultarColumnas("Cantidad");
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
                var prod = elemento as ProductoOrdenCompraViewModel;
                if (prod != null && int.TryParse(prod.Cantidad.ToString(), out int nuevoValor))
                    prod.Cantidad = nuevoValor;

            });

        }

        private void AgregarColumnaPrecioUnitarioEsperado()
        {
            dgvProductosOrdenCompra.AddNumericPrecioUnitarioColumna((elemento) =>
            {
                var prod = elemento as ProductoOrdenCompraViewModel;
                if (prod != null && int.TryParse(prod.PrecioUnitarioEsperado.ToString(), out int nuevoValor))
                    prod.PrecioUnitarioEsperado = nuevoValor;

            });

        }

        private void QuitarProductoSeleccionado()
        {
            var productoAEliminar = (ProductoOrdenCompraViewModel)dgvProductosOrdenCompra.ElementoSeleccionado;
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
                TipoCambio = txtNumericTipoCambio.Text.Equals(string.Empty)
                                       ? 0
                                       : decimal.Parse(txtNumericTipoCambio.Text),
                Estado = OrdenCompraEstadoEnum.Pendiente,
                TotalEsperado = ObtenerTotalEsperado(txtNumericTotalEsperado.Text),
                Observaciones = txtAreaObservaciones.Text,

                
                Detalles = (from producto in _ProductosOrdenCompra
                            select new OrdenDeCompraDetalleModel
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

        private decimal ObtenerTotalEsperado(string totalEsperado)
        {
            decimal.TryParse(totalEsperado, out decimal total);
            return total;
        }

        private void btnSeleccionarProductos_Click(object sender, EventArgs e)
        {
            var formMDI = this.MdiParent as FormMDI;
            new ModalSeleccionProdutosOrdenCompra(_ProductosOrdenCompra).AbrirFormModal(new Size(954, 722));

            Actualizar();
        }

        private void btnGenerarOrdenCompra_Click(object sender, EventArgs e)
        {
            try
            {
                var numOrdenCompra = GuardarOrdenDeCompra();

                CommonForms.MensajeInformativo($"Orden de compra {numOrdenCompra} generada correctamente");
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
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            var formMDI = this.MdiParent as FormMDI;
            formMDI.AbrirFormHijo(new FormListaOrdenCompra());
        }
    }
}
