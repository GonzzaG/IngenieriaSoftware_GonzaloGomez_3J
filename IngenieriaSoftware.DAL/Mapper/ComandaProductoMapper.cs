﻿using IngenieriaSoftware.BEL.Constantes;
using IngenieriaSoftware.BEL.Negocio;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IngenieriaSoftware.DAL.Mapper
{
    public class ComandaProductoMapper
    {
        public List<ComandaProducto> MapearComandaProductoDesdeDataSet(DataSet pDs)
        {
            List<ComandaProducto> comandaProductos = new List<ComandaProducto>();

            foreach (DataRow row in pDs.Tables[0].Rows)
            {
                ComandaProducto comandaProducto = new ComandaProducto();
                comandaProducto.ComandaId = (int)row["comanda_id"];
                comandaProducto.ProductoId = (int)row["producto_id"];
                comandaProducto.EstadoProducto = (EstadoProducto.Estado)(int)row["estado_producto"];
                comandaProducto.Cantidad = (int)row["cantidad"];
                comandaProducto.PrecioUnitario = (int)row["precio_unitario"];

                comandaProductos.Add(comandaProducto);
            }
            return comandaProductos;
        }
    }
}
