using IngenieriaSoftware.BLL.Ayuda;
using System;
using System.Windows.Forms;

namespace IngenieriaSoftware.UI.Ayuda
{
    public partial class FormSolicitarAyuda : Form
    {
        private AyudaService ayudaService = new AyudaService();
        public FormSolicitarAyuda()
        {
            InitializeComponent();
        }

        private async void btnSeleccionarProductos_Click(object sender, EventArgs e)
        {
            try
            {

                string resultado = await ayudaService.EnviarAyuda(
                            txtEmail.Text,
                            txtTelefono.Text,
                            txtMensaje.Text
                        );

                if (resultado == "OK")
                    MessageBox.Show("Su mensaje fue enviado con éxito.");
                else
                    MessageBox.Show("Hubo un problema: " + resultado);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
