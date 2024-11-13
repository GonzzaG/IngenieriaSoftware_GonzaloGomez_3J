using IngenieriaSoftware.BEL;
using IngenieriaSoftware.BEL.Negocio;
using IngenieriaSoftware.DAL.Mapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IngenieriaSoftware.DAL.EntityDAL
{
    public class ComandaDAL
    {
        private readonly DAO _dao = new DAO();
        private readonly ComandaProductoMapper _comandaProductoMapper = new ComandaProductoMapper();
        public ComandaDAL() { }

        public int InsertarComanda(int mesaId)
        {
            try
            {
                SqlParameter[] parametros = new SqlParameter[]
                {
                    new SqlParameter("@mesa_id", mesaId),
                    new SqlParameter("@fecha_hora_creacion", DateTime.Now),                
                };

                DataSet mDs = _dao.ExecuteStoredProcedure("sp_InsertarComanda", parametros);
                return Convert.ToInt32(mDs.Tables[0].Rows[0]["comanda_id"]);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<ComandaProducto> ObtenerComandaProductoPorMesaId(int mesaId)
        {
            try
            {
                SqlParameter[] parametros = new SqlParameter[]
                {
                    new SqlParameter("@mesa_id", mesaId),
                };

                DataSet mDs = _dao.ExecuteStoredProcedure("sp_ObtenerComandaProductoPorMesaId", parametros);
                return _comandaProductoMapper.MapearComandaProductoDesdeDataSet(mDs);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
