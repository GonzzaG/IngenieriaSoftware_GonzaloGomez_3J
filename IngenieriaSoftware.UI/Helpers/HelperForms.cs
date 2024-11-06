using System;
using System.Collections.Generic;
using System.Reflection;
using System.Windows.Forms;

namespace IngenieriaSoftware.UI
{
    internal class HelperForms
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