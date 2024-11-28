using IngenieriaSoftware.BEL;
using IngenieriaSoftware.BEL.Constantes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IngenieriaSoftware.DAL.Mapper
{
    public class FacturaMapper
    {

        public List<Factura> MapearFacturasDesdeDataSet(DataSet ds)
        {
            List<Factura> facturas = new List<Factura>();

            if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    Factura factura = new Factura
                    {
                        FacturaId = (int)row["FacturaId"],
                        NumeroFactura = row["NumeroFactura"].ToString(),
                        FechaEmision = Convert.ToDateTime(row["FechaEmision"]),
                        MesaId = Convert.ToInt32(row["MesaId"]),
                        ComandaId = Convert.ToInt32(row["ComandaId"]),
                        ClienteId = Convert.ToInt32(row["ClienteId"]),
                        SubtotalGeneral = Convert.ToDecimal(row["SubtotalGeneral"]),
                        DescuentoTotal = Convert.ToDecimal(row["DescuentoTotal"]),
                        ImpuestoTotal = Convert.ToDecimal(row["ImpuestoTotal"]),
                        Propina = Convert.ToDecimal(row["Propina"]),
                        TotalFinal = Convert.ToDecimal(row["TotalFinal"]),
                        EstadoPago = (EstadoFactura.Estado)Convert.ToInt32(row["EstadoPago"]),
                        MontoPagado = Convert.ToDecimal(row["MontoPagado"]),
                        Cambio = Convert.ToDecimal(row["Cambio"]),
                        Notas = row["Notas"].ToString(),
                        FechaCierre = (DateTime)(row["FechaCierre"] == DBNull.Value ? (DateTime?)null : Convert.ToDateTime(row["FechaCierre"])),
                        DivisionPago = Convert.ToBoolean(row["DivisionPago"]),
                        MetodoPagoId = Convert.ToInt32(row["MetodoPagoId"])
                    };

                    facturas.Add(factura);
                }
            }

            return facturas;
        }
    }
}
