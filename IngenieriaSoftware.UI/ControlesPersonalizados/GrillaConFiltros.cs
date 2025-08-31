using IngenieriaSoftware.BEL;
using IngenieriaSoftware.BEL.Interfaces;
using IngenieriaSoftware.Servicios.Tools;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace IngenieriaSoftware.UI.ControlesPersonalizados
{
    public partial class DataGridViewConFiltros : UserControl, IUserControlCustom
    {

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
