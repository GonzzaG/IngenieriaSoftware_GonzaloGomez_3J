using IngenieriaSoftware.BEL.Gestion_Compras_Insumos;
using IngenieriaSoftware.DAL.Mapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace IngenieriaSoftware.DAL.Gestion_Compras_Insumos.ProductoCategorizacion
{
    public class ProductoVentaInventarioDataAccess
    {
        private DAO _dao = new DAO();
        public void SetProductoVentaInventarioRelacion(ProductoVentaInventarioModel model)
        {
            try
            {
                var parametros = new SqlParameter[]
                {
                    new SqlParameter("@IdProductoVenta", model.IdProductoVenta),
                    new SqlParameter("@IdProductoInventario", model.IdProductoInventario),
                    new SqlParameter("@Cantidad", model.CantidadUsada)
                };

                DataSet mDs = _dao.ExecuteStoredProcedure("sp_SetRelacionProductoVentaInventario", parametros);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public List<ProductoVentaInventarioModel> GetProductoVentaInventarioByIdProductoInventario(int idProductoInventario)
        {
            try
            {
                var parametros = new SqlParameter[]
                {
                    new SqlParameter("@IdProductoVenta", idProductoInventario)
                };

                DataSet mDs = _dao.ExecuteStoredProcedure("sp_GetProductosVentaInventarioPorId", parametros);
                return new ProductoVentaInventarioMapper().MapearProductosVentaInventarioDesdeDataSet(mDs);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public void DeleteRelacionProductoVentaInventario(int idRelacion)
        {
            try
            {
                var parametros = new SqlParameter[]
                {
                    new SqlParameter("@IdRelacion", idRelacion)
                };

                DataSet mDs = _dao.ExecuteStoredProcedure("sp_DeleteRelacionProductoVentaInventario", parametros);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
