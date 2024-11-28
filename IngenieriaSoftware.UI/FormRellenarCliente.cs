using IngenieriaSoftware.BEL;
using IngenieriaSoftware.BEL.Negocio;
using IngenieriaSoftware.BLL;
using IngenieriaSoftware.BLL.Mesas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            txtEmail.Text = "gonza@gonza.com";
            txtTelefono.Text = "123131231";
            txtDireccion.Text = "Pasteur 3232";
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
    }
}
