using IngenieriaSoftware.BEL.Constantes;
using IngenieriaSoftware.BEL.OrdenDeCompra;
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
                        IdOrdenCompra = Convert.ToInt32(row["IdOrdenCompra"]),
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
    internal static class OrdenCompraGetDetallesMapper
    {
        public static OrdenCompraWithDetalles ConvertirOrdenCompraConDetallesDataSet(this DataSet ds)
        {
            return (from DataRow row in ds.Tables[0].Rows
                    select new OrdenCompraWithDetalles
                    {
                        IdOrdenCompra = Convert.ToInt32(row["IdOrdenCompra"]),
                        NumOrdenCompra = row["NumOrdenDeCompra"].ToString(),
                        RazonSocialProveedor = row["RazonSocial"].ToString(),
                        Fecha = Convert.ToDateTime(row["Fecha"]),
                        FechaEntregaEsperada = row["FechaEntregaEsperada"] == DBNull.Value ? (DateTime?)null : Convert.ToDateTime(row["FechaEntregaEsperada"]),
                        CondicionesPago = row["CondicionesPago"].ToString(),
                        TipoCambio = row["TipoCambio"] == DBNull.Value ? (decimal?)null : Convert.ToDecimal(row["TipoCambio"]),
                        Moneda = row["Moneda"].ToString(),
                        Estado = (OrdenCompraEstadoEnum)Convert.ToInt32(row["IdEstado"]),
                        TotalEsperado = Convert.ToDecimal(row["TotalEsperado"]),
                        IdProveedor = Convert.ToInt32(row["IdProveedor"]),
                        Observaciones = row["Observaciones"].ToString(),
                        FechaCreacion = Convert.ToDateTime(row["FechaCreacion"]),
                        UsuarioCreacion = row["UsuarioCreacion"].ToString()
                    }).FirstOrDefault();
        }

        public static OrdenCompraWithDetalles ConvertirOrdenCompraDetalleDataSet(this DataSet ds)
        {
            return (from DataRow row in ds.Tables[0].Rows
                    select new OrdenCompraWithDetalles
                    {
                        IdOrdenCompra = Convert.ToInt32(row["IdOrdenCompra"]),
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
                    }).FirstOrDefault();
        }

        public static List<ConvertirDetallesAprobacionDataSet> ConvertirDetallesDataSet(this DataSet ds)
        {
            return (from DataRow row in ds.Tables[0].Rows
                    select new ConvertirDetallesAprobacionDataSet
                    {
                        IdDetalle = Convert.ToInt32(row["IdDetalle"]),
                        IdProducto = Convert.ToInt32(row["IdProducto"]),
                        Cantidad = Convert.ToInt32(row["Cantidad"]),
                        PrecioUnitarioEsperado = row["PrecioUnitarioEsperado"] == DBNull.Value
                                    ? (decimal?)null
                                    : Convert.ToDecimal(row["PrecioUnitarioEsperado"]),
                        DescuentoLinea = row["DescuentoLinea"] == DBNull.Value
                                    ? (decimal?)null 
                                    : Convert.ToDecimal(row["DescuentoLinea"]),
                        NotasLinea = row["NotasLinea"].ToString(),
                    }).ToList();
        }

        public static List<OrdenDeCompraDetalleAprobacionModel> ConvertirDetallesAprobacionDataSet(this DataSet ds)
        {
            return (from DataRow row in ds.Tables[0].Rows
                    select new OrdenDeCompraDetalleAprobacionModel
                    {
                        IdDetalle = Convert.ToInt32(row["IdDetalle"]),
                        IdProducto = Convert.ToInt32(row["IdProducto"]),
                        NombreProducto = row["NombreProducto"].ToString(),
                        Cantidad = Convert.ToInt32(row["Cantidad"]),
                        PrecioUnitarioEsperado = row["PrecioUnitarioEsperado"] == DBNull.Value
                                    ? (decimal?)null
                                    : Convert.ToDecimal(row["PrecioUnitarioEsperado"]),
                        DescuentoLinea = row["DescuentoLinea"] == DBNull.Value
                                    ? (decimal?)null
                                    : Convert.ToDecimal(row["DescuentoLinea"]),
                        NotasLinea = row["NotasLinea"].ToString(),
                    }).ToList();
        }
    }

    internal static class OrdenCompraWithDetallesMapper
    {
        public static OrdenCompraWithDetalles ConvertirOrdenCompraWithDetallesDataSet(this DataSet ds)
        {
            if (ds == null || ds.Tables.Count == 0 || ds.Tables[0].Rows.Count == 0)
                return null;

            return (from DataRow row in ds.Tables[0].Rows
                    select new OrdenCompraWithDetalles
                    {
                        IdOrdenCompra = Convert.ToInt32(row["IdOrdenCompra"]),
                        NumOrdenCompra = row["NumOrdenDeCompra"].ToString(),
                        RazonSocialProveedor = row["RazonSocial"].ToString(),
                        Fecha = Convert.ToDateTime(row["Fecha"]),
                        FechaEntregaEsperada = row["FechaEntregaEsperada"] == DBNull.Value ? (DateTime?)null : Convert.ToDateTime(row["FechaEntregaEsperada"]),
                        CondicionesPago = row["CondicionesPago"].ToString(),
                        TipoCambio = row["TipoCambio"] == DBNull.Value ? (decimal?)null : Convert.ToDecimal(row["TipoCambio"]),
                        Moneda = row["Moneda"].ToString(),
                        Estado = (OrdenCompraEstadoEnum)Convert.ToInt32(row["IdEstado"]),
                        TotalEsperado = Convert.ToDecimal(row["TotalEsperado"]),
                        IdProveedor = Convert.ToInt32(row["IdProveedor"]),
                        Observaciones = row["Observaciones"].ToString(),
                        FechaCreacion = Convert.ToDateTime(row["FechaCreacion"]),
                        UsuarioCreacion = row["UsuarioCreacion"].ToString(),

                    }).FirstOrDefault();
        }

        public static List<OrdenDeCompraDetalleAprobacionModel> ConvertirDetallesOrdenCompra(this DataSet ds)
        {
            var lista = new List<OrdenDeCompraDetalleAprobacionModel>();

            if (ds == null || ds.Tables.Count < 1)
                return lista; // No hay detalles

            var tbl = ds.Tables[0];

            foreach (DataRow row in tbl.Rows)
            {
                var det = new OrdenDeCompraDetalleAprobacionModel
                {
                    IdDetalle = Convert.ToInt32(row["IdDetalle"]),
                    IdOrdenCompra = Convert.ToInt32(row["IdOrdenCompra"]),
                    IdProducto = Convert.ToInt32(row["IdProducto"]),
                    NombreProducto = row["NombreProducto"].ToString(),
                    Cantidad = Convert.ToInt32(row["Cantidad"]),

                    PrecioUnitarioEsperado = row["PrecioUnitarioEsperado"] == DBNull.Value
                        ? (decimal?)null
                        : Convert.ToDecimal(row["PrecioUnitarioEsperado"]),

                    DescuentoLinea = row["DescuentoLinea"] == DBNull.Value
                        ? (decimal?)null
                        : Convert.ToDecimal(row["DescuentoLinea"]),

                    NotasLinea = row["NotasLinea"].ToString()
                };

                lista.Add(det);
            }

            return lista;
        }

    }
}
