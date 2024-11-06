using IngenieriaSoftware.Servicios.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IngenieriaSoftware.UI
{
    public class ControlIdiomaAdaptador : IIdiomaObservador
    {
        private readonly Control _control;

        public int Tag { get; set; }
        public string Name { get; set; }

        public ControlIdiomaAdaptador(Control control)
        {
            _control = control;
            Tag = int.Parse(control.Tag?.ToString() ?? "0"); // Asume que el Tag del control contiene el ID de traducción
        }

        public void Actualizar(string nuevoTexto)
        {
            if (Regex.IsMatch(_control.Name, @"(txt|comboBox)", RegexOptions.IgnoreCase))
            {
                //si es un textBox o un ComboBox, no lo modificamos
                //Control.Text = string.Empty;
            }
            else
            {
                _control.Text = nuevoTexto;
            }
        }
    }
}
