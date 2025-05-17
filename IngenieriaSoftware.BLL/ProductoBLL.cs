using IngenieriaSoftware.BEL;
using IngenieriaSoftware.DAL.EntityDAL;
using System.Collections.Generic;

namespace IngenieriaSoftware.BLL
{
    public class ProductoBLL
    {
        private readonly ProductoDAL _productoDAL = new ProductoDAL();

        public ProductoBLL()
        { }

        public List<Producto> ObtenerTodosLosProductos()
        {
            return _productoDAL.ObtenerTodosLosProductos();
        }
    }
}