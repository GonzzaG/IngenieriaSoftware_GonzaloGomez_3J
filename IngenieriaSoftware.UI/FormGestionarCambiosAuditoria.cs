﻿using IngenieriaSoftware.BEL;
using IngenieriaSoftware.BLL;
using IngenieriaSoftware.Servicios;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace IngenieriaSoftware.UI
{
    public partial class FormGestionarCambiosAuditoria : Form, IActualizable
    {
        private readonly AuditoriaManager _auditoriaManager = new AuditoriaManager();
        public NotificacionService _notificacionService => new NotificacionService();
        private DigitoVerificadorManager _digitoVerificadorManager = new DigitoVerificadorManager();
        public FormGestionarCambiosAuditoria()
        {
            InitializeComponent();
        }

        private void FormGestionarCambiosAuditoria_Load(object sender, EventArgs e)
        {
            Actualizar();
        }

        public void Actualizar()
        {
            ListarPeticionesPendientes();
        }

        private void ListarPeticionesPendientes()
        {
            try
            {
                dataGridViewDetallesAntes.DataSource = null;
                dataGridViewDetallesNuevos.DataSource = null;   
                dataGridViewPeticionesPendientes.DataSource = null;
                var peticiones = _auditoriaManager.ObtenerPeticionesPendientes();

                if (peticiones.Count > 0)
                {
                    dataGridViewPeticionesPendientes.DataSource = peticiones;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al listar las peticiones pendientes: " + ex.Message);
            }
        }

        public void VerificarNotificaciones()
        {
            throw new NotImplementedException();
        }

        private void btnDetallesPeticion_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridViewPeticionesPendientes.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Seleccione una fila para ver los cambiosPropuestos.");
                    return;
                }

                // Obtenemos los cambios que se quieren realizar
                Guid idCambio = (Guid)dataGridViewPeticionesPendientes.SelectedRows[0].Cells[nameof(PeticionRestauracion.IdCambioOrigen)].Value;
                var cambiosPropuestos = ListarDetallesNuevos(idCambio);

                if (cambiosPropuestos.Count == 0)
                {
                    MessageBox.Show("No se encontraron cambios propuestos para la petición seleccionada.");
                    return;
                }

                // Obtenemos los detalles del registro actualmente

                string tabla = dataGridViewPeticionesPendientes.SelectedRows[0].Cells[nameof(PeticionRestauracion.Tabla)].Value.ToString();
                int registro = Convert.ToInt32(dataGridViewPeticionesPendientes.SelectedRows[0].Cells[nameof(PeticionRestauracion.Registro)].Value);

                var detallesActuales = ListarDetallesActuales(tabla, registro);

                if (detallesActuales.Count == 0)
                {
                    MessageBox.Show("No se encontraron detalles actuales para la petición seleccionada.");
                    return;
                }

                dataGridViewDetallesNuevos.DataSource = null;
                dataGridViewDetallesAntes.DataSource = null;
                dataGridViewDetallesAntes.DataSource = detallesActuales;
                dataGridViewDetallesNuevos.DataSource = cambiosPropuestos;

                OcultarColumnasDetalles();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener los cambiosPropuestos del registro seleccionado: " + ex.Message);
            }
        }

        private List<AuditoriaDetalle> ListarDetallesNuevos(Guid idCambio)
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

        private List<AuditoriaDetalle> ListarDetallesActuales(string tabla, int registro)
        {
            try
            {
                return _auditoriaManager.ObtenerDetalleCambio(tabla, registro);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private void OcultarColumnasDetalles()
        {
            dataGridViewDetallesAntes.Columns[nameof(AuditoriaDetalle.IdAuditoria)].Visible = false;
            dataGridViewDetallesAntes.Columns[nameof(AuditoriaDetalle.Registro)].Visible = false;
            dataGridViewDetallesAntes.Columns[nameof(AuditoriaDetalle.Tabla)].Visible = false;
            dataGridViewDetallesAntes.Columns[nameof(AuditoriaDetalle.ValorAntes)].Visible = false;
            dataGridViewDetallesAntes.Columns[nameof(AuditoriaDetalle.IdCambio)].Visible = false;

            dataGridViewDetallesNuevos.Columns[nameof(AuditoriaDetalle.IdAuditoria)].Visible = false;
            dataGridViewDetallesNuevos.Columns[nameof(AuditoriaDetalle.Registro)].Visible = false;
            dataGridViewDetallesNuevos.Columns[nameof(AuditoriaDetalle.Tabla)].Visible = false;
            dataGridViewDetallesNuevos.Columns[nameof(AuditoriaDetalle.ValorAntes)].Visible = false;
            dataGridViewDetallesNuevos.Columns[nameof(AuditoriaDetalle.IdCambio)].Visible = false;
        }

        private void btnAceptarCambio_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridViewPeticionesPendientes.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Seleccione una fila para aceptar la petición.");
                    return;
                }
                int idPeticion = int.Parse(dataGridViewPeticionesPendientes.SelectedRows[0].Cells[nameof(PeticionRestauracion.IdPeticion)].Value.ToString());
                string usuarioAutorizador = SessionManager.GetInstance.Usuario.Username;
                string fullName = dataGridViewPeticionesPendientes.SelectedRows[0].Cells[nameof(AuditoriaDetalle.Tabla)].Value.ToString();
                string[] partes = fullName.Replace("[", "").Replace("]", "").Split('.');
                string nombreTabla = partes.Length > 1 ? partes[1] : partes[0];

                if (TablasDVCamposId.ImplementaIDVHCalculo(nombreTabla))
                {
                    throw new Exception("No se puede aceptar la petición porque la tabla implementa IDVH y no se puede calcular el DVH (AUN).");
                }
                if (_auditoriaManager.AceptarPeticionDeRestauracion(idPeticion, usuarioAutorizador))
                {
                    MessageBox.Show("Se han realizado los cambios correctamente");

                }

               
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo aceptar los cambios: " + ex.Message);

            }
            finally
            {
                Actualizar();
            }
        }

        /// <summary>
        /// Metodo que calcula el digito verificador de un registro, dado el nombre de la tabla y el id del registro.
        /// Luego, verifica la integridad de los registros de la tabla, comparando el DVH almacenado con el DVH generado.
        /// </summary>
        /// <param name="entidadVerificable"></param>
        /// <exception cref="Exception"></exception>
    
        private bool CalcularDigitoVerificador(Entity entidadVerificable)
        {
            try
            {
                string nombreTabla = entidadVerificable.getNombreTabla();
                if (_digitoVerificadorManager.ActualizarDVH_Y_DVV_DeRegistro(nombreTabla, entidadVerificable.Id))
                {
                    if (_digitoVerificadorManager.VerificarDigitoVerticalYHorizontal())
                        return true;
                }

                throw new Exception(nombreTabla + " no se actualizo correctamente el DVH");
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private void btnRechazarCambio_Click(object sender, EventArgs e)
        {
            try
            {
                int idPeticion = int.Parse(dataGridViewPeticionesPendientes.SelectedRows[0].Cells[nameof(PeticionRestauracion.IdPeticion)].Value.ToString());

                if (_auditoriaManager.RechazarPeticionDeRestauracion(idPeticion))
                {
                    MessageBox.Show("Se han rechazado los cambios correctamente");
                }
                else
                    MessageBox.Show("No se pudo rechazar la petición.");

                Actualizar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo rechazar los cambios: " + ex.Message);
            }
            finally
            {
                Actualizar();
            }
        }
    }
}