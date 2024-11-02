using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IngenieriaSoftware.UI
{
    internal class ControlesHelper
    {
        // Método para establecer el Tag de cada control en función de su Nombre
        public static void EstablecerTags(Control control)
        {
            foreach (Control c in control.Controls)
            {
 
                if (c.HasChildren)
                {
                    EstablecerTags(c);
                }

         
                c.Tag = c.Name;
            }
        }

        public static List<string> ObtenerTagsDeTodosLosControles(Form formularioPadre)
        {
            var tags = new List<string>();

            ObtenerTagsRecursivamente(formularioPadre, tags);

            foreach (Form formularioHijo in formularioPadre.MdiChildren)
            {
                ObtenerTagsRecursivamente(formularioHijo, tags);
            }

            return tags;
        }

        private static void ObtenerTagsRecursivamente(Control control, List<string> tags)
        {
            foreach (Control c in control.Controls)
            {
                if (c.Tag != null) 
                {
                    tags.Add(c.Tag.ToString());
                }

                if (c.HasChildren)
                {
                    ObtenerTagsRecursivamente(c, tags);
                }
            }
        }

        // Método para cargar traducciones en los controles de un formulario
        public static void CargarTraducciones(Control control, Dictionary<string, string> traducciones)
        {
            foreach (Control c in control.Controls)
            {
                if (c.Tag != null && traducciones.ContainsKey(c.Tag.ToString()))
                {
                    c.Text = traducciones[c.Tag.ToString()];
                }
                if (c.HasChildren)
                {
                    CargarTraducciones(c, traducciones);
                }
            }
        }
    }
}
