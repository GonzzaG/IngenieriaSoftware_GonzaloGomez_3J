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
    public partial class Inicio : Form
    {
        private AuthService _authService = new AuthService();

        public Inicio()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                _authService.LogIn(textBox1.Text, textBox2.Text);
                button1.Visible = false;
                button2.Visible = true;
        
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }


        }

        private void button2_Click(object sender, EventArgs e)
        {

            try
            {
                _authService.LogOut();
                button1.Visible = true;
                button2.Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

          
        }
    }
}
