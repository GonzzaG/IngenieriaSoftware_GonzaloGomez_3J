using IngenieriaSoftware.Servicios;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace IngenieriaSoftware.UI
{
    public class IdiomaObservadorDTO : IIdiomaObservador
    {
        public string Tag { get; set; }
        public Control Control { get; set; }
        public ToolStripMenuItem MenuItem { get; set; } 
        public string Name { get; set; }

        public void Actualizar(string nuevoTexto)
        {
            // Si es un Control, aplicar el texto según las reglas establecidas
            if (Control != null)
            {
                if (Regex.IsMatch(Control.Name, @"(txt)", RegexOptions.IgnoreCase))
                {
                    Control.Text = string.Empty;
                }
                else
                {
                    Control.Text = nuevoTexto;
                }
            }
            // Si es un ToolStripMenuItem, asignar el texto directamente
            else if (MenuItem != null)
            {
                if (Regex.IsMatch(MenuItem.Name, @"(txt)", RegexOptions.IgnoreCase))
                {
                    MenuItem.Text = string.Empty;
                }
                else
                {
                    MenuItem.Text = nuevoTexto;
                }
            }
        }
    }
}