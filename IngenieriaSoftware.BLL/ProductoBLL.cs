using IngenieriaSoftware.BEL;
using IngenieriaSoftware.DAL.EntityDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IngenieriaSoftware.BLL
{
    public class ProductoBLL
    {
        private readonly ProductoDAL _productoDAL = new ProductoDAL();

        public ProductoBLL() { }

        public List<Producto> ObtenerTodosLosProductos()
        {
            return _productoDAL.ObtenerTodosLosProductos(); 
        }

    }
}
