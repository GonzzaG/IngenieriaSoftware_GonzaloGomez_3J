using IngenieriaSoftware.BEL;
using IngenieriaSoftware.BEL.Gestion_Compras_Insumos;
using IngenieriaSoftware.BLL;
using IngenieriaSoftware.UI.Common;
using IngenieriaSoftware.UI.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Diagnostics;
using System.Windows.Forms;

namespace IngenieriaSoftware.UI.Gestion_Compras_Insumos.Gestion_Inventario.Categorizar_productos
{
    public partial class FormRelacionarConsumoProductos : Form, IActualizable
    {
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

            // Inicializar filtro para que invoque el método unificado
            filtroNombreProducto.InicializarFiltro(CargarProductosInventario);
        }

        public void Actualizar()
        {
            throw new NotImplementedException();
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
    }
}
