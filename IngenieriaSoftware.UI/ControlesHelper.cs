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
        // Método para establecer el Tag de cada control en función de su Name
        public static void EstablecerTags(Control control)
        {
            foreach (Control c in control.Controls)
            {
                // Si el control tiene controles hijos, llamar recursivamente
                if (c.HasChildren)
                {
                    EstablecerTags(c);
                }

                // Establecer el Tag igual al Name del control
                c.Tag = c.Name;
            }
        }

        public static List<string> ObtenerTagsDeTodosLosControles(Form formularioPadre)
        {
            var tags = new List<string>();

            // Obtener tags de los controles del formulario principal
            ObtenerTagsRecursivamente(formularioPadre, tags);

            // Si el formulario principal tiene formularios hijos, obtener sus tags también
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
                if (c.Tag != null) // Verificar que el Tag no sea null
                {
                    tags.Add(c.Tag.ToString());
                }

                // Llamar recursivamente si el control tiene hijos
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

                // Si el control tiene controles hijos, llamar recursivamente
                if (c.HasChildren)
                {
                    CargarTraducciones(c, traducciones);
                }
            }
        }
    }
}
