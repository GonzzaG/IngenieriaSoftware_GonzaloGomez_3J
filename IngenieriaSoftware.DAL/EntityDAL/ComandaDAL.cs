using IngenieriaSoftware.BEL;
using IngenieriaSoftware.BEL.Negocio;
using IngenieriaSoftware.DAL.Mapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IngenieriaSoftware.DAL.EntityDAL
{
    public class ComandaDAL
    {
        private readonly DAO _dao = new DAO();
        private readonly ComandaProductoMapper _comandaProductoMapper = new ComandaProductoMapper();
        private readonly ComandaMapper _comandaMapper = new ComandaMapper();
        private readonly ProductoMapper _productoMapper = new ProductoMapper();
        public ComandaDAL() { }

        public int InsertarComanda(int mesaId)
        {
            try
            {
                SqlParameter[] parametros = new SqlParameter[]
                {
                    new SqlParameter("@mesa_id", mesaId),
                    new SqlParameter("@fecha_hora_creacion", DateTime.Now),                
                };

                DataSet mDs = _dao.ExecuteStoredProcedure("sp_InsertarComanda", parametros);
                return Convert.ToInt32(mDs.Tables[0].Rows[0]["comanda_id"]);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void InsertarComandaProductos(List<ComandaProducto> comandaProductos)
        {
            try
            {
                DataTable comandaProductoTable = CrearComandaProductoDataTable(comandaProductos);

                SqlParameter parametroComandaProductos = new SqlParameter("@ComandaProductos", SqlDbType.Structured)
                {
                    TypeName = "dbo.ComandaProductoType",
                    Value = comandaProductoTable
                };

                _dao.ExecuteStoredProcedure("sp_InsertarComandaProductos", new SqlParameter[] { parametroComandaProductos });
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<Comanda> ObtenerComandasPendientes()
        {
            try
            {
                DataSet mDs = _dao.ExecuteStoredProcedure("sp_ObtenerComandasPendientes", null);
                return _comandaMapper.MapearComandasDesdeDataSet(mDs);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Comanda ObtenerComandaPorMesaId(int mesaId)
        {
            try
            {
                SqlParameter[] parametros = new SqlParameter[]
               {
                    new SqlParameter("@mesa_id", mesaId),
               };

                DataSet mDs = _dao.ExecuteStoredProcedure("sp_ObtenerComandasPorMesaId", parametros);
                return _comandaMapper.MapearComandasDesdeDataSet(mDs)[0];
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<ComandaProducto> ObtenerComandaProductoPorMesaId(int mesaId)
        {
            try
            {
                SqlParameter[] parametros = new SqlParameter[]
                {
                    new SqlParameter("@mesa_id", mesaId),
                };

                DataSet mDs = _dao.ExecuteStoredProcedure("sp_ObtenerComandaProductoPorMesaId", parametros);
                return _comandaProductoMapper.MapearComandaProductoDesdeDataSet(mDs);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<ComandaProducto> ObtenerComandaProductoPorComandaId(int comandaId)
        {
            try
            {
                SqlParameter[] parametros = new SqlParameter[]
                {
                    new SqlParameter("@comanda_id", comandaId),
                };

                DataSet mDs = _dao.ExecuteStoredProcedure("sp_ObtenerComandaProductoPorComandaId", parametros);
                var comandaProducto = _comandaProductoMapper.MapearComandaProductoDesdeDataSet(mDs);

                return comandaProducto;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<ComandaProducto> ObtenerComandaProductoProductoPorComandaId(int comandaId)
        {
            try
            {
                SqlParameter[] parametros = new SqlParameter[]
                {
                    new SqlParameter("@comanda_id", comandaId),
                };

                DataSet mDs = _dao.ExecuteStoredProcedure("sp_ObtenerComandaProductoProductoPorComandaId", parametros);
                var comandaProducto = _comandaProductoMapper.MapearComandaProductoDesdeDataSet(mDs);

                return comandaProducto;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<ComandaProducto> ObtenerComandaProductosPendientes (int mesaId, int comandaId)
        {
            try
            {
                SqlParameter[] parametros = new SqlParameter[]
                {
                    new SqlParameter("@mesa_id", mesaId),
                    new SqlParameter("@comanda_id", comandaId) 
                };

                DataSet mDs = _dao.ExecuteStoredProcedure("sp_ObtenerComandaProductosPendientes", parametros);

                return _comandaProductoMapper.MapearComandaProductoDesdeDataSet(mDs);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void MarcarComandaProductosComoEntregados(int notificacionId)
        {
            try
            {
                SqlParameter[] parametros = new SqlParameter[]
                {
                    new SqlParameter("@notificacion_id", notificacionId)
                };

                _dao.ExecuteNonQuery("sp_MarcarComandaProductosComoEntregados", parametros);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void ActualizarEstadoComandaProducto(List<ComandaProducto> productos, int nuevoEstado)
        {
            try
            {
                DataTable table = CrearComandaProductoDataTable(productos);
                SqlParameter[] parametros = new SqlParameter[]
                {
                    new SqlParameter("@ComandaProductos", SqlDbType.Structured)
                    {
                        TypeName = "dbo.ComandaProductoType", 
                        Value = table
                    },  
                    new SqlParameter("@NuevoEstado", nuevoEstado)
                };

                _dao.ExecuteStoredProcedure("sp_ActualizarEstadoComandaProducto", parametros);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        private DataTable CrearComandaProductoDataTable(List<ComandaProducto> comandaProductos)
        {
            if(comandaProductos == null) {return null;}
            DataTable table = new DataTable();
            table.Columns.Add("comanda_id", typeof(int));
            table.Columns.Add("producto_id", typeof(int));
            table.Columns.Add("estado_producto", typeof(string));
            table.Columns.Add("cantidad", typeof(int));
            table.Columns.Add("precio_unitario", typeof(decimal));

      
            foreach (var comandaProducto in comandaProductos)
            {
                if(comandaProducto.Producto == null)
                {
                    table.Rows.Add(comandaProducto.ComandaId, comandaProducto.ProductoId, (int)comandaProducto.EstadoProducto,
                               comandaProducto.Cantidad, comandaProducto.PrecioUnitario);
                }
                else
                {
                    table.Rows.Add(comandaProducto.ComandaId, comandaProducto.Producto.ProductoId, (int)comandaProducto.EstadoProducto,
                                   comandaProducto.Cantidad, comandaProducto.PrecioUnitario);
                }
            }

            return table;
        }



    }
}
