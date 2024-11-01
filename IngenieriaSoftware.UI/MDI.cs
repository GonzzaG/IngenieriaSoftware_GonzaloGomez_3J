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
using System.Windows.Forms.VisualStyles;

namespace IngenieriaSoftware.UI
{
    public partial class MDI : Form
    {
        UsuarioBLL usuarioBLL;
        PermisoBLL permisoBLL;
        List<IPermiso> permisosUsuario;
        private readonly AuthService _authService = new AuthService();
        public MDI()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            usuarioBLL = new UsuarioBLL();  
            permisoBLL = new PermisoBLL();
        }

        private void MDI_Load(object sender, EventArgs e)
        {
            Actualizar();
        }



        private void gestionUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void registrarUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {

            CerrarFormulariosHijos();
            
            RegistrarUsuario formRegistrarUsuario = new RegistrarUsuario();
            formRegistrarUsuario.StartPosition = FormStartPosition.CenterScreen;
            formRegistrarUsuario.MdiParent = this;
            formRegistrarUsuario.Size = this.Size;
            formRegistrarUsuario.Show();

           // formRegistrarUsuario.ShowDialog();
            //AbrirFormMenu();
         
        }

        private void asignarPermisosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CerrarFormulariosHijos();

            GestionarPermisos formGestionPermisos = new GestionarPermisos();
            formGestionPermisos.StartPosition = FormStartPosition.CenterScreen;
            formGestionPermisos.MdiParent = this;
            formGestionPermisos.Size = this.Size;
            formGestionPermisos.Show();
           // formGestionPermisos.ShowDialog();
            //AbrirFormMenu();
        }

        private void gestionIdiomasToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void eliminarUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CerrarFormulariosHijos();

            EliminarUsuario formEliminarUsuario = new EliminarUsuario();
            formEliminarUsuario.StartPosition = FormStartPosition.CenterScreen;
            formEliminarUsuario.Size = this.Size;
            formEliminarUsuario.MdiParent = this;
            formEliminarUsuario.Show();

        }

        private void LogOutgestionUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                
                _authService.LogOut();

            Actualizar();
        }

        private void Actualizar()
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
            VerificarPermisosRoles(permisosUsuario);
            VerificarPermisosIndividuales(permisosUsuario);
        }

        private void VerificarPermisosRoles(List<IPermiso> permisos)
        {
            List<string> permisosPermitidos = new List<string>();

            if (PermisoChecker.TienePermiso(permisos, "PERM_ADMIN"))
            {
                //permisosPermitidos.Add( "PERM_ADMIN");
                permisosPermitidos.Add("PERM_GEST_USUARIO");
                permisosPermitidos.Add("PERM_GEST_PERMISOS");
                permisosPermitidos.Add("PERM_GEST_PERMISOS");
                //permisosPermitidos.Add( "PERM_MESERO");
                permisosPermitidos.Add("PERM_GEST_CAJA");
                permisosPermitidos.Add("PERM_GEST_MESAS");
                permisosPermitidos.Add("PERM_GEST_COBROS");

                gestionUsuariosToolStripMenuItem.Visible = true;
                gestionIdiomasToolStripMenuItem.Visible = true;

            }
            else //no es admin
            {

                gestionUsuariosToolStripMenuItem.Visible = false;
                gestionIdiomasToolStripMenuItem.Visible = false;

                if (PermisoChecker.TienePermiso(permisos, "PERM_CAJA"))
                {
                    permisosPermitidos.Add("PERM_GEST_COBROS");
                    cobrosToolStripMenuItem.Visible = true;
                }
                else
                {
                    //no tiene permiso de gestionar Caja
                    cobrosToolStripMenuItem.Visible = false;
                }

                if (PermisoChecker.TienePermiso(permisos, "PERM_MESERO"))
                {
                    permisosPermitidos.Add("PERM_GEST_MESAS");
                    mesasToolStripMenuItem.Visible = true;
                }
                else
                {
                    //no tiene permiso de gestionar Mesas
                    mesasToolStripMenuItem.Visible = false;
                }

                if (PermisoChecker.TienePermiso(permisos, "PERM_COCINA"))
                {
                    permisosPermitidos.Add("PERM_GEST_COMANDAS");
                    comandasToolStripMenuItem.Visible = true;
                }
                else
                {
                    //no tiene permiso de gestionar Mesas
                    comandasToolStripMenuItem.Visible = false;
                }
            }
            
            if(permisos.Count == 0)
            {
                //Usuario no tiene permisos
                
            }

            mostrarPermisosDelUsuario(permisosPermitidos);
        }

        private void VerificarPermisosIndividuales(List<IPermiso> permisos)
        {
            List<string> permisosPermitidos = new List<string>();

            if (PermisoChecker.TienePermiso(permisos, "PERM_GEST_USUARIO"))
            {
                permisosPermitidos.Add("PERM_GEST_USUARIO");

                gestionUsuariosToolStripMenuItem.Visible = true;
            }
            else
            {
                gestionUsuariosToolStripMenuItem.Visible = false;
            }

            if (PermisoChecker.TienePermiso(permisos, "PERM_GEST_PERMISOS"))
            {
                permisosPermitidos.Add("PERM_GEST_PERMISOS");
                gestionUsuariosToolStripMenuItem.Visible = true;
            }
            else
            {
                //no tiene permiso de gestionar permisos
                cobrosToolStripMenuItem.Visible = false;
            }

            if (PermisoChecker.TienePermiso(permisos, "PERM_GEST_MESAS"))
            {
                permisosPermitidos.Add("PERM_GEST_MESAS");
                mesasToolStripMenuItem.Visible = true;
            }
            else
            {
                //no tiene permiso de gestionar Mesas
                mesasToolStripMenuItem.Visible = false;
            }

            if (PermisoChecker.TienePermiso(permisos, "PERM_GEST_COBROS"))
            {
                permisosPermitidos.Add("PERM_GEST_COBROS");
                cobrosToolStripMenuItem.Visible = true;
            }
            else
            {
                //no tiene permiso de gestionar Mesas
                cobrosToolStripMenuItem.Visible = false;
            }

            if (PermisoChecker.TienePermiso(permisos, "PERM_GEST_COMANDAS"))
            {
                permisosPermitidos.Add("PERM_GEST_COMANDAS");
                
                comandasToolStripMenuItem.Visible = true;
            }
            else
            {
                //no tiene permiso de gestionar Mesas
                comandasToolStripMenuItem.Visible = false;
            }

            if (PermisoChecker.TienePermiso(permisos, "PERM_REGIST_USUARIO"))
            {
                permisosPermitidos.Add("PERM_REGIST_USUARIO");
                //como puede registrar usuarios, se puede ver Gestionar Usuarios
                gestionUsuariosToolStripMenuItem.Visible = true;

                registrarUsuarioToolStripMenuItem.Visible = true;
            }
            else
            {
                //no tiene permiso de gestionar Mesas
                registrarUsuarioToolStripMenuItem.Visible = false;
            }

            if (PermisoChecker.TienePermiso(permisos, "PERM_ELIM_USUARIO"))
            {
                permisosPermitidos.Add("PERM_REGIST_USUARIO");
                //como puede registrar usuarios, se puede ver Gestionar Usuarios
                gestionUsuariosToolStripMenuItem.Visible = true;

                eliminarUsuarioToolStripMenuItem.Visible = true;
            }
            else
            {
                //no tiene permiso de gestionar Mesas
                eliminarUsuarioToolStripMenuItem.Visible = false;
            }

            if (PermisoChecker.TienePermiso(permisos, "PERM_ASIGN_PERMISOS"))
            {
                permisosPermitidos.Add("PERM_ASIGN_PERMISOS");
                //como puede registrar usuarios, se puede ver Gestionar Usuarios
                gestionUsuariosToolStripMenuItem.Visible = true;

                asignarPermisosToolStripMenuItem.Visible = true;
            }
            else
            {
                //no tiene permiso de gestionar Mesas
                asignarPermisosToolStripMenuItem.Visible = false;
            }

            if (PermisoChecker.TienePermiso(permisos, "PERM_GEST_IDIOMAS"))
            {
                permisosPermitidos.Add("PERM_GEST_IDIOMAS");
                gestionIdiomasToolStripMenuItem.Visible = true;
            }
            else
            {
                //no tiene permiso de gestionar Mesas
                gestionIdiomasToolStripMenuItem.Visible = false;
            }

            mostrarPermisosDelUsuario(permisosPermitidos);
        }

        private void mostrarPermisosDelUsuario(List<string> permisos)
        {
            if (permisos.Count == 0)
            {
                MessageBox.Show("Usuario no tiene permisos");
                return;
            }

            string mensajeFinal = string.Join("\n", permisos);
            MessageBox.Show(mensajeFinal, "Lista de Permisos");
        }

        private void gestionUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void registrarUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegistrarUsuario formGestionUsuario = new RegistrarUsuario();
            formGestionUsuario.StartPosition = FormStartPosition.CenterScreen;
            formGestionUsuario.ShowDialog();

            AbrirFormMenu();
        }

        private void asignarPermisosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GestionarPermisos formGestionPermisos = new GestionarPermisos();
            formGestionPermisos.StartPosition = FormStartPosition.CenterScreen;
            formGestionPermisos.ShowDialog();

            AbrirFormMenu();
        }

        private void gestionIdiomasToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void eliminarUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EliminarUsuario formGestionPermisos = new EliminarUsuario();
            formGestionPermisos.StartPosition = FormStartPosition.CenterScreen;
            formGestionPermisos.ShowDialog();

            AbrirFormMenu();
        }

        private void LogOutgestionUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                
                _authService.LogOut();

                Actualizar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
