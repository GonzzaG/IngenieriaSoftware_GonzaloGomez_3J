using IngenieriaSoftware.BEL;
using IngenieriaSoftware.BEL.QueryModels;
using IngenieriaSoftware.DAL.EntityDAL;
using IngenieriaSoftware.Servicios.Tools;
using System.Collections.Generic;

namespace IngenieriaSoftware.BLL
{
    public class ProductoBLL
    {
        private readonly ProductoRestauranteDataAccess _productoDAL = new ProductoRestauranteDataAccess();

        public ProductoBLL()
        { }

        #region Obtener productos inventario
        public List<Producto> GetProductosInventario()
        {
            return new ProductoRestauranteDataAccess().GetAllProductosInventario();
        }

        public List<Producto> GetProductosInventarioPorNombre(string nombre)
        {
            return new ProductoRestauranteDataAccess().GetAllProductosInventarioPorNombre(nombre);
        }
        #endregion

        #region Metodos Genericos
        public List<Producto> GetAll()
        {
            return (List<Producto>)(new ProductoRestauranteDataAccess().GetAll());
        }

        public void Update(Producto entity)
        {
            if (entity is null) throw new System.Exception("El producto no puede ser nulo");
            new ProductoRestauranteDataAccess().Update(entity);
        }

        public void Save(Producto entity)
        {
            if (entity is null) throw new System.Exception("El producto no puede ser nulo");
            int idProd = new ProductoRestauranteDataAccess().Save(entity);
        }

        public Producto GetById(int id)
        {
            if (id.Equals(0)) throw new System.Exception("El id no puede ser 0");
            return new ProductoRestauranteDataAccess().GetById(id);
        }

        public List<Producto> GetByNombre(string nombre)
        {
            if (nombre.HasValue())
                return new ProductoRestauranteDataAccess().GetByNombre(nombre);
            throw new System.Exception("El id no puede ser 0");
        }
        /// <summary>
        /// Obtiene una lista de productos que coinciden con el filtro proporcionado.
        /// </summary>
        /// <param name="nombre"></param>
        /// <returns></returns>
        /// <exception cref="System.Exception"></exception>
        public List<Producto> GetWithFiltro(FiltroQueryModel filtro)
        {
            return new ProductoRestauranteDataAccess().GetWithFiltros(filtro);
        }

        public void DeleteById(int id)
        {
            if (id.Equals(0)) throw new System.Exception("El id no puede ser 0");
            new ProductoRestauranteDataAccess().DeleteById(id);
        }
        #endregion

    }
}