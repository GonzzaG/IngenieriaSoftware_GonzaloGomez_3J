using IngenieriaSoftware.BEL.Gestion_Compras_Insumos;
using System;
using System.Collections.Generic;
using System.Data;

namespace IngenieriaSoftware.DAL.Mapper
{
    internal class ProductoVentaInventarioMapper
    {

        public List<ProductoVentaInventarioModel> MapearProductosVentaInventarioDesdeDataSet(DataSet pDs)
        {
            List<ProductoVentaInventarioModel> productos = new List<ProductoVentaInventarioModel>();

            foreach (DataRow row in pDs.Tables[0].Rows)
            {
                ProductoVentaInventarioModel producto = new ProductoVentaInventarioModel();
                producto.IdRelacion = (int)row["IdRelacion"];
                producto.IdProductoVenta = (int)row["IdProductoVenta"];
                producto.IdProductoInventario = (int)row["IdProductoInventario"];
                producto.CantidadUsada = (int)row["CantidadUsada"];
                producto.NombreProductoInventario = row["NombreProductoInventario"] != DBNull.Value ? row["NombreProductoInventario"].ToString() : string.Empty;
                productos.Add(producto);
            }
            return productos;
        }

    }
}
