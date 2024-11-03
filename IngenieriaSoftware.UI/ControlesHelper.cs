using IngenieriaSoftware.BEL;
using IngenieriaSoftware.BEL.Idiomas;
using IngenieriaSoftware.Servicios.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IngenieriaSoftware.UI
{
    internal class ControlesHelper
    {
        private static Dictionary<string, string> etiquetasPorNombre = new Dictionary<string, string>();


        #region Tags
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

        public static void AsignarEtiquetaIdsAControles(Control form, List<EtiquetaDTO> etiquetasBD)
        {
            foreach (Control control in form.Controls)
            {
                // Aquí asumimos que cada control tiene su nombre configurado
                if (!string.IsNullOrEmpty(control.Name))
                {
                    // Busca la etiqueta correspondiente en la lista de etiquetas de la BD
                    EtiquetaDTO etiqueta = etiquetasBD.FirstOrDefault(e => e.Nombre.Equals(control.Name, StringComparison.OrdinalIgnoreCase));
                    if (etiqueta != null)
                    {
                        control.Tag = etiqueta.Id; // Asignar el etiqueta_id al Tag del control
                    }
                }

                // Llamada recursiva para controles que contienen otros controles
                if (control.HasChildren)
                {
                    AsignarEtiquetaIdsAControles(form, etiquetasBD);
                }
            }
        }
        #endregion

        #region Obtener tags en memoria
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
        #endregion

        #region Traducciones
        // Método para obtener un diccionario con los Tags y Nombres de todos los controles
        public static Dictionary<string, string> ObtenerTagsYNombresDeTodosLosControles(Form formularioPadre)
        {
            etiquetasPorNombre.Clear(); // Limpiar el diccionario antes de llenarlo
            ObtenerTagsYNombresRecursivamente(formularioPadre);

            foreach (Form formularioHijo in formularioPadre.MdiChildren)
            {
                ObtenerTagsYNombresRecursivamente(formularioHijo);
            }

            return etiquetasPorNombre;
        }
        private static void ObtenerTagsYNombresRecursivamente(Control control)
        {
            foreach (Control c in control.Controls)
            {
                if (c.Tag != null)
                {
                    etiquetasPorNombre[c.Name] = c.Text.ToString(); // Guardar nombre y etiqueta
                }

                if (c.HasChildren)
                {
                    ObtenerTagsYNombresRecursivamente(c);
                }
            }
        }

        public static void ActualizarControlesConTraducciones(Control control, Dictionary<string, string> traducciones, List<EtiquetaDTO> etiquetas)
        {
            // Definir un regex para las palabras clave que indican que el texto debe estar vacío
            var regex = new Regex("txt|treeView|dataGrid", RegexOptions.IgnoreCase); // Reemplaza por tus palabras clave

            foreach (Control c in control.Controls)
            {
                // Comprobar si el control tiene un Tag y obtener el id
                if (c.Tag != null)
                {
                    // Obtener el etiqueta_id desde el Tag
                    int etiquetaId;
                    if (int.TryParse(c.Tag.ToString(), out etiquetaId))
                    {
                        // Buscar la etiqueta correspondiente en la lista de etiquetas
                        var etiqueta = etiquetas.FirstOrDefault(e => e.Id == etiquetaId);
                        if (etiqueta != null)
                        {
                            // Crear la clave única para el Dictionary
                            string claveUnica = $"{etiqueta.Id}_{etiqueta.Nombre}";

                            // Comprobar si la clave existe en el Dictionary de traducciones
                            if (traducciones.ContainsKey(claveUnica))
                            {
                                // Obtener la traducción correspondiente
                                string traduccion = traducciones[claveUnica];

                                // Validar si el Nombre de la etiqueta contiene palabras clave
                                if (regex.IsMatch(etiqueta.Nombre)) // Verifica si el nombre de la etiqueta contiene palabras clave
                                {
                                    c.Text = ""; // Establecer el texto como vacío
                                }
                                else
                                {
                                    // Asignar la traducción correspondiente al Text del control
                                    c.Text = traduccion;
                                }
                            }
                        }
                    }
                }

                // Llamada recursiva para controles que contienen otros controles
                if (c.HasChildren)
                {
                    ActualizarControlesConTraducciones(c, traducciones, etiquetas);
                }
                if (control is MenuStrip menuStrip)
                {
                    foreach (ToolStripMenuItem item in menuStrip.Items)
                    {
                        ActualizarMenuItemConTraducciones(item, traducciones, etiquetas, regex);
                    }
                }
            }
        }

        // Método para actualizar los ToolStripMenuItems
        private static void ActualizarMenuItemConTraducciones(ToolStripMenuItem item, Dictionary<string, string> traducciones, List<EtiquetaDTO> etiquetas, Regex regex)
        {
            // Comprobar si el ToolStripMenuItem tiene un Tag y obtener el id
            if (item.Tag != null)
            {
                // Obtener el etiqueta_id desde el Tag
                int etiquetaId;
                if (int.TryParse(item.Tag.ToString(), out etiquetaId))
                {
                    // Buscar la etiqueta correspondiente en la lista de etiquetas
                    var etiqueta = etiquetas.FirstOrDefault(e => e.Id == etiquetaId);
                    if (etiqueta != null)
                    {
                        // Crear la clave única para el Dictionary
                        string claveUnica = $"{etiqueta.Id}_{etiqueta.Nombre}";

                        // Comprobar si la clave existe en el Dictionary de traducciones
                        if (traducciones.ContainsKey(claveUnica))
                        {
                            // Obtener la traducción correspondiente
                            string traduccion = traducciones[claveUnica];

                            // Validar si el Nombre de la etiqueta contiene palabras clave
                            if (!regex.IsMatch(etiqueta.Nombre))
                            {
                                // Asignar la traducción correspondiente al Text del ToolStripMenuItem
                                item.Text = traduccion;
                            }
                            else
                            {
                                // Establecer el texto como vacío si contiene palabras clave
                                item.Text = "";
                            }
                        }
                    }
                }
            }

            // Llamada recursiva para elementos de submenú
            foreach (ToolStripItem subItem in item.DropDownItems)
            {
                if (subItem is ToolStripMenuItem subMenuItem)
                {
                    ActualizarMenuItemConTraducciones(subMenuItem, traducciones, etiquetas, regex);
                }
            }
        }




        #endregion
    }
}
