using IngenieriaSoftware.BEL;
using IngenieriaSoftware.BEL.OrdenDeCompra.ViewModels;
using IngenieriaSoftware.BLL;
using IngenieriaSoftware.BLL.Gestion_Compras_Insumos;
using IngenieriaSoftware.UI.Common;
using IngenieriaSoftware.UI.ComprasProveedores;
using IngenieriaSoftware.UI.Gestion_Compras_Insumos.Gestion_Inventario;
using IngenieriaSoftware.UI.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using IngenieriaSoftware.BLL.Gestion_Compras_Insumos.Inventario;

namespace IngenieriaSoftware.UI.Gestion_Compras_Insumos
{
    public partial class FormGestionarInventario : Form, IActualizable
    {
        private List<Producto> _ListaProductos = new List<Producto>();
        private OrdenCompraWithDetalles _OrdenCompraRecepcion;
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

                dgvProductoInventario.OcultarColumnas("oCategoria", "Id", "Precio", "EsPostre", "TiempoPreparacion");

                dgvProductoInventario.RenombrarColumna("Categoria", "Categoria");

                AgregarColumnaCantidad();
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                ex.RegistrarError("Gestion de Productos");
            }
        }

        private void AgregarColumnaCantidad()
        {
            //que hacer cuadno se modifique la cantidad 
            dgvProductoInventario.AddNumericCantidadColumna((elemento) =>
            {
                var prod = elemento as Producto;
                if (prod != null && int.TryParse(prod.Cantidad.ToString(), out int nuevoValor))
                    prod.Cantidad = nuevoValor;

            });

            dgvProductoInventario.PermitirEdicionSoloEn("Cantidad");
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
                var productoSeleccionado = (Producto)dgvProductoInventario.ElementoSeleccionado;

                if (productoSeleccionado is null)
                    throw new Exception("Debe seleccionar un producto");

                // Abrir modal donde se ingresera la cantidad de merma
                new ModalMerma(productoSeleccionado).AbrirFormModal(new Size(517, 359));
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
                if (btnRecibirProductos.Text.Equals("Recibir Productos", StringComparison.InvariantCulture))
                {
                    RecibirOrdenCompra();
                }
                else
                {
                    var dialog = MessageBox.Show("¿Está seguro que desea finalizar la recepción de los productos seleccionados?", "Confirmar Recepción", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dialog == DialogResult.No)
                        return;
                    // Marcar la orden de compra como recibida
                    new OrdenCompraBussiness().SetOrdenCompraRecibida(_OrdenCompraRecepcion.IdOrdenCompra);

                    // Limpiamos la grilla y orden
                    DesactivarModoRecepcionOrden();
                }




            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void DesactivarModoRecepcionOrden()
        {
            //dgvOrdenDetalle.Limpiar();
            _OrdenCompraRecepcion = null;
            // Desactivar modo de recepcion de productos
            ModoRecepcionProducto(false);
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
            new FormListaOrdenCompra(CargarDetallesOrden)
                .AbrirFormModal(new Size(1440,600));
        }

        private void CargarDetallesOrden(string numOrden)
        {
            #region Validacion
            if (string.IsNullOrEmpty(numOrden))
                throw new Exception("No se pudo obtener los detalles de la orden de compra");
            #endregion
            // Obtenemos la orden con detalles por su numero
            _OrdenCompraRecepcion = new OrdenCompraBussiness().GetOrdenCompraByNumero(numOrden);
            #region Validacion
            if (_OrdenCompraRecepcion.Detalles.Count <= 0)
                throw new Exception("No se pudo obtener los detalles de la orden de compra");
            // Cargar los detalles en la grilla
            #endregion

            dgvOrdenDetalle.CargarDatos(_OrdenCompraRecepcion.Detalles);

            PrepararRecepcionProductosOrden();
        }

        private void PrepararRecepcionProductosOrden()
        {
            ModoRecepcionProducto(true);
            //todo ocultar columnas innecesarias
            dgvOrdenDetalle.OcultarColumnas("IdDetalle", "IdOrdenCompra", "IdProducto", "PrecioUnitarioEsperado", "DescuentoLinea", "NotasLinea", "Subtotal");
        }

        private void ModoRecepcionProducto(bool activado)
        {
            // Visibilizamos la grilla y label
            dgvOrdenDetalle.Visible = activado;
            lblDetalleOrden.Visible = activado;

            // Deshabilitamos otros botones hasta terminar con la recepcion
            btnAlertaEscasez.Visible = !activado;
            btnRegistrarMerma.Visible = !activado;
            btnCancelarRecepcion.Visible = activado;

            // Colocamos el texto correspondiente al boton de recibir productos 
            btnRecibirProductos.Text = activado ? "Confirmar Recepción" : "Recibir Productos";
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

                
                //Actualizar
                Actualizar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCancelarRecepcion_Click(object sender, EventArgs e)
        {
            try
            {
                // Cancelar recepcion de productos
                DesactivarModoRecepcionOrden();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            try
            {
                new FormGestionarProductos().AbrirFormModal(new Size(1500, 720));

                Actualizar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
