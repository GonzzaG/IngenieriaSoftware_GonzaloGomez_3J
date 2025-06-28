using IngenieriaSoftware.BEL.Gestion_Compras_Insumos;
using IngenieriaSoftware.DAL.Gestion_Compras_Insumos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IngenieriaSoftware.BLL.Gestion_Compras_Insumos
{
    public class CategoriaBussines
    {
        public void DeleteById(int id)
        {
            if (id > 0) new CategoriaDataAccess().DeleteById(id);

            else throw new Exception("Error al eliminar la categoria");
        }

        public IEnumerable<Categoria> GetAll()
        {
            var categorias = new CategoriaDataAccess().GetAll();

            return categorias.Count() > 0 ? categorias : throw new Exception("No hay categorias para mostar");
        }

        public Categoria GetById(int id)
        {
            if(id > 0) return new CategoriaDataAccess().GetById(id);

            throw new Exception("No se pudo obtener la categoria");
        }

        public void Save(Categoria entity)
        {
            if (entity is null) throw new Exception("Error al guardar la categoria");

            new CategoriaDataAccess().Save(entity);
        }

        public void Update(Categoria entity)
        {
            if (entity is null) throw new Exception("Error al actualizar la categoria");

            new CategoriaDataAccess().Update(entity);
        }
    }
}
