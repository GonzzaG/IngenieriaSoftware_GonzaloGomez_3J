using IngenieriaSoftware.BEL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IngenieriaSoftware.DAL.Interfaces
{
    public interface IDataAccessEntity<T> where T : IEntity
    {
        IEnumerable<T> GetAll();    
        T GetById(int id);
        void DeleteById(int id);
        void Save(T entity);
        void Update(T entity);

    }
}
