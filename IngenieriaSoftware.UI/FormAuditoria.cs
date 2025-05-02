using IngenieriaSoftware.BEL;
using IngenieriaSoftware.BLL;
using IngenieriaSoftware.Servicios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IngenieriaSoftware.UI
{
    public partial class FormAuditoria: Form, IActualizable
    {
        private readonly AuditoriaManager _auditoriaManager;
        private List<AuditoriaRegistro> _registros;
        private bool registrosCargados = false;
        public FormAuditoria(AuditoriaManager audit, List<AuditoriaRegistro> registros)
        {
            InitializeComponent();
            _registros = registros;  
            _auditoriaManager = audit;
            Actualizar();
        }

        public NotificacionService _notificacionService => throw new NotImplementedException();

        public void Actualizar()
        {
            //ListarTablasAuditadas();
            dataGridViewRegistrosModificados.DataSource = null;
            dataGridViewRegistrosModificados.DataSource = _registros;

        }
        public void ListarTablasAuditadas()
        {
            try
            {
                List<string> tablas = _auditoriaManager.ObtenerTablasAuditadas();
                
                foreach(string tabla in tablas)
                {
                    comboBoxTablasAuditadas.Items.Add(tabla);
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show("Error al obtener las tablas: " + ex.Message);
            }
        }

        public void VerificarNotificaciones()
        {
            throw new NotImplementedException();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridViewRegistrosModificados.DataSource = null;
                var registros = ListarRegistrosTabla(comboBoxTablasAuditadas.Text);
                dataGridViewRegistrosModificados.DataSource = registros;
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error al obtener los registros: " + ex.Message);   
            }
        }

        private List<AuditoriaRegistro> ListarRegistrosTabla(string nombre)
        {
            try
            {
                return _auditoriaManager.ObtenerRegistroDeTabla(nombre);
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private void btnDetallesRegistro_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridViewHistorialCambios.DataSource = null;

                Guid idCambio = (Guid)dataGridViewRegistrosModificados.SelectedRows[0].Cells[nameof(AuditoriaRegistro.IdCambio)].Value;
                var detalles = ListarDetallesRegistro(idCambio);

                dataGridViewHistorialCambios.DataSource = detalles;

            }
            catch(Exception ex)
            {
                MessageBox.Show("Error al obtener lso detalles del registro seleccionado: " + ex.Message);
            }
        }

        private List<AuditoriaDetalle> ListarDetallesRegistro(Guid idCambio)
        {
            try
            {
                return _auditoriaManager.ObtenerDetalleCambio(idCambio);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private void btnPeticionRestauracion_Click(object sender, EventArgs e)
        {
            try
            {
                if(dataGridViewHistorialCambios.SelectedRows.Count == 0)
                {
                    throw new Exception("Debe seleccionar una fila del historial de cambios");
                }
                PeticionRestauracion petRest = new PeticionRestauracion();

                petRest = MapearDesdeDataGridViewRow(dataGridViewHistorialCambios.SelectedRows[0]);
                _auditoriaManager.SolicitarRestauracion(petRest);

                MessageBox.Show("Peticion realizada con exito.");
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error al obtener los detalles del registro seleccionado: " + ex.Message);
            }
        }

        public PeticionRestauracion MapearDesdeDataGridViewRow(DataGridViewRow row)
        {
            try
            {
                if (row == null)
                {
                    throw new ArgumentNullException(nameof(row), "La fila proporcionada es nula.");
                }
                return new PeticionRestauracion
                {
                    Tabla = row.Cells["Tabla"].Value?.ToString(),
                    Registro = int.Parse(row.Cells["Registro"].Value?.ToString()),
                    Comentario = txtComentario.Text,
                    UsuarioSolicitante = SessionManager.GetInstance.Usuario.Username,
                    IdCambioOrigen = row.Cells["IdCambio"].Value != DBNull.Value ? Guid.Parse(row.Cells["IdCambio"].Value.ToString()) : throw new Exception("Error al realizar la peticion"),
                };
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private void FormAuditoria_Load(object sender, EventArgs e)
        {

        }

        private void comboBoxRegistros_SelectedValueChanged(object sender, EventArgs e)
        {
            if (comboBoxRegistros.SelectedIndex >= 0 && comboBoxRegistros.SelectedText != string.Empty && registrosCargados)
            {

            }
        }
    }
}
