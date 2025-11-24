using IngenieriaSoftware.BEL.OrdenDeCompra;
using IngenieriaSoftware.BEL.OrdenDeCompra.Models;
using IngenieriaSoftware.BEL.OrdenDeCompra.ViewModels;
using IngenieriaSoftware.DAL.Mapper;
using IngenieriaSoftware.DAL.Tools;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace IngenieriaSoftware.DAL.Gestion_Compras_Insumos
{
    public static class OrdenCompraDataAccess
    {
        public static void SetOrdenCompraAceptada(this int idOrdenCompra, string usuario)
        {
            var parametros = new SqlParameter[]
            {
                new SqlParameter("@IdOrdenCompra",idOrdenCompra),
                new SqlParameter("@usuarioModificacion",usuario)
            };

            new DAO().ExecuteStoredProcedure("OrdenCompra.sp_SetOrdenCompraAprobada", parametros);
        }

        public static void SetOrdenCompraRechazada(this int idOrdenCompra, string usuario)
        {
            var parametros = new SqlParameter[]
            {
                new SqlParameter("@IdOrdenCompra",idOrdenCompra),
                new SqlParameter("@usuarioModificacion",usuario)
            };

            new DAO().ExecuteStoredProcedure("OrdenCompra.sp_SetOrdenCompraRechazada", parametros);
        }


        public static void SetOrdenCompraRecibida(this int idOrdenCompra, string usuario)
        {
            var parametros = new SqlParameter[]
            {
                new SqlParameter("@IdOrdenCompra",idOrdenCompra),
                new SqlParameter("@usuarioModificacion",usuario)
            };

            new DAO().ExecuteStoredProcedure("OrdenCompra.sp_SetOrdenCompraRecibida", parametros);
        }

        public static void SetOrdenCompraRegistrada(this int idOrdenCompra, string usuario)
        {
            var parametros = new SqlParameter[]
            {
                new SqlParameter("@IdOrdenCompra",idOrdenCompra),
                new SqlParameter("@usuarioModificacion",usuario)
            };

            new DAO().ExecuteStoredProcedure("OrdenCompra.sp_SetOrdenCompraRegistrada", parametros);
        }

        public static List<OrdenCompraGetListaModel> GetOrdenesCompra()
        {
            return new DAO()
                .ExecuteStoredProcedure("OrdenCompra.sp_GetOrdenCompras", null)
                .ConvertirDataSet();
        }

        public static OrdenCompraWithDetalles GetOrdenCompraByNumero(this string numOrdenCompra)
        {
            var parametros = new SqlParameter[]
            {
                new SqlParameter("@NumOrdenCompra",numOrdenCompra)
            };

            var ordenCompra = new DAO()
                .ExecuteStoredProcedure("OrdenCompra.sp_GetOrdenCompraByNumero", parametros)
                .ConvertirOrdenCompraDetalleDataSet();

            if(ordenCompra == null)
                throw new Exception($"No se encontró una orden de compra con el número {numOrdenCompra}");

            if(ordenCompra is OrdenCompraWithDetalles orden)
            {
                var ds = new DAO()
                    .ExecuteStoredProcedure("OrdenCompra.sp_OrdenCompraDetalles", new SqlParameter[]
                    {
                        new SqlParameter("@IdOrdenCompra", orden.IdOrdenCompra)
                    });

                orden.Detalles = ds.ConvertirDetallesAprobacionDataSet();
            }

            return ordenCompra;
        }

        public static OrdenCompraWithDetalles GetOrdenCompraById(this int idOrdenCompra)
         {
            var parametros = new SqlParameter[]
            {
                new SqlParameter("@IdOrdenCompra",idOrdenCompra)
            };

            var ordenCompra = new DAO()
                .ExecuteStoredProcedure("OrdenCompra.sp_GetOrdenCompraById", parametros)
                .ConvertirOrdenCompraConDetallesDataSet();

            if (ordenCompra == null)
                throw new Exception($"La orden de compra no existe.");

            if (ordenCompra is OrdenCompraWithDetalles orden)
            {
                var ds = new DAO()
                    .ExecuteStoredProcedure("OrdenCompra.sp_OrdenCompraDetalles", new SqlParameter[]
                    {
                        new SqlParameter("@IdOrdenCompra", orden.IdOrdenCompra)
                    });

                orden.Detalles = ds.ConvertirDetallesAprobacionDataSet();
            }

            return ordenCompra;
        }

        public static List<OrdenCompraGetListaModel> GetOrdenesCompraDataAccess(this OrdenCompraQuery query)
        {
            var parametros = new SqlParameter[]
            {
                new SqlParameter("@NumOrdenCompra",query.NumOrdenCompra.ToDbValue()),
                new SqlParameter("@FechaDesde", query.FechaDesde.ToDbValue()),
                new SqlParameter("@IdEstado", query.IdEstado.ToDbValue())
            };

            return new DAO()
                .ExecuteStoredProcedure("OrdenCompra.sp_GetOrdenCompras", parametros)
                .ConvertirDataSet();
        }


        public static void OrdenCompraExist(this string numOrdenCompra)
        {
            SqlParameter[] parameteros = new SqlParameter[]
            {
                new SqlParameter("@NumOrdenCompra", numOrdenCompra),
                new SqlParameter("@Exist", SqlDbType.Bit) { Direction = ParameterDirection.Output }
            };

            new DAO().ExecuteStoredProcedure("OrdenCompra.sp_OrdenCompraExist", parameteros);

            if (parameteros.Last().Value is bool exist && exist)
                throw new System.Exception($"Ya existe una orden de compra con el número {numOrdenCompra}");

        }


        /// <summary>
        /// Guarda una orden de compra
        /// </summary>
        /// <param name="ordenCompra"></param>
        public static void Guardar(this OrdenDeCompraModel ordenCompra)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["ConnectionStringBD"].ConnectionString;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                using (SqlTransaction tran = conn.BeginTransaction())
                {
                    try
                    {
                        SqlParameter[] parametrosOrden = new SqlParameter[]
                        {
                            new SqlParameter("@NumOrdenCompra", ordenCompra.NumOrdenCompra),
                            new SqlParameter("@IdProveedor", ordenCompra.IdProveedor),
                            new SqlParameter("@Fecha", ordenCompra.Fecha),
                            new SqlParameter("@FechaEntregaEsperada", ordenCompra.FechaEntregaEsperada.ToDbValue()),
                            new SqlParameter("@CondicionesPago", ordenCompra.CondicionesPago.ToDbValue()),
                            new SqlParameter("@Moneda", ordenCompra.Moneda),
                            new SqlParameter("@TipoCambio", ordenCompra.TipoCambio.ToDbValue()),
                            new SqlParameter("@TotalEsperado", ordenCompra.TotalEsperado),
                            new SqlParameter("@Observaciones", ordenCompra.Observaciones.ToDbValue()),
                            new SqlParameter("@FechaCreacion", ordenCompra.FechaCreacion),
                            new SqlParameter("@UsuarioCreacion", ordenCompra.UsuarioCreacion),
                            new SqlParameter("@FechaModificacion", ordenCompra.FechaModificacion.ToDbValue()),
                            new SqlParameter("@UsuarioModificacion", ordenCompra.UsuarioModificacion.ToDbValue()),
                            new SqlParameter("@IdOrdenCompra", SqlDbType.Int) { Direction = ParameterDirection.Output }
                        };

                        new DAO().ExecuteStoredProcedure("OrdenCompra.sp_OrdenCompra_Guardar", parametrosOrden, conn, tran);

                        // Obtenemos IdOrdenCompra generado
                        ordenCompra.IdOrdenCompra = (int)parametrosOrden.Last().Value;

                        foreach (var detalle in ordenCompra.Detalles)
                        {
                            SqlParameter[] parametrosDetalle = new SqlParameter[]
                            {
                                new SqlParameter("@IdOrdenCompra", ordenCompra.IdOrdenCompra),
                                new SqlParameter("@IdProducto", detalle.IdProducto),
                                new SqlParameter("@Cantidad", detalle.Cantidad),
                                new SqlParameter("@PrecioUnitarioEsperado", detalle.PrecioUnitarioEsperado),
                                new SqlParameter("@DescuentoLinea", detalle.DescuentoLinea),
                                new SqlParameter("@NotasLinea", detalle.NotasLinea.ToDbValue()),
                                new SqlParameter("@Subtotal", detalle.Subtotal.ToDbValue()),
                            };

                            new DAO().ExecuteStoredProcedure("OrdenCompra.sp_OrdenCompraDetalle_Guardar", parametrosDetalle, conn, tran);
                        }

                        tran.Commit();
                    }
                    catch
                    {
                        tran.Rollback();
                        throw;
                    }
                }
            }
        }

    }
}
