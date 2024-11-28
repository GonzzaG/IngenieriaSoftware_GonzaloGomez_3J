using IngenieriaSoftware.BEL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IngenieriaSoftware.DAL.Mapper
{
    public class ProductoFacturaMapper
    {
        public List<ProductoFactura> MapearProductosFacturaDesdeDataSet(DataSet ds)
        {
            List<ProductoFactura> productosFactura = new List<ProductoFactura>();

            if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    ProductoFactura productoFactura = new ProductoFactura
                    {
                        ProductoId = Convert.ToInt32(row["ProductoId"]),
                        NombreProducto = row["NombreProducto"].ToString(),
                        Cantidad = Convert.ToInt32(row["Cantidad"]),
                        PrecioUnitario = Convert.ToDecimal(row["PrecioUnitario"]),
                        
                        //implementar descuento
                        //Descuento = row["Descuento"] != DBNull.Value ? Convert.ToDecimal(row["Descuento"]) : 0
                    };

                    productosFactura.Add(productoFactura);
                }
            }

            return productosFactura;
        }

    }
}
