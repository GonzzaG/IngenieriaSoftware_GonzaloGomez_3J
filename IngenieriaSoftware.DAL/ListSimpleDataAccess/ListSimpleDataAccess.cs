using IngenieriaSoftware.Servicios.DTOs.ListSimple;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace IngenieriaSoftware.DAL.ListSimpleDataAccess
{
    public class ListSimpleDataAccess
    {
        public List<ProveedorListSimpleViewModel> GetProveedoresListSimple()
        {
            var result = new DAO().ExecuteStoredProcedure("Proveedor.sp_Proveedor_ListSimpleGetAll", null);

            return (from DataRow row in result.Tables[0].Rows
                    select new ProveedorListSimpleViewModel()
                    {
                        IdProveedor = int.Parse(row["IdProveedor"].ToString()),
                        RazonSocial = row["RazonSocial"].ToString()
                    }).ToList();
        }

    }
}
