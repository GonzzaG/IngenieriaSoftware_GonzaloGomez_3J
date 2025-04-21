using IngenieriaSoftware.BEL;
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
    public partial class FormBitacoraBusqueda : Form, IActualizable
    {
       

        public NotificacionService _notificacionService => new NotificacionService();

        public FormBitacoraBusqueda()
        {
            InitializeComponent();
        }

        private void btnBuscarRegistros_Click(object sender, EventArgs e)
        {
            //txtRegistros.Text = ConsultarBitacora(desdeDateTimePicker.Value, hastaDateTimePicker.Value, txtModulo.Text).ToString();

            dataGridViewBitacora.DataSource = BitacoraHelper.ConsultarBitacora(desdeDateTimePicker.Value, hastaDateTimePicker.Value, txtModulo.Text);


        }

        public StringBuilder ConsultarBitacora(DateTime desde, DateTime hasta, string modulo = null)
        {
            try
            {
                var registros = BitacoraHelper.ConsultarBitacora(desde,hasta, modulo);

                StringBuilder cadena = new StringBuilder();
                foreach (Bitacora registro in registros)
                {
                    cadena.AppendLine($"-- {registro.Actividad} | {registro.InfoAdicional} | {registro.FechaHora} | {registro.Usuario}");

                }
                BitacoraHelper.RegistrarActividad(SessionManager.GetInstance.Usuario.ToString(), "Consulta de bitácora", DateTime.Now, $"Desde: {desde}, Hasta: {hasta}, Controller: {modulo}", this.Name,AppDomain.CurrentDomain.BaseDirectory, "Bitacora");    

                return cadena;

            }
            catch (Exception ex)
            {
                BitacoraHelper.RegistrarError(this.Name, ex, "Bitacora",SessionManager.GetInstance.Usuario.ToString());
                StringBuilder cadena = new StringBuilder();
                cadena.Append($"Error al consultar la bitácora: {ex.Message}");
                return cadena;
            }

        }

        private void checkBoxBuscarPorModulo_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBoxBuscarPorArea.Checked)
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
    }
}
