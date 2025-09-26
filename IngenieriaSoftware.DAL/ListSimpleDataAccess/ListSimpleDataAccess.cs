using IngenieriaSoftware.BEL.Common;
using IngenieriaSoftware.Servicios.DTOs.ListSimple;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace IngenieriaSoftware.DAL.ListSimpleDataAccess
{
    public class ListSimpleDataAccess
    {
        public List<ProveedorListSimpleModel> GetProveedoresListSimple()
        {
            var result = new DAO().ExecuteStoredProcedure("Proveedor.sp_Proveedor_ListSimpleGetAll", null);

            return (from DataRow row in result.Tables[0].Rows
                    select new ProveedorListSimpleModel()
                    {
                        IdProveedor = int.Parse(row["IdProveedor"].ToString()),
                        RazonSocial = row["RazonSocial"].ToString()
                    }).ToList();
        }

        public List<SelectListSimple> GetOrdenCompraEstadosListSimple()
        {
            var result = new DAO().ExecuteStoredProcedure("OrdenCompra.sp_GetOrdenCompraEstadosListSimple", null);
            return (from DataRow row in result.Tables[0].Rows
                    select new SelectListSimple()
                    {
                        Id = Convert.ToInt32(row["IdEstado"]),
                        Nombre = row["Nombre"].ToString()
                    }).ToList();
        }



    }
}
