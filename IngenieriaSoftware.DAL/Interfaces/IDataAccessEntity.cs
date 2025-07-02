using IngenieriaSoftware.BEL;
using System.Collections.Generic;

namespace IngenieriaSoftware.DAL.Interfaces
{
    public interface IDataAccessEntity<T> where T : IEntity
    {
        IEnumerable<T> GetAll();
        T GetById(int id);
        void DeleteById(int id);
        int Save(T entity);
        void Update(T entity);

    }
}
