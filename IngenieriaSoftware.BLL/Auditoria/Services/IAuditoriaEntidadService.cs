using IngenieriaSoftware.BEL.Auditoria;
using System.Collections.Generic;

namespace IngenieriaSoftware.BLL.Auditoria
{
    public interface IAuditoriaEntidadService<T> where T : IAuditableModel
    {

        void RegistrarCambio(T entidad);
        IEnumerable<T> GetAll();
    }

}
