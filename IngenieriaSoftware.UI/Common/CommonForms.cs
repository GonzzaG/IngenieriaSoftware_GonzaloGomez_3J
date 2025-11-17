using IngenieriaSoftware.BEL.Negocio;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IngenieriaSoftware.UI.Common
{
    public static class CommonForms
    {
        internal static event EventHandler ModalCerrado;

        public static void Redireccionar(this Form formActual, Form formDestino)
        {
            if(formActual is null || formDestino is null)
                return; 

            var formMDI = formActual.MdiParent as FormMDI;
            if (formMDI is null)
                return;

            formMDI.AbrirFormHijo(formDestino);

        }

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


        internal static void AbrirFormModal(this Form modal, Size? size = null)
        {
            modal.StartPosition = FormStartPosition.CenterScreen;
            modal.Size = size ?? new Size(1680, 800);
            modal.AutoScroll = true;
            modal.ShowDialog();
        }

        internal static void MensajeInformativo(this string mensaje)
        {
            MessageBox.Show(mensaje, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        internal static void MensajeError(this string mensaje)
        {
            MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        internal static void MensajeAdvertencia(this string mensaje)
        {
            MessageBox.Show(mensaje, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }   

    }
}
