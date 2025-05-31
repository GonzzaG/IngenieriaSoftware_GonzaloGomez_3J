using IngenieriaSoftware.BLL;
using IngenieriaSoftware.BLL.Mesas;
using IngenieriaSoftware.Servicios;
using System;
using System.Windows.Forms;

namespace IngenieriaSoftware.UI
{
    public partial class FormSeleccionMedioDePago : Form, IActualizable
    {
        private readonly MedioDePagoBLL _medioDePagoBLL = new MedioDePagoBLL();
        private readonly MesaBLL _mesaBLL = new MesaBLL();
        private readonly int _mesaId;

        public FormSeleccionMedioDePago(int mesaId)
        {
            InitializeComponent();
            _mesaId = mesaId;
        }

        public NotificacionService _notificacionService => new NotificacionService();

        public void Actualizar()
        {
            try
            {
                var mediosDePago = _medioDePagoBLL.ObtenerMediosDePago();

                if (mediosDePago != null)
                {
                    dataGridViewMediosDePago.DataSource = null;
                    dataGridViewMediosDePago.DataSource = mediosDePago;
                    dataGridViewMediosDePago.Columns[2].Visible = false;
                }
            }
            catch (Exception ex)
            {
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

        private void FormSeleccionMedioDePago_Load(object sender, EventArgs e)
        {
            Actualizar();
        }

        private void btnSeleccionarMedioDePago_Click(object sender, EventArgs e)
        {
            try
            {
                // aca seleccionamos y obtenemos el metodo de pago
                // podemos hacer un switch dependiendo el metodo de pago
                var descuento = numericUpDownDescuento.Value;
                var propina = numericUpDownPropina.Value;
                var medioDePagoId = (int)dataGridViewMediosDePago.SelectedRows[0].Cells[0].Value;

                //si no selecciona efectivo, vamos a mostrar el formulario de rellenar cliente
                //if (medioDePagoId != 1)
                //{
                bool esBancario;
                if (medioDePagoId == 1)
                    esBancario = false;
                else
                    esBancario = true;

                FormRellenarCliente formRellenarCliente = new FormRellenarCliente(esBancario);
                formRellenarCliente.StartPosition = FormStartPosition.CenterScreen;
                formRellenarCliente.ShowDialog();

                var clienteId = formRellenarCliente.ClienteId;
                //}

                //tegno que crear un cliente y mostrar un formulario de datos si elije otra opcion que no sea
                //efectivo
                if (clienteId > 0)
                {
                    _mesaBLL.CerrarMesa(_mesaId, propina, descuento, medioDePagoId, clienteId);
                    MessageBox.Show("La mesa fue cerrada y se guardo el cliente");
                    this.Close();
                }

                BitacoraHelper.RegistrarActividad(SessionManager.GetInstance.Usuario.Username, "Cerrar Mesa", DateTime.Now, "Mesa cerrada", this.Name, AppDomain.CurrentDomain.BaseDirectory, "Mesas");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cerrar la mesa: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                BitacoraHelper.RegistrarError(this.Name, ex, "Mesas", SessionManager.GetInstance.Usuario.Username);
            }
        }
    }
}