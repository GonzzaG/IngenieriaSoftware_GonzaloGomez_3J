using IngenieriaSoftware.BLL;
using IngenieriaSoftware.BLL.Mesas;
using IngenieriaSoftware.Servicios;
using System;
using System.Transactions;
using System.Windows.Forms;

namespace IngenieriaSoftware.UI
{
    public partial class FormGenerarFacturas : Form, IActualizable
    {
        private MesaBLL _mesaBLL = new MesaBLL();

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
            if (PermisosData.PermisosString.Contains("Mesero"))
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
            try
            {
                if (dataGridViewMesasCerradas.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Seleccione una mesa para poder generar la factura");
                }

                int mesaId = (int)dataGridViewMesasCerradas.SelectedRows[0].Cells[0].Value;

                var padre = this.MdiParent as FormMDI;

                using (var transaction = new TransactionScope())
                {
                    FormSeleccionMedioDePago formSeleccionMedioDePago = new FormSeleccionMedioDePago(mesaId);

                    formSeleccionMedioDePago.FormClosed += (s, ev) =>
                    {
                        _mesaBLL.CambiarEstadoMesaDesocupada(mesaId);
                        MessageBox.Show("La mesa ha sido desocupada");
                    };

                    padre.AbrirFormHijo(formSeleccionMedioDePago);

                    transaction.Complete();
                }

                BitacoraHelper.RegistrarActividad(SessionManager.GetInstance.Usuario.Username, "Generar Factura", DateTime.Now, "MesaId: " + mesaId, this.Name, AppDomain.CurrentDomain.BaseDirectory, "Caja");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al generar la factura: " + ex.Message);
                BitacoraHelper.RegistrarError(this.Name, ex, "Caja", SessionManager.GetInstance.Usuario.Username);
            }
        }
    }
}