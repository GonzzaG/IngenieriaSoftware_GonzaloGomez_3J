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
            cbProveedor.DataSource = proveedores.Select(p => p.RazonSocial).ToList();

        }

        private void ListarProductos()
        {
            //Aca se van a ir cargando los productos que se van agregando a la orden de compra
            dgvProductosOrdenCompra.CargarDatos(_ProductosOrdenCompra);

            if (_ProductosOrdenCompra is null || _ProductosOrdenCompra.Count == 0)
                return;

            // Supongamos que la columna se llama "IdProducto"
            //dgvProductosOrdenCompra.OcultarColumna("Cantidad");
            dgvProductosOrdenCompra.OcultarColumna("IdProducto");
            AgregarColumnaCantidad();
            dgvProductosOrdenCompra.PermitirEdicionSoloEn("Cantidad");
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

        private void QuitarProductoSeleccionado()
        {
            var productoAEliminar = (ProductoOrdenCompraViewModel)dgvProductosOrdenCompra.ElementoSeleccionado;
            if (productoAEliminar != null)
            {
                _ProductosOrdenCompra.Remove(productoAEliminar);
                Actualizar();
            }
        }

        public void GuardarOrdenDeCompra()
        {
            var ordenCompra = new OrdenDeCompraModel
            {
                NumOrdenCompra = txtNumeroOrdenCompra.Text,
                IdProveedor = ((ProveedorListSimpleViewModel)cbProveedor.SelectedItem).IdProveedor,
                Fecha = dtpFechaEmision.Value,
                FechaEntregaEsperada = dtpFechaEntregaEsperada.Value,
                CondicionesPago = txtCondicionesPago.Text,
                Moneda = txtMoneda.Text,
                TipoCambio = decimal.Parse(txtNumericTipoCambio.Text),
                Estado = OrdenCompraEstado.Pendiente,
                TotalEsperado = int.Parse(txtNumericTotalEsperado.Text.ToString()),
                Observaciones = txtAreaObservaciones.Text,
                FechaCreacion = DateTime.Now,
                UsuarioCreacion = SessionManager.GetInstance.Usuario.Username
            };


        }

        private void btnAgregarCategoria_Click(object sender, EventArgs e)
        {
            try
            {
                GuardarOrdenDeCompra();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSeleccionarProductos_Click(object sender, EventArgs e)
        {
            var formMDI = this.MdiParent as FormMDI;
            new ModalSeleccionProdutosOrdenCompra(_ProductosOrdenCompra).AbrirFormModal();

            Actualizar();
        }
    }
}
