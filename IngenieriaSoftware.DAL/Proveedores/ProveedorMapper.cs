using IngenieriaSoftware.BEL.Proveedor;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IngenieriaSoftware.DAL.Proveedores
{
    public static class ProveedorMapper 
    {
        public static Proveedor MappearDesdeDatarow (DataRow dr)
        {
            var proveedor = new Proveedor()
            {
                IdProveedor = int.Parse(dr["IdProveedor"].ToString()),
                Documento = dr["Documento"].ToString(),
                RazonSocial = dr["RazonSocial"].ToString(),
                Correo = dr["Correo"].ToString(),
                Telefono = dr["Telefono"].ToString(),
                Estado = bool.Parse(dr["Estado"].ToString()),
            };

            return proveedor;
        }


    }
}
