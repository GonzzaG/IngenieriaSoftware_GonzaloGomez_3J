using IngenieriaSoftware.BEL.Constantes;
using IngenieriaSoftware.BEL.OrdenDeCompra.ViewModels;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace IngenieriaSoftware.DAL.Mapper
{
    internal static class OrdenCompraMapper
    {
        public static List<OrdenCompraGetListaModel> ConvertirDataSet(this DataSet ds)
        {
           return (from DataRow row in ds.Tables[0].Rows
                   select new OrdenCompraGetListaModel
                    {
                        NumOrdenCompra = row["NumOrdenDeCompra"].ToString(),
                        RazonSocialProveedor = row["RazonSocial"].ToString(),
                        Fecha = Convert.ToDateTime(row["Fecha"]),
                        FechaEntregaEsperada = row["FechaEntregaEsperada"] == DBNull.Value ? (DateTime?)null : Convert.ToDateTime(row["FechaEntregaEsperada"]),
                        CondicionesPago = row["CondicionesPago"].ToString(),
                        TipoCambio = row["TipoCambio"] == DBNull.Value ? (decimal?)null : Convert.ToDecimal(row["TipoCambio"]),
                        Moneda = row["Moneda"].ToString(),
                        Estado = (OrdenCompraEstadoEnum)Convert.ToInt32(row["IdEstado"]),
                        TotalEsperado = Convert.ToDecimal(row["TotalEsperado"]),
                        Observaciones = row["Observaciones"].ToString(),
                        FechaCreacion = Convert.ToDateTime(row["FechaCreacion"]),
                        UsuarioCreacion = row["UsuarioCreacion"].ToString()
                    }).ToList();    
        }
    }
}
