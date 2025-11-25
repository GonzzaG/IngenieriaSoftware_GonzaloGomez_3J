using IngenieriaSoftware.BEL.Gestion_Compras_Insumos;
using IngenieriaSoftware.DAL.Gestion_Compras_Insumos.ProductoCategorizacion;
using System;
using System.Collections.Generic;

namespace IngenieriaSoftware.BLL.Gestion_Compras_Insumos.Inventario
{
    public class ProductoVentaInventarioBusiness
    {
        public List<ProductoVentaInventarioModel> GetProductoVentaInventario(int idProductoInventario)
        {
            return new ProductoVentaInventarioDataAccess().GetProductoVentaInventarioByIdProductoInventario(idProductoInventario);
        }
        public void SetProductoVentaInventarioRelacion(ProductoVentaInventarioModel model)
        {
            if (model.CantidadUsada <= 0)
                throw new Exception("La cantidad debe ser mayor o igual a 0");
            if(model.IdProductoInventario <= 0 || model.IdProductoVenta <= 0)
                throw new Exception("El id del producto inventario y venta deben ser mayores a 0");


             new ProductoVentaInventarioDataAccess().SetProductoVentaInventarioRelacion(model);
        }

        public void DeleteRelacionProductoVentaInventario(int idRelacion)
        {
            if (idRelacion <= 0)
                throw new Exception("El id no puede ser 0");

            new ProductoVentaInventarioDataAccess().DeleteRelacionProductoVentaInventario(idRelacion);
        }


    }


}
