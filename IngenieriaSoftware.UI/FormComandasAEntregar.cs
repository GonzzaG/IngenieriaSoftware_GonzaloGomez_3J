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
    public partial class FormComandasAEntregar : Form, IActualizable
    {
        private readonly ComandaBLL _comandaBLL = new ComandaBLL();
        public FormComandasAEntregar()
        {
            InitializeComponent();
        }

        public NotificacionService _notificacionService => new NotificacionService();

        public void Actualizar()
        {
            //vamos a mostrar las notificaciones que no hayan sido vistas
            var notificaciones = _comandaBLL.ObtenerNotificacionesNoVistas();
            dataGridViewComandasAEntregar.DataSource = null;
            dataGridViewComandasAEntregar.DataSource = notificaciones;
        }

        public void VerificarNotificaciones()
        {
            if (PermisosData.PermisosString.Contains("PERM_ADMIN") ||
             PermisosData.PermisosString.Contains("PERM_MESERO") ||
             PermisosData.PermisosString.Contains("PERM_GEST_MESAS") ||
             PermisosData.PermisosString.Contains("PERM_COM_ENTREGAR"))
            {
                var notificaciones = _notificacionService.ObtenerNotificaciones();
                if (notificaciones.Count > 0)
                {
                    HelperForms.MostrarNotificacion(notificaciones, this);
                }
            }
        }



        private void btnComandaEntregada_Click(object sender, EventArgs e)
        {
            //vamos a marcar los productos como entregados
            //vamos a marcar la notificacion como vista
            int notificacionId = (int)dataGridViewComandasAEntregar.SelectedRows[0].Cells[0].Value;
            _comandaBLL.MarcarProductosEntregados(notificacionId);

            Actualizar();
        }

        private void FormComandasAEntregar_Load(object sender, EventArgs e)
        {
            Actualizar();
            //VerificarNotificaciones();
        }
    }
}
