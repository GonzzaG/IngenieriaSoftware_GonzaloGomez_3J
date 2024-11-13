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
    public class NotificacionDAL
    {
        private readonly DAO _dao = new DAO();
        private readonly NotificacionMapper _notificacionMapper = new NotificacionMapper();
        public NotificacionDAL() { }
        public void InsertarNotificacion(int mesaId, int comandaId)
        {
            try
            {
                SqlParameter[] parametros = new SqlParameter[]
                {
                    new SqlParameter("@mesa_id", mesaId),
                    new SqlParameter("@comanda_id", comandaId),
                };

                _dao.ExecuteNonQuery("sp_InsertarNotificacion", parametros);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<Notificacion> ObtenerNotificacionesNoVistas(int mesaId, int comandaId)
        {
            try
            {
                SqlParameter[] parametros = new SqlParameter[]
                {
                    new SqlParameter("@mesa_id", mesaId),
                    new SqlParameter("@comanda_id", comandaId),
                };
                    
                DataSet mDs = _dao.ExecuteStoredProcedure("sp_ObtenerNotificacionesNoVistas", parametros);
                return _notificacionMapper.MapearComandasDesdeDataSet(mDs);

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}
