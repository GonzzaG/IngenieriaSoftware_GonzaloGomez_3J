using IngenieriaSoftware.BLL;
using IngenieriaSoftware.BLL.Mesas;
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
    public partial class FormGenerarFacturas : Form, IActualizable
    {
        MesaBLL _mesaBLL = new MesaBLL();
        public FormGenerarFacturas()
        {
            InitializeComponent();
        }

        public NotificacionService _notificacionService => new NotificacionService();

        public void Actualizar()
        {
            //vamos a obtener las mesas en estado cerradas;
            var mesas = _mesaBLL.ObtenerMesasCerradas();

            dataGridViewMesasCerradas.DataSource = null;
            dataGridViewMesasCerradas.DataSource = mesas;
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

        private void FormGenerarFacturas_Load(object sender, EventArgs e)
        {
            Actualizar();
        }

        private void btnGenerarFactura_Click(object sender, EventArgs e)
        {
            if(dataGridViewMesasCerradas.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione una mesa para poder generar la factura");
            }

            int mesaId = (int)dataGridViewMesasCerradas.SelectedRows[0].Cells[0].Value;

            var padre = this.MdiParent as FormMDI;
            FormSeleccionMedioDePago formSeleccionMedioDePago = new FormSeleccionMedioDePago(mesaId);
            padre.AbrirFormHijo(formSeleccionMedioDePago);

        }
    }
}
