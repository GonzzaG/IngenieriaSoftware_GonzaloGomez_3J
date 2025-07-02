using IngenieriaSoftware.BEL;
using IngenieriaSoftware.BEL.Constantes;
using System;
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
                producto.Disponible = (bool)row["disponible"];
                producto.EsPostre = (bool)row["es_postre"];
                int categoria = (int)row["categoria"];
                producto.IdCategoria = (TipoProducto.Tipo)categoria;
                producto.Tipo = row["Tipo"].ToString();

                productos.Add(producto);
            }
            return productos;
        }

        public Producto ConvertirDesdeRow(DataRow row)
        {

            Producto producto = new Producto
            {
                ProductoId = (int)row["producto_id"],
                Nombre = row["nombre"].ToString(),
                Descripcion = row["descripcion"].ToString(),
                Precio = (decimal)row["precio"],
                TiempoPreparacion = (int)row["tiempo_preparacion"],
                Disponible = (bool)row["disponible"],
                EsPostre = (bool)row["es_postre"],
                Tipo = row["Tipo"].ToString(),
                IdCategoria = row["categoria"] is DBNull ? 0 : (TipoProducto.Tipo)(int.Parse(row["categoria"].ToString())),
            };

            return producto;
        }
    }
}