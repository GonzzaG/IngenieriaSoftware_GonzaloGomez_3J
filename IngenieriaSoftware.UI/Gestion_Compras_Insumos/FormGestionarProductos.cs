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
            dgvProductos.ActualizarDataSource(new ProductoBLL().GetAll());
            dgvProductos.PersonalizarEstiloPredeterminado();
        }

        private void ListarCategorias()
        {
            var categorias = new CategoriaBussines().GetAll();
            int[] catVector = new int[categorias.Count()];

            cbCategoria.ActualizarComboBox<Categoria>(new CategoriaBussines().GetAll());
        }

        void IActualizable.Actualizar()
        {
            Actualizar();
        }

        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            try
            {
                VerificarCamposGuardar();
                var categoria =  cbCategoria.Text;
                var producto = new Producto
                {
                    Nombre = txtNombre.Text,
                    Descripcion = txtDescripcion.Text,
                    oCategoria = cbCategoria.Text == string.Empty ?
                                   throw new Exception("Debe seleccionar una categoria") :
                                   new CategoriaBussines().GetCategoriaByNombre(cbCategoria.Text),
                    Precio = (decimal)nudPrecio.Value,
                    TiempoPreparacion = (int)nudTiempoPreparacion.Value,
                    Disponible = cbDisponible.Checked,
                    EsPostre = cbEsPostre.Checked,
                    
                };

                new ProductoBLL().Save(producto);

                Actualizar();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void VerificarCamposGuardar()
        {
            if (txtNombre.Text == string.Empty
               || txtDescripcion.Text == string.Empty
               || cbCategoria.SelectedItem is null
               || nudTiempoPreparacion.Value < 1
               || nudPrecio.Value < 1)

                throw new Exception("Verificar los datos ingresados");
        }

        private void btnEliminarProducto_Click(object sender, EventArgs e)
        {
            try
            {
                int id = dgvProductos.SelectedRows.Count > 0 ? (int)dgvProductos.SelectedRows[0].Cells[nameof(Producto.ProductoId)].Value :
                    throw new Exception("Debe seleccionar un producto");

                new ProductoBLL().DeleteById(id);
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
