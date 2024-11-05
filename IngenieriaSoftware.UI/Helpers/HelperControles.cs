using IngenieriaSoftware.Servicios.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace IngenieriaSoftware.UI
{
    public class ControlesHelper
    {
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
            if (!string.IsNullOrEmpty(control.Tag?.ToString()))
            {
                // Crear y agregar el IdiomaSuscriptorDTO con el Control
                controles[control.Tag.ToString()] = new IdiomaObservadorDTO
                {
                    Tag = control.Tag.ToString(),
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
                    Tag = item.Tag.ToString(),
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