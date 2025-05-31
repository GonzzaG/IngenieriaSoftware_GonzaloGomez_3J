using IngenieriaSoftware.BEL.Negocio;
using IngenieriaSoftware.BLL;
using IngenieriaSoftware.Servicios;
using System;
using System.Windows.Forms;

namespace IngenieriaSoftware.UI
{
    public partial class FormRellenarCliente : Form
    {
        private readonly ClienteBLL _clienteBLL = new ClienteBLL();
        private bool EsBancario;
        internal int ClienteId { get; private set; }

        public FormRellenarCliente(bool esBancario)
        {
            InitializeComponent();

            txtNombre.Text = "gonza";
            txtApellido.Text = "gomez";
            txtEmail.Text = "gonzalogomezhf@gmail.com";
            txtTelefono.Text = "1234567890";
            txtDireccion.Text = "Av. Siempre viva 742";
            EsBancario = esBancario;
            DatosBancarios(esBancario);
        }

        private void DatosBancarios(bool _esBancario)
        {
            if (_esBancario)
            {
                lblTipoTarjeta.Visible = true;
                txtTipoTarjeta.Visible = true;
                lblNumeroTarjeta.Visible = true;
                txtNumeroTarjeta.Visible = true;
                lblBancoEmisor.Visible = true;
                txtBancoEmisor.Visible = true;

                txtTipoTarjeta.Text = "asdf";
                txtNumeroTarjeta.Text = "1231312123";
                txtBancoEmisor.Text = "itau";
            }
            else
            {
                lblTipoTarjeta.Visible = false;
                txtTipoTarjeta.Visible = false;
                lblNumeroTarjeta.Visible = false;
                txtNumeroTarjeta.Visible = false;
                lblBancoEmisor.Visible = false;
                txtBancoEmisor.Visible = false;
            }
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            try
            {
                Cliente cliente;
                if (EsBancario)
                {
                    cliente = new Cliente
                    {
                        Nombre = txtNombre.Text,
                        Apellido = txtApellido.Text,
                        Email = txtEmail.Text,
                        Telefono = txtTelefono.Text,
                        Direccion = txtDireccion.Text,
                        numeroTarjetaUltimos4 = txtNumeroTarjeta.Text,
                        TipoTarjeta = txtTipoTarjeta.Text,
                        BancoEmisor = txtBancoEmisor.Text
                    };
                }
                else
                {
                    cliente = new Cliente
                    {
                        Nombre = txtNombre.Text,
                        Apellido = txtApellido.Text,
                        Email = txtEmail.Text,
                        Telefono = txtTelefono.Text,
                        Direccion = txtDireccion.Text
                    };
                }

                ClienteId = _clienteBLL.InsertarCliente(cliente);

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al registrar el cliente: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                BitacoraHelper.RegistrarError(this.Name, ex, "Caja", SessionManager.GetInstance.Usuario.Username);
            }
        }
    }
}