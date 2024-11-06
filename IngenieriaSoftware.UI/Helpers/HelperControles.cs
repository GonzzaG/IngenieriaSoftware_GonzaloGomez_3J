using IngenieriaSoftware.Servicios.DTOs;
using IngenieriaSoftware.Servicios.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace IngenieriaSoftware.UI
{
    public class ControlesHelper
    {
        private readonly IIdiomaSujeto _idiomaSujeto;

        public ControlesHelper(IIdiomaSujeto idiomaSujeto)
        {
            _idiomaSujeto = idiomaSujeto;
        }

        #region ObtenerSuscriptores
        public void SuscribirControles(Form formulario)
        {
            foreach (Control control in formulario.Controls)
            {
                // Suscribir controles simples (que tienen un Tag que se puede usar como ID)
                if (control.Tag != null && int.TryParse(control.Tag.ToString(), out int _))
                {
                    var idiomaObservador = new IdiomaObservadorDTO
                    {
                        Control = control,
                        Tag = int.Parse(control.Tag.ToString()), // Asumiendo que el Tag contiene el ID del idioma
                        Name = control.Name,
                    };
                    _idiomaSujeto.Suscribir(idiomaObservador);
                }

                // Suscribir los elementos de menú dentro del menú strip
                if (control is MenuStrip menuStrip)
                {
                    foreach (ToolStripMenuItem menuItem in menuStrip.Items)
                    {
                        SuscribirMenuItems(menuItem);
                    }
                }

                // Recursivamente suscribir a controles dentro de contenedores
                SuscribirControlesRecursivos(control);
            }
        }

        private void SuscribirMenuItems(ToolStripMenuItem menuItem)
        {
            if (menuItem.Tag != null && int.TryParse(menuItem.Tag.ToString(), out int tag))
            {
                var idiomaObservador = new IdiomaObservadorDTO
                {
                    MenuItem = menuItem,
                    Tag = tag,
                    Name = menuItem.Name,
                };

                _idiomaSujeto.Suscribir(idiomaObservador);
            }

            // Si el menú tiene submenús, suscribir también
            foreach (ToolStripMenuItem subItem in menuItem.DropDownItems.OfType<ToolStripMenuItem>())
            {
                SuscribirMenuItems(subItem);
            }
        }

        private void SuscribirControlesRecursivos(Control parentControl)
        {
            foreach (Control control in parentControl.Controls)
            {
                if (control.Tag != null && int.TryParse(control.Tag.ToString(), out int tag))
                {
                    var idiomaObservador = new IdiomaObservadorDTO
                    {
                        Control = control,
                        Tag = tag,
                        Name = control.Name,
                    };

                    _idiomaSujeto.Suscribir(idiomaObservador);
                }

                // Recursivamente suscribir controles hijos
                SuscribirControlesRecursivos(control);
            }
        }

    #endregion



    #region ObtenerControlesDeFormulario
        public static Dictionary<string, IdiomaObservadorDTO> ListarControles(Control formulario)
        {
            Dictionary<string, IdiomaObservadorDTO> controles = new Dictionary<string, IdiomaObservadorDTO>();

            // Llamada recursiva para listar controles
            RecorrerControles(formulario, controles);

            return controles;
        }

        private static void RecorrerControles(Control control, Dictionary<string, IdiomaObservadorDTO> controles)
        {
            // Solo añadir si el Tag no es nulo o vacío
            if (!string.IsNullOrEmpty(control.Tag.ToString()))
            {
                // Crear y agregar el IdiomaSuscriptorDTO con el Control
                controles[control.Tag.ToString()] = new IdiomaObservadorDTO
                {
                    Tag = int.Parse(control.Tag.ToString()),
                    Control = control,
                    Name = control.Name
                };
            }

            // Si el control es un MenuStrip, recorrer sus items
            if (control is MenuStrip menuStrip)
            {
                foreach (ToolStripMenuItem item in menuStrip.Items)
                {
                    RecorrerMenuItems(item, controles);
                }
            }

            // Recorrer los controles hijos
            foreach (Control hijo in control.Controls)
            {
                RecorrerControles(hijo, controles);
            }
        }

        private static void RecorrerMenuItems(ToolStripMenuItem item, Dictionary<string, IdiomaObservadorDTO> controles)
        {
            // Agregar el item si tiene un Tag válido
            if (!string.IsNullOrEmpty(item.Tag?.ToString()))
            {
                // Crear y agregar el IdiomaSuscriptorDTO con el ToolStripMenuItem
                controles[item.Tag.ToString()] = new IdiomaObservadorDTO
                {
                    Tag = (int)item.Tag,
                    MenuItem = item,
                    Name = item.Name
                };
            }

            // Recursivamente recorrer sub-items
            foreach (ToolStripItem subItem in item.DropDownItems)
            {
                if (subItem is ToolStripMenuItem menuItem)
                {
                    RecorrerMenuItems(menuItem, controles);
                }
            }
        }

        #endregion

    }
}