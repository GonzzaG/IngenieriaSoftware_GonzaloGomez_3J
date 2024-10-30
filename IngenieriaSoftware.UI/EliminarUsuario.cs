using IngenieriaSoftware.BEL;
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
    public partial class EliminarUsuario : Form
    {
        UsuarioBLL usuarioBLL;
        List<Usuario> usuarios;
        public EliminarUsuario()
        {
            InitializeComponent();
            usuarioBLL = new UsuarioBLL();
            usuarios = new List<Usuario>();
        }

        private void EliminarUsuario_Load(object sender, EventArgs e)
        {
            try
            {
                usuarios = usuarioBLL.CargarUsuarios();
                listarUsuarios(usuarios);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void listarUsuarios(List<Usuario> pUsuarios)
        {
            comboBoxUsuarios.Items.Clear();
            foreach (Usuario usuario in pUsuarios)
            {
                comboBoxUsuarios.Items.Add(usuario.Username);
            }
        }

        private void btnEliminarUsuario_Click(object sender, EventArgs e)
        {
            if(comboBoxUsuarios.SelectedItem == null) { return; }
            DialogResult respuesta = MessageBox.Show("Está seguro que desea eliminar?", "Alerta de eliminacion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if(respuesta == DialogResult.No) return;
            else if(respuesta == DialogResult.Yes)
            {
                usuarios = usuarioBLL.EliminarUsuario(usuarios, comboBoxUsuarios.SelectedItem.ToString());
                listarUsuarios(usuarios);
            }

        }
    }
}
