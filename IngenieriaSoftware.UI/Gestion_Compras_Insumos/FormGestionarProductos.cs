using IngenieriaSoftware.BEL;
using IngenieriaSoftware.BEL.Gestion_Compras_Insumos;
using IngenieriaSoftware.BLL;
using IngenieriaSoftware.BLL.Gestion_Compras_Insumos;
using IngenieriaSoftware.UI.ControlesPersonalizados.Inputs;
using IngenieriaSoftware.UI.Interfaces;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
namespace IngenieriaSoftware.UI.Gestion_Compras_Insumos
{
    public partial class FormGestionarProductos : Form, IVerificoNotificaciones
    {
        List<Producto> _ListaProductos = new List<Producto>();

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
            ListarTipos();
            ListarCategorias();
        }
        private void Actualizar()
        {
            ListarProductos();
            LimpiarFormulario();
        }

        private void ListarTipos()
        {
            var tipos = new TiposBusiness().GetProductosTipo();

            #region ComboBox Tipo Detalle
            cbcTipoDetalle.Items.Clear();
            var tipoDetalle = new List<string>() { "Seleccione..." };
            tipoDetalle.AddRange(tipos);
            cbcTipoDetalle.DataSource = tipoDetalle;
            #endregion

            #region ComboBox Tipo Filtro
            cbcTipo.Items.Clear();
            var tiposCombo = new List<string>() { "Todos" };
            tiposCombo.AddRange(tipos);
            cbcTipo.DataSource = tiposCombo;
            #endregion
        }

        void LimpiarFormulario()
        {
            //groupBoxProducto.LimpiarControles(typeof(Button), typeof(Label));
            txtNombre.Text = string.Empty;
            txtDescripcion.Text = string.Empty;
            cbDisponible.Checked = false;
            cbEsPostre.Checked = false;
            nudTiempoPreparacion.Value = 0;
            nudPrecio.Value = 0;
        }

        private void ListarProductos()
        {
            try
            {

                if (filtroNombreProducto.Texto == string.Empty)
                    _ListaProductos = new ProductoBLL().GetAll();
                else
                    _ListaProductos = new ProductoBLL().GetByNombre(filtroNombreProducto.Texto);

                FiltrarPorTipo(ref _ListaProductos);

                gcfProductos.CargarDatos(_ListaProductos);

                gcfProductos.OcultarColumnas("oCategoria", "Id", "Cantidad");

                gcfProductos.RenombrarColumna("Categoria", "Categoria");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                ex.RegistrarError("Gestion de Productos");
            }
        }

        private void ListarCategorias()
        {
            cbCategoria.Items.Clear();  
            var categorias = new List<Categoria>() { new Categoria { Id = 0, Nombre = "Seleccione..." } };
            categorias.AddRange(new CategoriaBussines().GetAll());

            cbCategoria.DataSource = categorias;    
        }

        void IActualizable.Actualizar()
        {
            Actualizar();
        }

        private void Modificar()
        {
            var producto = (Producto)gcfProductos.ElementoSeleccionado;

            if (producto is null) throw new Exception("No se ha seleccionado ningun productosFiltrados para modificar");

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
                        tb.Text = string.Empty;
                        break;
                    case ComboBoxCustom d:
                        d.SelectedIndex = 0;
                        break;
                    case ComboBox d:
                        d.SelectedIndex = 0;
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
               || txtDescripcion.Text == string.Empty)

                throw new Exception("Verificar los datos ingresados");
        }

        private void EliminarProducto()
        {
            if (gcfProductos.CantidadElementos.Equals(0))
                throw new Exception("Debe seleccionar un productosFiltrados");

            var proveedorId = ((Producto)gcfProductos.ElementoSeleccionado).Id;

            new ProductoBLL().DeleteById(proveedorId);
        }

        private void CargarProductorEnTextos(Producto producto)
        {
            txtNombre.Text = producto.Nombre;
            txtDescripcion.Text = producto.Descripcion;
            //cbCategoria.Text = producto.Categoria.ToString();
            cbCategoria.SelectedItem = cbCategoria.Items
                                        .Cast<Categoria>()
                                        .FirstOrDefault(c => c.Nombre == producto.Categoria.ToString());
            


            cbcTipoDetalle.SelectedItem = cbcTipoDetalle.Items.Cast<string>().FirstOrDefault(c => c == producto.Tipo);
            
            //cbcTipo.Text = producto.Tipo.ToString();
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
                if (gcfProductos.CantidadElementos.Equals(0)) throw new Exception("Seleccione un productosFiltrados para modificarlo");

                CargarProductorEnTextos((Producto)gcfProductos.ElementoSeleccionado);

                PrepararModificacion();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cbcTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cbcTipo.SelectedIndex < 0) return;

                ListarProductos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FiltrarPorTipo(ref List<Producto> productos)
        {
            // Si selecciono el tipo "Todos" debemos listar todos los productos con el filtro de nombre
            if (cbcTipo.SelectedIndex <= 0)
                return;

            //  Caso contrario, obtenemos el tipo y mostramos unicamente los productos que coincidan con el tipo seleccionado
            var tipo = cbcTipo.SelectedItem as string;

            productos = _ListaProductos
                                .Where(p => p.Tipo.Equals(tipo, StringComparison.OrdinalIgnoreCase))
                                .ToList();
        }
    }
}
