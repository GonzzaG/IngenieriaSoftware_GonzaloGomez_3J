using System.Collections.Generic;
using System.Data.SqlClient;

namespace IngenieriaSoftware.DAL.Gestion_Compras_Insumos.UpdateProductoInventario
{
    public class ProductoInventarioDataAccess
    {
        public void UpdateCantidadInventario(List<BEL.Gestion_Compras_Insumos.ProductoInventario> productosModificados)
        {
            for(int i = 0; i < productosModificados.Count; i++)
            {
                if (productosModificados[i].Modificado)
                {
                    var parametros = new SqlParameter[]
                    {
                        new SqlParameter("@Id", productosModificados[i].Id),
                        new SqlParameter("@Cantidad", productosModificados[i].Cantidad)
                    };
                    new DAO().ExecuteStoredProcedure("sp_ActualizarCantidadProductoInventario", parametros);
                }
            }
        }

    }
}

