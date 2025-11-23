using System;
using System.Collections.Generic;
using System.Data;

namespace IngenieriaSoftware.DAL.EntityDAL.ProductoTipo
{
    public class ProductoTipoDataAccess
    {
        private readonly DAO _dao = new DAO();

        public List<string> GetProductosTipo()
        {
            try
            {
                DataSet ds = _dao.ExecuteStoredProcedure("sp_GetProductosTipo", null);

                var tipos = new List<string>();
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    tipos.Add(row["Tipo"].ToString());
                }

                return tipos;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }



    }
}
