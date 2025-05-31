using IngenieriaSoftware.DAL.Mapper;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IngenieriaSoftware.DAL
{
    public class ObjetoDAL
    {
        private readonly DAO _dao = new DAO();

        /// <summary>
        /// Metodo que obtiene los datos de una tabla, dado el nombre de la tabla.
        /// </summary>
        /// <param name="nombreTabla"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public DataSet ObtenerDatosDeTabla(string nombreTabla)
        {
            try
            {
                SqlParameter[] parametros = new SqlParameter[]
                {
                     new SqlParameter("@NombreTabla", nombreTabla)
                };

                DataSet mDs = _dao.ExecuteStoredProcedure("sp_ObtenerDatosDeTabla", parametros);
                return mDs;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al agregar el verificador horizontal: " + ex.Message, ex);
            }
        }

        /// <summary>
        /// Metodo que obtiene un registro de una tabla, dado el nombre de la tabla, el campo id y el valor del id.
        /// </summary>
        /// <param name="nombreTabla"></param>
        /// <param name="campoId"></param>
        /// <param name="valorId"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public DataRow ObtenerRegistroDeTabla(string nombreTabla, string campoId, object valorId)
        {
            try
            {
                SqlParameter[] parametros = new SqlParameter[]
                {
                    new SqlParameter("@NombreTabla", nombreTabla),
                    new SqlParameter("@CampoId", campoId),
                    new SqlParameter("@ValorId", valorId.ToString())
                };

                DataSet mDs = _dao.ExecuteStoredProcedure("sp_ObtenerRegistroDeTabla", parametros);

                if (mDs.Tables.Count == 0 || mDs.Tables[0].Rows.Count == 0)
                    return null;

                return mDs.Tables[0].Rows[0];
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al obtener el registro de la tabla {nombreTabla}: {ex.Message}", ex);
            }
        }

    }
}
