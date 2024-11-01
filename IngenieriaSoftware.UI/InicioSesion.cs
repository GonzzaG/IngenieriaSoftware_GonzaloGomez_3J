using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IngenieriaSoftware.BLL;
using IngenieriaSoftware.BEL;


namespace IngenieriaSoftware.UI
{
    public partial class InicioSesion : Form
    {
        private readonly AuthService _authService = new AuthService();

        public InicioSesion()
        {
            InitializeComponent();

            this.StartPosition = FormStartPosition.CenterScreen;
            this.DialogResult = DialogResult.No;
        }

        private void LogIn(object sender, EventArgs e)
        {
            try
            {
                
                if(_authService.LogIn(txtUsuario.Text, txtContrasena.Text))
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

        private void LogOut(object sender, EventArgs e)
        {

            try
            {
                _authService.LogOut();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

          
        }

        private void Inicio_Load(object sender, EventArgs e)
        {
          
        }

    }
}
