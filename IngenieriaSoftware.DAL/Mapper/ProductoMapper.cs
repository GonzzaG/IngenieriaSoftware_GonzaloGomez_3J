using IngenieriaSoftware.BEL;
using IngenieriaSoftware.BEL.Constantes;
using IngenieriaSoftware.BEL.Gestion_Compras_Insumos;
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
                producto.Id = (int)row["producto_id"];
                producto.Nombre = row["nombre"].ToString();
                producto.Descripcion = row["descripcion"].ToString();
                producto.Precio = row["precio"] == DBNull.Value ? 0 : (decimal)row["precio"];
                producto.TiempoPreparacion = (int)row["tiempo_preparacion"];
                producto.Disponible = (bool)row["disponible"];
                producto.EsPostre = (bool)row["es_postre"];
                int categoria = row["categoria"] == DBNull.Value ? 0 : (int)row["categoria"];
                producto.Categoria = (TipoProducto.Tipo)categoria;
                producto.Tipo = row["Tipo"].ToString();

                productos.Add(producto);
            }
            return productos;
        }

        public List<Producto> MapearProductosInventarioDesdeDataSet(DataSet pDs)
        {
            List<Producto> productos = new List<Producto>();

            foreach (DataRow row in pDs.Tables[0].Rows)
            {
                Producto producto = new Producto();
                producto.Id = (int)row["producto_id"];
                producto.Nombre = row["nombre"].ToString();
                producto.Descripcion = row["descripcion"].ToString();
                producto.Precio = row["precio"] == DBNull.Value ? 0 : (decimal)row["precio"];
                producto.TiempoPreparacion = (int)row["tiempo_preparacion"];
                producto.Disponible = (bool)row["disponible"];
                producto.Cantidad = row["Cantidad"] == DBNull.Value ? (int?)null : (int)row["Cantidad"];
                producto.EsPostre = (bool)row["es_postre"];
                int categoria = row["categoria"] == DBNull.Value ? 0 : (int)row["categoria"];
                producto.Categoria = (TipoProducto.Tipo)categoria;
                producto.Tipo = row["Tipo"].ToString();

                productos.Add(producto);
            }
            return productos;
        }

        public List<ProductoCategorizacion> MapearProductosCategorizacionDesdeDataSet(DataSet pDs)
        {
            List<ProductoCategorizacion> productos = new List<ProductoCategorizacion>();

            foreach (DataRow row in pDs.Tables[0].Rows)
            {
                ProductoCategorizacion producto = new ProductoCategorizacion();
                producto.IdProducto = (int)row["producto_id"];
                producto.Nombre = row["nombre"].ToString();

                productos.Add(producto);
            }
            return productos;
        }


        public Producto ConvertirDesdeRow(DataRow row)
        {

            Producto producto = new Producto
            {
                Id = (int)row["producto_id"],
                Nombre = row["nombre"].ToString(),
                Descripcion = row["descripcion"].ToString(),
                TiempoPreparacion = row["tiempo_preparacion"] is DBNull ? 0 : (int)row["tiempo_preparacion"],
                Disponible = (bool)row["disponible"],
                EsPostre = row["es_postre"] is DBNull ? false: (bool)row["es_postre"],
                Tipo = row["Tipo"].ToString(),
                Categoria = row["categoria"] is DBNull ? 0 : (TipoProducto.Tipo)(int.Parse(row["categoria"].ToString())),
            };

            return producto;
        }
    }
}