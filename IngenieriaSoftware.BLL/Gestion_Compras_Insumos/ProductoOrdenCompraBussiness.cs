using IngenieriaSoftware.DAL.Gestion_Compras_Insumos;
using IngenieriaSoftware.Servicios.DTOs;
using System.Collections.Generic;

namespace IngenieriaSoftware.BLL.Gestion_Compras_Insumos
{
    public class ProductoOrdenCompraBussiness
    {
        public List<ProductoSelectionModel> GetProductosToOrdenCompra()
        {
            return new ProductoOrdenCompraDataAccess().GetProductosToOrdenCompra();
        }

        public ProductoSelectionModel GetProductosToOrdenCompra(int idProducto)
        {
            if(idProducto <= 0)
                return null;

            return new ProductoOrdenCompraDataAccess().GetProductosToOrdenCompra(idProducto);
        }
    }
}
