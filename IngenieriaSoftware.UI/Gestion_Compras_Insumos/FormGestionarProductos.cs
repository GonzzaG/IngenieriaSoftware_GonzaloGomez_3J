using IngenieriaSoftware.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IngenieriaSoftware.Servicios.Tools;
using IngenieriaSoftware.BLL.Gestion_Compras_Insumos;
using IngenieriaSoftware.BEL.Gestion_Compras_Insumos;
using IngenieriaSoftware.BEL;
namespace IngenieriaSoftware.UI.Gestion_Compras_Insumos
{
    public partial class FormGestionarProductos : Form, IActualizable
    {
        public FormGestionarProductos()
        {
            InitializeComponent();
            Actualizar();
        }

        public NotificacionService _notificacionService => new NotificacionService();

        public void VerificarNotificaciones()
        {
        }

        private void Actualizar()
        {
            ListarProductos();
            LimpiarFormulario();
            ListarCategorias();
        }
        
        void LimpiarFormulario()
        {
            groupBoxProducto.LimpiarControles(typeof(Button), typeof(Label));
        }
        private void ListarProductos()
        {
            dgvProductos.ActualizarDataSource(new ProductoBLL().ObtenerTodosLosProductos());
            dgvProductos.PersonalizarEstiloPredeterminado();
        }

        private void ListarCategorias()
        {
            cbCategoria.ActualizarComboBox(new CategoriaBussines().GetAll());
        }

        void IActualizable.Actualizar()
        {
            Actualizar();
        }

        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            try
            {
                var producto = new Producto
                {
                    Nombre = txtNombre.Text,
                    Descripcion = txtDescripcion.Text,
                    oCategoria = cbCategoria.SelectedItem is null ? 
                                cbCategoria.SelectedItem as Categoria : 
                                throw new Exception("Debe seleccionar una categoria"),
                    Precio = (decimal)nudPrecio.Value,
                    TiempoPreparacion = (int)nudTiempoPreparacion.Value,
                    Diponible = cbDisponible.Checked,
                    EsPostre = cbEsPostre.Checked,

                };

                
                new ProductoBLL()

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnEliminarProducto_Click(object sender, EventArgs e)
        {
            try
            {

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {

            }   
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAgregarCategoria_Click(object sender, EventArgs e)
        {
            try
            {
                



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
