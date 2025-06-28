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
            throw new NotImplementedException();
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
            throw new NotImplementedException();
        }

        public void Save(Categoria entity)
        {
            throw new NotImplementedException();
        }

        public void Update(Categoria entity)
        {
            throw new NotImplementedException();
        }

      
    }
}
