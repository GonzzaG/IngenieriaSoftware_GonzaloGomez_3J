using IngenieriaSoftware.BEL.Gestion_Compras_Insumos;
using System;
using System.Data.SqlClient;

namespace IngenieriaSoftware.DAL.Gestion_Compras_Insumos.UpdateProductoInventario
{
    public class EscasezDataAccess
    {

        public void InsertEscasez(EscasezInsertModel model)
        {
            var parametros = new SqlParameter[]
            {
                new SqlParameter("@IdProducto", model.IdProducto),
                new SqlParameter("@CantidadRecomendada", model.CantidadRecomendada),
                new SqlParameter("@FechaRegistro", model.FechaRegistro),
                new SqlParameter("@RegistradoPor", model.RegistradoPor),
                new SqlParameter("@Observacion", model.Observacion)
            }; 

            new DAO().ExecuteStoredProcedure("sp_InsertarEscasez", parametros);
        }


    }
}
