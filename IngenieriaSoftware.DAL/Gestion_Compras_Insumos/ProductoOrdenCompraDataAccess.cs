using IngenieriaSoftware.Servicios.DTOs;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace IngenieriaSoftware.DAL.Gestion_Compras_Insumos
{
    public class ProductoOrdenCompraDataAccess
    {
        /// <summary>
        /// Trae una lista de productos para la orden de compra
        /// </summary>
        /// <returns></returns>
        public List<ProductoOrdenCompraViewModel> GetProductosToOrdenCompra()
        {
            var result = new DAO().ExecuteStoredProcedure("Producto.sp_ProductoRestaurante_OrdenCompra_GetAll", null);
            
            return (from DataRow row in result.Tables[0].Rows
                    select new ProductoOrdenCompraViewModel()
                    {
                        Nombre = row["nombre"].ToString(),
                        Descripcion = row["descripcion"].ToString(),
                        Categoria = row["categoria"].ToString(),
                        Tipo = row["Tipo"].ToString()
                    }).ToList();
        }

        /// <summary>
        /// Trae los productos para la orden de compra
        /// </summary>
        /// <returns></returns>
        public ProductoOrdenCompraViewModel GetProductosToOrdenCompra(int idProducto)
        {
            var parametro = new SqlParameter[]
            {
                new SqlParameter("@IdProducto", idProducto)
            };

            var result = new DAO().ExecuteStoredProcedure("Producto.sp_ProductoRestaurante_OrdenCompra_GetById", parametro);

            return (from DataRow row in result.Tables[0].Rows
                    select new ProductoOrdenCompraViewModel()
                    {
                        Nombre = row["nombre"].ToString(),
                        Descripcion = row["descripcion"].ToString(),
                        Categoria = row["categoria"].ToString(),
                        Tipo = row["Tipo"].ToString()
                    }).FirstOrDefault();
        }
    }
}
