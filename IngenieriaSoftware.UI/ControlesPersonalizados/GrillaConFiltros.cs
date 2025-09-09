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
        #endregion
        public DataGridViewConFiltros()
        {
            InitializeComponent();
            InicializarGrilla();
            InicializarFiltros();
        }

        #region Metodos
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            AplicarTamanoGrilla();
        }

        private void AplicarTamanoGrilla()
        {
            Size tamanoGrilla;
            Size tamanoControl;
            Size tamanoMensaje;

            switch (this.tamanoGrilla)
            {
                case ModoTamanoGrilla.Pequeño:
                    tamanoControl = new Size(678, 390);
                    tamanoGrilla = new Size(674, 346);
                    tamanoMensaje = new Size(267, 47);
                    break;

                case ModoTamanoGrilla.Grande:
                    tamanoControl = new Size(1016, 487);
                    tamanoGrilla = new Size(1011, 433);
                    tamanoMensaje = new Size(401, 71);
                    break;

                case ModoTamanoGrilla.Mediano:
                default:
                    tamanoControl = new Size(906, 487);
                    tamanoGrilla = new Size(903, 433);
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

        public void CargarDatos(List<object> datos)
        {
            datosOriginales = datos;
            paginaActual = 1;
            AplicarFiltros();
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
            if (datos.isEmpty())
            {
                panelNoResultadoProducto.MostrarNoResultado(true);
                dgv.DataSource = null;
                return;
            }

            panelNoResultadoProducto.MostrarNoResultado(false);
            datosOriginales = datos.Cast<object>().ToList();
            paginaActual = 1;
            AplicarFiltros();
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

        /// <summary>
        /// Bloquea todas las columnas excepto la indicada.
        /// </summary>
        public void PermitirEdicionSoloEn(string columnNameEditable)
        {
            foreach (DataGridViewColumn col in dgv.Columns)
            {
                col.ReadOnly = col.Name != columnNameEditable;
            }
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
            datosOriginales = datosOriginales
                .OrderBy(d => d.GetType().GetProperty(columna)?.GetValue(d))
                .ToList();

            AplicarFiltros();
        }
        private void btnSiguiente_Click(object sender, EventArgs e)
        {

        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {

        }

        public void OcultarColumna(string nombreColumna)
        {
            if (dgv.Columns.Contains(nombreColumna))
                dgv.Columns[nombreColumna].Visible = false;
        }
        #endregion

        private void dgv_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            if (dgv.Columns[e.ColumnIndex].Name == "Cantidad")
            {
                // Obtener el objeto asociado a la fila
                var rowObj = dgv.Rows[e.RowIndex].DataBoundItem as ProductoOrdenCompraViewModel;
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
    }
}
