using IngenieriaSoftware.Abstracciones;
using IngenieriaSoftware.BEL.Auditoria;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace IngenieriaSoftware.DAL.Auditoria
{
    public class PeticionesRestauracionRepository
    {
        DAO _dao;

        public PeticionesRestauracionRepository()
        {
            _dao = new DAO();
        }

        public PeticionRestauracionModel GetById(int id)
        {
            try
            {
                SqlParameter[] parametros = new SqlParameter[]
                {
                    new SqlParameter("@Id", id)
                };
                DataSet dS = _dao.ExecuteStoredProcedure("audit.sp_ObtenerPeticionDeRestauracionPorId", parametros);

                if (dS.Tables.Count > 0 && dS.Tables[0].Rows.Count > 0)
                {
                    return PeticionRestauracionMapper.MappearDesdeDataSet(dS).FirstOrDefault();
                }
                else
                {
                    throw new Exception("No se encontró la petición de restauración con el ID especificado.");
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener la petición de restauración: " + ex.Message);
            }
        }


        public void CambiarEstadoPeticion(int idPeticion, string estado, int procesadoPor)
        {
            try
            {
                SqlParameter[] parametros = new SqlParameter[]
                {
                    new SqlParameter("@Id", idPeticion),
                     new SqlParameter("@Estado", estado),
                     new SqlParameter("@ProcesadoPor", procesadoPor),
                };

                DataSet dS = _dao.ExecuteStoredProcedure("audit.sp_CambiarEstadoPeticionPorId ", parametros);

                PeticionRestauracionMapper.MappearDesdeDataSet(dS);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener las peticiones pendientes: " + ex.Message);
            }
        }



        public List<PeticionRestauracionModel> ObtenerPeticionesPendientes()
        {
            try
            {
                DataSet dS = _dao.ExecuteStoredProcedure("audit.sp_ObtenerPeticionesDeRestauracionPendientes", null);

                return PeticionRestauracionMapper.MappearDesdeDataSet(dS);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener las peticiones pendientes: " + ex.Message);
            }
        }

        public IAuditableModel ObtenerUltimaVersionDeEntidadAuditable(string nombreTabla, int idEntidad)
        {
            try
            {
                string[] nombreTablaAuditada = AuditoriaTableName.GetAuditoryTableNameOrThrow(nombreTabla);

                SqlParameter[] parametros = new SqlParameter[]
                {
                    new SqlParameter("@Schema", nombreTablaAuditada[0]),
                    new SqlParameter("@NombreTabla", nombreTablaAuditada[1]),
                    new SqlParameter("@Id_entidad", idEntidad),
                };

                var mapper = AuditoriaMapperRegistry.GetMapperOrThrow(nombreTabla);

                DataSet dS = _dao.ExecuteStoredProcedure("audit.sp_ObtenerHistorialActual", parametros);

                if (dS.Tables.Count > 0 && dS.Tables[0].Rows.Count > 0)
                {
                    DataRow row = dS.Tables[0].Rows[0];
                    return mapper.ConvertirDesdeRow(row);
                }
                else
                {
                    throw new Exception("No se encontraron datos en el historial actual.");
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener las peticiones pendientes: " + ex.Message);
            }
        }

    }
}
