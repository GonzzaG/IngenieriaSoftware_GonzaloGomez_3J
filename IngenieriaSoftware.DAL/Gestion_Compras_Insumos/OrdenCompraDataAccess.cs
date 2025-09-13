using IngenieriaSoftware.BEL.OrdenDeCompra;
using IngenieriaSoftware.DAL.Tools;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace IngenieriaSoftware.DAL.Gestion_Compras_Insumos
{
    public static class OrdenCompraDataAccess
    {
        public static void OrdenCompraExist(string numOrdenCompra)
        {
            SqlParameter[] parameteros = new SqlParameter[]
            {
                new SqlParameter("@NumOrdenCompra", numOrdenCompra),
                new SqlParameter("@Exist", SqlDbType.Bit) { Direction = ParameterDirection.Output }
            };

            new DAO().ExecuteStoredProcedure("OrdenCompra.sp_OrdenCompraExist", parameteros);

            if(parameteros.Last().Value is bool exist && exist)
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
                            new SqlParameter("@Estado", ordenCompra.Estado),
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
