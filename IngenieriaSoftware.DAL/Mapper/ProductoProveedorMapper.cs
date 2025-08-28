using IngenieriaSoftware.BEL;
using IngenieriaSoftware.DAL.Auditoria.Interfaces;
using IngenieriaSoftware.Servicios.Tools;
using System;
using System.Data;

namespace IngenieriaSoftware.DAL.Mapper
{
    internal class ProductoProveedorMapper : IMapper<Producto>
    {
        public Producto ConvertirDesdeRow(DataRow row)
        {
            return new Producto
            {
                ProductoId = !(row["producto_id"] is DBNull) ? Convert.ToInt32(row["producto_id"]) : throw new Exception("El id no puede ser nulo"),
                Nombre = !(row["nombre"] is DBNull) ? row["nombre"].ToString() : string.Empty,
                Precio = !(row["precio_actual"] is DBNull) ? decimal.Parse(row["precio_actual"].ToString()) : 0,
                Descripcion = !(row["descripcion"] is DBNull) ? row["descripcion"].ToString() : string.Empty,
                Tipo = !(row["Tipo"] is DBNull) ? row["Tipo"].ToString() : string.Empty,
                Cantidad = !(row["cantidad"] is DBNull) ? Convert.ToInt32(row["cantidad"]) : 0,
            };
        }
    }
}
