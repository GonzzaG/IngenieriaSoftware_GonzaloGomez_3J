using IngenieriaSoftware.BEL;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IngenieriaSoftware.DAL.Mapper;
using System.Windows.Forms;

namespace IngenieriaSoftware.DAL.EntityDAL
{
    public class FacturaDAL
    {
        private readonly DAO _dao = new DAO();
        private readonly FacturaMapper _facturaMapper = new FacturaMapper();
        public FacturaDAL() { }

        public int GuardarFactura(Factura factura)
        {
            try
            {
                SqlParameter[] parametros = new SqlParameter[]
                {
                    new SqlParameter("@NumeroFactura", factura.NumeroFactura),
                    new SqlParameter("@FechaEmision", factura.FechaEmision),
                    new SqlParameter("@MesaId", factura.MesaId),
                    new SqlParameter("@ClienteId", factura.ClienteId),
                    new SqlParameter("@ComandaId", factura.ComandaId),
                    new SqlParameter("@SubtotalGeneral", factura.SubtotalGeneral),
                    new SqlParameter("@DescuentoTotal", factura.DescuentoTotal),
                    new SqlParameter("@ImpuestoTotal", factura.ImpuestoTotal),
                    new SqlParameter("@Propina", factura.Propina),
                    new SqlParameter("@TotalFinal", factura.TotalFinal),
                    new SqlParameter("@MetodoPagoId", factura.MetodoPagoId),  
                    new SqlParameter("@EstadoPago", (int)factura.EstadoPago),
                    new SqlParameter("@MontoPagado", factura.MontoPagado),
                    new SqlParameter("@Cambio", factura.Cambio),
                    new SqlParameter("@Notas", factura.Notas),
                    new SqlParameter("@DivisionPago", factura.DivisionPago)
                };

                DataSet mDs = _dao.ExecuteStoredProcedure("sp_GuardarFactura", parametros);

                int facturaId = Convert.ToInt32(mDs.Tables[0].Rows[0]["FacturaId"]);

                return facturaId;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public void GuardarProductosFactura(int facturaId, List<ProductoFactura> productosFactura)
        {
            try
            {
                DataTable productoFacturaTable = new DataTable();
                productoFacturaTable.Columns.Add("ProductoId", typeof(int));
                productoFacturaTable.Columns.Add("NombreProducto", typeof(string));
                productoFacturaTable.Columns.Add("Cantidad", typeof(int));
                productoFacturaTable.Columns.Add("PrecioUnitario", typeof(decimal));

                foreach (var producto in productosFactura)
                {
                    productoFacturaTable.Rows.Add(producto.ProductoId, producto.NombreProducto, producto.Cantidad, producto.PrecioUnitario);
                }
                SqlParameter[] parametros = new SqlParameter[]
                {
                    new SqlParameter("@FacturaId", facturaId),
                    new SqlParameter("@ProductoFactura", productoFacturaTable)
                    {
                        SqlDbType = SqlDbType.Structured,
                        TypeName = "dbo.ProductoFacturaType" 
                    }
                };

                _dao.ExecuteStoredProcedure("sp_GuardarProductosFactura", parametros);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<Factura> ObtenerFacturasPorEstado(int Estado)
        {
            try
            {
                SqlParameter[] parametros = new SqlParameter[]
                {
                    new SqlParameter("@Estado", Estado)
                };

                DataSet mDs = _dao.ExecuteStoredProcedure("sp_ObtenerFacturasPorEstado", parametros);

                var facturas = _facturaMapper.MapearFacturasDesdeDataSet(mDs);

                return facturas;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Factura ObtenerFacturasPorFacturaId(int facturaId)
        {
            try
            {
                SqlParameter[] parametros = new SqlParameter[]
                {
                    new SqlParameter("@FacturaId", facturaId)
                };

                DataSet mDs = _dao.ExecuteStoredProcedure("sp_ObtenerFacturaPorId", parametros);

                var factura = _facturaMapper.MapearFacturasDesdeDataSet(mDs)[0];

                return factura;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void CambiarEstadoFactura(int facturaId, int nuevoEstado)
        {
            try
            {
                SqlParameter[] parametros = new SqlParameter[]
                {
                    new SqlParameter("@FacturaId", facturaId),
                    new SqlParameter("@NuevoEstado", nuevoEstado)
                };

                _dao.ExecuteNonQuery("sp_CambiarEstadoFactura", parametros);

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
