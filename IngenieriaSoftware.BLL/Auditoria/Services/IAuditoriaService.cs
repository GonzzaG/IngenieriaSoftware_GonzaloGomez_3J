using IngenieriaSoftware.BEL.Auditoria;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IngenieriaSoftware.BLL.Auditoria
{
    public interface IAuditoriaService<T> where T : IAuditableModel
    {

        void RegistrarCambio(T entidad);
        IEnumerable<T> GetAll();
        T GetById(int id);
    }

}
