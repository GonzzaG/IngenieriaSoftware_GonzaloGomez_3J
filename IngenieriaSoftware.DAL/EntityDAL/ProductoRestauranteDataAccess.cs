using IngenieriaSoftware.BEL;
using IngenieriaSoftware.BEL.QueryModels;
using IngenieriaSoftware.DAL.Interfaces;
using IngenieriaSoftware.DAL.Mapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace IngenieriaSoftware.DAL.EntityDAL
{
    public class ProductoRestauranteDataAccess : IDataAccessEntity<Producto>
    {
        private readonly DAO _dao = new DAO();

        public void DeleteById(int id)
        {
            try
            {
                SqlParameter[] parametros = new SqlParameter[]
                {
                new SqlParameter("@Id", id)
                };

                _dao.ExecuteStoredProcedure("sp_Producto_Eliminar", parametros);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Producto GetById(int id)
        {
            try
            {
                SqlParameter[] parametros = new SqlParameter[]
                {
                new SqlParameter("@Id", id)
                };

                DataSet ds = _dao.ExecuteStoredProcedure("sp_ProductoRestaurante_ObtenerPorId", parametros);

                if (ds.Tables[0].Rows.Count == 0)
                    return null;

                DataRow row = ds.Tables[0].Rows[0];

                return new ProductoMapper().ConvertirDesdeRow
                    (row);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<Producto> GetWithFiltros (FiltroQueryModel filtro)
        {
            try
            {
                var tablaFiltros = CrearTablaFiltros(filtro);

                SqlParameter[] parametros = new SqlParameter[]
                {
                    new SqlParameter("@Filtros", SqlDbType.Structured)
                    {
                        TypeName = "FiltrosBusquedaQuery", 
                        Value = tablaFiltros
                    }
                };

                DataSet ds = _dao.ExecuteStoredProcedure("sp_ProductoRestaurante_ObtenerFiltrado", parametros);

                if (ds.Tables[0].Rows.Count == 0)
                    return null;

                var result = new List<Producto>();
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    result.Add(new ProductoMapper().ConvertirDesdeRow(row));
                }

                return result;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        private DataTable CrearTablaFiltros(FiltroQueryModel filtro)
        {
            var table = new DataTable();
            table.Columns.Add("Nombre", typeof(string));
            table.Columns.Add("Codigo", typeof(int));
            table.Columns.Add("Estado", typeof(bool));

            var row = table.NewRow();
            row["Nombre"] = filtro.Nombre ?? (object)DBNull.Value;
            row["Codigo"] = filtro.Id.HasValue ? filtro.Id.Value : (object)DBNull.Value;
            row["Estado"] = filtro.Estado.HasValue ? filtro.Estado.Value : (object)DBNull.Value;

            table.Rows.Add(row);
            return table;
        }
        public List<Producto> GetByNombre(string nombre)
        {
            try
            {
                SqlParameter[] parametros = new SqlParameter[]
                {
                new SqlParameter("@Nombre", nombre)
                };

                DataSet ds = _dao.ExecuteStoredProcedure("Producto.sp_ProductoRestaurante_ObtenerPorNombre", parametros);

                if (ds.Tables[0].Rows.Count == 0)
                    return null;

                DataRow row = ds.Tables[0].Rows[0];

                var result = new List<Producto>();

                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    result.Add(new ProductoMapper().ConvertirDesdeRow(ds.Tables[0].Rows[i]));
                }

                return result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int Save(Producto entity)
        {
            try
            {
                SqlParameter[] parametros = new SqlParameter[]
                {
                    new SqlParameter("@Nombre", entity.Nombre),
                    new SqlParameter("@Descripcion", entity.Descripcion ?? (object)DBNull.Value),
                    new SqlParameter("@TiempoPreparacion", entity.TiempoPreparacion),
                    new SqlParameter("@Disponible", entity.Disponible),
                    new SqlParameter("@EsPostre", entity.EsPostre),
                    new SqlParameter("@Categoria", entity.oCategoria.Id),
                    new SqlParameter("@Tipo", "RESTAURANTE"),
                    new SqlParameter("@NuevoId", SqlDbType.Int) { Direction = ParameterDirection.Output }
                };

                _dao.ExecuteStoredProcedure("sp_Producto_Guardar", parametros);

                return Convert.ToInt32(parametros.First(p => p.ParameterName == "@NuevoId").Value);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Update(Producto entity)
        {
            try
            {
                SqlParameter[] parametros = new SqlParameter[]
                {
                    new SqlParameter("@Id", entity.Id),
                    new SqlParameter("@Precio", entity.Precio),
                    new SqlParameter("@Nombre", entity.Nombre),
                    new SqlParameter("@Descripcion", entity.Descripcion ?? (object)DBNull.Value),
                    new SqlParameter("@TiempoPreparacion", entity.TiempoPreparacion),
                    new SqlParameter("@Disponible", entity.Disponible),
                    new SqlParameter("@EsPostre", entity.EsPostre),
                    new SqlParameter("@Categoria", entity.oCategoria.Id)
                };

                _dao.ExecuteStoredProcedure("sp_Producto_Actualizar", parametros);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IEnumerable<Producto> GetAll()
        {
            try
            {
                DataSet mDs = _dao.ExecuteStoredProcedure("sp_ObtenerTodosLosProductosRestaurante", null);
                return new ProductoMapper().MapearProductosDesdeDataSet(mDs);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}