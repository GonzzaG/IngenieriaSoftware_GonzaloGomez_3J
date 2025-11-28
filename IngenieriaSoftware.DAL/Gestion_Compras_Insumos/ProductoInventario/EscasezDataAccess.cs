using IngenieriaSoftware.BEL.Gestion_Compras_Insumos;
using IngenieriaSoftware.DAL.Gestion_Compras_Insumos.ProductoInventario.Mapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace IngenieriaSoftware.DAL.Gestion_Compras_Insumos.UpdateProductoInventario
{
    public class EscasezDataAccess
    {

        public void InsertEscasez(EscasezModel model)
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


        public List<EscasezModel> GetProductosEscasez()
        {
            return new DAO().ExecuteStoredProcedure("sp_GetProductosEscasez", null)
                .MapearEscasezDesdeDataSet();
        }

       
    }
}
