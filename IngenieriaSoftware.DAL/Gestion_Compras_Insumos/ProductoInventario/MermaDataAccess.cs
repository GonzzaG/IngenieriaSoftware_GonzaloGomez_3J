using IngenieriaSoftware.BEL.Gestion_Compras_Insumos;
using System;
using System.Data.SqlClient;

namespace IngenieriaSoftware.DAL.Gestion_Compras_Insumos.UpdateProductoInventario
{
    public class MermaDataAccess
    {

        public void InsertMerma(MermaInsertModel model)
        {
            var parametros = new SqlParameter[]
            {
                new SqlParameter("@IdProducto", model.IdProducto),
                new SqlParameter("@CantidadMerma", model.CantidadMerma),
                new SqlParameter("@FechaMerma", DateTime.Now),
                new SqlParameter("@Descripcion", model.Descripcion),
                new SqlParameter("@RegistradoPor", model.RegistradoPor)
            };

            new DAO().ExecuteStoredProcedure("sp_InsertarMerma", parametros);
        }

    }
}
