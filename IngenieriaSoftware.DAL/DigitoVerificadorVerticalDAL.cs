using IngenieriaSoftware.BEL;
using IngenieriaSoftware.DAL.Mapper;
using System;
using System.Data;
using System.Data.SqlClient;

namespace IngenieriaSoftware.DAL
{
    public class DigitoVerificadorVerticalDAL
    {
        private readonly DAO _dao = new DAO();

        public string CalcularDVVDeTabla(string nombreTabla)
        {
            try
            {
                SqlParameter[] parametros = new SqlParameter[]
               {
                    new SqlParameter("@nombreTabla", nombreTabla)
               };

                DataSet mDs = _dao.ExecuteStoredProcedure("sp_ObtenerDVHs", parametros);
                return DVMapper.GenerarDVV(mDs);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al actualizar el verificador vertical: " + ex.Message, ex);
            }
        }

        public DigitoVerificadorVertical ObtenerDVV(string nombreTabla)
        {
            try
            {
                SqlParameter[] parametros = new SqlParameter[]
                {
                    new SqlParameter("@nombreTabla", nombreTabla)
                };
                DataSet mDs = _dao.ExecuteStoredProcedure("sp_ObtenerDVV", parametros);
                DigitoVerificadorVertical DVV = DVMapper.MapearDVV(mDs);
                return DVV;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener el verificador vertical: " + ex.Message, ex);
            }
        }

        //Ejecutar SOLO cuando se esta seguro que se quiere INSERTAR un nuevo DVV
        public bool ActualizarVerificadorVertical(DigitoVerificadorVertical dvv)
        {
            try
            {
                SqlParameter[] parametros = new SqlParameter[]
                {
                    new SqlParameter("@nombreTabla", dvv.NombreTabla),
                    new SqlParameter("@dVV", dvv.DVV),
                    new SqlParameter("@fechaGeneracion", dvv.FechaGeneracion),
                };

                _dao.ExecuteNonQuery("sp_InsertarDVV", parametros);

                return true;

            }
            catch (Exception ex)
            {
                throw new Exception("Error al actualizar el verificador vertical: " + ex.Message, ex);
            }
        }

        public void EliminarVerificadorVertical(int id)
        {
            try
            {
                // Lógica para eliminar el verificador vertical de la base de datos
            }
            catch (Exception ex)
            {
                throw new Exception("Error al eliminar el verificador vertical: " + ex.Message, ex);
            }
        }
    }
}