using IngenieriaSoftware.BLL;
using IngenieriaSoftware.Servicios;
using IngenieriaSoftware.Servicios.DTOs;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace IngenieriaSoftware.UI
{
    public partial class FormInicioSesion : Form, IActualizable
    {
        private readonly AuthService _authService = new AuthService();

        public event Action InicioSesionExitoso;

        private readonly IdiomaSujeto _idiomaObserver;

        public FormInicioSesion() { InitializeComponent(); }
        public FormInicioSesion(IdiomaSujeto idiomaObserver)
        {
            InitializeComponent();

            this.StartPosition = FormStartPosition.CenterScreen;
            this.DialogResult = DialogResult.No;

            _idiomaObserver = idiomaObserver;

          

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

        private void Inicio_Load(object sender, EventArgs e)
        {
            txtUsuario.Text = "gonza2";
            txtContrasena.Text = "gonza";
        }

        #region LogIn LogOut
        private void LogIn(object sender, EventArgs e)
        {
            try
            {
                if (_authService.LogIn(txtUsuario.Text, txtContrasena.Text))
                {
                    InicioSesionExitoso?.Invoke();

                    //obtenemos el usuario que inicio sesion
                    var usuario = SessionManager.GetInstance.Usuario;

                    //cambiamos el idioma el cual tiene el usuario
                    _idiomaObserver.CambiarEstado(usuario.Id);
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion
    }
}