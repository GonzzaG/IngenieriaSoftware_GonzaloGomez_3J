using IngenieriaSoftware.BEL;
using IngenieriaSoftware.BEL.Gestion_Compras_Insumos;
using IngenieriaSoftware.BEL.OrdenDeCompra;
using IngenieriaSoftware.BEL.OrdenDeCompra.ViewModels;
using IngenieriaSoftware.BLL;
using IngenieriaSoftware.BLL.Gestion_Compras_Insumos;
using IngenieriaSoftware.BLL.Gestion_Compras_Insumos.Inventario;
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

namespace IngenieriaSoftware.UI.Gestion_Compras_Insumos
{
    public partial class FormGestionarInventario : Form, IActualizable
    {
        // ---- listas principales (nombres unificados y sin duplicados) ----
        private List<ProductoInventario> _ListaProductos = new List<ProductoInventario>();
        private List<ProductoInventario> _ListaOriginal = new List<ProductoInventario>();
        private Dictionary<int, int> _ValoresOriginales = new Dictionary<int, int>();

        private object valorOriginal;
        private OrdenCompraWithDetalles _OrdenCompraRecepcion;

        public FormGestionarInventario()
        {
            InitializeComponent();
            Incializar();

            SuscribirEventosEdicionCantidad();
        }

        private void Incializar()
        {
            ListarTipos();

            // Usamos CargarProductosInventario como método unificado para cargar desde BD
            CargarProductosInventario();

            // Inicializar filtro para que invoque el método unificado
            filtroNombreProducto.InicializarFiltro(CargarProductosInventario);
        }

        public void Actualizar()
        {
            CargarProductosInventario();
        }

        /// <summary>
        /// Método unificado: carga desde BD, aplica filtros, crea copia para cancelar,
        /// carga la grilla y suscribe eventos una sola vez.
        /// </summary>
        private void CargarProductosInventario()
        {
            try
            {
                List<Producto> productos;

                // Paso 1 → obtener desde BD según filtro
                if (string.IsNullOrWhiteSpace(filtroNombreProducto.Texto))
                    productos = new ProductoBLL().GetProductosInventario();
                else
                    productos = new ProductoBLL().GetProductosInventarioPorNombre(filtroNombreProducto.Texto);

                // Paso 2 → convertir a ProductoInventario
                var listaNueva = productos.Select(p => MapToInventario(p)).ToList();

                // Paso 3 → filtrar por tipo
                FiltrarPorTipo(ref listaNueva);

                // combinar cambios locales con los datos nuevos
                foreach (var prodNuevo in listaNueva)
                {
                    var prodViejo = _ListaProductos.FirstOrDefault(x => x.Id == prodNuevo.Id);

                    if (prodViejo != null && prodViejo.Modificado)
                    {
                        // Mantener cantidad modificada
                        prodNuevo.Cantidad = prodViejo.Cantidad;
                        prodNuevo.Modificado = true;
                    }
                }

                // Reemplazar la lista actual con la lista combinada
                _ListaProductos = listaNueva;

                // Paso 4 → Clonar lista original (estado inicial después del filtro)
                _ListaOriginal = _ListaProductos.Select(p => p.Clone()).ToList();

                // Paso 5 → guardar cantidades "originales" para detectar cambios al editar
                _ValoresOriginales.Clear();
                foreach (var p in _ListaOriginal)
                    _ValoresOriginales[p.Id] = p.Cantidad is null ? 0 : (int)p.Cantidad;

                // Paso 6 → cargar grilla
                dgvProductoInventario.CargarDatos(_ListaProductos);

                // Paso 7 → columnas
                ConfiguraraColumnas();

                // Paso 8 → conectar evento una sola vez
                SuscribirEventos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                ex.RegistrarError("Gestion de Productos");
            }
        }

        private void SuscribirEventos()
        {
            dgvProductoInventario.CeldaEditada -= OnCeldaEditada;
            dgvProductoInventario.CeldaEditada += OnCeldaEditada;
        }

        private void ConfiguraraColumnas()
        {
            dgvProductoInventario.OcultarColumnas("oCategoria", "Id", "Precio", "EsPostre", "TiempoPreparacion", "Disponible");
            dgvProductoInventario.RenombrarColumna("Categoria", "Categoria");
            AgregarColumnaCantidad();
        }


        /// <summary>
        /// Refresca la grilla usando la lista temporal actual (sin ir a BD).
        /// Útil para cancelar cambios o para refrescar vista tras modificaciones en memoria.
        /// </summary>
        private void RefrescarGrillaInventario()
        {
            dgvProductoInventario.CargarDatos(_ListaProductos);
            dgvProductoInventario.OcultarColumnas("oCategoria", "Id", "Precio", "EsPostre", "TiempoPreparacion", "Disponible");
            dgvProductoInventario.RenombrarColumna("Categoria", "Categoria");
            AgregarColumnaCantidad();
        }

        /// <summary>
        /// Agrega columna editable de Cantidad y prepara la grilla para permitir solo esa edición.
        /// NO suscribe al evento CeldaEditada aquí (se hace en CargarProductosInventario) para evitar duplicados.
        /// </summary>
        private void AgregarColumnaCantidad()
        {
            //dgvProductoInventario.AddNumericCantidadColumna(null);
            dgvProductoInventario.PermitirEdicionSoloEn("Cantidad");

            dgvProductoInventario.CeldaEditada -= OnCeldaEditada;
            dgvProductoInventario.CeldaEditada += OnCeldaEditada;
        }

        /// <summary>
        /// Manejador que se ejecuta cuando el UserControl notifica que una celda fue editada.
        /// Marca el producto como Modificado si corresponde.
        /// </summary>
        private void OnCeldaEditada(object objeto, string columnName)
        {
            if (objeto is ProductoInventario prod && columnName == "Cantidad")
            {
                // Valor original
                if (_ValoresOriginales.TryGetValue(prod.Id, out int valorOriginal))
                {
                    // Comparar contra el valor actual
                    if (prod.Cantidad != valorOriginal)
                        prod.Modificado = true;
                    else
                        prod.Modificado = false;
                }
                else
                {
                    // Si no existe en el diccionario (caso raro), lo consideramos no modificado
                    prod.Modificado = false;
                }
            }
        }


        private void FiltrarPorTipo(ref List<ProductoInventario> productos)
        {
            if (cbcTipo.SelectedIndex <= 0)
                return;

            string tipo = cbcTipo.SelectedItem.ToString();

            productos = productos
                .Where(p => p.Tipo.Equals(tipo, StringComparison.OrdinalIgnoreCase))
                .ToList();
        }

        private void ListarTipos()
        {
            var tipos = new TiposBusiness().GetProductosTipo();
            var tipoVenta = tipos.Find(i => i == "Compra");

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

                // Usar el método unificado para que regenere listas/copia original adecuadamente
                CargarProductosInventario();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Abrirá un modal que permitira cargar un numero de merma, para un producto seleciconado
        /// </summary>
        private void btnRegistrarMerma_Click(object sender, EventArgs e)
        {
            try
            {
                // validar que se selecciono un producto
                // ElementoSeleccionado devuelve object: ProductoInventario hereda Producto (si es así), casteamos a Producto
                var productoSeleccionado = dgvProductoInventario.ElementoSeleccionado as Producto;

                if (productoSeleccionado is null)
                    throw new Exception("Debe seleccionar un producto");

                // Abrir modal donde se ingresera la cantidad de merma
                new ModalMerma(productoSeleccionado).AbrirFormModal(new Size(705, 532));
                // si se acepta se registra merma y se descuenta del stock

                //Actualizar vista desde BD
                Actualizar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Botón Recibir Productos / Confirmar Recepción
        /// - Si está en modo "Recibir Productos" abre modal
        /// - Si está en modo "Confirmar Recepción" guarda los cambios de cantidades modificadas y marca orden recibida
        /// </summary>
        private void btnRecibirProductos_Click(object sender, EventArgs e)
        {
            try
            {
                if (btnRecibirProductos.Text.Equals("Recibir Productos", StringComparison.InvariantCulture))
                    RecibirOrdenCompra();
                else
                    ActualizarModificados();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ActualizarModificados()
        {
            var dialog = MessageBox.Show(
                "¿Está seguro que desea finalizar la recepción de los productos seleccionados?",
                "Confirmar Recepción",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (dialog == DialogResult.No)
                return;

            var modificados = _ListaProductos.Where(p => p.Modificado).ToList();

            if (modificados.Count == 0)
                throw new Exception("No hay cambios para guardar.");

            // Guardar en BD
            new ProductoInventarioBusiness().UpdateCantidadInventario(modificados);

            if (_OrdenCompraRecepcion is not null && _OrdenCompraRecepcion.IdOrdenCompra > 0)
                new OrdenCompraBussiness().SetOrdenCompraRegistrada(_OrdenCompraRecepcion.IdOrdenCompra);

            MessageBox.Show("Cambios guardados correctamente.");

            // Recargar desde BD
            CargarProductosInventario();

            // limpiar marcas de modificado
            _ListaProductos.ForEach(p => p.Modificado = false);

            //  Opcional: resetear paginación si querés arrancar desde página 1
            dgvProductoInventario.ResetearPaginacion();

            // Reaplicar columnas editables
            AgregarColumnaCantidad();

            // Salir del modo recepción
            DesactivarModoRecepcionOrden();
        }


        private void DesactivarModoRecepcionOrden()
        {
            _OrdenCompraRecepcion = null;
            ModoRecepcionProducto(false);
        }

        private void RecibirOrdenCompra()
        {
            AbrirSeleccionOrdenModal();
            // Queda en modo recepción hasta que confirme/cancele
        }

        private void AbrirSeleccionOrdenModal()
        {
            new FormListaOrdenCompra(CargarDetallesOrden)
                .AbrirFormModal(new Size(1440, 600));
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
            #endregion

            // Cargar los detalles en la grilla
            dgvOrdenDetalle.CargarDatos(_OrdenCompraRecepcion.Detalles);

            PrepararRecepcionProductosOrden();
        }

        private void PrepararRecepcionProductosOrden()
        {
            ModoRecepcionProducto(true);
            // ocultar columnas innecesarias
            dgvOrdenDetalle.OcultarColumnas("IdDetalle", "IdOrdenCompra", "IdProducto", "PrecioUnitarioEsperado", "DescuentoLinea", "NotasLinea", "Subtotal");
        }

        private void ModoRecepcionProducto(bool activado)
        {
            // Visibilizamos la grilla y label
            dgvOrdenDetalle.Visible = activado;
            lblDetalleOrden.Visible = activado;
            //btnCancelar.Visible = activado;

            // Deshabilitamos/mostramos otros botones hasta terminar con la recepcion
            btnAlertaEscasez.Visible = !activado;
            btnRegistrarMerma.Visible = !activado;
            btnGuardarCantidades.Visible = !activado;

            // Colocamos el texto correspondiente al boton de recibir productos 
            btnRecibirProductos.Text = activado ? "Confirmar Recepción" : "Recibir Productos";
        }

        /// <summary>
        /// Abrirá un modal que permitira cargar un numero de alerta por escasez, para un producto seleccionado
        /// </summary>
        private void btnAlertaEscasez_Click(object sender, EventArgs e)
        {
            try
            {
                var productoSeleccionado = dgvProductoInventario.ElementoSeleccionado as Producto;

                if (productoSeleccionado is null)
                    throw new Exception("Debe seleccionar un producto");

                if (productoSeleccionado.Tipo.Equals("Compra", StringComparison.OrdinalIgnoreCase))
                    throw new Exception("Solo se pueden generar alertas de escasez para productos que no sean de tipo 'Compra'");

                new ModalEscasez(productoSeleccionado).AbrirFormModal(new Size(705, 532));

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
                // Restaurar copia original (descartar cambios temporales)
                _ListaProductos = _ListaOriginal
                                .Select(p => p.Clone())
                                .ToList();

                RefrescarGrillaInventario();

                MessageBox.Show("Cambios descartados.");

                // Cancelar modo recepcion
                DesactivarModoRecepcionOrden();


                // limpiar marcas de modificado
                _ListaProductos.ForEach(p => p.Modificado = false);


                // Recargar desde BD
                CargarProductosInventario();
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

        private void btnGuardarCantidades_Click(object sender, EventArgs e)
        {
            try
            {
                ActualizarModificados();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo realizar la suma");
            }
        }

        private ProductoInventario MapToInventario(Producto p)
        {
            return new ProductoInventario
            {
                Id = p.Id,
                Nombre = p.Nombre,
                Categoria = p.Categoria,
                Tipo = p.Tipo,
                Cantidad = p.Cantidad,
                Precio = p.Precio,
                EsPostre = p.EsPostre,
                TiempoPreparacion = p.TiempoPreparacion,
                Modificado = false
            };
        }

        private void SuscribirEventosEdicionCantidad()
        {
            dgvProductoInventario.CeldaComienzoEdicion += (s, e) =>
            {
                var nombreColumna = dgvProductoInventario.Columnas[e.ColumnIndex].Name;

                if (nombreColumna == "Cantidad")
                {
                    valorOriginal = dgvProductoInventario.ObtenerValor(e.RowIndex, e.ColumnIndex);
                }
            };

            dgvProductoInventario.CeldaFinEdicion += (s, e) =>
            {
                var nombreColumna = dgvProductoInventario.Columnas[e.ColumnIndex].Name;
                if (nombreColumna != "Cantidad") return;

                var nuevoValor = dgvProductoInventario.ObtenerValor(e.RowIndex, e.ColumnIndex);

                if (!Equals(nuevoValor, valorOriginal))
                {
                    var p = dgvProductoInventario.ObtenerItem<ProductoInventario>(e.RowIndex);
                    p.Modificado = true;
                }
            };
        }

    }
}
