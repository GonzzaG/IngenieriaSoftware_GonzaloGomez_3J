using IngenieriaSoftware.BEL;
using IngenieriaSoftware.BEL.Proveedor;
using IngenieriaSoftware.DAL.Mapper;
using IngenieriaSoftware.DAL.Tools;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IngenieriaSoftware.DAL.Proveedores
{
    public class ProductoProveedorDataAccess 
    {
        /// <summary>
        /// Obtenemos lo productos asociados a un proveedor por su Id.
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        public List<Producto> GetById(int Id)
        {
            var parametros = new SqlParameter[]
            {
                new SqlParameter("@IdProveedor", Id)
            };

            var dt = new DAO().ExecuteStoredProcedure("Proveedor.sp_Proveedor_ObtenerProductos", parametros);

            if (!dt.esValido())
                return new List<Producto>();

            List<Producto> productos = new ProductoMapper().MapearProductosDesdeDataSet(dt);

            return productos;
        }
    }
}
