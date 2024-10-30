using IngenieriaSoftware.BEL;
using IngenieriaSoftware.BLL;
using IngenieriaSoftware.Servicios;
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
        UsuarioBLL usuarioBLL;
        List<Permiso> permisosUsuario;
        
        public MDI()
        {
            InitializeComponent();
            usuarioBLL = new UsuarioBLL();  
        }

        private void MDI_Load(object sender, EventArgs e)
        {
            InicioSesion FormInicio = new InicioSesion();
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
            //Menu FormMenu = new Menu();
            //FormMenu.MdiParent = this;
            //FormMenu.Show();
            var nombreUsuario = SessionManager.UsuarioActual.Username;
            permisosUsuario = usuarioBLL.ObtenerPermisosDelUsuario(nombreUsuario);
        }
        
        public void CargarFormularioConPermisos(List<Permiso> permisos)
        {
            //aca iremos cargando el formulario segun los permisos que tenga el usuario
            //EJ: si no tiene permiso GestionarUsuarios, el boton Gestionar Usuarios no sera visible
            //EJ: si es Administrador, no se modificara nada
            //EJ: si es Cajero, no se veran Gestion de usuarios y gestion de idiomas
            // Por cada usuario, se verificara que es y se realizara una accion
        }
        private void gestionUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void registrarUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GestionUsuarios formGestionUsuario = new GestionUsuarios();
            formGestionUsuario.StartPosition = FormStartPosition.CenterScreen;
            formGestionUsuario.Show();
        }

        private void asignarPermisosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GestionarPermisos formGestionPermisos = new GestionarPermisos();
            formGestionPermisos.StartPosition = FormStartPosition.CenterScreen;
            formGestionPermisos.Show();
        }

        private void gestionIdiomasToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void eliminarUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EliminarUsuario formGestionPermisos = new EliminarUsuario();
            formGestionPermisos.StartPosition = FormStartPosition.CenterScreen;
            formGestionPermisos.Show();
        }
    }
}
