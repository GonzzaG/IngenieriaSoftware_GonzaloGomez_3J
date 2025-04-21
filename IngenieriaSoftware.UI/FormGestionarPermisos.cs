using IngenieriaSoftware.BLL;
using IngenieriaSoftware.Servicios;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace IngenieriaSoftware.UI
{
    public partial class FormGestionarPermisos : Form, IActualizable
    {
        private readonly UsuarioBLL _usuarioBLL;
        private readonly PermisoBLL _permisoBLL;
        private readonly IdiomaSujeto _idiomaObserver;

        public NotificacionService _notificacionService => new NotificacionService();

        public FormGestionarPermisos()
        {
            InitializeComponent();
            _usuarioBLL = new UsuarioBLL();
            _permisoBLL = new PermisoBLL();
        }

        #region Metodos de Interfaz

        public void Actualizar()
        {

        }
        #endregion

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            if (this.MdiParent is FormMDI formPrincipal && this is IActualizable actualizableForm)
            {
                formPrincipal.ActualizarFormsHijos -= actualizableForm.Actualizar;
            }
            base.OnFormClosed(e);
        }

        private void GestionarPermisos_Load(object sender, EventArgs e)
        {
            ActualizarFormulario();
            VerificarNotificaciones();
        }

        private void CargarUsuarios()
        {
           // List<UsuarioDTO> usuarios = _usuarioBLL.CargarUsuarios();     
           List<UsuarioDTO> usuarios = _usuarioBLL.CargarUsuarios();

           listarUsuarios(usuarios);
        }

        public void listarUsuarios(List<UsuarioDTO> pUsuarios)
        {
            comboBoxUsuario.Items.Clear();
            foreach (UsuarioDTO usuario in pUsuarios)
            {
                comboBoxUsuario.Items.Add(usuario.Username);
            }
        }

        public void ActualizarFormulario()
        {
            CargarUsuarios();
            CargarPermisos();
        }

        private void CargarPermisos()
        {
            List<PermisoDTO> permisos = _permisoBLL.CargarPermisos();
            FillTreeView(permisos, treeViewPermisos);
        }

        private void FillTreeView(List<PermisoDTO> permisosJerarquizados, TreeView treeViewPermisos)
        {
            treeViewPermisos.Nodes.Clear();
            foreach (PermisoDTO permiso in permisosJerarquizados)
            {
                TreeNode nodoRaiz = CrearNodoRecursivo(permiso);
                treeViewPermisos.Nodes.Add(nodoRaiz);
            }
            treeViewPermisos.ExpandAll();
        }

        private TreeNode CrearNodoRecursivo(PermisoDTO permiso)
        {
            TreeNode nodo = new TreeNode(permiso.CodPermiso)
            {
                Tag = permiso.Id 
            };
            foreach (PermisoDTO hijo in permiso.permisosHijos)
            {
                TreeNode nodoHijo = CrearNodoRecursivo(hijo);
                nodo.Nodes.Add(nodoHijo);
            }

            return nodo;
        }

        private void comboBoxUsuario_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxUsuario.SelectedItem == null) return;
            string nombreUsuario = comboBoxUsuario.SelectedItem.ToString();
           // var permisosDelUsuario = _usuarioBLL.ObtenerPermisosDelUsuarioEnMemoria(nombreUsuario);
            var permisosUsuario = _permisoBLL.ObtenerPermisosDelUsuario(nombreUsuario);
           
       
            FillTreeView(permisosUsuario, treeViewPermisoUsuario);
        }

        private void btnAsignarPermiso_Click(object sender, EventArgs e)
        {
            if (treeViewPermisoUsuario.SelectedNode == null) return;
            if (comboBoxUsuario.Text.Length == 0) return;
            try
            {
                string usuarioNombre = comboBoxUsuario.Text.ToString();
                var usuario = _usuarioBLL.ObtenerUsuarioPorNombre(usuarioNombre);
                usuario.Permisos = _permisoBLL.ObtenerPermisosDelUsuario(usuario.Username);
                List<PermisoDTO> permisosUsuario = _permisoBLL.AsignarPermisoUsuario((int)treeViewPermisoUsuario.SelectedNode.Tag, usuario);

                ActualizarFormulario();
                permisosUsuario = _permisoBLL.ObtenerPermisosDelUsuario(usuario.Username);

                FillTreeView(permisosUsuario, treeViewPermisoUsuario);
                BitacoraHelper.RegistrarActividad(SessionManager.GetInstance.Usuario.ToString(), "Asignar Permiso", DateTime.Now, $"Se asigno el permiso {treeViewPermisoUsuario.SelectedNode.Text} al usuario {usuarioNombre}", this.Name, AppDomain.CurrentDomain.BaseDirectory,"Permisos"); 
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                BitacoraHelper.RegistrarError(this.Name, ex, "Permisos" ,SessionManager.GetInstance.Usuario.Username); 

            }
        }

        private void btnDesasignarPermiso_Click(object sender, EventArgs e)
        {
            if (treeViewPermisoUsuario.SelectedNode == null) return;
            if (comboBoxUsuario.Text.Length == 0) return;
            try
            {
                string usuarioNombre = comboBoxUsuario.Text.ToString();
                var usuario = _usuarioBLL.ObtenerUsuarioPorNombre(usuarioNombre);
                _permisoBLL.DesasignarPermisoUsuario(usuario.Id, (int)treeViewPermisoUsuario.SelectedNode.Tag);

                var permisosUsuario = _permisoBLL.ObtenerPermisosDelUsuario(usuario.Username);

                if (treeViewPermisoUsuario.SelectedNode.Text.ToLower() == "asignar permisos" && comboBoxUsuario.Text == SessionManager.GetInstance.Usuario.Username)
                {
                    var padre = this.MdiParent as FormMDI;
                  
                    this.Close();
                }

                    ActualizarFormulario();
                FillTreeView(permisosUsuario, treeViewPermisoUsuario);

                BitacoraHelper.RegistrarActividad(SessionManager.GetInstance.Usuario.ToString(), "Desasignar Permiso", DateTime.Now, $"Se desasigno el permiso {treeViewPermisoUsuario.SelectedNode.Text} al usuario {usuarioNombre}", this.Name, AppDomain.CurrentDomain.BaseDirectory, "Permisos");   
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                BitacoraHelper.RegistrarError(this.Name, ex, "Permisos", SessionManager.GetInstance.Usuario.Username);

            }
        }

        private void GestionarPermisos_FormClosed(object sender, FormClosedEventArgs e)
        {
            var formPadre = this.MdiParent as FormMDI;
            formPadre.AbrirFormMenu();
        }

        public void VerificarNotificaciones()
        {
            if (PermisosData.PermisosString.Contains("Mesero"))
            {
                var notificaciones = _notificacionService.ObtenerNotificaciones();
                if (notificaciones.Count > 0)
                {
                    HelperForms.MostrarNotificacion(notificaciones, this);
                }
            }
        }
    }
}