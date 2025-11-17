using IngenieriaSoftware.BLL.ConnectionManager;
using System;
using System.Windows.Forms;

namespace IngenieriaSoftware.UI
{
    internal static class Program
    {
        [STAThread]
        private static void Main()
        {
            try
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);

                //if (!ProductoService.TestConnection(out string error))
                //{
                //    MessageBox.Show(
                //        "No se pudo iniciar la aplicación:\n\n" + error,
                //        "Error de conexión a SQL Server",
                //        MessageBoxButtons.OK,
                //        MessageBoxIcon.Error
                //    );
                //    return;
                //}

                Application.Run(new FormMDI());
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al inicializar la aplicación:\n" + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }
    }
}
