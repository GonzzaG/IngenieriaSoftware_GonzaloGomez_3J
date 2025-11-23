using IngenieriaSoftware.BEL.Interfaces;
using IngenieriaSoftware.Servicios.Interfaces;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace IngenieriaSoftware.UI.Common
{
    public class CommonControles
    {
        private static int TagContador = 500;

        private readonly IIdiomaSujeto _idiomaSujeto;

        public CommonControles(IIdiomaSujeto idiomaSujeto)
        {
            _idiomaSujeto = idiomaSujeto;
        }

        #region Suscribir Controles

        public void SuscribirControles(Form formulario)
        {
            foreach (Control control in formulario.Controls)
            {
                if (control.Tag != null && int.TryParse(control.Tag.ToString(), out int _) && control is not IUserControlCustom)
                {
                    var controlAdaptador = new ControlIdiomaAdaptador(control);
                    _idiomaSujeto.Suscribir(controlAdaptador);
                }

                if (control is MenuStrip menuStrip)
                {
                    foreach (ToolStripMenuItem menuItem in menuStrip.Items)
                    {
                        SuscribirMenuItems(menuItem);
                    }
                }

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

        #endregion Suscribir Controles

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
            int tagValue;

            // Intentamos obtener el tag como entero
            if (control.Tag != null &&
                !string.IsNullOrWhiteSpace(control.Tag.ToString()) &&
                int.TryParse(control.Tag.ToString(), out tagValue) &&
                tagValue > 0)
            {
                // Tag existente válido
            }
            else
            {
                // Asignamos uno nuevo
                tagValue = controles.Count + TagContador++;
                control.Tag = tagValue;
            }

            // Registrar el control
            controles[tagValue.ToString()] = new IdiomaObservadorDTO
            {
                Tag = tagValue,
                Control = control,
                Name = control.Name
            };

            // Recorrer MenuStrip
            if (control is MenuStrip menuStrip)
            {
                foreach (ToolStripMenuItem item in menuStrip.Items)
                {
                    RecorrerMenuItems(item, controles);
                }
            }

            // Recorrer hijos
            foreach (Control hijo in control.Controls)
            {
                RecorrerControles(hijo, controles);
            }
        }


        private static void RecorrerMenuItems(ToolStripMenuItem item, Dictionary<string, IdiomaObservadorDTO> controles)
        {
            int tagValue;

            if (item.Tag != null &&
                !string.IsNullOrWhiteSpace(item.Tag.ToString()) &&
                int.TryParse(item.Tag.ToString(), out tagValue) &&
                tagValue > 0)
            {
                // Tag válido
            }
            else
            {
                tagValue = controles.Count + TagContador++;
                item.Tag = tagValue;
            }

            controles[tagValue.ToString()] = new IdiomaObservadorDTO
            {
                Tag = tagValue,
                MenuItem = item,
                Name = item.Name
            };

            foreach (ToolStripItem subItem in item.DropDownItems)
            {
                if (subItem is ToolStripMenuItem menuItem)
                {
                    RecorrerMenuItems(menuItem, controles);
                }
            }
        }


        #endregion Obtener Controles Del Formulario
    }
}