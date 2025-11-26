using IngenieriaSoftware.BEL.FacturaProveedor;
using IngenieriaSoftware.BEL.OrdenDeCompra.Models;
using IngenieriaSoftware.DAL.Tools;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace IngenieriaSoftware.DAL.FacturaProveedores.DataAccess
{
    public static class FacturaProveedorDataAccess
    {



        /// <summary>
        /// Inserta una nueva factura de proveedor en la base de datos.
        /// </summary>
        /// <param name="facturaProveedor"></param>
        /// <returns></returns>
        public static int InsertFacturaProveedor(this FacturaProveedor facturaProveedor)
        {
            var parametros = new SqlParameter[]
            {
                new SqlParameter("@NumeroFactura",facturaProveedor.NumeroFactura),
                new SqlParameter("@FechaEmision",facturaProveedor.FechaEmision),
                new SqlParameter("@IdOrdenCompra",facturaProveedor.IdOrdenCompra.ToDbValue()),
                new SqlParameter("@IdProveedor",facturaProveedor.IdProveedor),
                new SqlParameter("@IdUsuarioCreador",facturaProveedor.IdUsuarioCreador),
                new SqlParameter("@Subtotal",facturaProveedor.Subtotal),
                new SqlParameter("@Impuestos",facturaProveedor.Impuestos),
                new SqlParameter("@Descuento",facturaProveedor.Descuento),
                new SqlParameter("@Total",facturaProveedor.Total),
                new SqlParameter("@MetodoPago",facturaProveedor.MetodoPago),
                new SqlParameter("@IdFacturaProveedorEstado",facturaProveedor.IdFacturaProveedorEstado),
                new SqlParameter("@Observaciones",facturaProveedor.Observaciones),
                new SqlParameter("@FechaPago",facturaProveedor.FechaPago.ToDbValue()),
                new SqlParameter("@NewIdFacturaProveedor", SqlDbType.Int) { Direction = ParameterDirection.Output }
            };

            new DAO().ExecuteStoredProcedure("Fact.sp_InsertFacturaProveedor", parametros);

            return (int)parametros.Last().Value;
        }


        /// <summary>
        /// Inserta los detalles de una factura de proveedor en la base de datos.
        /// </summary>
        /// <param name="facturaProveedor"></param>
        /// <returns></returns>
        public static int[] InsertFacturaProveedorDetalles(this FacturaProveedor facturaProveedor)
        {
            var newIds = new List<int>();
            foreach (var detalle in facturaProveedor.Detalles)
            {
                var parametros = new SqlParameter[]
                {
                    new SqlParameter("@IdFacturaProveedor",facturaProveedor.IdFacturaProveedor),
                    new SqlParameter("@IdProducto",detalle.IdProducto),
                    new SqlParameter("@Descripcion",detalle.Descripcion),
                    new SqlParameter("@Cantidad",detalle.Cantidad),
                    new SqlParameter("@PrecioUnitario",detalle.PrecioUnitario),
                    new SqlParameter("@Descuento",detalle.Descuento),
                    new SqlParameter("@Impuesto",detalle.Impuesto),
                    new SqlParameter("@IdOrdenCompraDetalle", detalle.IdOrdenCompraDetalle <= 0 ? null : detalle.IdOrdenCompraDetalle),

                    new SqlParameter("@NewIdDetalleFacturaProveedor", SqlDbType.Int) { Direction = ParameterDirection.Output }
                };
                new DAO().ExecuteStoredProcedure("Fact.sp_InsertFacturaProveedorDetalle", parametros);
                newIds.Add((int)parametros.Last().Value);
            }
            return newIds.ToArray();
        }


        public static void CambiarEstadoFacturaProveedorTo(this int idFacturaProveedor, int idFacturaProveedorEstado)
        {
            var parametros = new SqlParameter[]
            {
                new SqlParameter("@IdFacturaProveedor",idFacturaProveedor),
                new SqlParameter("@IdFacturaProveedorEstado",idFacturaProveedorEstado)
            };

            new DAO().ExecuteStoredProcedure("Fact.sp_CambiarEstadoFactura", parametros);
        }

        /// <summary>
        /// Obtiene los detalles de una factura de proveedor por su Id.
        /// </summary>
        /// <param name="idFacturaProveedor"></param>
        /// <returns></returns>
        public static List<FacturaProveedorDetalle> GetListDetallesByIdFacturaProveedor(this int idFacturaProveedor)
        {
            var parametros = new SqlParameter[]
            {
                new SqlParameter("@IdFacturaProveedor", idFacturaProveedor)
            };

            return new DAO()
                .ExecuteStoredProcedure("Fact.sp_GetDetalleFactura", parametros)
                .MapFacturaProveedorDetallesGetList();
        }


        /// <summary>
        /// Obtiene una Factura de Proveedor por su Id.
        /// </summary>
        /// <param name="idFacturaProveedor"></param>
        /// <returns></returns>
        public static FacturaProveedor GetFacturaProveedorById(this int idFacturaProveedor)
        {
            var parametros = new SqlParameter[]
            {
                new SqlParameter("@IdFacturaProveedor",idFacturaProveedor)
            };

            return new DAO()
                .ExecuteStoredProcedure("Fact.sp_GetFacturaPorId", parametros)
                .MapFacturaProveedoresGetById();
        }

        /// <summary>
        /// Obtiene una Factura de Proveedor por su Id de Orden de Compra.
        /// </summary>
        /// <param name="idOrdenCompra"></param>
        /// <returns></returns>
        public static FacturaProveedor GetFacturaProveedorByIdOrdenCompra(this int idOrdenCompra)
        {
            var parametros = new SqlParameter[]
            {
                new SqlParameter("@IdOrdenCompra", idOrdenCompra)
            };

            return new DAO()
                .ExecuteStoredProcedure("Fact.sp_GetFacturaPorIdOrdenCompra", parametros)
                .MapFacturaProveedoresGetById();
        }


        #region Obtener Facturas por Estado
        /// <summary>
        /// Obtiene las Facturas que se encuentran en estado pendiente de pago.
        /// </summary>
        public static List<FacturaProveedorGetListModel> GetListFacturasPendientes(this string estadoFactura)
        {
            var parametros = new SqlParameter[]
            {
                new SqlParameter("@IdFacturaProveedorEstado",1)
            };

            return new DAO()
                .ExecuteStoredProcedure("Fact.sp_GetFacturasPorEstado", parametros)
                .MapFacturaProveedoresGetListPendiente(estadoFactura);
        }

        /// <summary>
        /// Obtiene las Facturas que se encuentran en estado pendiente de pago.
        /// </summary>
        public static List<FacturaProveedorGetListModel> GetListFacturasPagadas(this string estadoFactura)
        {
            var parametros = new SqlParameter[]
            {
                new SqlParameter("@IdFacturaProveedorEstado",2)
            };

            return new DAO()
                .ExecuteStoredProcedure("Fact.sp_GetFacturasPorEstado", parametros)
                .MapFacturaProveedoresGetListPendiente(estadoFactura);
        }

        /// <summary>
        /// Obtiene las Facturas que se encuentran en estado canceladas.
        /// </summary>
        /// <returns></returns>
        public static List<FacturaProveedorGetListModel> GetListFacturasCanceladas(this string estadoFactura)
        {
            var parametros = new SqlParameter[]
            {
                new SqlParameter("@IdFacturaProveedorEstado",3)
            };

            return new DAO()
                .ExecuteStoredProcedure("Fact.sp_GetFacturasPorEstado", parametros)
                .MapFacturaProveedoresGetListPendiente(estadoFactura);
        }

        /// <summary>
        /// Obtiene las Facturas que se encuentran en estado anuladas.
        /// </summary>
        /// <returns></returns>
        public static List<FacturaProveedorGetListModel> GetListFacturasAnuladas(this string estadoFactura)
        {
            var parametros = new SqlParameter[]
            {
                new SqlParameter("@IdFacturaProveedorEstado",4)
            };

            return new DAO()
                .ExecuteStoredProcedure("Fact.sp_GetFacturasPorEstado", parametros)
                .MapFacturaProveedoresGetListPendiente(estadoFactura);
        }

        public static List<FacturaProveedorGetListFilterModel> GetListFacturas(this ObjectQuery query)
        {
            var parametros = new SqlParameter[]
            {
                new SqlParameter("@NumFactura",query.Numero.ToDbValue()),
                new SqlParameter("@FechaDesde", query.FechaDesde.ToDbValue()),
                new SqlParameter("@IdEstado", query.IdEstado.ToDbValue())
            };

            return new DAO()
                .ExecuteStoredProcedure("Fact.sp_GetFacturasProveedor", null)
                .MapFacturaProveedoresGetList();
        }
        #endregion

        #region Metodos Privados

        #region Mapeadores
        private static FacturaProveedor MapFacturaProveedoresGetById(this DataSet mDs)
        {
            if (mDs == null || mDs.Tables.Count == 0 || mDs.Tables[0].Rows.Count == 0)
                return new FacturaProveedor();

            var row = mDs.Tables[0].Rows[0];

            return new FacturaProveedor()
            {
                IdFacturaProveedor = Convert.ToInt32(((DataRow)row)["IdFacturaProveedor"]),
                IdFacturaProveedorEstado = Convert.ToInt32(((DataRow)row)["IdFacturaProveedorEstado"]),
                IdOrdenCompra = ((DataRow)row)["IdOrdenCompra"] != DBNull.Value ? Convert.ToInt32(((DataRow)row)["IdOrdenCompra"]) : (int?)null,
                NumeroFactura = Convert.ToString(((DataRow)row)["NumeroFactura"]),
                FechaEmision = Convert.ToDateTime(((DataRow)row)["FechaEmision"]),
                IdProveedor = Convert.ToInt32(((DataRow)row)["IdProveedor"]),
                IdUsuarioCreador = Convert.ToInt32(((DataRow)row)["IdUsuarioCreador"]),
                Subtotal = Convert.ToDecimal(((DataRow)row)["Subtotal"]),
                Impuestos = Convert.ToDecimal(((DataRow)row)["Impuestos"]),
                Descuento = Convert.ToDecimal(((DataRow)row)["Descuento"]),
                Total = Convert.ToDecimal(((DataRow)row)["Total"]),
                MetodoPago = Convert.ToString(((DataRow)row)["MetodoPago"]),
                Observaciones = Convert.ToString(((DataRow)row)["Observaciones"]),
                FechaRegistro = Convert.ToDateTime(((DataRow)row)["FechaRegistro"]),
                FechaPago = ((DataRow)row)["FechaPago"] != DBNull.Value ? Convert.ToDateTime(((DataRow)row)["fecha_pago"]) : (DateTime?)null,
            };
        }

        /// <summary>
        /// Mapper para convertir un DataSet en una lista de FacturaProveedorGetListModel
        /// </summary>
        /// <param name="mDs"></param>
        /// <returns></returns>
        private static List<FacturaProveedorGetListModel> MapFacturaProveedoresGetListPendiente(this DataSet mDs, string estadoFactura)
        {
            if (mDs == null || mDs.Tables.Count == 0)
                return new List<FacturaProveedorGetListModel>();

            var facturasProveedores = new List<FacturaProveedorGetListModel>();

            foreach (var row in mDs.Tables[0].Rows)
            {
                facturasProveedores.Add(new FacturaProveedorGetListModel()
                {
                    NumeroFactura = Convert.ToString(((DataRow)row)["NumeroFactura"]),
                    FechaEmision = Convert.ToDateTime(((DataRow)row)["FechaEmision"]),
                    IdProveedor = Convert.ToInt32(((DataRow)row)["IdProveedor"]),
                    IdUsuarioCreador = Convert.ToInt32(((DataRow)row)["IdUsuarioCreador"]),
                    Subtotal = Convert.ToDecimal(((DataRow)row)["Subtotal"]),
                    Impuestos = Convert.ToDecimal(((DataRow)row)["Impuestos"]),
                    Descuento = Convert.ToDecimal(((DataRow)row)["Descuento"]),
                    EstadoFactura = estadoFactura,
                    Total = Convert.ToDecimal(((DataRow)row)["Total"]),
                    MetodoPago = Convert.ToString(((DataRow)row)["MetodoPago"]),
                    Observaciones = Convert.ToString(((DataRow)row)["Observaciones"]),
                    FechaRegistro = Convert.ToDateTime(((DataRow)row)["FechaRegistro"]),
                    FechaPago = ((DataRow)row)["FechaPago"] != DBNull.Value ? Convert.ToDateTime(((DataRow)row)["fecha_pago"]) : (DateTime?)null,
                });
            }

            return facturasProveedores;
        }

        /// <summary>
        /// Mapper para convertir un DataSet en una lista de FacturaProveedorGetListModel
        /// </summary>
        /// <param name="mDs"></param>
        /// <returns></returns>
        private static List<FacturaProveedorGetListFilterModel> MapFacturaProveedoresGetList(this DataSet mDs)
        {
            if (mDs == null || mDs.Tables.Count == 0)
                return new List<FacturaProveedorGetListFilterModel>();

            var facturasProveedores = new List<FacturaProveedorGetListFilterModel>();

            foreach (var row in mDs.Tables[0].Rows)
            {
                facturasProveedores.Add(new FacturaProveedorGetListFilterModel()
                {
                    IdFacturaProveedor = Convert.ToInt32(((DataRow)row)["IdFacturaProveedor"]),
                    NumeroFactura = Convert.ToString(((DataRow)row)["NumeroFactura"]),
                    FechaEmision = Convert.ToDateTime(((DataRow)row)["FechaEmision"]),
                    ProveedorNombre = Convert.ToString(((DataRow)row)["RazonSocial"]),
                    UsuarioNombre = Convert.ToString(((DataRow)row)["username"]),
                    Subtotal = Convert.ToDecimal(((DataRow)row)["Subtotal"]),
                    Impuestos = Convert.ToDecimal(((DataRow)row)["Impuestos"]),
                    Descuento = Convert.ToDecimal(((DataRow)row)["Descuento"]),
                    EstadoFactura = Convert.ToString(((DataRow)row)["EstadoFactura"]),
                    Total = Convert.ToDecimal(((DataRow)row)["Total"]),
                    MetodoPago = Convert.ToString(((DataRow)row)["MetodoPago"]),
                    Observaciones = Convert.ToString(((DataRow)row)["Observaciones"]),
                    FechaRegistro = Convert.ToDateTime(((DataRow)row)["FechaRegistro"]),
                    FechaPago = ((DataRow)row)["FechaPago"] != DBNull.Value ? Convert.ToDateTime(((DataRow)row)["FechaPago"]) : (DateTime?)null,
                });
            }

            return facturasProveedores;
        }
        #endregion

        public static List<FacturaProveedorDetalle> MapFacturaProveedorDetallesGetList(this DataSet mDs)
        {
            if (mDs == null || mDs.Tables.Count == 0)
                return new List<FacturaProveedorDetalle>();
            var facturaProveedorDetalles = new List<FacturaProveedorDetalle>();
            foreach (var row in mDs.Tables[0].Rows)
            {
                facturaProveedorDetalles.Add(new FacturaProveedorDetalle()
                {
                    IdDetalleFacturaProveedor = Convert.ToInt32(((DataRow)row)["IdDetalleFacturaProveedor"]),
                    IdOrdenCompraDetalle = Convert.ToInt32(((DataRow)row)["IdFacturaProveedorDetalle"]),
                    IdFacturaProveedor = Convert.ToInt32(((DataRow)row)["IdFacturaProveedor"]),
                    Descripcion = Convert.ToString(((DataRow)row)["Descripcion"]),
                    Cantidad = Convert.ToInt32(((DataRow)row)["Cantidad"]),
                    PrecioUnitario = Convert.ToDecimal(((DataRow)row)["PrecioUnitario"]),
                    Impuesto = Convert.ToDecimal(((DataRow)row)["Impuesto"]),
                    Descuento = Convert.ToDecimal(((DataRow)row)["Descuento"]),
                    IdProducto = Convert.ToInt32(((DataRow)row)["IdProducto"]),
                });
            }
            return facturaProveedorDetalles;
        }

        #endregion
    }
}
