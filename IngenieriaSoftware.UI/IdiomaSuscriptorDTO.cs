using IngenieriaSoftware.Servicios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IngenieriaSoftware.UI
{
    public class IdiomaSuscriptorDTO: IIdiomaSuscriptor
    {
        public string Tag { get; set; }
        public Control Control {  get; set; }
    
        public void Actualizar(string nuevoTexto)
        {
            if (Regex.IsMatch(Control.Name, @"(txt)", RegexOptions.IgnoreCase))
            {
               // Si contiene una de las cadenas ingresdas, ej "txt" el texto estara vacio
                Control.Text = string.Empty;
            }
            else
            {
                // Si no contiene "txt" ni "lbl", asignar el nuevo texto
                Control.Text = nuevoTexto;
            }
        }
    }

}
