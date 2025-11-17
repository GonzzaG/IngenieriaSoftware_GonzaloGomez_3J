using IngenieriaSoftware.BEL;
using IngenieriaSoftware.BEL.Gestion_Compras_Insumos;
using IngenieriaSoftware.BEL.Proveedor;
using IngenieriaSoftware.BLL;
using IngenieriaSoftware.BLL.Gestion_Compras_Insumos;
using IngenieriaSoftware.Servicios.Tools;
using IngenieriaSoftware.UI.Interfaces;
using System;
using System.Collections;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
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
            nudTiempoPreparacion.Value = 0;
            nudPrecio.Value = 0;
        }

        private void ListarProductos()
        {
            try
            {
                if (filtroNombreProducto.Texto == string.Empty)
                    gcfProductos.CargarDatos(new ProductoBLL().GetAll());
                else
                    gcfProductos.CargarDatos(new ProductoBLL().GetByNombre(filtroNombreProducto.Texto));
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                ex.RegistrarError("Gestion de Productos");
            }
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

        private void Modificar()
        {
            var producto = (Producto)gcfProductos.ElementoSeleccionado;

            if (producto is null) throw new Exception("No se ha seleccionado ningun producto para modificar");
          
            new ProductoBLL().Update(new Producto
            {
                Id = producto.Id,
                Nombre = txtNombre.Text,
                Descripcion = txtDescripcion.Text,
                oCategoria = cbCategoria.Text == string.Empty ?
                               throw new Exception("Debe seleccionar una categoria") :
                               new CategoriaBussines().GetCategoriaByNombre(cbCategoria.Text),
                TiempoPreparacion = (int)nudTiempoPreparacion.Value,
                Disponible = cbDisponible.Checked,
                EsPostre = cbEsPostre.Checked,
            });

            LimpiarCampos();
            PrepararAgregar();
        }

        private void PrepararModificacion()
        {
            btnAgregarProducto.Text = "Guardar Cambios";
            btnModificar.Enabled = false;
            btnEliminarProducto.Text = "Cancelar";
            btnModificar.BackColor = Color.Gray;
            gcfProductos.Deshabilitar();
        }

        private void PrepararAgregar()
        {
            btnAgregarProducto.Text = "Guardar";
            btnModificar.Enabled = true;
            btnEliminarProducto.Text = "Eliminar";
            gcfProductos.Habilitar();
            btnModificar.BackColor = Color.Orange;
            LimpiarCampos();
        }

        private void LimpiarCampos()
        {

            IList list = groupBoxProducto.Controls;
            for (int i = 0; i < list.Count; i++)
            {
                Control tb = (Control)list[i];
                switch (tb)
                {
                    case TextBox:
                    case ComboBox:
                        tb.Text = string.Empty;
                        break;
                    case NumericUpDown nud:
                        nud.Value = nud.Minimum;
                        break;
                    case CheckBox cb when cb.Name != "cbDisponible":
                        cb.Checked = false;
                        break;
                }
            }

            Actualizar();
        }

        private void Guardar()
        {
            new ProductoBLL().Save(new Producto
            {
                Nombre = txtNombre.Text,
                Descripcion = txtDescripcion.Text,
                oCategoria = cbCategoria.Text == string.Empty ?
                               throw new Exception("Debe seleccionar una categoria") :
                               new CategoriaBussines().GetCategoriaByNombre(cbCategoria.Text),
                TiempoPreparacion = (int)nudTiempoPreparacion.Value,
                Precio = nudPrecio.Value,
                Disponible = cbDisponible.Checked,
                EsPostre = cbEsPostre.Checked,
            });
        }

        private void VerificarCamposGuardar()
        {
            if (txtNombre.Text == string.Empty
               || txtDescripcion.Text == string.Empty
               || cbCategoria.SelectedItem is null
               || nudTiempoPreparacion.Value < 1)

                throw new Exception("Verificar los datos ingresados");
        }

        private void EliminarProducto()
        {
            if (gcfProductos.CantidadElementos.Equals(0))
                throw new Exception("Debe seleccionar un producto");

            var proveedorId = ((Producto)gcfProductos.ElementoSeleccionado).Id;

            new ProductoBLL().DeleteById(proveedorId);
        }

        private void CargarProductorEnTextos(Producto producto)
        {
            txtNombre.Text = producto.Nombre;
            txtDescripcion.Text = producto.Descripcion;
            cbCategoria.Text = producto.IdCategoria.ToString();

            nudTiempoPreparacion.Value = producto.TiempoPreparacion;
            cbDisponible.Checked = producto.Disponible;
            cbEsPostre.Checked = producto.EsPostre;
        }

        private void btnAgregarProducto_Click_1(object sender, EventArgs e)
        {
            try
            {
                VerificarCamposGuardar();

                if (btnAgregarProducto.Text.Equals("Guardar"))
                    Guardar();
                else
                    Modificar();

                Actualizar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnEliminarProducto_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (btnEliminarProducto.Text.Equals("Eliminar"))
                    EliminarProducto();
                else
                    PrepararAgregar();

                Actualizar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnModificar_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (gcfProductos.CantidadElementos.Equals(0)) throw new Exception("Seleccione un producto para modificarlo");

                CargarProductorEnTextos((Producto)gcfProductos.ElementoSeleccionado);

                PrepararModificacion();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
