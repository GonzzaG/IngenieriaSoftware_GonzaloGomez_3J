using IngenieriaSoftware.BEL;
using IngenieriaSoftware.BEL.Gestion_Compras_Insumos;
using IngenieriaSoftware.BEL.Negocio;
using IngenieriaSoftware.DAL.Interfaces;
using IngenieriaSoftware.DAL.Mapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IngenieriaSoftware.DAL.Gestion_Compras_Insumos
{
    public class CategoriaDataAccess : IDataAccessEntity<Categoria>
    {
        public void DeleteById(int id)
        {
            SqlParameter[] parametros = new SqlParameter[]
            {
                new SqlParameter("@Id", id)
            };

            DataSet ds = new DAO().ExecuteStoredProcedure("sp_Categoria_Delete", parametros);
        }

        public IEnumerable<Categoria> GetAll()
        {
            try
            {

                DataSet ds = new DAO().ExecuteStoredProcedure("sp_Categoria_GetAll", null);

                var mapper = new CategoriaMapper();
                var lista = new List<Categoria>();

                foreach (DataRow item in ds.Tables[0].Rows) { lista.Add(mapper.ConvertirDesdeRow(item)); }
                
                return lista;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Categoria GetById(int id)
        {
            

            try
            {
                SqlParameter[] parametros = new SqlParameter[]
                {
                    new SqlParameter("@Id", id)
                };

                DataSet ds = new DAO().ExecuteStoredProcedure("sp_Categoria_GetById", parametros);

                return new CategoriaMapper().ConvertirDesdeRow(ds.Tables[0].Rows[0]);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void Update(Categoria entity)
        {
            try
            {
                SqlParameter[] parametros = new SqlParameter[]
                {
                    new SqlParameter("@Nombre", entity.Nombre),
                    new SqlParameter("@NewId ", SqlDbType.Int) { Direction = ParameterDirection.Output }
                };

                DataSet ds = new DAO().ExecuteStoredProcedure("sp_Categoria_Update", parametros);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int Save(Categoria entity)
        {
            try
            {
                DataSet ds = new DAO().ExecuteStoredProcedure("sp_Categoria_Insert", null);

                return int.Parse(ds.Tables[0].Rows[0].ToString());
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Categoria GetCategoriaByNombre(string nombreCategoria)
        {
            try
            {
                SqlParameter[] parametros = new SqlParameter[]
                {
                    new SqlParameter("@Nombre", nombreCategoria),
                };
                DataSet ds = new DAO().ExecuteStoredProcedure("sp_ObtenerCategoriaPorNombre", parametros);

                return new CategoriaMapper().ConvertirDesdeRow(ds.Tables[0].Rows[0]);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
