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
    public class MedioDePagoDAL
    {
        private readonly DAO _dao = new DAO();
        private readonly MedioDePagoMapper _medioDePagoMapper = new MedioDePagoMapper();        

        public MedioDePago ObtenerMedioDePagoPorId(int medioDePagoId)
        {
            try
            {
                SqlParameter[] parametros = new SqlParameter[]
                {
                    new SqlParameter("@MedioDePagoId", medioDePagoId),
                };
                DataSet mDs = _dao.ExecuteStoredProcedure("sp_ObtenerMedioDePagoPorId", null);
                return _medioDePagoMapper.MapearMedioDePagoDesdeDataSet(mDs)[0];
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<MedioDePago> ObtenerMediosDePago()
        {
            try
            {
                DataSet mDs = _dao.ExecuteStoredProcedure("sp_ObtenerMediosDePago", null);
                return _medioDePagoMapper.MapearMedioDePagoDesdeDataSet(mDs);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
