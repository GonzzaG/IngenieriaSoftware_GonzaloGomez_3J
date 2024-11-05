using System;
using System.Collections.Generic;
using System.Reflection;
using System.Windows.Forms;

namespace IngenieriaSoftware.UI
{
    internal class HelperForms
    {
        #region ObtenerControlesDeFormulario

        public static Dictionary<string, IdiomaSuscriptorDTO> ListarControles(Control formulario)
        {
            Dictionary<string, IdiomaSuscriptorDTO> controles = new Dictionary<string, IdiomaSuscriptorDTO>();

            // Llamada recursiva para listar controles
            RecorrerControles(formulario, controles);

            return controles;
        }

        private static void RecorrerControles(Control control, Dictionary<string, IdiomaSuscriptorDTO> controles)
        {
            // Solo añadir si el Tag no es nulo o vacío
            if (!string.IsNullOrEmpty(control.Tag?.ToString()))
            {
                // Crear y agregar el IdiomaSuscriptorDTO con el Control
                controles[control.Tag.ToString()] = new IdiomaSuscriptorDTO
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

        private static void RecorrerMenuItems(ToolStripMenuItem item, Dictionary<string, IdiomaSuscriptorDTO> controles)
        {
            // Agregar el item si tiene un Tag válido
            if (!string.IsNullOrEmpty(item.Tag?.ToString()))
            {
                // Crear y agregar el IdiomaSuscriptorDTO con el ToolStripMenuItem
                controles[item.Tag.ToString()] = new IdiomaSuscriptorDTO
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

        #endregion ObtenerControlesDeFormulario







        #region ObtenerControlesDeFormulario

        //public static Dictionary<string, Control> ListarControles(Control formulario)
        //{
        //    Dictionary<string, Control> controles = new Dictionary<string, Control>();

        //    // Llamada recursiva para listar controles
        //    RecorrerControles(formulario, controles);

        //    return controles;
        //}

        //private static void RecorrerControles(Control control, Dictionary<string, Control> controles)
        //{
        //    // Solo añadir si el Tag no es nulo o vacío
        //    if (!string.IsNullOrEmpty(control.Tag?.ToString()))
        //    {
        //        // Agregar el Tag y el Control al diccionario
        //        controles[control.Tag.ToString()] = control;
        //    }

        //    if (control is MenuStrip menuStrip)
        //    {
        //        foreach (ToolStripMenuItem item in menuStrip.Items)
        //        {
        //            RecorrerMenuItems(item, controles);
        //        }
        //    }

        //    // Recorrer los controles hijos
        //    foreach (Control hijo in control.Controls)
        //    {
        //        RecorrerControles(hijo, controles);
        //    }
        //}

        //private static void RecorrerMenuItems(ToolStripMenuItem item, Dictionary<string, Control> controles)
        //{
        //    // Agregar el item si tiene un Tag válido
        //    if (!string.IsNullOrEmpty(item.Tag?.ToString()))
        //    {
        //        // Dado que ToolStripMenuItem no es un Control, no se puede agregar directamente como Control
        //        // Guardaremos su referencia como `null` u otra estructura personalizada si es necesario
        //        controles[item.Tag.ToString()] = null;
        //    }

        //    // Recursivamente recorrer sub-items
        //    foreach (ToolStripMenuItem subItem in item.DropDownItems)
        //    {
        //        if (subItem is ToolStripMenuItem) // Verificar que sea un ToolStripMenuItem
        //        {
        //            RecorrerMenuItems(subItem as ToolStripMenuItem, controles);
        //        }
        //    }
        //}

        #endregion ObtenerControlesDeFormulario

        public static List<Form> InstanciarTodosLosFormularios(Form mdiParent)
        {
            List<Form> formularios = new List<Form>();

            // Obtener el ensamblado actual
            Assembly ensamblado = Assembly.GetExecutingAssembly();

            // Buscar todos los tipos dentro del ensamblado
            foreach (Type tipo in ensamblado.GetTypes())
            {
                // Verificar si el tipo es un formulario y tiene un constructor público sin parámetros
                if (tipo.IsSubclassOf(typeof(Form)) && tipo.GetConstructor(Type.EmptyTypes) != null)
                {
                    try
                    {
                        Form formulario = (Form)Activator.CreateInstance(tipo);

                        // Asignar el MDI parent solo si no es contenedor MDI
                        if (!formulario.IsMdiContainer)
                        {
                            formulario.MdiParent = mdiParent;
                            formularios.Add(formulario);
                        }
                    }
                    catch (Exception ex)
                    {
                        // Opcional: Manejar o registrar la excepción para saber cuál formulario no pudo instanciarse
                        Console.WriteLine($"Error al instanciar el formulario {tipo.Name}: {ex.Message}");
                    }
                }
            }

            return formularios;
        }

    }
}