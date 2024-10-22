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
    public partial class MDI : Form
    {
        public MDI()
        {
            InitializeComponent();
        }

        private void MDI_Load(object sender, EventArgs e)
        {
            Inicio FormInicio = new Inicio();
            if (FormInicio.ShowDialog(this) == DialogResult.OK)
            {
                // Si el inicio de sesion es correcto, se abre el formulario menu
                AbrirFormMenu();
            }
            else
            {
                this.Close();   
            }
        }

        private void AbrirFormMenu()
        {
            Menu FormMenu = new Menu();
            FormMenu.MdiParent = this;
            FormMenu.Show();
        }

        private void gestionUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
