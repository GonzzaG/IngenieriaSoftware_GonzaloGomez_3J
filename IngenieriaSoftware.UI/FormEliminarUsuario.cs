using IngenieriaSoftware.BEL;
using IngenieriaSoftware.BLL;
using IngenieriaSoftware.BLL.Auditoria;
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
        private readonly DigitoVerificadorManager _digitoVerificadorManager = new DigitoVerificadorManager();

        public NotificacionService _notificacionService => new NotificacionService();
        
        private UsuarioAuditoriaService _usuarioAuditoriaService;
        public FormEliminarUsuario()
        {
            InitializeComponent();
            usuarioBLL = new UsuarioBLL();
            usuarios = new List<UsuarioDTO>();
            _usuarioAuditoriaService = new UsuarioAuditoriaService();
        }

        #region Metodos de Interfaz

        public void Actualizar()
        {
        }

        #endregion Metodos de Interfaz

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
            comboBoxUsuarios.Text = string.Empty;
            comboBoxUsuarios.Items.Clear();
            foreach (UsuarioDTO usuario in pUsuarios)
            {
                comboBoxUsuarios.Items.Add(usuario.Username);
            }
        }

        private void btnEliminarUsuario_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBoxUsuarios.SelectedItem == null) { return; }
                DialogResult respuesta = MessageBox.Show("Está seguro que desea eliminar?", "Alerta de eliminacion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                int usuarioId = usuarios[usuarios.FindIndex(u => u.Username == comboBoxUsuarios.SelectedItem.ToString())].Id;   

                if (respuesta == DialogResult.No) return;
                else if (respuesta == DialogResult.Yes)
                {
                    var usuario = usuarioBLL.ObtenerUsuarioPorId(usuarioId);

                    AuditarUsuarioDelete(usuario);

                    Entity usuarioVerificable = new Usuario
                    {
                        Id = usuarioId,
                    };
                    usuarios = usuarioBLL.EliminarUsuario(usuarios, comboBoxUsuarios.SelectedItem.ToString());

                    //if (CalcularDigitoVerificador(usuarioVerificable))
                    //{
                    //    MessageBox.Show($"El digito verificador del usuario {comboBoxUsuarios.SelectedItem} fue calculado con exito");
                    //}

                    BitacoraHelper.RegistrarActividad(SessionManager.GetInstance.Usuario.Username, "Eliminar Usuario", DateTime.Now, $"Se eliminó el usuario {comboBoxUsuarios.SelectedItem.ToString()}", this.Name, AppDomain.CurrentDomain.BaseDirectory, "Usuarios");

                    listarUsuarios(usuarios);
                }


            }
            catch (Exception ex)
            {
                BitacoraHelper.RegistrarError(this.Name, ex, "Usuarios", SessionManager.GetInstance.Usuario.Username);
                MessageBox.Show(ex.Message);
            }
        }

        private void AuditarUsuarioDelete(Usuario usuario)
        {
            if (usuario != null)
            {
                var cambiadoPor = SessionManager.GetInstance.Usuario.Username;

                var usuarioAuditado = UsuarioAuditoriaFactory.CrearParaDelete(usuario, cambiadoPor);

                _usuarioAuditoriaService.RegistrarCambio(usuarioAuditado);
            }
        }
        /// <summary>
        /// Metodo que calcula el digito verificador de un registro, dado el nombre de la tabla y el id del registro.
        /// Luego, verifica la integridad de los registros de la tabla, comparando el DVH almacenado con el DVH generado.
        /// </summary>
        /// <param name="entidadVerificable"></param>
        /// <exception cref="Exception"></exception>
        private bool CalcularDigitoVerificador(Entity entidadVerificable)
        {
            try
            {
                string nombreTabla = entidadVerificable.getNombreTabla();
                if (_digitoVerificadorManager.ActualizarDVH_Y_DVV_DeRegistro(nombreTabla, null))
                {
                    if (_digitoVerificadorManager.VerificarDigitoVerticalYHorizontal())
                        return true;
                }

                throw new Exception(nombreTabla + " no se actualizo correctamente el DVH");
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private void comboBoxUsuarios_SelectedIndexChanged(object sender, EventArgs e)
        {
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