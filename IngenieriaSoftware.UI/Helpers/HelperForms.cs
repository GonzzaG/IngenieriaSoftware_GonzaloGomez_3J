using IngenieriaSoftware.BEL.Negocio;
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

            Assembly ensamblado = Assembly.GetExecutingAssembly();

            foreach (Type tipo in ensamblado.GetTypes())
            {
                if (tipo.IsSubclassOf(typeof(Form)) && tipo.GetConstructor(Type.EmptyTypes) != null)
                {
                    try
                    {
                        Form formulario = (Form)Activator.CreateInstance(tipo);

                        if (!formulario.IsMdiContainer)
                        {
                            formulario.MdiParent = mdiParent;
                            formularios.Add(formulario);
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Error al instanciar el formulario {tipo.Name}: {ex.Message}");
                    }
                }
            }

            return formularios;
        }

        public static void MostrarNotificacion(List<Notificacion> notificaciones, Form form)
        {
            ToolTip notificacionTooltip = new ToolTip
            {
                IsBalloon = true,
                AutoPopDelay = 5000,
                InitialDelay = 500,
                ReshowDelay = 500,
                ToolTipTitle = "Notificación",
                ToolTipIcon = ToolTipIcon.Info
            };

            string mensaje = string.Join("\n", notificaciones);

            int posX = 10;
            int posY = form.Height - 130;

            notificacionTooltip.Show("Tiene comandas listas para entregar", form, posX, posY);

            Timer timer = new Timer
            {
                Interval = notificacionTooltip.AutoPopDelay
            };
            timer.Tick += (s, e) =>
            {
                if (!form.IsDisposed)
                {
                    notificacionTooltip.Hide(form);
                }

                timer.Stop();
                timer.Dispose();
            };
            timer.Start();
        }
    }
}