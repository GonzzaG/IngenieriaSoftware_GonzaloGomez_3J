using IngenieriaSoftware.BLL;
using IngenieriaSoftware.Servicios;
using System.Windows.Forms;

namespace IngenieriaSoftware.UI
{
    public partial class FormGestionarIdioma : Form, IActualizable
    {
        public FormGestionarIdioma()
        {
            InitializeComponent();
        }

        public NotificacionService _notificacionService => new NotificacionService();

        #region Metodos de Interfaz
        public void Actualizar()
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
        #endregion

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            if (this.MdiParent is FormMDI formPrincipal && this is IActualizable actualizableForm)
            {
                formPrincipal.ActualizarFormsHijos -= actualizableForm.Actualizar;
            }
            base.OnFormClosed(e);
        }
        private void FormGestionarIdioma_Load(object sender, System.EventArgs e)
        {
            VerificarNotificaciones();
        }
    }
}