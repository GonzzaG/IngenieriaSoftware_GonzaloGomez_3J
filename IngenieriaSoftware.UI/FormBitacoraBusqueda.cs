using IngenieriaSoftware.BLL;
using IngenieriaSoftware.Servicios;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace IngenieriaSoftware.UI
{
    public partial class FormBitacoraBusqueda : Form, IActualizable
    {
        public NotificacionService _notificacionService => new NotificacionService();
        private bool formCargado = false;

        public FormBitacoraBusqueda()
        {
            InitializeComponent();
        }

        private void btnBuscarRegistros_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridViewBitacora.DataSource = BitacoraHelper.ConsultarBitacora(desdeDateTimePicker.Value, hastaDateTimePicker.Value, txtModulo.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener registros de bitacora: " + ex.Message);
            }
        }

        private void checkBoxBuscarPorModulo_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxBuscarPorArea.Checked)
            {
                txtModulo.Enabled = true;
                txtModulo.BackColor = Color.White;
            }
            else
            {
                txtModulo.Enabled = false;
                txtModulo.Text = string.Empty;
                txtModulo.BackColor = Color.DarkGray;
            }
        }

        public void Actualizar()
        {
            throw new NotImplementedException();
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

        private void InicializarFechas()
        {
            try
            {
                desdeDateTimePicker.Value = DateTime.Now.AddDays(-7);
                hastaDateTimePicker.Value = DateTime.Now;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al inicializar fechas: " + ex.Message);
            }
        }

        private void desdeDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            if (desdeDateTimePicker.Value > hastaDateTimePicker.Value && formCargado)
            {
                MessageBox.Show("La fecha de inicio no puede ser mayor que la fecha de fin.");
                desdeDateTimePicker.Value = hastaDateTimePicker.Value;
            }
        }

        private void hastaDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            if (hastaDateTimePicker.Value < desdeDateTimePicker.Value && formCargado)
            {
                MessageBox.Show("La fecha de fin no puede ser menor que la fecha de inicio.");
                hastaDateTimePicker.Value = desdeDateTimePicker.Value;
            }
        }

        private void FormBitacoraBusqueda_Load(object sender, EventArgs e)
        {
            InicializarFechas();
            formCargado = true;
        }
    }
}