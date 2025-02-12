﻿using IngenieriaSoftware.BLL;
using IngenieriaSoftware.Servicios;
using IngenieriaSoftware.Servicios.DTOs;
using IngenieriaSoftware.UI.Adaptadores;
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

        public NotificacionService _notificacionService => new NotificacionService();

        public FormInicioSesion() { InitializeComponent(); }
        public FormInicioSesion(IdiomaSujeto idiomaObserver)
        {
            InitializeComponent();

            this.StartPosition = FormStartPosition.CenterScreen;

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

                    var usuario = SessionManager.GetInstance.Usuario;

                    _idiomaObserver.CambiarEstado(usuario.Id);
                    throw new CredencialesCorrectasException();
                }
            }
            catch (FalloCredencialesException ex)
            {
                var adaptador = new ExcepcionesIdiomaAdaptador(ex.Tag, ex.Name);
                MessageBox.Show(adaptador.ObtenerMensajeTraducido());
            }
            catch (CredencialesCorrectasException ex)
            {
                var adaptador = new ExcepcionesIdiomaAdaptador(ex.Tag, ex.Name);
                MessageBox.Show(adaptador.ObtenerMensajeTraducido());
                this.Close();
            }

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
        #endregion
    }
}