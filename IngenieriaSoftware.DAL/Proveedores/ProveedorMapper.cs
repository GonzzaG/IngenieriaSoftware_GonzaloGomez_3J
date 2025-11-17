using IngenieriaSoftware.BEL.Proveedor;
using System;
using System.Data;

namespace IngenieriaSoftware.DAL.Proveedores
{
    public static class ProveedorMapper
    {
        public static Proveedor MappearDesdeDatarow(DataRow dr)
        {
            var proveedor = new Proveedor()
            {
                IdProveedor = int.Parse(dr["IdProveedor"].ToString()),
                Documento = dr["Documento"].ToString(),
                RazonSocial = dr["RazonSocial"].ToString(),
                Correo = dr["Correo"].ToString(),
                Telefono = dr["Telefono"].ToString(),
                Estado = Convert.ToBoolean(dr["Estado"])
            };

            return proveedor;
        }


    }
}
