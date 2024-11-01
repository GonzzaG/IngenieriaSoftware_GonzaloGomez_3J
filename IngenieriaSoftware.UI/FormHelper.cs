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
