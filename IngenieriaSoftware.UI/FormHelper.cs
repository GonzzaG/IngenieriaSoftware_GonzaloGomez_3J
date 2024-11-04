using IngenieriaSoftware.Servicios.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IngenieriaSoftware.UI
{
    internal class FormHelper
    {

        #region Actualizar Traduccion de controles
        public static void ActualizarTraducciones(Dictionary<string, string> traducciones, Control Control)
        {
            // Actualizar los controles de nivel superior
            foreach (Control control in Control.Controls)
            {
                if (control.Tag != null && traducciones.ContainsKey(control.Tag.ToString()))
                {
                    control.Text = traducciones[control.Tag.ToString()];
                }

                // Llamar recursivamente a ActualizarTraducciones para controlar los controles hijos
                ActualizarControlesHijos(control, traducciones);
            }
        }


        private static void ActualizarControlesHijos(Control Control, Dictionary<string, string> traducciones)
        {
            // Actualizar controles secundarios
            foreach (Control controlHijo in Control.Controls)
            {
                if (controlHijo.Tag != null && traducciones.ContainsKey(controlHijo.Tag.ToString()))
                {
                    controlHijo.Text = traducciones[controlHijo.Tag.ToString()];
                }

                // Llamar recursivamente si hay más controles anidados
                ActualizarControlesHijos(controlHijo, traducciones);
            }
        }

        #endregion

        #region ObtenerControlesDeFormulario

        public static Dictionary<string, Control> ListarControles(Control formulario)
        {
            Dictionary<string, Control> controles = new Dictionary<string, Control>();

            // Llamada recursiva para listar controles
            RecorrerControles(formulario, controles);

            return controles;
        }
        private static void RecorrerControles(Control control, Dictionary<string, Control> controles)
        {
            // Solo añadir si el Tag no es nulo o vacío
            if (!string.IsNullOrEmpty(control.Tag?.ToString()))
            {
                // Agregar el Tag y el Control al diccionario
                controles[control.Tag.ToString()] = control;
            }

            // Recorrer los controles hijos
            foreach (Control hijo in control.Controls)
            {
                RecorrerControles(hijo, controles);
            }
        }

        #endregion

















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
                    // Crear instancia del formulario
                    Form formulario = (Form)Activator.CreateInstance(tipo);
                    if (formulario.IsMdiContainer == true) break;
                    // Establecer el formulario como hijo del MDI
                    formulario.MdiParent = mdiParent;

                    // Agregar el formulario a la lista
                    formularios.Add(formulario);
                }
            }

            return formularios;
        }

    }
}
