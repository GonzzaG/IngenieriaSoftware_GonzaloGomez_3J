using IngenieriaSoftware.BEL;
using IngenieriaSoftware.DAL.EntityDAL;
using System.Collections.Generic;

namespace IngenieriaSoftware.BLL
{
    public class ProductoBLL
    {
        private readonly ProductoRestauranteDAL _productoDAL = new ProductoRestauranteDAL();

        public ProductoBLL()
        { }

        public List<Producto> GetAll()
        {
            return (List<Producto>)(new ProductoRestauranteDAL().GetAll());
        }

        public void Update(Producto entity)
        {
            if (entity is null) throw new System.Exception("El producto no puede ser nulo");
            new ProductoBLL().Update(entity);
        }

        public void Save(Producto entity)
        {
            if (entity is null) throw new System.Exception("El producto no puede ser nulo");
            int idProd = new ProductoRestauranteDAL().Save(entity);
        }

        public Producto GetById(int id)
        {
            if (id.Equals(0)) throw new System.Exception("El id no puede ser 0");
            return new ProductoRestauranteDAL().GetById(id);
        }

        public void DeleteById(int id)
        {
            if (id.Equals(0)) throw new System.Exception("El id no puede ser 0");
            new ProductoRestauranteDAL().DeleteById(id);
        }
    }
}