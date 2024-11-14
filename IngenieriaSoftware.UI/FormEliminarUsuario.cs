using IngenieriaSoftware.BLL;
using IngenieriaSoftware.Servicios;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace IngenieriaSoftware.UI
{
    public partial class FormEliminarUsuario : Form, IActualizable
    {
        private UsuarioBLL usuarioBLL;
        private List<UsuarioDTO> usuarios;

        public NotificacionService _notificacionService => new NotificacionService();

        public FormEliminarUsuario()
        {
            InitializeComponent();
            usuarioBLL = new UsuarioBLL();
            usuarios = new List<UsuarioDTO>();
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
        private void EliminarUsuario_Load(object sender, EventArgs e)
        {
            try
            {
                VerificarNotificaciones();
                usuarios = usuarioBLL.CargarUsuarios();
                listarUsuarios(usuarios);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void listarUsuarios(List<UsuarioDTO> pUsuarios)
        {
            comboBoxUsuarios.Items.Clear();
            foreach (UsuarioDTO usuario in pUsuarios)
            {
                comboBoxUsuarios.Items.Add(usuario.Username);
            }
        }

        private void btnEliminarUsuario_Click(object sender, EventArgs e)
        {
            if (comboBoxUsuarios.SelectedItem == null) { return; }
            DialogResult respuesta = MessageBox.Show("Está seguro que desea eliminar?", "Alerta de eliminacion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (respuesta == DialogResult.No) return;
            else if (respuesta == DialogResult.Yes)
            {
                usuarios = usuarioBLL.EliminarUsuario(usuarios, comboBoxUsuarios.SelectedItem.ToString());
                listarUsuarios(usuarios);
            }
        }

        private void comboBoxUsuarios_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        public void VerificarNotificaciones()
        {
            if (PermisosData.Permisos.Contains("PERM_ADMIN") ||
                PermisosData.Permisos.Contains("PERM_MESERO"))
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