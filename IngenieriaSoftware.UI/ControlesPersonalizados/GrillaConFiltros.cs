using IngenieriaSoftware.BEL.Interfaces;
using IngenieriaSoftware.Servicios.Tools;
using IngenieriaSoftware.UI.ControlesPersonalizados.grillaCustom;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace IngenieriaSoftware.UI.ControlesPersonalizados
{
    public partial class DataGridViewConFiltros : UserControl, IUserControlCustom
    {
        [Browsable(true)]
        [Category("Apariencia")]
        [Description("Permite establecer el tamaño de la grilla y el fondo del control.")]
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


      

        private void AplicarTamanoGrilla()
        {
            Size tamanoGrilla;
            Size tamanoControl;
            Size tamanoMensaje;

            switch (this.tamanoGrilla)
            {
                case ModoTamanoGrilla.Pequeño:
                    tamanoGrilla = new Size(500, 300);
                    tamanoControl = new Size(505, 385);
                    tamanoMensaje = new Size(200, 152);
                    break;

                case ModoTamanoGrilla.Grande:
                    tamanoGrilla = new Size(900, 500);
                    tamanoControl = new Size(905, 585);
                    tamanoMensaje = new Size(523, 152); 
                    break;

                case ModoTamanoGrilla.Mediano:
                default:
                    tamanoGrilla = new Size(632, 352); 
                    tamanoControl = new Size(637, 437);
                    tamanoMensaje = new Size(523, 152);
                    break;
            }

            dgv.Size = tamanoGrilla;
            panelNoResultadoProducto.Size = tamanoGrilla;
        }


    
        public DataGridViewConFiltros()
        {
            InitializeComponent();
            InicializarGrilla();
            InicializarFiltros();
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

            //ReajustarMensaje();
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


        /// <summary>
        /// Reajusta la posicion del mensaje de "No se encontraron resultados" en el centro de la grilla, y que se vaya centrando horizontalmente dentro de el.
        /// </summary>
        private void ReajustarMensaje()
        {
            panelNoResultadoProducto.Location = new Point((dgv.Width - panelNoResultadoProducto.Width) / 2, (dgv.Height - panelNoResultadoProducto.Height) / 2);
        }


        public void Limpiar()
        {
            dgv.DataSource = null;  
        }

        public void Deshabilitar()
        {
            for(int i = 0; i < this.Controls.Count; i++)
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
        private void dgv_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var columna = dgv.Columns[e.ColumnIndex].DataPropertyName;
            datosOriginales = datosOriginales
                .OrderBy(d => d.GetType().GetProperty(columna)?.GetValue(d))
                .ToList();

            AplicarFiltros();
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

        private void btnSiguiente_Click(object sender, EventArgs e)
        {

        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {

        }
    }
}
