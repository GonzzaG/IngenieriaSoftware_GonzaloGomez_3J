using IngenieriaSoftware.DAL.Gestion_Compras_Insumos;
using IngenieriaSoftware.Servicios.DTOs;
using System.Collections.Generic;

namespace IngenieriaSoftware.BLL.Gestion_Compras_Insumos
{
    public class ProductoOrdenCompraBussiness
    {
        /// <summary>
        /// Obtiene productos los cuales NO pertenecen a la venta al publico
        /// </summary>
        /// <returns></returns>
        public List<ProductoSelectionModel> GetProductosToOrdenCompra()
        {
            return new ProductoOrdenCompraDataAccess().GetProductosToOrdenCompra();
        }

        /// <summary>
        /// Obtiene productos por nombre los cuales NO pertenecen a la venta al publico
        /// </summary>
        /// <param name="nombre"></param>
        /// <returns></returns>
        public List<ProductoSelectionModel> GetProductosToOrdenCompraByNombre(string nombre)
        {
            return new ProductoOrdenCompraDataAccess().GetProductosToOrdenCompraByNombre(nombre);
        }

        public ProductoSelectionModel GetProductosToOrdenCompra(int idProducto)
        {
            if(idProducto <= 0)
                return null;

            return new ProductoOrdenCompraDataAccess().GetProductosToOrdenCompra(idProducto);
        }
    }
}
