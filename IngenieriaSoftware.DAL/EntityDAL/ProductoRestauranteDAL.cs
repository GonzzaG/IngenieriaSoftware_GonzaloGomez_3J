using IngenieriaSoftware.BEL;
using IngenieriaSoftware.DAL.Interfaces;
using IngenieriaSoftware.DAL.Mapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace IngenieriaSoftware.DAL.EntityDAL
{
    public class ProductoRestauranteDAL : IDataAccessEntity<Producto>
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

        public int Save(Producto entity)
        {
            try
            {
                SqlParameter[] parametros = new SqlParameter[]
                {
                    new SqlParameter("@Nombre", entity.Nombre),
                    new SqlParameter("@Descripcion", entity.Descripcion ?? (object)DBNull.Value),
                    new SqlParameter("@Precio", entity.Precio),
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
                    new SqlParameter("@Id", entity.ProductoId),
                    new SqlParameter("@Nombre", entity.Nombre),
                    new SqlParameter("@Descripcion", entity.Descripcion ?? (object)DBNull.Value),
                    new SqlParameter("@Precio", entity.Precio),
                    new SqlParameter("@TiempoPreparacion", entity.TiempoPreparacion),
                    new SqlParameter("@Disponible", entity.Disponible),
                    new SqlParameter("@EsPostre", entity.EsPostre),
                    new SqlParameter("@Categoria", entity.IdCategoria)
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