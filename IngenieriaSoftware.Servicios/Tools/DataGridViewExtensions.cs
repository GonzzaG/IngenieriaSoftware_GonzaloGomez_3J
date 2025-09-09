using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace IngenieriaSoftware.Servicios.Tools
{
    public static class DataGridViewExtensions
    {
        public static void ActualizarDataSource<T>(this DataGridView dgv, IEnumerable<T> data)
        {
            dgv.DataSource = null;
            dgv.DataSource = data?.ToList();
        }

        public static bool EstaVacio<T>(this DataGridView dgv)
        {
            return dgv.RowCount > 0;
        }

        public static bool isEmpty(this DataGridView dgv)
        {
            return dgv is null || dgv.RowCount.Equals(0);
        }
        #region Personalizacion Grilla estandar
        public static void PersonalizarEstiloPredeterminado(this DataGridView dgv)
        {
            dgv.AplicarColoresBase();
            dgv.ConfigurarEncabezados();
            dgv.ConfigurarComportamiento();
            dgv.InicializarSiVacio();
            dgv.AplicarEstiloDinamico();
        }

        private static void AplicarColoresBase(this DataGridView dgv)
        {
            dgv.BackgroundColor = Color.FromArgb(0, 64, 64);
            dgv.BorderStyle = BorderStyle.None;
            dgv.GridColor = Color.FromArgb(20, 100, 100); // líneas suaves
        }

        private static void ConfigurarEncabezados(this DataGridView dgv)
        {
            Color colorEncabezado = Color.FromArgb(0, 90, 90);
            Color colorTexto = Color.WhiteSmoke;

            dgv.ColumnHeadersDefaultCellStyle.BackColor = colorEncabezado;
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = colorTexto;
            dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            dgv.ColumnHeadersHeight = 50;

            dgv.RowHeadersVisible = false;
            dgv.EnableHeadersVisualStyles = false;
        }

        private static void ConfigurarComportamiento(this DataGridView dgv)
        {
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgv.RowTemplate.Height = 45;
            dgv.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgv.Width += 5;

            dgv.MultiSelect = false;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            // ⚡ Esto es importante: NO bloqueamos todas las celdas,
            // después vas a decidir qué columnas son editables
            dgv.EditMode = DataGridViewEditMode.EditOnEnter;
            dgv.ReadOnly = false;
        }

        private static void InicializarSiVacio(this DataGridView dgv)
        {
            if (dgv.Rows.Count == 0)
            {
                dgv.AutoGenerateColumns = true;
                dgv.DataSource = new List<object>();
            }
        }

        private static void AplicarEstiloDinamico(this DataGridView dgv)
        {
            Color colorBase = Color.FromArgb(0, 64, 64);
            Color colorAlterno = Color.FromArgb(0, 80, 80);
            Color colorTexto = Color.WhiteSmoke;

            dgv.CellFormatting += (s, e) =>
            {
                if (dgv.Columns[e.ColumnIndex] is DataGridViewButtonColumn)
                    return; // no tocar botones

                if (e.RowIndex % 2 == 0)
                {
                    e.CellStyle.BackColor = colorBase;
                    e.CellStyle.ForeColor = colorTexto;
                }
                else
                {
                    e.CellStyle.BackColor = colorAlterno;
                    e.CellStyle.ForeColor = colorTexto;
                }

                e.CellStyle.SelectionBackColor = Color.FromArgb(0, 120, 120);
                e.CellStyle.SelectionForeColor = Color.White;
                e.CellStyle.Font = new Font("Segoe UI", 11F);
            };
        }
        #endregion

       
    }
}
