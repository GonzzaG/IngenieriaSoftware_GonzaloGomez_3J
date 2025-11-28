using IngenieriaSoftware.BEL.Gestion_Compras_Insumos;
using IngenieriaSoftware.BLL;
using IngenieriaSoftware.BLL.Gestion_Compras_Insumos.Inventario;
using IngenieriaSoftware.UI.Common;
using IngenieriaSoftware.UI.Interfaces;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace IngenieriaSoftware.UI.Gestion_Compras_Insumos.Gestion_Inventario.Categorizar_productos
{
    public partial class FormRelacionarConsumoProductos : Form, IActualizable
    {
        List<ProductoVentaInventarioModel> _ProductosRelacionados;

        /// <summary>
        /// Contiene el producto a relacionar junto con la lista de ids de los productos inventarios a los que esta relacionado
        /// </summary>
        private Dictionary<ProductoCategorizacion, int[]> productosRelacionados = new Dictionary<ProductoCategorizacion, int[]>();
        public FormRelacionarConsumoProductos()
        {
            InitializeComponent();
            Inicilizar();
        }

        public void Inicilizar()
        {
            CargarProductosInventario();

            ActualizarProductosRelacionados();
            // Inicializar filtro para que invoque el método unificado
            filtroNombreProducto.InicializarFiltro(CargarProductosInventario);
        }

        public void Actualizar()
        {
        }

        private void CargarProductosInventario()
        {
            try
            {
                List<ProductoCategorizacion> productos;

                #region Carga productos VENTA
                productos = CargarProductosVenta();

                #endregion


            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Error al cargar los productos del inventario.\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private List<ProductoCategorizacion> CargarProductosVenta()
        {
            List<ProductoCategorizacion> productos;
            // Paso 1 → obtener desde BD según filtro
            if (string.IsNullOrWhiteSpace(filtroNombreProducto.Texto))
                productos = new ProductoBLL().GetAllProductosCategorizacionTipoVenta();
            else
                productos = new ProductoBLL().GetAllProductosCategorizacionTipoVentaPorNombre(filtroNombreProducto.Texto);

            // Paso 2 → cargar en el control de usuario
            dgvProductosVenta.CargarDatos(productos);
            return productos;
        }

       

        private void btnRecibirProductos_Click(object sender, EventArgs e)
        {

        }

        private void btnComenzarRelacion_Click(object sender, EventArgs e)
        {
            try
            {
                var prodVentaSeleccionado = (ProductoCategorizacion)dgvProductosVenta.ElementoSeleccionado;

                if(prodVentaSeleccionado is null)
                    throw new Exception ("Debe seleccionar un producto de venta para comenzar la relación.");

                new ModalRelacionarProductos(prodVentaSeleccionado).AbrirFormModal();

            }
            catch(Exception ex)
            {
                MessageBox.Show(this, "Error al comenzar la relación de productos.\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }       
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormRelacionarConsumoProductos_Load(object sender, EventArgs e)
        {
            dgvProductosVenta.ActivarEventoSeleccion();
            dgvProductosVenta.SelectionChangedCustom += dgv_SelectionChangedCustom;
        }
        private void dgv_SelectionChangedCustom(object sender, EventArgs e)
        {
            ActualizarProductosRelacionados();
        }

        private void ActualizarProductosRelacionados()
        {
            // Acá hacés lo que necesites cuando cambia la selección
            var fila = (ProductoCategorizacion)dgvProductosVenta.ElementoSeleccionado;
            if (fila != null)
                CargarProductosInventariosRelacionados(fila.IdProducto);
            //Obtenemos los productos relacionados
        }

        /// <summary>
        /// En este metodo listaremos los productosVentaInventario que tienen relacion con el seleccionado en la pantalla anterior
        /// </summary>
        private void CargarProductosInventariosRelacionados(int idProducto)
        {
            List<ProductoVentaInventarioModel> productosVentaInventario;

            productosVentaInventario = new ProductoVentaInventarioBusiness().GetProductoVentaInventario(idProducto);

            _ProductosRelacionados = productosVentaInventario;

            // Paso 2 → cargar en el control de usuario
            dgvProductosRelacionados.CargarDatos(productosVentaInventario);

            dgvProductosRelacionados.OcultarColumnas("IdRelacion", "IdProductoVenta");
            dgvProductosRelacionados.RenombrarColumna("IdProductoInventario", "Id");
            dgvProductosRelacionados.RenombrarColumna("NombreProductoInventario", "Nombre");

        }
    }
}
