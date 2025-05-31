using IngenieriaSoftware.BLL;
using IngenieriaSoftware.Servicios;
using IngenieriaSoftware.UI.Adaptadores;
using System;
using System.Windows.Forms;

namespace IngenieriaSoftware.UI
{
    public partial class FormInicioSesion : Form, IActualizable
    {
        private readonly AuthService _authService = new AuthService();

        public event Action InicioSesionExitoso;

        private readonly IdiomaSujeto _idiomaObserver;

        public NotificacionService _notificacionService => new NotificacionService();

        public FormInicioSesion()
        { InitializeComponent(); }

        public FormInicioSesion(IdiomaSujeto idiomaObserver)
        {
            InitializeComponent();

            _idiomaObserver = idiomaObserver;
            this.WindowState = FormWindowState.Maximized;
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

        private void Inicio_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            //txtUsuario.Text = "gonza2";
            //txtContrasena.Text = "gonza";
        }

        #region LogIn LogOut

        //private void LogIn(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        if (_authService.LogIn(txtUsuario.Text, txtContrasena.Text))
        //        {
        //            InicioSesionExitoso?.Invoke();

        //            var usuario = SessionManager.GetInstance.Usuario;

        //            //_idiomaObserver.CambiarEstado(usuario.Id);
        //            throw new CredencialesCorrectasException();
        //        }
        //    }
        //    catch (FalloCredencialesException ex)
        //    {
        //        var adaptador = new ExcepcionesIdiomaAdaptador(ex.Tag, ex.Name);
        //        MessageBox.Show(adaptador.ObtenerMensajeTraducido());
        //    }
        //    catch (CredencialesCorrectasException ex)
        //    {
        //        var adaptador = new ExcepcionesIdiomaAdaptador(ex.Tag, ex.Name);
        //        MessageBox.Show(adaptador.ObtenerMensajeTraducido());
        //        this.Close();
        //    }

        //}

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

        #endregion LogIn LogOut

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            try
            {
                if (_authService.LogIn(txtUsuario.Text, txtContrasena.Text))
                {
                    InicioSesionExitoso?.Invoke();

                    var usuario = SessionManager.GetInstance.Usuario;

                    BitacoraHelper.RegistrarActividad(SessionManager.GetInstance.Usuario.Username, "Inicio de Sesion", DateTime.Now, "Inicio de sesion exitoso", this.Name, AppDomain.CurrentDomain.BaseDirectory, "Sesion");
                    //_idiomaObserver.CambiarEstado(usuario.Id);
                    throw new CredencialesCorrectasException();
                }
            }
            catch (FalloCredencialesException ex)
            {
                var adaptador = new ExcepcionesIdiomaAdaptador(ex.Tag, ex.Name);
                MessageBox.Show(adaptador.ObtenerMensajeTraducido());

                BitacoraHelper.RegistrarError(this.Name, ex, "Sesion", null);
            }
            catch (CredencialesCorrectasException ex)
            {
                var adaptador = new ExcepcionesIdiomaAdaptador(ex.Tag, ex.Name);
                MessageBox.Show(adaptador.ObtenerMensajeTraducido());
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se produjo un error al iniciar sesion: ", ex.Message);
            }
        }
    }
}