using System;
using System.Data.SqlClient;

namespace IngenieriaSoftware.DAL.Auditoria
{
    public class AuditoriaRepository : IAuditoriaRepository
    {
        DAO _dao = new DAO();

        public object GetPorIdYVersion(int id, int version, string nombreTabla)
        {
            try
            {
                var parametros = new[]
                {
                    new SqlParameter("@Id", id),
                    new SqlParameter("@Version", version),
                };

                var ds = _dao.ExecuteStoredProcedure("audit.sp_ObtenerAuditoriaUsuarioPorIdYVersion", parametros);

                return AuditoriaMapperRegistry.GetMapperOrThrow(nombreTabla).ConvertirDesdeRow(ds.Tables[0].Rows[0]);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void RealizarPeticion(string tabla, int idEntidad, int version, int idUsuarioActual, string comentario = null)
        {
            try
            {
                var parametros = new[]
                {
                    new SqlParameter("@Tabla", tabla),
                    new SqlParameter("@IdEntidad", idEntidad),
                    new SqlParameter("@Version", version),
                    new SqlParameter("@SolicitadoPor", idUsuarioActual),
                    new SqlParameter("@Comentario", comentario)
                };

                _dao.ExecuteStoredProcedure("audit.sp_SolicitarRestauracion", parametros);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

    }
}
