using IngenieriaSoftware.BLL.Gestion_Compras_Insumos;
using IngenieriaSoftware.Servicios.DTOs;
using IngenieriaSoftware.UI.Common;
using IngenieriaSoftware.UI.Gestion_Compras_Insumos;
using IngenieriaSoftware.UI.Interfaces;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace IngenieriaSoftware.UI.ComprasProveedores
{
    public partial class ModalSeleccionProdutosOrdenCompra : Form, IActualizable
    {
        private List<ProductoOrdenCompraViewModel> _ProductosOrdenCompra;
        private List<ProductoOrdenCompraViewModel> _ProductosListado;

        private Timer avisoTimer;
        private int tiempoRestante;
        private const int duracionMiliseg = 1000; 
        private const int intervaloMiliseg = 100; 

        public ModalSeleccionProdutosOrdenCompra(List<ProductoOrdenCompraViewModel> productos)
        {
            InitializeComponent();
            Inicializar(productos);

        }

        private void Inicializar(List<ProductoOrdenCompraViewModel> productos)
        {
            _ProductosOrdenCompra = productos;
            _ProductosListado = new List<ProductoOrdenCompraViewModel>();
            Actualizar();

            avisoTimer = new Timer();
            avisoTimer.Interval = intervaloMiliseg;
            avisoTimer.Tick += timerProductoAgregado_Tick;

            lblProductoAgregadoTimer.Visible = false;
            lblProductoAgregadoTimer.Text = "Producto agregado!";
        }   

        public void Actualizar()
        {
            ListaProductos();
        }

        private void ListaProductos()
        {
            _ProductosListado = new ProductoOrdenCompraBussiness().GetProductosToOrdenCompra();
            dgvConFiltroProductos.CargarDatos(_ProductosListado);
            dgvConFiltroProductos.OcultarColumna("Cantidad");   
            dgvConFiltroProductos.AddButtonAgregarColumna(AgregarProductoSeleccionado);
        }   

        private void btnAgregarNuevo_Click(object sender, EventArgs e)
        {
            var formMDI = this.MdiParent as FormMDI;
            new FormGestionarProductos().AbrirFormModal();

            Actualizar();
        }

        public void AgregarProductoSeleccionado()
        {
            try
            {
                var productoSeleccionado = (ProductoOrdenCompraViewModel)dgvConFiltroProductos.ElementoSeleccionado;

                ThrowIfProductoIsNull(productoSeleccionado);

                AgregarProductoOrdenCompra(productoSeleccionado);

                ActualizarListado(productoSeleccionado);
            }
            catch (Exception ex)
            {
                System.Windows.MessageBox.Show(ex.Message);
            }
        }

        private static void ThrowIfProductoIsNull(ProductoOrdenCompraViewModel productoSeleccionado)
        {
            if (productoSeleccionado == null)
                throw new Exception("Debe seleccionar un producto");
        }

        private void AgregarProductoOrdenCompra(ProductoOrdenCompraViewModel productoSeleccionado)
        {
            var productoExistente = (ProductoOrdenCompraViewModel)_ProductosOrdenCompra
                .Find(p => p.IdProducto == productoSeleccionado.IdProducto);

            if (productoExistente != null)
                productoExistente.Cantidad += 1;
            else
            {
                productoSeleccionado.Cantidad = 1;
                _ProductosOrdenCompra.Add(productoSeleccionado);
            }

        }

        private void ActualizarListado(ProductoOrdenCompraViewModel productoSeleccionado)
        {
           // ModificarProductoAgregadoExtension(productoSeleccionado);

            MostrarAviso();

            dgvConFiltroProductos.CargarDatos(_ProductosListado);
        }

        private void ModificarProductoAgregadoExtension(ProductoOrdenCompraViewModel productoSeleccionado)
        {
            var productoAgregado = (ProductoOrdenCompraViewModel)_ProductosListado
                .Find(p => p.IdProducto == productoSeleccionado.IdProducto);

            if (productoAgregado == null)
            {
                this.Close();
                throw new Exception("Error al agregar el producto.");
            }

            productoAgregado.Cantidad = productoSeleccionado.Cantidad;
        }

        // Método para mostrar el aviso
        private void MostrarAviso()
        {
            tiempoRestante = duracionMiliseg;
            lblProductoAgregadoTimer.Visible = true;
            lblProductoAgregadoTimer.ForeColor = Color.MediumSpringGreen; 
            avisoTimer.Start();
        }

        private void timerProductoAgregado_Tick(object sender, EventArgs e)
        {
            tiempoRestante -= intervaloMiliseg;

            // Calcular opacidad proporcional
            float progreso = (float)tiempoRestante / duracionMiliseg;
            int alpha = (int)(255 * progreso);

            lblProductoAgregadoTimer.ForeColor = Color.FromArgb(alpha, Color.MediumSpringGreen);

            if (tiempoRestante <= 0)
            {
                avisoTimer.Stop();
                lblProductoAgregadoTimer.Visible = false;
            }
        }
    }
}
