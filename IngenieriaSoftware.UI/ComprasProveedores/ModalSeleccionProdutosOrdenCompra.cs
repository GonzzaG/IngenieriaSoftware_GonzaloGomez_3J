using IngenieriaSoftware.BEL;
using IngenieriaSoftware.BLL;
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
        private List<ProductoSelectionModel> _ProductosOrdenCompra;
        private List<ProductoSelectionModel> _ProductosListado;

        private Timer avisoTimer;
        private int tiempoRestante;
        private const int duracionMiliseg = 1000; 
        private const int intervaloMiliseg = 100; 

        public ModalSeleccionProdutosOrdenCompra(List<ProductoSelectionModel> productos)
        {
            if (productos is null)
                throw new Exception("La lista de productos no puede ser nula");
            InitializeComponent();
            Inicializar(productos);

        }

        private void Inicializar(List<ProductoSelectionModel> productos)
        {
            _ProductosOrdenCompra = productos;
            _ProductosListado = new List<ProductoSelectionModel>();

            inputNombreFiltroOrdenCompra.InicializarFiltro(ListarProductos);
            Actualizar();
            InicializarTimerProductoAgregado();

        }

        private void InicializarTimerProductoAgregado()
        {
            avisoTimer = new Timer();
            avisoTimer.Interval = intervaloMiliseg;
            avisoTimer.Tick += timerProductoAgregado_Tick;

            lblProductoAgregadoTimer.Visible = false;
            lblProductoAgregadoTimer.Text = "Producto agregado!";
        }

        public void Actualizar()
        {
            ListarProductos();
        }

        private void ListarProductos()
        {
            try
            {
                // Obtener los productos los cuales no son de tipo "Venta"

                if (inputNombreFiltroOrdenCompra.Texto == string.Empty)
                    _ProductosListado = new ProductoOrdenCompraBussiness().GetProductosToOrdenCompra();
                else
                    _ProductosListado = new ProductoOrdenCompraBussiness().GetProductosToOrdenCompraByNombre(inputNombreFiltroOrdenCompra.Texto);

                //if (productos is not null && productos.Count > 0)
                //{
                //    _ProductosListado.Clear();

                //    productos.ForEach(p => _ProductosListado.Add(new ProductoSelectionModel()
                //    {
                //        IdProducto = p.Id,
                //        Nombre = p.Nombre,
                //        Descripcion = p.Descripcion,
                //        PrecioUnitarioEsperado = p.Precio,
                //        Cantidad = 0
                //    }));
                //}

                dgvConFiltroProductos.CargarDatos(_ProductosListado);
                dgvConFiltroProductos.OcultarColumnas("Cantidad", "PrecioUnitarioEsperado");
                dgvConFiltroProductos.AddButtonAgregarColumna(AgregarProductoSeleccionado);
            }
            catch(Exception ex)
            {
               MessageBox.Show(ex.Message);
            }
           
        }   


        public void AgregarProductoSeleccionado()
        {
            try
            {
                var productoSeleccionado = (ProductoSelectionModel)dgvConFiltroProductos.ElementoSeleccionado;

                ThrowIfProductoIsNull(productoSeleccionado);

                AgregarProductoOrdenCompra(productoSeleccionado);

                ActualizarListado(productoSeleccionado);
            }
            catch (Exception ex)
            {
                System.Windows.MessageBox.Show(ex.Message);
            }
        }

        private static void ThrowIfProductoIsNull(ProductoSelectionModel productoSeleccionado)
        {
            if (productoSeleccionado == null)
                throw new Exception("Debe seleccionar un producto");
        }

        private void AgregarProductoOrdenCompra(ProductoSelectionModel productoSeleccionado)
        {
            var productoExistente = (ProductoSelectionModel)_ProductosOrdenCompra
                .Find(p => p.IdProducto == productoSeleccionado.IdProducto);

            if (productoExistente != null)
                productoExistente.Cantidad += 1;
            else
            {
                productoSeleccionado.Cantidad = 1;
                _ProductosOrdenCompra.Add(productoSeleccionado);
            }

        }

        private void ActualizarListado(ProductoSelectionModel productoSeleccionado)
        {
            MostrarAviso();

            dgvConFiltroProductos.CargarDatos(_ProductosListado);
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

        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            new FormGestionarProductos().AbrirFormModal();

            Actualizar();
        }
    }
}
