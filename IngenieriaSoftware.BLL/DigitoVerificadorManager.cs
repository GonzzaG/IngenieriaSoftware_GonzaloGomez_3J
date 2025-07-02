using IngenieriaSoftware.BEL;
using IngenieriaSoftware.DAL;
using IngenieriaSoftware.Servicios;
using System;
using System.Collections.Generic;
using System.Data;

namespace IngenieriaSoftware.BLL
{
    public class DigitoVerificadorManager
    {
        private readonly DigitoVerificadorVerticalDAL _dvVerticalDAL = new DigitoVerificadorVerticalDAL();
        private readonly DigitoVerificadorHorizontalDAL _dvHorizontalDAL = new DigitoVerificadorHorizontalDAL();
        private readonly ObjetoDAL _objetoDAL = new ObjetoDAL();

        public bool VerificarDigitoVerticalYHorizontal()
        {
            try
            {
                List<string> nombreTablas = _dvHorizontalDAL.ObtenerTablasConDVH();

                foreach (string tabla in nombreTablas)
                {
                    // Verificar el DVH de cada registro y retornamos cada dvh generado
                    List<string> dvHorizontales = _dvHorizontalDAL.VerificarIntegridadDeRegistrosDeTabla(tabla);

                    //ahora concatenamos todos los dvH y generamos el hash
                    VerificarDVVDeTabla(tabla, dvHorizontales);
                }

                BitacoraHelper.RegistrarActividad("Sistema", "Verificación de integridad de registros", DateTime.Now, "Verificación de DVH y DVV", "VerificarDigitoVerticalYHorizontal", "VerificarIntegridadDeRegistrosDeTabla");
                return true;
            }
            catch (Exception ex)
            {
                BitacoraHelper.RegistrarError("VerificarDigitoVerticalYHorizontal", ex, "Verificación de DVH y DVV", "Sistema");
                throw new Exception("Error al verificar integridad: " + ex.Message, ex);
            }
        }

        /// <summary>
        /// Verificar el DVV de una tabla específica segun una lista de DV Horizontales en memoria.
        /// </summary>
        /// <param name="dvHorizontales"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public bool VerificarDVVDeTabla(string nombreTabla, List<string> dvHorizontales)
        {
            try
            {
                string concat = string.Concat(dvHorizontales);
                string dvvGenerado = Encriptador.GetMd5Hash(concat);

                DigitoVerificadorVertical dvvAlmacenado = _dvVerticalDAL.ObtenerDVV(nombreTabla);

                if (dvvGenerado != dvvAlmacenado.DVV)
                {
                    throw new Exception("El DVV almacenado no coincide con el DVV generado.");
                }
                // Si el DVV coincide, se puede continuar
                BitacoraHelper.RegistrarActividad("Sistema", "Verificación de integridad de registros", DateTime.Now, "Verificación de DVH y DVV", "VerificarDVVDeTabla", "VerificarIntegridadDeRegistrosDeTabla");
                return true;
            }
            catch (Exception ex)
            {
                BitacoraHelper.RegistrarError("VerificarDVVDeTabla", ex, "Verificación de DVH y DVV", "Sistema");
                throw new Exception("Error al obtener el verificador vertical: " + ex.Message, ex);
            }
        }

        /// <summary>
        ///  Verificar el DVV de una tabla específica buscando sus DVHorizontales en la BD.
        /// </summary>
        /// <param name="nombreTabla"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public bool VerificarDVVDeTabla(string nombreTabla)
        {
            try
            {
                string dvvGenerado = _dvVerticalDAL.CalcularDVVDeTabla(nombreTabla);
                DigitoVerificadorVertical dvvAlmacenado = _dvVerticalDAL.ObtenerDVV(nombreTabla);

                if (dvvGenerado != dvvAlmacenado.DVV)
                {
                    throw new Exception("El DVV almacenado no coincide con el DVV generado.");
                }
                // Si el DVV coincide, se puede continuar

                BitacoraHelper.RegistrarActividad("Sistema", "Verificación de integridad de registros", DateTime.Now, "Verificación de DVH y DVV", "VerificarDVVDeTabla", "VerificarIntegridadDeRegistrosDeTabla");
                return true;
            }
            catch (Exception ex)
            {
                BitacoraHelper.RegistrarError("VerificarDVVDeTabla", ex, "Verificación de DVH y DVV", "Sistema");
                throw new Exception("Error al obtener el verificador vertical: " + ex.Message, ex);
            }
        }

        /// <summary>
        /// Actualiza el DVH y el DVV de un registro específico en la tabla.    
        /// </summary>
        /// <param name="nombreTabla"></param>
        /// <param name="valorId"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public bool ActualizarDVH_Y_DVV_DeRegistro(string nombreTabla, object valorId)
        {
            try
            {
                if (valorId == null)
                {
                    // Si es null, asumimos que es una eliminación
                    return ActualizarVerificadorVertical(nombreTabla);
                }

                // Caso normal: alta o modificación
                string campoId = TablasDVCamposId.ObtenerCampoId(nombreTabla);

                // Obtener el DataRow del registro
                DataRow registro = _objetoDAL.ObtenerRegistroDeTabla(nombreTabla, campoId, valorId);

                if (registro == null)
                    throw new Exception("No se encontró el registro especificado para la tabla " + nombreTabla);

                List<string> valoresParaHash = new List<string>();

                foreach (DataColumn columna in registro.Table.Columns)
                {
                    if (columna.ColumnName.Equals("DVH", StringComparison.OrdinalIgnoreCase))
                        continue;

                    valoresParaHash.Add(registro[columna].ToString());
                }

                string dvhGenerado = Encriptador.GetMd5Hash(string.Concat(valoresParaHash));

                bool actualizado = _dvHorizontalDAL.ActualizarDVHorizontalDeRegistro(nombreTabla, campoId, valorId, dvhGenerado);

                if (!actualizado)
                    throw new Exception("No se pudo actualizar el DVH.");

                BitacoraHelper.RegistrarActividad("Sistema", "Actualización de DVH y DVV", DateTime.Now, "Actualización de DVH y DVV", "ActualizarDVH_Y_DVV_DeRegistro", "ActualizarDVH_Y_DVV_DeRegistro");
                return ActualizarVerificadorVertical(nombreTabla);
            }
            catch (Exception ex)
            {
                BitacoraHelper.RegistrarError("ActualizarDVH_Y_DVV_DeRegistro", ex, "Actualización de DVH y DVV", "Sistema");
                throw new Exception($"Error al actualizar DVH y/o DVV para {nombreTabla}: {ex.Message}", ex);
            }
        }


        /// <summary>
        /// Actualiza el DVH de un registro específico en la tabla.
        /// </summary>
        /// <param name="nombreTabla"></param>
        /// <param name="registro"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public bool ActualizarDVHorizontalDeRegistro(string nombreTabla, object valorId)
        {
            try
            {
                string campoId = TablasDVCamposId.ObtenerCampoId(nombreTabla);

                // Obtener el DataRow del registro
                DataRow registro = _objetoDAL.ObtenerRegistroDeTabla(nombreTabla, campoId, valorId);

                if (registro == null)
                    throw new Exception("No se encontró el registro especificado para la tabla " + nombreTabla);

                List<string> valoresParaHash = new List<string>();

                foreach (DataColumn columna in registro.Table.Columns)
                {
                    if (columna.ColumnName.Equals("DVH", StringComparison.OrdinalIgnoreCase))
                        continue;

                    valoresParaHash.Add(registro[columna].ToString());
                }

                string dvhGenerado = Encriptador.GetMd5Hash(string.Concat(valoresParaHash));

                BitacoraHelper.RegistrarActividad("Sistema", "Actualización de DVH", DateTime.Now, "Actualización de DVH", "ActualizarDVHorizontalDeRegistro", "ActualizarDVHorizontalDeRegistro");

                return _dvHorizontalDAL.ActualizarDVHorizontalDeRegistro(nombreTabla, campoId, valorId, dvhGenerado);
            }
            catch (Exception ex)
            {
                BitacoraHelper.RegistrarError("ActualizarDVHorizontalDeRegistro", ex, "Actualización de DVH", "Sistema");
                throw new Exception($"Error actualizando DVH horizontal para {nombreTabla}: {ex.Message}", ex);
            }
        }

        /// <summary>
        /// !!Solo usar en caso de estar seguro de querer actualizar los digitos verificadores!!
        /// </summary>
        /// <param name="nombreTabla"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public bool ActualizarVerificadores(string nombreTabla)
        {
            try
            {
                if (ActualizarVerificadorHorizontal(nombreTabla))
                {
                    if (ActualizarVerificadorVertical(nombreTabla))
                    {
                        BitacoraHelper.RegistrarActividad("Sistema", "Actualización de DVH y DVV", DateTime.Now, "Actualización de DVH y DVV", "ActualizarVerificadores", "ActualizarVerificadores");
                        return true;
                    }
                    throw new Exception("Error al actualizar el DV Vertical de la tabla: " + nombreTabla);
                }

                throw new Exception("Error al actualizar el DV Horizontal de la tabla: " + nombreTabla);
            }
            catch (Exception ex)
            {
                BitacoraHelper.RegistrarError("ActualizarVerificadores", ex, "Actualización de DVH y DVV", "Sistema");
                throw new Exception("Error al actualizar los DV: " + ex.Message, ex);
            }
        }

        /// <summary>
        /// !!Solo usar en caso de estar seguro de querer actualizar el DVV!!
        /// </summary>
        /// <param name="nombreTabla"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public bool ActualizarVerificadorVertical(string nombreTabla)
        {
            try
            {
                string dvvGenerado = _dvVerticalDAL.CalcularDVVDeTabla(nombreTabla);
                DigitoVerificadorVertical dvvNuevo = new DigitoVerificadorVertical
                {
                    NombreTabla = nombreTabla,
                    DVV = dvvGenerado,
                    FechaGeneracion = DateTime.Now
                };
                BitacoraHelper.RegistrarActividad("Sistema", "Actualización de DVV", DateTime.Now, "Actualización de DVV", "ActualizarVerificadorVertical", "ActualizarVerificadorVertical");
                return _dvVerticalDAL.ActualizarVerificadorVertical(dvvNuevo);
            }
            catch (Exception ex)
            {
                BitacoraHelper.RegistrarError("ActualizarVerificadorVertical", ex, "Actualización de DVV", "Sistema");
                throw new Exception("Error al actualizar el verificador vertical: " + ex.Message, ex);
            }
        }

        /// <summary>
        /// !!Solo usar en caso de estar seguro de querer actualizar el DVH!!
        /// </summary>
        /// <param name="nombreTabla"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        private bool ActualizarVerificadorHorizontal(string nombreTabla)
        {
            try
            {
                BitacoraHelper.RegistrarActividad("Sistema", "Actualización de DVH", DateTime.Now, "Actualización de DVH", "ActualizarVerificadorHorizontal", "ActualizarVerificadorHorizontal");
                return _dvHorizontalDAL.AgregarVerificadorHorizontal(nombreTabla);
            }
            catch (Exception ex)
            {
                BitacoraHelper.RegistrarError("ActualizarVerificadorHorizontal", ex, "Actualización de DVH", "Sistema");
                throw new Exception("Error al actualizar el verificador vertical: " + ex.Message, ex);
            }
        }
    }
}