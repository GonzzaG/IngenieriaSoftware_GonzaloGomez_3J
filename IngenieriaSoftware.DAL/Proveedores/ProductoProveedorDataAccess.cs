using IngenieriaSoftware.BEL;
using IngenieriaSoftware.BEL.Proveedor;
using IngenieriaSoftware.DAL.Mapper;
using IngenieriaSoftware.DAL.Tools;
using System;
using System.Collections.Generic;
using System.Data;
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
        public List<Producto> GetProductosByIdDelProveedor(int id)
        {
            try
            {
                SqlParameter[] parametros = new SqlParameter[]
                {
                    new SqlParameter("@Id", id)
                };

                DataSet ds = new DAO().ExecuteStoredProcedure("Proveedor.sp_ObtenerProductosDeProveedorPorId", parametros);

                ds.esValido();

                var productos = new List<Producto>();

                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    productos.Add(new ProductoProveedorMapper().ConvertirDesdeRow(row));
                }

                return productos;
            }
            catch (ArgumentNullException)
            {
                return new List<Producto>();
            }
        }
    }
}
