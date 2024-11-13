﻿using IngenieriaSoftware.BEL;
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


        private DataTable CrearComandaProductoDataTable(List<ComandaProducto> comandaProductos)
        {
            DataTable table = new DataTable();
            table.Columns.Add("comanda_id", typeof(int));
            table.Columns.Add("producto_id", typeof(int));
            table.Columns.Add("estado_producto", typeof(string));
            table.Columns.Add("cantidad", typeof(int));
            table.Columns.Add("precio_unitario", typeof(decimal));

            foreach (var comandaProducto in comandaProductos)
            {
                table.Rows.Add(comandaProducto.ComandaId, comandaProducto.Producto.ProductoId, (int)comandaProducto.EstadoProducto,
                               comandaProducto.Cantidad, comandaProducto.PrecioUnitario);
            }

            return table;
        }



    }
}
