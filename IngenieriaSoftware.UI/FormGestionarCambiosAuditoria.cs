using IngenieriaSoftware.BEL;
using IngenieriaSoftware.BEL.Auditoria;
using IngenieriaSoftware.BLL;
using IngenieriaSoftware.BLL.Auditoria;
using IngenieriaSoftware.Servicios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

namespace IngenieriaSoftware.UI
{
    public partial class FormGestionarCambiosAuditoria : Form, IActualizable
    {
        //private readonly AuditoriaManager _auditoriaManager = new AuditoriaManager();
        public NotificacionService _notificacionService => new NotificacionService();
        private DigitoVerificadorManager _digitoVerificadorManager = new DigitoVerificadorManager();

        private IAuditoriaService _auditoriaService;
        private AuditoriaPeticionesPendientesService _auditoriaPeticionesPendientesService;
        public FormGestionarCambiosAuditoria()
        {
            InitializeComponent();
            _auditoriaPeticionesPendientesService = new AuditoriaPeticionesPendientesService();
//            _auditoriaService = new AuditoriaService();

        }

        private void FormGestionarCambiosAuditoria_Load(object sender, EventArgs e)
        {
            Actualizar();

            dataGridViewDetallesNuevos.DataError += DataGridViewDetallesAntes_DataError;
            dataGridViewDetallesAntes.DataError += DataGridViewDetallesAntes_DataError;
        }

        public void Actualizar()
        {
            ListarPeticionesPendientes();
        }

        private void ListarPeticionesPendientesDataSource()
        {
            try
            {
                dataGridViewDetallesAntes.DataSource = null;
                dataGridViewDetallesNuevos.DataSource = null;   
                dataGridViewPeticionesPendientes.DataSource = null;

                // Obtenemos las peticiones pendientes de restauración
                var peticiones = _auditoriaPeticionesPendientesService.ObtenerPeticionesPendientes();

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

        private void ListarPeticionesPendientes()
        {
            try
            {
                dataGridViewDetallesAntes.DataSource = null;
                dataGridViewDetallesAntes.Columns.Clear();
                dataGridViewDetallesAntes.Rows.Clear();
               

                dataGridViewDetallesNuevos.DataSource = null;
                dataGridViewDetallesNuevos.Columns.Clear();
                dataGridViewDetallesNuevos.Rows.Clear();

                dataGridViewPeticionesPendientes.DataSource = null;
                dataGridViewPeticionesPendientes.Columns.Clear();
                dataGridViewPeticionesPendientes.Rows.Clear();

                var peticiones = _auditoriaPeticionesPendientesService.ObtenerPeticionesPendientes();

                if (peticiones == null || peticiones.Count == 0)
                {
                    MessageBox.Show("No hay peticiones pendientes de restauración.");
                    return;
                }

                var tipo = typeof(PeticionRestauracionModel);

                foreach (var prop in tipo.GetProperties())
                {
                    dataGridViewPeticionesPendientes.Columns.Add(prop.Name, prop.Name);
                }

                foreach (var peticion in peticiones)
                {
                    int rowIndex = dataGridViewPeticionesPendientes.Rows.Add();
                    var row = dataGridViewPeticionesPendientes.Rows[rowIndex];

                    for (int i = 0; i < tipo.GetProperties().Length; i++)
                    {
                        var prop = tipo.GetProperties()[i];
                        row.Cells[i].Value = prop.GetValue(peticion);
                    }

                    row.Tag = peticion; // Guardamos la petición completa en la fila
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al listar las peticiones pendientes: " + ex.Message);
                return;
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
                    MessageBox.Show("Seleccione una fila para ver los cambios propuestos.");
                    return;
                }

                var nombreTabla = dataGridViewPeticionesPendientes.SelectedRows[0].Cells[nameof(PeticionRestauracionModel.Tabla)].Value.ToString();

                if (string.IsNullOrEmpty(nombreTabla))
                {
                    MessageBox.Show("Debe seleccionar una tabla para listar los detalles de los cambios propuestos.");
                    return;
                }
                var tipoModelo = AuditoriaModelTyperRegistry.GetModelTypeOrThrow(nombreTabla);

                var tipoServicio = typeof(AuditoriaService<>).MakeGenericType(tipoModelo);

                _auditoriaService = (IAuditoriaService)Activator.CreateInstance(tipoServicio);

                var peticionRestauracion = dataGridViewPeticionesPendientes.SelectedRows[0].Tag as PeticionRestauracionModel;
                
             

                if (peticionRestauracion == null)
                {
                    MessageBox.Show("No se pudo obtener la petición seleccionada.");
                    return;
                }

                var registro = ObtenerRegistroDesdePeticionRestauracion(
                    peticionRestauracion.IdEntidad,
                    peticionRestauracion.Version,
                    peticionRestauracion.Tabla
                );

                ListarRegistroPropuesto(registro);

                //Listar los detalles del estado actual

                var registroActual = ObtenerRegistroAuditableActualPorTabla(peticionRestauracion.Tabla, peticionRestauracion.IdEntidad);

                ListarRegistroActual(registroActual);   
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener los cambiosPropuestos del registro seleccionado: " + ex.Message);
            }
        }

        // Metodo para obtener un registro modificable
        private IAuditableModel ObtenerRegistroDesdePeticionRestauracion (int idEntidad, int version, string nombreTabla)
        {
            try
            {

                if (string.IsNullOrEmpty(nombreTabla))
                {
                    throw new Exception("Debe seleccionar una tabla para listar los detalles de los cambios propuestos.");
                }

                var registroAuditoria = _auditoriaService.GetPorIdYVersion(idEntidad, version);

                 if(registroAuditoria == null)
                {
                    throw new Exception("No se encontró el registro con el id y versión especificados.");
                }

                return registroAuditoria as IAuditableModel;
                //Luego de obtener el tipo, obtenemos el registro por id y version.

            }
            catch (Exception ex)
            {
                throw new Exception("Error al listar los detalles de los cambios propuestos: " + ex.Message);
            }
        }

        private void ListarRegistroPropuesto(IAuditableModel registro)
        {
            dataGridViewDetallesNuevos.Columns.Clear();
            dataGridViewDetallesNuevos.Rows.Clear();
            if (registro == null)
            {
                MessageBox.Show("No se encontró el registro propuesto.");
                return;
            }

            var tipo = registro.GetType();

            foreach (var prop in tipo.GetProperties())
            {
                dataGridViewDetallesNuevos.Columns.Add(prop.Name, prop.Name);
            }

            var valores = new List<object>();

            foreach (var prop in tipo.GetProperties())
            {
                object valor = prop.GetValue(registro);
                valores.Add(valor ?? "Nulo");
            }

            int rowIndex = dataGridViewDetallesNuevos.Rows.Add(valores.ToArray());

            dataGridViewDetallesNuevos.Rows[rowIndex].Tag = registro; // Guardamos el registro completo en la fila para referencia futura

            ListarEntidadEnGrid(registro.Entidad, dataGridViewDetallesNuevos);

        }

        private IAuditableModel ObtenerRegistroAuditableActualPorTabla (string nombreTabla, int idEntidad)
        {
            return _auditoriaService.ObtenerUltimaVersionDeEntidadAuditable(nombreTabla, idEntidad);
        }

        private void ListarRegistroActual(IAuditableModel registro)
        {
            dataGridViewDetallesAntes.Columns.Clear();
            dataGridViewDetallesAntes.Rows.Clear();

            if (registro == null)
            {
                MessageBox.Show("No se encontró el registro actual.");
                return;
            }

            var tipo = registro.GetType();

            foreach (var prop in tipo.GetProperties())
            {
                dataGridViewDetallesAntes.Columns.Add(prop.Name, prop.Name);
            }

            var valores = new List<object>();

            foreach (var prop in tipo.GetProperties())
            {
                object valor = prop.GetValue(registro);
                valores.Add(valor ?? "Nulo");
            }

            int rowIndex = dataGridViewDetallesAntes.Rows.Add(valores.ToArray());

            dataGridViewDetallesAntes.Rows[rowIndex].Tag = registro; // Guardamos el registro completo en la fila para referencia futura

            ListarEntidadEnGrid(registro.Entidad, dataGridViewDetallesAntes);    

        }

        private void DataGridViewDetallesAntes_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            // Evita que se lance una excepción cuando hay error de tipo
            e.ThrowException = false;
            e.Cancel = true;
        }

        private object ListarEntidadEnGrid(object entidad, DataGridView gridView)
        {
            gridView.Columns.Clear();
            gridView.Rows.Clear();

            if (entidad == null)
            {
                MessageBox.Show("No se encontró la entidad.");
                return null;
            }
            var tipo = entidad.GetType();
            foreach (var prop in tipo.GetProperties())
            {
                gridView.Columns.Add(prop.Name, prop.Name);
            }
            var valores = new List<object>();
            foreach (var prop in tipo.GetProperties())
            {
                object valor = prop.GetValue(entidad);
                valores.Add(valor ?? "Nulo");
            }
            int rowIndex = gridView.Rows.Add(valores.ToArray());
            gridView.Rows[rowIndex].Tag = entidad; // Guardamos la entidad completa en la fila para referencia futura
            return entidad;
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

                var registroPropuesto = dataGridViewPeticionesPendientes.SelectedRows[0].Tag as PeticionRestauracionModel;

                var idEntidad = registroPropuesto.IdEntidad;
                var version = registroPropuesto.Version;
                var idPeticion = registroPropuesto.Id;
                var procesadoPor = SessionManager.GetInstance.Usuario.Id;
                _auditoriaService.AceptarPeticionDeRestauracion(idEntidad, version, idPeticion, procesadoPor);

                //if (TablasDVCamposId.ImplementaIDVHCalculo(nombreTabla))
                //{
                //    throw new Exception("No se puede aceptar la petición porque la tabla implementa IDVH y no se puede calcular el DVH (AUN).");
                //}
                 MessageBox.Show("Se han realizado los cambios correctamente");
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
                var peticion = dataGridViewPeticionesPendientes.SelectedRows[0].Tag as PeticionRestauracionModel;   

                if (peticion == null)
                {
                    MessageBox.Show("Debe seleccionar una petición para rechazar.");
                    return;
                }

                var idPeticion = peticion.Id;
                var procesadoPor = SessionManager.GetInstance.Usuario.Id; 

                _auditoriaService.RechazarPeticionDeRestauracion(idPeticion, procesadoPor);


                //if (TablasDVCamposId.ImplementaIDVHCalculo(nombreTabla))
                //{
                //    throw new Exception("No se puede aceptar la petición porque la tabla implementa IDVH y no se puede calcular el DVH (AUN).");
                //}
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