using IngenieriaSoftware.BEL;
using IngenieriaSoftware.BEL.Auditoria;
using IngenieriaSoftware.BLL;
using IngenieriaSoftware.BLL.Auditoria;
using IngenieriaSoftware.Servicios;
using System;
using System.Data;
using System.Transactions;
using System.Windows.Forms;

namespace IngenieriaSoftware.UI
{
    public partial class FormRegistrarUsuario : Form, IActualizable
    {
        private readonly AuthService _authService = new AuthService();
        private readonly UsuarioBLL _usuarioBLL;
        private readonly PermisoBLL _permisoBLL;
        private readonly DigitoVerificadorManager _digitoVerificadorManager = new DigitoVerificadorManager();
        public NotificacionService _notificacionService => new NotificacionService();

        private readonly UsuarioAuditoriaService _usuarioAuditoriaService;

        public FormRegistrarUsuario(DigitoVerificadorManager digitoVerificador)
        {
            InitializeComponent();
            _usuarioBLL = new UsuarioBLL();
            _permisoBLL = new PermisoBLL();
            _digitoVerificadorManager = digitoVerificador;
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

        private void GestionUsuarios_Load(object sender, EventArgs e)
        {
            VerificarNotificaciones();
           
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtUsername.Text.Length == 0 || txtPassword.Text.Length == 0) { return; }

                using(var transaccion = new TransactionScope())
                {
                    int usuarioId = _authService.RegistrarUsuario(txtUsername.Text, txtPassword.Text);
                    if (usuarioId > 0)
                    {
                        MessageBox.Show($"El usuario {txtUsername.Text} fue registrado con exito");

                        Entity usuarioVerificable = new Usuario
                        {
                            Id = usuarioId,
                        };

                        //if (CalcularDigitoVerificador(usuarioVerificable))
                        //{
                        //    MessageBox.Show($"El digito verificador del usuario {txtUsername.Text} fue calculado con exito");
                        //}

                        var usuario = _usuarioBLL.ObtenerUsuarioPorId(usuarioId);

                        AuditarUsuarioInsert(usuario);

                        this.DialogResult = DialogResult.OK;

                        MessageBox.Show("Entidad registrado con exito");

                    }
                        transaccion.Complete();
                }
              
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

                BitacoraHelper.RegistrarError(this.Name, ex, "Usuarios", SessionManager.GetInstance.Usuario.Username);
            }
            finally
            {
                this.Close();
                BitacoraHelper.RegistrarActividad(SessionManager.GetInstance.Usuario.ToString(), "Registro de Entidad", DateTime.Now, $"Entidad {txtUsername.Text} registrado", this.Name, AppDomain.CurrentDomain.BaseDirectory, "Usuarios");
            }
        }

        private void AuditarUsuarioInsert(Usuario usuario)
        {
            if (usuario != null)
            {
                var cambiadoPor = SessionManager.GetInstance.Usuario.Username;

                var usuarioAuditado = UsuarioAuditoriaFactory.CrearParaInsert(usuario, cambiadoPor);

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
                if (_digitoVerificadorManager.ActualizarDVH_Y_DVV_DeRegistro(nombreTabla, entidadVerificable.Id))
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