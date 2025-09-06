using IngenieriaSoftware.BEL;
using IngenieriaSoftware.BLL;
using IngenieriaSoftware.BLL.Gestion_Compras_Insumos;
using IngenieriaSoftware.Servicios.Tools;
using IngenieriaSoftware.UI.Common;
using IngenieriaSoftware.UI.Gestion_Compras_Insumos;
using IngenieriaSoftware.UI.Interfaces;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows;
using System.Windows.Forms;

namespace IngenieriaSoftware.UI.ComprasProveedores
{
    public partial class ModalSeleccionProdutosOrdenCompra : Form, IActualizable
    {
        private List<Producto> _Productos;

        private Timer avisoTimer;
        private int tiempoRestante;
        private const int duracionMiliseg = 1000; 
        private const int intervaloMiliseg = 100; 


        public ModalSeleccionProdutosOrdenCompra(List<Producto> productos)
        {
            InitializeComponent();
            Inicializar(productos);

        }

        private void Inicializar(List<Producto> productos)
        {
            _Productos = productos;
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
            dgvConFiltroProductos.CargarDatos(new ProductoOrdenCompraBussiness().GetProductosToOrdenCompra());
            dgvConFiltroProductos.AddButtonAgregarColumna();
        }   

        private void btnAgregarNuevo_Click(object sender, EventArgs e)
        {
            var formMDI = this.MdiParent as FormMDI;
            new FormGestionarProductos().AbrirFormModal();

            Actualizar();
        }
            
        private void btnSeleccionar_Click_1(object sender, EventArgs e)
        {
            try
            {
                var productoSeleccionado = (Producto)dgvConFiltroProductos.ElementoSeleccionado;
                
                if (productoSeleccionado == null)
                    throw new Exception("Debe seleccionar un producto");

                _Productos.Add(productoSeleccionado);
                MostrarAviso();

            }
            catch (Exception ex)
            {
                System.Windows.MessageBox.Show(ex.Message);
            }
        }


        // Método para mostrar el aviso
        private void MostrarAviso()
        {
            tiempoRestante = duracionMiliseg;
            lblProductoAgregadoTimer.Visible = true;
            lblProductoAgregadoTimer.ForeColor = Color.Black; // reinicia a opaco
            avisoTimer.Start();
        }
        private void timerProductoAgregado_Tick(object sender, EventArgs e)
        {
            tiempoRestante -= intervaloMiliseg;

            // Calcular opacidad proporcional
            float progreso = (float)tiempoRestante / duracionMiliseg;
            int alpha = (int)(255 * progreso);

            lblProductoAgregadoTimer.ForeColor = Color.FromArgb(alpha, lblProductoAgregadoTimer.ForeColor.R, lblProductoAgregadoTimer.ForeColor.G, lblProductoAgregadoTimer.ForeColor.B);

            if (tiempoRestante <= 0)
            {
                avisoTimer.Stop();
                lblProductoAgregadoTimer.Visible = false;
            }
        }
    }
}
