using IngenieriaSoftware.Servicios;
using IngenieriaSoftware.Servicios.Interfaces;
using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace IngenieriaSoftware.UI
{
    public class IdiomaObservadorDTO : IIdiomaObservador
    {
        public Control Control { get; set; }
        public ToolStripMenuItem MenuItem { get; set; }
        public int Tag { get; set; }
        public string Name { get; set; }

        public void Actualizar(string nuevoTexto)
        {
         
            if (Control != null)
            {
                if (Regex.IsMatch(Control.Name, @"(txt|comboBox)", RegexOptions.IgnoreCase))
                {
                    //Control.Text = string.Empty;
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
                    //si es un textBox o un ComboBox, no lo modificamos
                    //MenuItem.Text = string.Empty;
                }
                else
                {
                    MenuItem.Text = nuevoTexto;
                }
            }
        }

    }
}