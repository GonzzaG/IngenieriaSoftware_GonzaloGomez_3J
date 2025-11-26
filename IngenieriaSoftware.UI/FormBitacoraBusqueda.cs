using IngenieriaSoftware.Abstracciones;
using IngenieriaSoftware.BEL;
using IngenieriaSoftware.BLL;
using IngenieriaSoftware.BLL.Serializacion.Bitacora;
using IngenieriaSoftware.Servicios;
using IngenieriaSoftware.UI.Common;
using IngenieriaSoftware.UI.Common.ModalCommon;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace IngenieriaSoftware.UI
{
    public partial class FormBitacoraBusqueda : Form, IVerificoNotificaciones
    {
        public NotificacionService _notificacionService => new NotificacionService();
        private bool formCargado = false;
        private List<Bitacora> _Bitacora = new List<Bitacora>();
        public FormBitacoraBusqueda()
        {
            InitializeComponent();
            dgvBitacora.SetCustomSize(new Size(1300, 383));
        }

        private void btnBuscarRegistros_Click(object sender, EventArgs e)
        {
            try
            {
                _Bitacora = BitacoraHelper.ConsultarBitacora(desdeDateTimePicker.Value, hastaDateTimePicker.Value, txtModulo.Text);
                dgvBitacora.CargarDatos(_Bitacora);
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
                    CommonForms.MostrarNotificacion(notificaciones, this);
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

        private void btnExportar_Click(object sender, EventArgs e)
        {
            try
            {
                if (_Bitacora == null)
                {
                    MessageBox.Show("No hay datos para exportar.");
                    return;
                }

                if (_Bitacora == null || _Bitacora.Count == 0)
                {
                    MessageBox.Show("No hay registros para exportar.");
                    return;
                }

                var exportador = new ExportadorSerializadorService();

                string nombreArchivo = $"bitacora_{DateTime.Now:yyyyMMdd_HHmmss}";
                string ruta = exportador.ExportarObjeto(_Bitacora, nombreArchivo);

                //MessageBox.Show($"Bitácora exportada en:\n\n{ruta}");

                var frm = new FormMensajeConCopia(ruta);
                frm.ShowDialog();


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al exportar bitácora: " + ex.Message);
            }
        }
    }
}