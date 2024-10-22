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
    }
}
