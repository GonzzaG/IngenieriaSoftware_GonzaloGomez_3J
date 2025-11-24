using IngenieriaSoftware.BEL.Gestion_Compras_Insumos;
using IngenieriaSoftware.DAL.Gestion_Compras_Insumos.UpdateProductoInventario;
using System.Collections.Generic;

namespace IngenieriaSoftware.BLL.Gestion_Compras_Insumos.Inventario
{
    public class ProductoInventarioBusiness
    {
        public void UpdateCantidadInventario(List<ProductoInventario> productosModificados)
        {
           new ProductoInventarioDataAccess().UpdateCantidadInventario(productosModificados);
        }
    }
}
