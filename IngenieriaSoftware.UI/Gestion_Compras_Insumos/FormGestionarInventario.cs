using IngenieriaSoftware.BEL;
using IngenieriaSoftware.BEL.Constantes;
using IngenieriaSoftware.BEL.OrdenDeCompra.ViewModels;
using IngenieriaSoftware.BLL;
using IngenieriaSoftware.BLL.Gestion_Compras_Insumos;
using IngenieriaSoftware.UI.Common;
using IngenieriaSoftware.UI.ComprasProveedores;
using IngenieriaSoftware.UI.Gestion_Compras_Insumos.Gestion_Inventario;
using IngenieriaSoftware.UI.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IngenieriaSoftware.UI.Gestion_Compras_Insumos
{
    public partial class FormGestionarInventario : Form, IActualizable
    {
        private List<Producto> _ListaProductos = new List<Producto>();

        public FormGestionarInventario()
        {
            InitializeComponent();
            Incializar();
        }

        private void Incializar()
        {
            ListarTipos();
            ListarProductosInventario();
            filtroNombreProducto.InicializarFiltro(ListarProductosInventario);
        }

        public void Actualizar()
        {
            ListarProductosInventario();    
        }


        // Vamos a obtener los productos los cuales no aparecen en la orden de compra
        // Seran los productos tanto de consumidor final como de inventario/insumos

        // Inventario / Restaurante 
        private void ListarProductosInventario()
        {
            try
            {
                if (filtroNombreProducto.Texto == string.Empty)
                    _ListaProductos = new ProductoBLL().GetProductosInventario();
                else
                    _ListaProductos = new ProductoBLL().GetProductosInventarioPorNombre(filtroNombreProducto.Texto);

                FiltrarPorTipo(ref _ListaProductos);

                dgvProductoInventario.CargarDatos(_ListaProductos);

                dgvProductoInventario.OcultarColumnas("oCategoria", "Id", "Cantidad");

                dgvProductoInventario.RenombrarColumna("Categoria", "Categoria");

                //que hacer cuadno se modifique la cantidad 
                dgvProductoInventario.AddNumericCantidadColumna((elemento) =>
                {
                    var prod = elemento as Producto;
                    if (prod != null && int.TryParse(prod.Cantidad.ToString(), out int nuevoValor))
                        prod.Cantidad = nuevoValor;

                });
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                ex.RegistrarError("Gestion de Productos");
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

        private void ListarTipos()
        {
            var tipos = new TiposBusiness().GetProductosTipo();
            var tipoVenta = tipos.Find(i => i == "Venta");

            tipos.Remove(tipoVenta);

            #region ComboBox Tipo Filtro
            cbcTipo.Items.Clear();
            var tiposCombo = new List<string>() { "Todos" };
            tiposCombo.AddRange(tipos);
            cbcTipo.DataSource = tiposCombo;
            #endregion
        }

        private void cbcTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cbcTipo.SelectedIndex < 0) return;

                ListarProductosInventario();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Abrirá un modal que permitira cargar un numero de merma, para un producto seleciconado
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRegistrarMerma_Click(object sender, EventArgs e)
        {
            try
            {
                // validar que se selecciono un producto
                var productoSeleccionado = dgvProductoInventario.ElementoSeleccionado;

                if (productoSeleccionado is null)
                    throw new Exception("Debe seleccionar un producto");

                // Abrir modal donde se ingresera la cantidad de merma
                new ModalMerma().AbrirFormModal(new Size(517,359));
                // si se acepta se registra merma y se descuenta del stock

                //Actualizar
                Actualizar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Este evento abrira un modal con las ordenes de compra que no se recibieron aun
        /// Al seleccionarse una, se podrá realizar la recepción de la misma, teniendo un listado de ayuda en una grilla a un costado para mayor facilidad
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRecibirProductos_Click(object sender, EventArgs e)
        {
            try
            {
                if(btnRecibirProductos.Text.Equals("Recibir Productos", StringComparison.InvariantCulture))
                {
                    RecibirOrdenCompra();
                }
                else
                {
                    // Finalizacion de recepcion orden compra

                    // Se debe de modificar el estado de la orden marcandola como recibida, para que no aparezca mas en la lista

                    // Se invisibiliza nuevamente la grilla label de orden y se cambia n ombre de boton

                    btnRecibirProductos.Text = "Recibir Productos";
                    btnAlertaEscasez.Visible = true;
                    btnRegistrarMerma.Visible = true;
                    lblDetalleOrden.Visible = false;
                    dgvOrdenDetalle.Visible = false;
                }




            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void RecibirOrdenCompra()
        {
            // Abrir modal de seleccion de productos, asignandole el metodo que se ejecutara cunado se seleccione una orden de compra
            AbrirSeleccionOrdenModal();

            // Al cerrar el modal con una orden seleccionada, se cargaran en otra grilla a un costado con los productos de esa odrden

            // Se iran cargando los productos que la persona del inventario crea conveniente, luego guardara de finalizar maracara la orden como recibida

            // Actualizar el inventario con los productos recibidos
        }

        private void AbrirSeleccionOrdenModal()
        {
            new FormListaOrdenCompra(CargarDetallesOrden).AbrirFormModal(new Size(1680, 800));
        }

        private void CargarDetallesOrden(string numOrden)
        {
            if (string.IsNullOrEmpty(numOrden))
                throw new Exception("No se pudo obtener los detalles de la orden de compra");

            // Obtenemos la orden con detalles por su numero
            var ordenDetalles = new OrdenCompraBussiness().GetOrdenCompraByNumero(numOrden);

            if(ordenDetalles.Detalles.Count <= 0)
                throw new Exception("No se pudo obtener los detalles de la orden de compra");
            // Cargar los detalles en la grilla
            dgvOrdenDetalle.CargarDatos(ordenDetalles.Detalles);

            // Visibilizamos la grilla y label
            dgvOrdenDetalle.Visible = true;
            lblDetalleOrden.Visible = true;

            // Deshabilitamos otros botones hasta terminar con la recepcion
            btnAlertaEscasez.Visible = false;
            btnRegistrarMerma.Visible = false;
            // Colocamos el boton de recibir producto como finalizar recepcion
            btnRecibirProductos.Text = "Finalizar recepcion";
            //todo ocultar columnas innecesarias
            dgvOrdenDetalle.OcultarColumnas("IdDetalle", "IdOrdenCompra","IdProducto","PrecioUnitarioEsperado","DescuentoLinea","NotasLinea","Subtotal");
        }

        /// <summary>
        /// Abrirá un modal que permitira cargar un numero de alerta por escasez, para un producto seleciconado
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAlertaEscasez_Click(object sender, EventArgs e)
        {
            try
            {
                // validar que se selecciono un producto
                var productoSeleccionado = dgvProductoInventario.ElementoSeleccionado;

                if (productoSeleccionado is null)
                    throw new Exception("Debe seleccionar un producto");
                // Abrir modal donde se ingresera la cantidad sugerida para poder comprar
                new ModalEscasez().AbrirFormModal(new Size(705, 359));

                // se acepta y se envia la alerta

                //Actualizar
                Actualizar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
