using IngenieriaSoftware.BEL;
using IngenieriaSoftware.DAL.Mapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IngenieriaSoftware.DAL.EntityDAL
{
    public class ProductoDAL
    {
        private readonly DAO _dao = new DAO();
        private readonly ProductoMapper _productoMapper = new ProductoMapper();

        public List<Producto> ObtenerTodasLasMesas()
        {
            try
            {
                DataSet mDs = _dao.ExecuteStoredProcedure("sp_ObtenerTodosLosProductos", null);
                return _productoMapper.MapearProductosDesdeDataSet(mDs);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}
