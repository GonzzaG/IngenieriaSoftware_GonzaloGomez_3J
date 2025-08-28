using IngenieriaSoftware.BEL;
using IngenieriaSoftware.BEL.Gestion_Compras_Insumos;
using IngenieriaSoftware.BLL;
using IngenieriaSoftware.BLL.Gestion_Compras_Insumos;
using IngenieriaSoftware.Servicios.Tools;
using IngenieriaSoftware.UI.Interfaces;
using System;

using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using IngenieriaSoftware.BEL.QueryModels;
namespace IngenieriaSoftware.UI.Gestion_Compras_Insumos
{
    public partial class FormGestionarProductos : Form, IVerificoNotificaciones
    {
        public FormGestionarProductos()
        {
            InitializeComponent();
            Inicializar();
            
        }

        public NotificacionService _notificacionService => new NotificacionService();
        public void VerificarNotificaciones()
        {
        }

        private void Inicializar()
        {
            #region Filtros
            filtroNombreProducto.InicializarFiltro(ListarProductos);
            filtroCodigoProducto.InicializarFiltro(ListarProductos);

            #endregion
            Actualizar();
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
            var filtro = MappearFiltros();

            
            gcfProductos.CargarDatos(new ProductoBLL().GetWithFiltro(filtro));
            //else
            //    gcfProductos.CargarDatos(new ProductoBLL().GetAll());
        }

        private FiltroQueryModel MappearFiltros()
        {
            return new FiltroQueryModel
            {
                Nombre = filtroNombreProducto.Text ,
                Id = int.Parse(filtroCodigoProducto.Text),
            };
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
                var categoria = cbCategoria.Text;
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
                
                int id = gcfProductos.CantidadElementos;
                if(id.Equals(0))
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
