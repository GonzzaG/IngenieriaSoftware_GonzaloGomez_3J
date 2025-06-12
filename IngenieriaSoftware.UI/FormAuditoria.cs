using IngenieriaSoftware.BEL;
using IngenieriaSoftware.BEL.Auditoria;
using IngenieriaSoftware.BLL;
using IngenieriaSoftware.BLL.Auditoria;
using IngenieriaSoftware.Servicios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace IngenieriaSoftware.UI
{
    public partial class FormAuditoria : Form, IActualizable
    {
        private readonly AuditoriaManager _auditoriaManager;
        private List<AuditoriaRegistro> _registros;


        private List<IAuditableModel> _registrosAuditable;
        private IAuditoriaService _auditoriaService;
        private string NombreTabla;

        private bool registrosCargados = false;

        public FormAuditoria(List<IAuditableModel> registros, string nombreTabla)
        {
            InitializeComponent();

            var tipoModelo = AuditoriaModelTyperRegistry.GetModelTypeOrThrow(nombreTabla);

            var tipoServicio = typeof(AuditoriaService<>).MakeGenericType(tipoModelo);

            _auditoriaService = (IAuditoriaService)Activator.CreateInstance(tipoServicio);

            _registrosAuditable = registros;

            NombreTabla = nombreTabla;

            Actualizar();
        }

        public NotificacionService _notificacionService => throw new NotImplementedException();

        public void Actualizar()
        {
            //ListarTablasAuditadas();
            txtComentario.Clear();
            dataGridViewHistorialCambios.DataSource = null;
            //dataGridViewRegistrosModificados.DataSource = null;
            //dataGridViewRegistrosModificados.DataSource = _registrosAuditable;

            if (!registrosCargados)
            {
                LlenarDataGridView();
                registrosCargados = true;
            }
        }
        private void LlenarDataGridView()
        {
            dataGridViewHistorialCambios.Columns.Clear();
            dataGridViewHistorialCambios.Rows.Clear();

            if (_registrosAuditable == null || !_registrosAuditable.Any())
                return;

            // Obtener las propiedades simples de la entidad (no colecciones, excepto string)
            var primeraEntidad = _registrosAuditable[0].Entidad;
            var propiedades = primeraEntidad.GetType()
                .GetProperties()
                .Where(p =>
                    !typeof(System.Collections.IEnumerable).IsAssignableFrom(p.PropertyType) ||
                    p.PropertyType == typeof(string))
                .ToList();

            // Crear columnas por cada propiedad válida
            foreach (var prop in propiedades)
            {
                dataGridViewHistorialCambios.Columns.Add(prop.Name, prop.Name);
            }

            // Agregar columnas del modelo auditable
            dataGridViewHistorialCambios.Columns.Add("Version", "Version");
            dataGridViewHistorialCambios.Columns.Add("Accion", "Acción");
            dataGridViewHistorialCambios.Columns.Add("CambiadoPor", "Cambiado Por");
            dataGridViewHistorialCambios.Columns.Add("FechaCambio", "Fecha de Cambio");
            dataGridViewHistorialCambios.Columns.Add("EsUltimaVersion", "Última Versión");

            // Agregar filas
            foreach (var registro in _registrosAuditable)
            {
                var entidad = registro.Entidad;
                var valores = new List<object>();

                foreach (var prop in propiedades)
                {
                    object valor = prop.GetValue(entidad);
                    valores.Add(FormatearValor(valor));
                }

                valores.Add(registro.Version);
                valores.Add(registro.Accion);
                valores.Add(registro.CambiadoPor);
                valores.Add(registro.FechaCambio.ToString("yyyy-MM-dd HH:mm:ss"));
                valores.Add(registro.EsUltimaVersion ? "Sí" : "No");

                int rowIndex = dataGridViewHistorialCambios.Rows.Add(valores.ToArray());

                dataGridViewHistorialCambios.Rows[rowIndex].Tag = registro; // Guardar el registro completo en la fila para referencia futura
            }
        }

        private object FormatearValor(object valor)
        {
            if (valor == null)
                return "[Nulo]";

            if (valor is DateTime fecha)
                return fecha.ToString("yyyy-MM-dd");

            if (valor.GetType().IsEnum)
                return valor.ToString();

            return valor;
        }


        public void VerificarNotificaciones()
        {
            throw new NotImplementedException();
        }

        private void btnDetallesRegistro_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    dataGridViewHistorialCambios.DataSource = null;

            //    Guid idCambio = (Guid)dataGridViewRegistrosModificados.SelectedRows[0].Cells[nameof(AuditoriaRegistro.IdCambio)].Value;
            //    var detalles = ListarDetallesRegistro(idCambio);

            //    dataGridViewHistorialCambios.DataSource = detalles;
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Error al obtener lso detalles del registro seleccionado: " + ex.Message);
            //}
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
                if (dataGridViewHistorialCambios.SelectedRows.Count == 0)
                {
                    throw new Exception("Debe seleccionar una fila del historial de cambios");
                }
                var registroSeleccionado = dataGridViewHistorialCambios.SelectedRows[0].Tag as IAuditableModel;

                if (registroSeleccionado == null)
                {
                    throw new Exception("No se pudo obtener el registro seleccionado.");
                }

                bool esUltimaVersion = registroSeleccionado.EsUltimaVersion;

                if (esUltimaVersion)
                {
                    throw new Exception("No se puede realizar una petición de restauración sobre la última versión del registro.");
                }

                #region Implementacion vieja de auditoria
                //PeticionRestauracion petRest = new PeticionRestauracion();
                //string fullName = dataGridViewHistorialCambios.SelectedRows[0].Cells[nameof(AuditoriaDetalle.Tabla)].Value.ToString();
                //string[] partes = fullName.Replace("[", "").Replace("]", "").Split('.');
                //string nombreTabla = partes.Length > 1 ? partes[1] : partes[0];

                //if (TablasDVCamposId.ImplementaIDVHCalculo(nombreTabla))
                //{
                //    throw new Exception("No se puede aceptar la petición porque la tabla implementa IDVH y no se puede calcular el DVH (AUN).");
                //}
                //petRest = MapearDesdeDataGridViewRow(dataGridViewHistorialCambios.SelectedRows[0]);
                //_auditoriaManager.SolicitarRestauracion(petRest);
                #endregion

                if (NombreTabla.Length <= 0)
                {
                    throw new Exception("Debe seleccionar una tabla para realizar la petición de restauración.");
                }

                int idEntidad = registroSeleccionado.Entidad.Id;

                int version = registroSeleccionado.Version;

                int idUsuarioActual = SessionManager.GetInstance.Usuario.Id;

                string comentario = txtComentario.Text.Trim();

                _auditoriaService.RealizarPeticionRestauracion(NombreTabla, idEntidad, version, idUsuarioActual, comentario);

                MessageBox.Show("Peticion realizada con exito.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener los detalles del registro seleccionado: " + ex.Message);
            }
            finally
            {
                Actualizar();
            }
        }



        //private bool RealizarPeticionRestauracion()
        //{
        //    try
        //    {

        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("Error al obtener los detalles del registro seleccionado: " + ex.Message);
        //    }
        //    finally
        //    {
        //        Actualizar();
        //    }
        //}

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
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private void FormAuditoria_Load(object sender, EventArgs e)
        {
        }
    }
}