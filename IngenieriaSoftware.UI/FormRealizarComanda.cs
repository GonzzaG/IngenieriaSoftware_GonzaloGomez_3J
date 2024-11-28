using IngenieriaSoftware.BEL;
using IngenieriaSoftware.BEL.Negocio;
using IngenieriaSoftware.BLL;
using IngenieriaSoftware.BLL.Mesas;
using IngenieriaSoftware.Servicios;
using IngenieriaSoftware.Servicios.DTOs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace IngenieriaSoftware.UI
{
    public partial class FormRealizarComanda : Form, IActualizable
    {
        private readonly ProductoBLL _productoBLL = new ProductoBLL();
        private readonly ComandaBLL _comandaBLL = new ComandaBLL();
        private Mesa _mesa;
        private int _comandaId;
        private Comanda _comanda;
        private TraduccionBLL _traduccionBLL = new TraduccionBLL();      
        private EtiquetaBLL _etiquetaBLL = new EtiquetaBLL();

        private List<Producto> _productos = new List<Producto>();

        public NotificacionService _notificacionService => new NotificacionService();

        public FormRealizarComanda(Mesa mesa, int comandaId)
        {
            InitializeComponent();
            _mesa = mesa;
            _comandaId = comandaId;
            Inicializar();
            
        }



        private void Inicializar()
        {
            try
            {
                _productos = _productoBLL.ObtenerTodosLosProductos();

                if (_productos != null)
                {
                    dataGridViewProductos.DataSource = null;
                    dataGridViewProductos.DataSource = _productos;
                    
                    #region Traduccion implementacion
                    //List<EtiquetaDTO> etiquetas = _etiquetaBLL.ObtenerEtiquetasPorPalabra("DataGridViewRow");

                    //var etiquetasRelacionadasId = etiquetas
                    //    .Where(etiqueta => _productos
                    //    .Any(producto => etiqueta.Name.Contains(producto.Nombre)))
                    //    .Select(e => e.Tag)
                    //    .ToList();

                    //var traducciones = _traduccionBLL.ObtenerTraduccionesPorEtiquetas(
                    //    etiquetasRelacionadasId, IdiomaData.IdiomaActual.Id);

                    //var productosConTraduccion = _productos.Select(producto =>
                    //{
                    //    var traduccion = traducciones
                    //        .FirstOrDefault(t => etiquetas.Any(e => e.Tag == t.EtiquetaId && e.Name.Contains(producto.Nombre)));

                    //    return new
                    //    {
                    //        producto.ProductoId,
                    //        Nombre = traduccion?.Texto ?? producto.Nombre,
                    //        producto.Precio,
                    //        producto.TiempoPreparacion,
                    //        producto.EsPostre,
                    //        producto.Categoria
                    //    };
                    //}).ToList();

                    //dataGridViewProductos.DataSource = null;
                    //dataGridViewProductos.DataSource = productosConTraduccion;

                    //dataGridViewProductos.AutoGenerateColumns = false;
                    //dataGridViewProductos.Columns.Clear();

                    //dataGridViewProductos.Columns.Add(new DataGridViewTextBoxColumn { Name = "ProductoId", HeaderText = "ID", DataPropertyName = "ProductoId" });
                    //dataGridViewProductos.Columns.Add(new DataGridViewTextBoxColumn { Name = "Nombre", HeaderText = "Nombre", DataPropertyName = "Nombre" });
                    //dataGridViewProductos.Columns.Add(new DataGridViewTextBoxColumn { Name = "Precio", HeaderText = "Precio", DataPropertyName = "Precio" });
                    //dataGridViewProductos.Columns.Add(new DataGridViewTextBoxColumn { Name = "Tiempo Preparacion", HeaderText = "Tiempo Preparacion", DataPropertyName = "TiempoPreparacion" });
                    //dataGridViewProductos.Columns.Add(new DataGridViewTextBoxColumn { Name = "EsPostre", HeaderText = "EsPostre", DataPropertyName = "EsPostre" });
                    //dataGridViewProductos.Columns.Add(new DataGridViewTextBoxColumn { Name = "Categoria", HeaderText = "Categoría", DataPropertyName = "Categoria" });
                    #endregion
                }

                lblNumeroMesa.Text = _mesa.MesaId.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al inicializar los datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormRealizarComanda_Load(object sender, EventArgs e)
        {
            VerificarNotificaciones();
        }

        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            //en este boton se agregara el producto seleccionado a la comanda de la mesa actual seleccionada
            //se tiene que guardar en comandaProducto la relacion que va a existir entre ese producto y la comanda de la mesa
            int indice = dataGridViewProductos.SelectedRows[0].Index;
            int productoId = (int)dataGridViewProductos.SelectedRows[0].Cells[0].Value;
            Producto producto = _productos.Find(p => p.ProductoId == productoId);
   
            _comandaBLL.NuevoComandaProducto(producto, _comandaId, (int)numericUpDownCantidad.Value);
        }

        private void NuevoProducto()
        {
           

          
        }

        private void btnVerComanda_Click(object sender, EventArgs e)
        {
            // Mostramos el formulario ver comanda con la mesa actual como parametro
            
            var padre = this.MdiParent as FormMDI;

            FormVerComanda formVerComanda = new FormVerComanda(_comandaBLL, _comandaId);
            formVerComanda.StartPosition = FormStartPosition.CenterScreen;
            formVerComanda.ShowDialog();
          // padre.AbrirFormHijo(formVerComanda);

            Actualizar();
        }

        public void Actualizar()
        {
            try
            {
                _productos = _productoBLL.ObtenerTodosLosProductos();

                if (_productos != null)
                {
                    dataGridViewProductos.DataSource = null;
                    dataGridViewProductos.DataSource = _productos;

                    //List<EtiquetaDTO> etiquetas = _etiquetaBLL.ObtenerEtiquetasPorPalabra("DataGridViewRow");

                    //var etiquetasRelacionadasId = etiquetas
                    //    .Where(etiqueta => _productos
                    //        .Any(producto => etiqueta.Name.Contains(producto.Nombre)))
                    //    .Select(e => e.Tag)
                    //    .ToList();
                    //var traducciones = _traduccionBLL.ObtenerTraduccionesPorEtiquetas(
                    //    etiquetasRelacionadasId, IdiomaData.IdiomaActual.Id);

                    //var productosConTraduccion = _productos.Select(producto =>
                    //{
                    //    var traduccion = traducciones
                    //        .FirstOrDefault(t => etiquetas.Any(e => e.Tag == t.EtiquetaId && e.Name.Contains(producto.Nombre)));

                    //    return new
                    //    {
                    //        producto.ProductoId,
                    //        Nombre = traduccion?.Texto ?? producto.Nombre,
                    //        producto.Precio,
                    //        producto.TiempoPreparacion,
                    //        producto.EsPostre,
                    //        producto.Categoria
                    //    };
                    //}).ToList();

                    //dataGridViewProductos.DataSource = null;
                    //dataGridViewProductos.DataSource = productosConTraduccion;

                    //dataGridViewProductos.AutoGenerateColumns = false;
                    //dataGridViewProductos.Columns.Clear();

                    //dataGridViewProductos.Columns.Add(new DataGridViewTextBoxColumn { Name = "ProductoId", HeaderText = "ID", DataPropertyName = "ProductoId" });
                    //dataGridViewProductos.Columns.Add(new DataGridViewTextBoxColumn { Name = "Nombre", HeaderText = "Nombre", DataPropertyName = "Nombre" });
                    //dataGridViewProductos.Columns.Add(new DataGridViewTextBoxColumn { Name = "Precio", HeaderText = "Precio", DataPropertyName = "Precio" });
                    //dataGridViewProductos.Columns.Add(new DataGridViewTextBoxColumn { Name = "Tiempo Preparacion", HeaderText = "Tiempo Preparacion", DataPropertyName = "TiempoPreparacion" });
                    //dataGridViewProductos.Columns.Add(new DataGridViewTextBoxColumn { Name = "EsPostre", HeaderText = "EsPostre", DataPropertyName = "EsPostre" });
                    //dataGridViewProductos.Columns.Add(new DataGridViewTextBoxColumn { Name = "Categoria", HeaderText = "Categoría", DataPropertyName = "Categoria" });
                }

                lblNumeroMesa.Text = _mesa.MesaId.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar los datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void VerificarNotificaciones()
        {
            if (PermisosData.PermisosString.Contains("Mesero"))
            {
                var notificaciones = _notificacionService.ObtenerNotificaciones();
                if (notificaciones.Count > 0)
                {
                    HelperForms.MostrarNotificacion(notificaciones, this);
                }
            }
        }
        public void CargarProductosConTraduccion(DataGridView dgv, string idioma)
        {
            var productos = _productoBLL.ObtenerTodosLosProductos();
            List<EtiquetaDTO> etiquetas = _etiquetaBLL.ObtenerEtiquetasPorPalabra("DataGridViewRow");
            
            var etiquetasRelacionadasId = etiquetas
            .Where(etiqueta => productos
            .Any(producto => etiqueta.Name.Contains(producto.Nombre)))
            .Select(e => e.Tag)
            .ToList();

            var traducciones = _traduccionBLL.ObtenerTraduccionesPorEtiquetas(etiquetasRelacionadasId, IdiomaData.IdiomaActual.Id);


            foreach (var traduccion in traducciones)
            {
   
                dgv.Rows.Add(traduccion.Texto);
            }
        }


    }
}
