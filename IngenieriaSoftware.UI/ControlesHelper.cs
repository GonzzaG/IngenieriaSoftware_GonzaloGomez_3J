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
    public class ControlesHelper
    {

        public static List<EtiquetaDTO> ObtenerEtiquetas(Control.ControlCollection controles)
        {
            var etiquetas = new List<EtiquetaDTO>();
            ObtenerEtiquetasRecursivo(controles, etiquetas);
            return etiquetas;
        }

        private static void ObtenerEtiquetasRecursivo(Control.ControlCollection controles, List<EtiquetaDTO> etiquetas)
        {
            // Recorrer todos los controles en el formulario
            foreach (Control c in controles)
            {
                // Comprobar que el Tag sea un entero y el Name no sea nulo o vacío
                if (Convert.ToInt32(c.Tag) is int etiquetaId && !string.IsNullOrEmpty(c.Name))
                {
                    etiquetas.Add(new EtiquetaDTO
                    {
                        Id = etiquetaId,
                        Nombre = c.Name,
                        Tag = c.Tag.ToString() 
                    });
                }

                // Si el control tiene hijos, recorrerlos recursivamente
                ObtenerEtiquetasRecursivo(c.Controls, etiquetas);
            }
        }
























        public static Dictionary<string, object> ControlesRegistrados = new Dictionary<string, object>();

        public static void RegistrarControles(Control control, List<EtiquetaDTO> etiquetas)
        {
            foreach (Control c in control.Controls)
            {
                // Si el control es un MenuStrip, procesar sus elementos de menú
                if (c is MenuStrip menuStrip)
                {
                    foreach (ToolStripItem menuItem in menuStrip.Items)
                    {
                        RegistrarElementoMenu(menuItem, etiquetas);
                    }
                }
                else
                {
                    // Para controles normales, buscar la etiqueta y asignar el Tag si hay coincidencia
                    var etiqueta = etiquetas.FirstOrDefault(e => e.Nombre == c.Name);
                    if (etiqueta != null)
                    {
                        c.Tag = etiqueta.Id;
                        string claveUnica = $"{etiqueta.Id}_{etiqueta.Nombre}";

                        if (!ControlesRegistrados.ContainsKey(claveUnica))
                        {
                            ControlesRegistrados[claveUnica] = c;
                        }
                    }

                    // Llamada recursiva para subcontroles
                    if (c.HasChildren)
                    {
                        RegistrarControles(c, etiquetas);
                    }
                }
            }
        }

        // Método auxiliar para registrar los elementos de menú recursivamente
        private static void RegistrarElementoMenu(ToolStripItem menuItem, List<EtiquetaDTO> etiquetas)
        {
            var etiqueta = etiquetas.FirstOrDefault(e => e.Nombre == menuItem.Name);
            if (etiqueta != null)
            {
                // Asignar el etiqueta_id al Tag del elemento de menú
                menuItem.Tag = etiqueta.Id;
                string claveUnica = $"{etiqueta.Id}_{etiqueta.Nombre}";

                if (!ControlesRegistrados.ContainsKey(claveUnica))
                {
                    ControlesRegistrados[claveUnica] = menuItem;
                }
            }

            // Si el elemento es un ToolStripMenuItem, verificar si tiene subelementos
            if (menuItem is ToolStripMenuItem toolStripMenuItem && toolStripMenuItem.DropDownItems.Count > 0)
            {
                foreach (ToolStripItem subItem in toolStripMenuItem.DropDownItems)
                {
                    RegistrarElementoMenu(subItem, etiquetas);
                }
            }
        }

        //le paso como parametro la lista de traducciones traida de la BD
        public static void AplicarTraducciones(Dictionary<string, string> traducciones)
        {
            foreach (var entry in ControlesRegistrados)
            {
                string claveUnica = entry.Key;
                Control control = (Control)entry.Value;

                // Verificar si existe una traducción para la clave
                if (traducciones.ContainsKey(claveUnica))
                {
                    control.Text = traducciones[claveUnica];
                }
            }
        }





























        private static Dictionary<string, string> etiquetasPorNombre = new Dictionary<string, string>();

        #region Tagsablecer el Tag de cada control en función de su Nombre
        public static void EstablecerTags(Control control)
        {
            foreach (Control c in control.Controls)
            {
 
        // Método para est
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
