using IngenieriaSoftware.BEL;
using IngenieriaSoftware.BEL.Constantes;
using IngenieriaSoftware.BEL.OrdenDeCompra;
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

            //cbProveedor.DataSource = proveedores.Select(p => p.RazonSocial).ToList();
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
                              : ((ProveedorListSimpleViewModel)cbProveedor.SelectedItem).IdProveedor,
                Fecha = dtpFechaEmision.Value,
                FechaEntregaEsperada = dtpFechaEntregaEsperada.Checked 
                                        ? dtpFechaEntregaEsperada.Value 
                                        : null,
                CondicionesPago = txtCondicionesPago.Text,
                Moneda = txtMoneda.Text,
                TipoCambio = txtNumericTipoCambio.Text.Equals(string.Empty)
                                       ? 0
                                       : decimal.Parse(txtNumericTipoCambio.Text),
                Estado = OrdenCompraEstado.Pendiente,
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

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            var formMDI = this.MdiParent as FormMDI;
            formMDI.AbrirFormHijo(new FormListaOrdenCompra());
        }
    }
}
