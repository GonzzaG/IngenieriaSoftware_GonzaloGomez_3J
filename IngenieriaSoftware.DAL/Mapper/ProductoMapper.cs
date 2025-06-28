using IngenieriaSoftware.BEL;
using IngenieriaSoftware.BEL.Constantes;
using System.Collections.Generic;
using System.Data;

namespace IngenieriaSoftware.DAL.Mapper
{
    public class ProductoMapper
    {
        public List<Producto> MapearProductosDesdeDataSet(DataSet pDs)
        {
            List<Producto> productos = new List<Producto>();

            foreach (DataRow row in pDs.Tables[0].Rows)
            {
                Producto producto = new Producto();
                producto.ProductoId = (int)row["producto_id"];
                producto.Nombre = row["nombre"].ToString();
                producto.Descripcion = row["descripcion"].ToString();
                producto.Precio = (decimal)row["precio"];
                producto.TiempoPreparacion = (int)row["tiempo_preparacion"];
                producto.Diponible = (bool)row["disponible"];
                producto.EsPostre = (bool)row["es_postre"];
                int categoria = (int)row["categoria"];
                producto.IdCategoria = (TipoProducto.Tipo)categoria;

                productos.Add(producto);
            }
            return productos;
        }
    }
}