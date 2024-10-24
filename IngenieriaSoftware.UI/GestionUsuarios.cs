using IngenieriaSoftware.BLL;
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
    public partial class GestionUsuarios : Form
    {
        private readonly AuthService _authService = new AuthService();
        public GestionUsuarios()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void GestionUsuarios_Load(object sender, EventArgs e)
        {
            comboBoxCategorias.Items.Add("Administrador");
            comboBoxCategorias.Items.Add("Mesero");
            comboBoxCategorias.Items.Add("Caja");
            comboBoxCategorias.Items.Add("Cocina");

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            try
            {

                if (_authService.RegistrarUsuario(txtUsername.Text, txtPassword.Text))
                {
                 

                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }
    }
}
