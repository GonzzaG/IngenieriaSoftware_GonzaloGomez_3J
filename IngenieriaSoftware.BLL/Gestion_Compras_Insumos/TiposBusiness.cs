using IngenieriaSoftware.DAL.EntityDAL.ProductoTipo;
using System.Collections.Generic;

namespace IngenieriaSoftware.BLL.Gestion_Compras_Insumos
{
    public class TiposBusiness
    {

        public List<string> GetProductosTipo()
        {
            return new ProductoTipoDataAccess().GetProductosTipo(); 
        }
    }
}
