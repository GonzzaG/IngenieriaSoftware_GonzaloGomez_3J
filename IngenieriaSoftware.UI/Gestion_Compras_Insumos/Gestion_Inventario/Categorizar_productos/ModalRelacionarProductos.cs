using IngenieriaSoftware.BEL.Gestion_Compras_Insumos;
using IngenieriaSoftware.BLL;
using IngenieriaSoftware.BLL.Gestion_Compras_Insumos.Inventario;
using IngenieriaSoftware.UI.Common;
using IngenieriaSoftware.UI.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IngenieriaSoftware.UI.Gestion_Compras_Insumos.Gestion_Inventario.Categorizar_productos
{
    public partial class ModalRelacionarProductos : Form, IActualizable
    {
        private ProductoCategorizacion _ProductoVentaSeleccionado;
        private ProductoCategorizacion _ProductoRelacionado;

        private List<ProductoVentaInventarioModel> _ProductosRelacionados;
        public ModalRelacionarProductos(ProductoCategorizacion producto)
        {
            InitializeComponent();
            Inicializar(producto);
        }

        private void Inicializar(ProductoCategorizacion productoVenta)
        {
            if (productoVenta is null)
                throw new Exception("Debe seleccionar un productoVenta para relacionar");

            _ProductoVentaSeleccionado = productoVenta;
            lblNombreProducto.Text = $"Producto: " + productoVenta.Nombre;
            Actualizar();
        }

        public void Actualizar()
        {
            CargarProductosInventario();
            CargarProductosInventariosRelacionados();
        }

        private List<ProductoCategorizacion> CargarProductosInventario()
        {
            List<ProductoCategorizacion> productos;
            // Paso 1 → obtener desde BD según filtro
            if (string.IsNullOrWhiteSpace(filtroNombreProducto.Texto))
                productos = new ProductoBLL().GetAllProductosCategorizacionTipoInventario();
            else
                productos = new ProductoBLL().GetAllProductosCategorizacionTipoInventarioPorNombre(filtroNombreProducto.Texto);

            // Paso 2 → cargar en el control de usuario
            dgvProductosInventario.CargarDatos(productos);
            dgvProductosRelacionados.RenombrarColumna("IdProducto", "Id");
            return productos;
        }

        /// <summary>
        /// En este metodo listaremos los productosVentaInventario que tienen relacion con el seleccionado en la pantalla anterior
        /// </summary>
        private void CargarProductosInventariosRelacionados()
        {
            List<ProductoVentaInventarioModel> productosVentaInventario;

            productosVentaInventario = new ProductoVentaInventarioBusiness().GetProductoVentaInventario(_ProductoVentaSeleccionado.IdProducto);

            _ProductosRelacionados = productosVentaInventario;

            // Paso 2 → cargar en el control de usuario
            dgvProductosRelacionados.CargarDatos(productosVentaInventario);

            dgvProductosRelacionados.OcultarColumnas("IdRelacion", "IdProductoVenta");
            dgvProductosRelacionados.RenombrarColumna("IdProductoInventario", "Id");
            dgvProductosRelacionados.RenombrarColumna("NombreProductoInventario", "Nombre");

        }

        private void btnComenzarRelacion_Click(object sender, EventArgs e)
        {
            try
            {
                // Obtenemos el productoVenta seleccionado 
                _ProductoRelacionado = (ProductoCategorizacion)dgvProductosInventario.ElementoSeleccionado;
                
                var productoYaRelacionado = _ProductosRelacionados.Where(p => p.IdProductoInventario == _ProductoRelacionado.IdProducto).FirstOrDefault();

                if (productoYaRelacionado is not null)
                    throw new Exception("Este producto ya se encuentra relacionado");

                // Abrimos le modal para ingresar la cantidad y luego guardamos la relacion
                new ModalIngresarCantidadReferencia(Guardar).AbrirFormModal(new Size(498,387));

                Actualizar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        /// <summary>
        /// Va a guardar la relacion entre el productoVenta venta y prodcuto inventario
        /// </summary>
        /// <param name="cantidad"></param>
        private void Guardar(int cantidad)
        {
            var idProductoVenta = _ProductoVentaSeleccionado.IdProducto;
            var idProductoInventario = _ProductoRelacionado.IdProducto;

            if (idProductoVenta <= 0 || idProductoInventario <= 0)
                throw new Exception("No se pudo establecer la relacion entre los productos");

            var model = new ProductoVentaInventarioModel()
            {
                IdProductoVenta = idProductoVenta,
                IdProductoInventario = idProductoInventario,
                CantidadUsada = cantidad
            };

            new ProductoVentaInventarioBusiness().SetProductoVentaInventarioRelacion(model);

        }

        private void btnQuitarRelacion_Click(object sender, EventArgs e)
        {
            try
            {

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

