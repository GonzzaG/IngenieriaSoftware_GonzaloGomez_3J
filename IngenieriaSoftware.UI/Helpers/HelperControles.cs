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
        // Contador global para el Tag
        private static int TagContador = 500;

        private readonly IIdiomaSujeto _idiomaSujeto;

        public ControlesHelper(IIdiomaSujeto idiomaSujeto)
        {
            _idiomaSujeto = idiomaSujeto;
        }

        #region Suscribir Controles
        public void SuscribirControles(Form formulario)
        {
            foreach (Control control in formulario.Controls)
            {
                // Suscribir controles comunes usando adaptador
                if (control.Tag != null && int.TryParse(control.Tag.ToString(), out int _))
                {
                    var controlAdaptador = new ControlIdiomaAdaptador(control);
                    _idiomaSujeto.Suscribir(controlAdaptador);
                }

                // Suscribir los elementos de menú dentro del MenuStrip usando adaptador
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
            if (menuItem.Tag != null && int.TryParse(menuItem.Tag.ToString(), out int _))
            {
                var menuItemAdaptador = new MenuItemIdiomaAdaptador(menuItem);
                _idiomaSujeto.Suscribir(menuItemAdaptador);
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
                if (control.Tag != null && int.TryParse(control.Tag.ToString(), out int _))
                {
                    var controlAdaptador = new ControlIdiomaAdaptador(control);
                    _idiomaSujeto.Suscribir(controlAdaptador);
                }

                // Recursivamente suscribir controles hijos
                SuscribirControlesRecursivos(control);
            }
        }
        #endregion



        #region Obtener Controles Del Formulario
        public static Dictionary<string, IdiomaObservadorDTO> ListarControles(Control formulario)
        {
            Dictionary<string, IdiomaObservadorDTO> controles = new Dictionary<string, IdiomaObservadorDTO>();

            RecorrerControles(formulario, controles);

            TagContador = 1;

            return controles;
        }

        private static void RecorrerControles(Control control, Dictionary<string, IdiomaObservadorDTO> controles)
        {
            // Si el control tiene un Tag, lo usamos, si no, asignamos uno nuevo usando el TagContador
            if(control.Tag == null) { control.Tag = 0; }
            if (int.Parse(control.Tag.ToString()) is int tagValue)
            {
                controles[tagValue.ToString()] = new IdiomaObservadorDTO
                {
                    Tag = tagValue,
                    Control = control,
                    Name = control.Name
                };
            }
            else
            {
                // Asignar un nuevo Tag si el control no tiene uno
                int nuevoTag = controles.Count() + TagContador++;
                control.Tag = nuevoTag;  // Asignamos el Tag al control
                controles[nuevoTag.ToString()] = new IdiomaObservadorDTO
                {
                    Tag = nuevoTag,
                    Control = control,
                    Name = control.Name
                };
            }

            // Si el control es un MenuStrip, recorremos sus items
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

        // Recursivamente recorrer los items del MenuStrip
        private static void RecorrerMenuItems(ToolStripMenuItem item, Dictionary<string, IdiomaObservadorDTO> controles)
        {
            // Verificamos si el Tag es nulo o vacío, o si el valor es 0
            if (item.Tag == null || string.IsNullOrEmpty(item.Tag.ToString()) || int.Parse(item.Tag.ToString()) == 0)
            {
                item.Tag = controles.Count() + TagContador++;
            }

            controles[item.Tag.ToString()] = new IdiomaObservadorDTO
            {
                Tag = int.Parse(item.Tag.ToString()),
                MenuItem = item,
                Name = item.Name
            };

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