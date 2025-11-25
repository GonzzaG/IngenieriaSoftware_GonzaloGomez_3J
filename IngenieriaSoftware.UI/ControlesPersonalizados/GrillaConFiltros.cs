using IngenieriaSoftware.BEL.Interfaces;
using IngenieriaSoftware.Servicios.DTOs;
using IngenieriaSoftware.Servicios.Tools;
using IngenieriaSoftware.UI.ControlesPersonalizados.grillaCustom;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace IngenieriaSoftware.UI.ControlesPersonalizados
{
    public partial class DataGridViewConFiltros : UserControl, IUserControlCustom
    {
        #region Propiedades
        [Browsable(true)]
        [Category("Apariencia")]
        [Description("Permite establecer el tamaño de la grilla y el fondo del control.")]
        [DefaultValue(ModoTamanoGrilla.Mediano)]
        public ModoTamanoGrilla TamanoGrilla
        {
            get => tamanoGrilla;
            set
            {
                tamanoGrilla = value;
                AplicarTamanoGrilla();
            }
        }
        private ModoTamanoGrilla tamanoGrilla = ModoTamanoGrilla.Mediano;
        private Size CustomSize;
        public int CantidadElementos
        {
            get => TotalElementos();
        }

        public object ElementoSeleccionado
        {
            get
            {
                if (dgv.CurrentRow == null) return null;
                return dgv.CurrentRow.DataBoundItem;
            }
        }
        private int paginaActual = 1;
        private int tamanoPagina = 10;
        private List<object> datosOriginales = new();
        private string ultimaColumnaOrden = null;
        private bool ordenAscendente = true;
        public event Action<object, string>? CeldaEditada;
        public event DataGridViewCellCancelEventHandler CeldaComienzoEdicion;
        public event DataGridViewCellEventHandler CeldaFinEdicion;
        #endregion

        public DataGridViewConFiltros()
        {
            InitializeComponent();
            InicializarGrilla();
            InicializarFiltros();

            dgv.CellEndEdit += dgv_CellEndEdit;

            dgv.CellBeginEdit += (s, e) =>
            {
                CeldaComienzoEdicion?.Invoke(s, e);
            };

            dgv.CellEndEdit += (s, e) =>
            {
                CeldaFinEdicion?.Invoke(s, e);
            };
        }

        

        #region Metodos

        public void SetCustomSize(Size size)
        {
            if(size == null || size == Size.Empty)
                throw new ArgumentException("El tamaño personalizado no puede ser nulo o vacío.");

            CustomSize = size;
            AplicarTamanoGrilla();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            AplicarTamanoGrilla();
        }

        public void Limpiar()
        {
            dgv.DataSource = null;
            dgv = new DataGridView();
            datosOriginales.Clear();
            paginaActual = 1;
        }

        private void AplicarTamanoGrilla()
        {
            if (CustomSize != null && CustomSize != Size.Empty)
            {
                this.Size = CustomSize;
                dgv.Size = new Size(CustomSize.Width - 4, CustomSize.Height - 4);
                return;
            }
            Size tamanoGrilla;
            Size tamanoControl;
            Size tamanoMensaje;

            switch (this.tamanoGrilla)
            {
                case ModoTamanoGrilla.Pequeño:
                    tamanoControl = new Size(678, 282);
                    tamanoGrilla = new Size(674, 282);
                    tamanoMensaje = new Size(267, 47);
                    break;

                case ModoTamanoGrilla.Grande:
                    tamanoControl = new Size(1016, 282);
                    tamanoGrilla = new Size(1011, 282);
                    tamanoMensaje = new Size(401, 71);
                    break;
                case ModoTamanoGrilla.Gigante:
                    tamanoControl = new Size(1404, 350);
                    tamanoGrilla = new Size(1400, 350);
                    tamanoMensaje = new Size(450, 80);
                    break;

                case ModoTamanoGrilla.Mediano:
                default:
                    tamanoControl = new Size(906, 282);
                    tamanoGrilla = new Size(903, 282);
                    tamanoMensaje = new Size(334, 59);
                    break;
            }

            this.Size = tamanoControl;
            dgv.Size = tamanoGrilla;
            panelNoResultadoProducto.Size = tamanoMensaje;
            Debug.WriteLine($"Modo: {tamanoGrilla}, Size aplicado: {this.Size}, Grilla: {dgv.Size}");

        }

        private int TotalElementos()
        {
            if (dgv.isEmpty()) return 0;
            return dgv.DataSource is DataTable dt ? dt.Rows.Count : ((IEnumerable<object>)dgv.DataSource).Count();
        }

        private void InicializarGrilla()
        {
            dgv.PersonalizarEstiloPredeterminado();
            dgv.AutoGenerateColumns = true;
            dgv.AllowUserToOrderColumns = true;
            dgv.ColumnHeaderMouseClick += dgv_ColumnHeaderMouseClick;
        }

        private void InicializarFiltros()
        {
            btnAnterior.Click += (s, e) => CambiarPagina(-1);
            btnSiguiente.Click += (s, e) => CambiarPagina(1);
        }

        private void AplicarFiltros()
        {
            //Aca se podrian poner filtros, que se pasaran como parametro en MostrarPagina
            MostrarPagina(datosOriginales);
        }

        public void Deshabilitar()
        {
            for (int i = 0; i < this.Controls.Count; i++)
            {
                this.Controls[i].Enabled = false;
            }
        }

        public void Habilitar()
        {
            for (int i = 0; i < this.Controls.Count; i++)
            {
                this.Controls[i].Enabled = true;
            }
        }

        private void MostrarPagina(List<object> datosFiltrados)
        {
            var paginados = datosFiltrados
                .Skip((paginaActual - 1) * tamanoPagina)
                .Take(tamanoPagina)
                .ToList();

            dgv.DataSource = paginados;
            lblPagina.Text = $"Página {paginaActual}";

            //dgv.SetColumnasReadonly();
        }

        private void CambiarPagina(int delta)
        {
            paginaActual += delta;
            if (EsPrimeraPagina()) paginaActual = 1;
            if (EsUltimaPagina()) paginaActual -= 1;
            AplicarFiltros();
        }

        private bool EsPrimeraPagina()
        {
            return paginaActual < 1;
        }
        public string EstadoGrilla { get { return dgv != null ? dgv.Visible.ToString() : "NO INICIALIZADO"; } }


        private bool EsUltimaPagina()
        {
            //Guardamos el resto de dividir la cantidad de datos por el tamanio de pagina
            var resto = datosOriginales.Count() % tamanoPagina;

            //si tiene resto, significa que podemos ver hay una pagina mas con elementos
            if (resto > 0)
                return paginaActual > (datosOriginales.Count() / tamanoPagina) + 1;

            //si no tiene resto, entonces validamos si la pagina actual es mayor a la cantidad de paginas que tendrian los datos
            return paginaActual > (datosOriginales.Count() / tamanoPagina);

        }

        public void CargarDatos<T>(List<T> datos) where T : class, new()
        {
            if (datos.Empty())
            {
                panelNoResultadoProducto.MostrarNoResultado(true);
                dgv.Visible = false;
                datosOriginales = new List<object>();
                dgv.DataSource = null;
                return;
            }

            dgv.BringToFront();
            panelNoResultadoProducto.MostrarNoResultado(false);
            datosOriginales = datos.Cast<object>().ToList();

            paginaActual = 1;
            AplicarFiltros();

            SetAllColumnsReadOnly();

            dgv.Visible = true;
        }


        public void CambiarTamanoPagina(int nuevoTamano)
        {
            if (nuevoTamano <= 0) throw new ArgumentException("El tamaño de página debe ser mayor que cero.");
            tamanoPagina = nuevoTamano;
            paginaActual = 1; // Reiniciar a la primera página al cambiar el tamaño
            AplicarFiltros();
        }

        public void CambiarTamanoGrilla(int nuevoTamano)
        {
            if (nuevoTamano <= 0) throw new ArgumentException("El tamaño de página debe ser mayor que cero.");
            tamanoPagina = nuevoTamano;
            paginaActual = 1; // Reiniciar a la primera página al cambiar el tamaño
            AplicarFiltros();
        }

        #region Agregar columnas

        // Variables privadas para manejar la suscripción
        private DataGridViewCellEventHandler _agregarHandler;
        private DataGridViewCellEventHandler _quitarHandler;
        private bool _cantidadColumnHandlerAdded = false;
        private bool _precioUnitarioColumnHandlerAdded = false;

        /// <summary>
        /// Agrega una columna con botón "Agregar"
        /// </summary>
        public void AddButtonAgregarColumna(Action eventoClick, string columnName = "Agregar", string text = "Agregar")
        {
            if (!dgv.Columns.Contains(columnName))
            {
                var btnCol = new DataGridViewButtonColumn
                {
                    Name = columnName,
                    HeaderText = "",
                    Text = text,
                    UseColumnTextForButtonValue = true,
                    FlatStyle = FlatStyle.Flat
                };
                btnCol.DefaultCellStyle.BackColor = Color.FromArgb(25, 135, 84);
                btnCol.DefaultCellStyle.ForeColor = Color.White;
                btnCol.DefaultCellStyle.SelectionBackColor = Color.FromArgb(15, 95, 54);

                dgv.Columns.Add(btnCol);
            }

            // Desuscribir si ya estaba
            if (_agregarHandler != null)
                dgv.CellContentClick -= _agregarHandler;

            // Suscribir
            _agregarHandler = (s, e) =>
            {
                if (e.RowIndex >= 0 && dgv.Columns[e.ColumnIndex].Name == columnName)
                {
                    eventoClick?.Invoke();
                }
            };
            dgv.CellContentClick += _agregarHandler;
        }

        /// <summary>
        /// Agrega una columna con botón "Quitar"
        /// </summary>
        public void AddButtonQuitarColumna(Action eventoClick, string columnName = "Quitar", string text = "Quitar")
        {
            if (!dgv.Columns.Contains(columnName))
            {
                var btnCol = new DataGridViewButtonColumn
                {
                    Name = columnName,
                    HeaderText = "",
                    Text = text,
                    UseColumnTextForButtonValue = true
                };
                btnCol.DefaultCellStyle.BackColor = Color.FromArgb(220, 53, 69);
                btnCol.DefaultCellStyle.ForeColor = Color.White;
                btnCol.DefaultCellStyle.SelectionBackColor = Color.FromArgb(180, 13, 29);

                dgv.Columns.Add(btnCol);
            }

            // Desuscribir si ya estaba
            if (_quitarHandler != null)
                dgv.CellContentClick -= _quitarHandler;

            // Suscribir
            _quitarHandler = (s, e) =>
            {
                if (e.RowIndex >= 0 && dgv.Columns[e.ColumnIndex].Name == columnName)
                {
                    eventoClick?.Invoke();

                }
            };
            dgv.CellContentClick += _quitarHandler;
        }

        #region Agregar Columna Cantidad
        /// <summary>
        /// Metodo que añade una columna editable para modificar el valor de la cantidad de un registro
        /// </summary>
        /// <param name="onValueChanged"></param>
        /// <param name="columnName"></param>
        /// <param name="defaultValue"></param>
        // Método principal que orquesta la creación de la columna
        public void AddNumericCantidadColumna(Action<object> onValueChanged, string columnName = "Cantidad", int defaultValue = 1)
        {
            if (ColumnExists(columnName))
                return;

            var col = CreateNumericColumn(columnName);
            InitializeColumnValues(col, defaultValue);
            ConfigureColumnEvents(columnName);
        }

        // Verifica si la columna ya existe
        private bool ColumnExists(string columnName)
        {
            return dgv.Columns.Contains(columnName);
        }

        //  Crea la columna editable de tipo int con estilo
        private DataGridViewTextBoxColumn CreateNumericColumn(string columnName)
        {
            var col = new DataGridViewTextBoxColumn
            {
                Name = columnName,
                HeaderText = "Cantidad",
                ValueType = typeof(int),
                ReadOnly = false
            };

            // Estilo por defecto
            col.DefaultCellStyle.BackColor = Color.FromArgb(200, 230, 201); // verde claro
            col.DefaultCellStyle.ForeColor = Color.Black;

            dgv.Columns.Add(col);
            return col;
        }

        // Inicializa los valores de cada fila y aplica estilo
        private void InitializeColumnValues(DataGridViewTextBoxColumn col, int defaultValue)
        {
            foreach (DataGridViewRow row in dgv.Rows)
            {
                if (!row.IsNewRow)
                {
                    var cell = row.Cells[col.Name];
                    cell.Value = defaultValue;
                    cell.Style.BackColor = Color.FromArgb(200, 230, 201);
                    cell.Style.ForeColor = Color.Black;
                }
            }
        }

        // Configura eventos de la columna: commit, edición, keydown
        private void ConfigureColumnEvents(string columnName)
        {
            if (_cantidadColumnHandlerAdded)
                return;

            // Commit automático al editar celda
            dgv.CurrentCellDirtyStateChanged += (s, e) =>
            {
                if (dgv.IsCurrentCellDirty)
                    dgv.CommitEdit(DataGridViewDataErrorContexts.Commit);
            };

            // Detectar Enter para salir de la celda
            dgv.EditingControlShowing += (s, e) =>
            {
                if (dgv.CurrentCell.ColumnIndex == dgv.Columns[columnName].Index && e.Control is TextBox tb)
                {
                    tb.KeyDown -= NumericCell_KeyDown;
                    tb.KeyDown += NumericCell_KeyDown;
                }
            };

            _cantidadColumnHandlerAdded = true;
        }

        #endregion

        #region Agregar Columna PrecioUnitarioEsperado
        /// <summary>
        /// Método que añade una columna editable para modificar el valor del precio unitario esperado de un registro.
        /// </summary>
        /// <param name="onValueChanged"></param>
        /// <param name="columnName"></param>
        /// <param name="defaultValue"></param>
        public void AddNumericPrecioUnitarioColumna(Action<object> onValueChanged, string columnName = "PrecioUnitarioEsperado", decimal defaultValue = 0.00m)
        {
            if (ColumnExists(columnName))
                return;

            var col = CreateDecimalColumn(columnName);
            InitializePrecioUnitarioValues(col, defaultValue);
            ConfigurePrecioUnitarioEvents(columnName);
        }

        // Crea la columna editable de tipo decimal con estilo
        private DataGridViewTextBoxColumn CreateDecimalColumn(string columnName)
        {
            var col = new DataGridViewTextBoxColumn
            {
                Name = columnName,
                HeaderText = "Precio Unitario Esperado",
                ValueType = typeof(decimal),
                ReadOnly = false
            };

            //Celeste claro por defecto
            col.DefaultCellStyle.BackColor = Color.FromArgb(200, 220, 240);
            col.DefaultCellStyle.ForeColor = Color.Black;
            col.DefaultCellStyle.Format = "N2";

            dgv.Columns.Add(col);
            return col;
        }

        // Inicializa valores de cada fila
        private void InitializePrecioUnitarioValues(DataGridViewTextBoxColumn col, decimal defaultValue)
        {
            foreach (DataGridViewRow row in dgv.Rows)
            {
                if (!row.IsNewRow)
                {
                    var cell = row.Cells[col.Name];
                    cell.Value = defaultValue.Equals(0) ? 0.00m : defaultValue;
                    cell.Style.BackColor = Color.FromArgb(200, 220, 240);
                    cell.Style.ForeColor = Color.Black;
                }
            }
        }

        // Configura eventos de edición, validación y commit
        private void ConfigurePrecioUnitarioEvents(string columnName)
        {
            if (_precioUnitarioColumnHandlerAdded)
                return;

            dgv.CurrentCellDirtyStateChanged += (s, e) =>
            {
                if (dgv.IsCurrentCellDirty)
                    dgv.CommitEdit(DataGridViewDataErrorContexts.Commit);
            };

            dgv.EditingControlShowing += (s, e) =>
            {
                if (dgv.CurrentCell.ColumnIndex == dgv.Columns[columnName].Index && e.Control is TextBox tb)
                {
                    tb.KeyDown -= DecimalCell_KeyDown;
                    tb.KeyDown += DecimalCell_KeyDown;
                }
            };

            _precioUnitarioColumnHandlerAdded = true;
        }

        // Maneja la validación al presionar teclas
        private void DecimalCell_KeyDown(object sender, KeyEventArgs e)
        {
            if (sender is TextBox tb)
            {
                // Permitir números, decimales y control
                if (!(char.IsDigit((char)e.KeyCode) ||
                      e.KeyCode == Keys.Back ||
                      e.KeyCode == Keys.Delete ||
                      e.KeyCode == Keys.Decimal ||
                      e.KeyCode == Keys.OemPeriod))
                {
                    e.SuppressKeyPress = true;
                }
            }
        }
        #endregion




        /// <summary>
        /// Hace readonly todas las columnas excepto las indicadas
        /// </summary>
        public void PermitirEdicionSoloEn(params string[] columnNameEditable)
        {
            for (int i = 0; i < dgv.Columns.Count; i++)
            {
                var col = dgv.Columns[i];

                col.ReadOnly = !columnNameEditable.Contains(col.Name);
            }
        }

        /// <summary>
        /// Oculta las columnas indicadas por nombre
        /// </summary>
        /// <param name="nombreColumnas"></param>
        public void OcultarColumnas(params string[] nombreColumnas)
        {
            for (int i = 0; i < dgv.Columns.Count; i++)
            {
                var col = dgv.Columns[i];
                col.Visible = !nombreColumnas.Contains(col.Name);
            }
        }

        public void SetBackColorColumna(string columname, Color color)
        {
            dgv.Columns[columname].DefaultCellStyle.BackColor = color;
        }

        #endregion
        #endregion
        #region Eventos
        private void NumericCell_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                dgv.EndEdit(); // Termina edición
                dgv.CurrentCell = null; // Saca el foco de la celda
                e.Handled = true;
            }
        }
        private void dgv_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var columna = dgv.Columns[e.ColumnIndex].DataPropertyName;

            // Si se hace clic en la misma columna → invertir orden
            if (columna == ultimaColumnaOrden)
            {
                ordenAscendente = !ordenAscendente;
            }
            else
            {
                // Nueva columna → arrancamos orden ascendente
                ultimaColumnaOrden = columna;
                ordenAscendente = true;
            }

            // Obtener la propiedad
            var propInfo = datosOriginales.First().GetType().GetProperty(columna);

            // Ordenar
            if (ordenAscendente)
            {
                datosOriginales = datosOriginales
                    .OrderBy(d => propInfo.GetValue(d))
                    .ToList();
            }
            else
            {
                datosOriginales = datosOriginales
                    .OrderByDescending(d => propInfo.GetValue(d))
                    .ToList();
            }

            AplicarFiltros();
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {

        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {

        }

        #endregion

        public void RenombrarColumna(string nombreColumna, string nuevoNombre)
        {
            if (dgv.Columns.Contains(nombreColumna))
            {
                dgv.Columns[nombreColumna].HeaderText = nuevoNombre;
            }
        }
        private void dgv_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            if (dgv.Columns[e.ColumnIndex].Name == "Cantidad")
            {
                // Obtener el objeto asociado a la fila
                var rowObj = dgv.Rows[e.RowIndex].DataBoundItem as ProductoSelectionModel;
                if (rowObj != null)
                {
                    // Restaurar el valor original desde la propiedad
                    dgv.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = rowObj.Cantidad;
                }

                MessageBox.Show("Valor inválido. Solo se permiten números enteros.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                e.ThrowException = false; // evita que la excepción se propague
                e.Cancel = true;          // cancela la edición
            }
        }
        private object valorOriginalCelda;

        private void dgv_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            var valorNuevo = dgv[e.ColumnIndex, e.RowIndex].Value;

            // Si el valor no cambió, NO marcar como modificado
            if (Convert.ToDecimal(valorOriginalCelda) == Convert.ToDecimal(valorNuevo))
                return;

            // Si cambió, marcás la celda como modificada
            dgv[e.ColumnIndex, e.RowIndex].Style.BackColor = Color.LightYellow;
        }

       

        private void dgv_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            valorOriginalCelda = dgv[e.ColumnIndex, e.RowIndex].Value;
        }

        public DataGridViewColumnCollection Columnas => dgv.Columns;

        public object ObtenerValor(int row, int col)
        {
            return dgv.Rows[row].Cells[col].Value;
        }

        public T ObtenerItem<T>(int row)
        {
            return (T)dgv.Rows[row].DataBoundItem;
        }

        public void ResetearPaginacion()
        {
            paginaActual = 1;
            AplicarFiltros();
        }

        private void SetAllColumnsReadOnly()
        {
            foreach (DataGridViewColumn col in dgv.Columns)
                col.ReadOnly = true;
        }


    }
}
