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

        public static void PersonalizarEstiloPredeterminado(this DataGridView dgv)
        {
            // Paleta de colores que combinan con DarkSlateGray
            Color colorBase = Color.FromArgb(0, 64, 64);        // fondo principal
            Color colorAlterno = Color.FromArgb(0, 80, 80);     // fila alterna
            Color colorEncabezado = Color.FromArgb(0, 90, 90);  // encabezado
            Color colorTexto = Color.WhiteSmoke;

            // General
            dgv.BackgroundColor = colorBase;
            dgv.BorderStyle = BorderStyle.None;
            dgv.EnableHeadersVisualStyles = false;
            dgv.GridColor = Color.FromArgb(20, 100, 100); // líneas suaves
            dgv.MultiSelect = false;
            dgv.EditMode = DataGridViewEditMode.EditProgrammatically;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            // Encabezado de columnas
            dgv.ColumnHeadersDefaultCellStyle.BackColor = colorEncabezado;
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = colorTexto;
            dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            dgv.ColumnHeadersHeight = 50;

            // Celdas normales
            dgv.DefaultCellStyle.BackColor = colorBase;
            dgv.DefaultCellStyle.ForeColor = colorTexto;
            dgv.DefaultCellStyle.SelectionBackColor = Color.FromArgb(0, 120, 120);
            dgv.DefaultCellStyle.SelectionForeColor = Color.White;
            dgv.DefaultCellStyle.Font = new Font("Segoe UI", 11F);

            // Celdas alternas
            dgv.AlternatingRowsDefaultCellStyle.BackColor = colorAlterno;
            dgv.AlternatingRowsDefaultCellStyle.ForeColor = colorTexto;
            dgv.AlternatingRowsDefaultCellStyle.SelectionBackColor = Color.FromArgb(0, 120, 120);
            dgv.AlternatingRowsDefaultCellStyle.SelectionForeColor = Color.White;
            dgv.AlternatingRowsDefaultCellStyle.Font = new Font("Segoe UI", 11F);

            // Quitar encabezado de filas
            dgv.RowHeadersVisible = false;

            // AutoSize
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv.RowTemplate.Height = 45; // Ajusta altura para que no se corte el texto
            dgv.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgv.Width += 5;

        }
    }
}
