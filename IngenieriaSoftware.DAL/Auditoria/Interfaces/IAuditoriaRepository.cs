using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IngenieriaSoftware.DAL.Auditoria
{
    public interface IAuditoriaRepository
    {
        void RealizarPeticion(string tabla, int idEntidad, int version, int idUsuarioActual, string comentario);
        object GetPorIdYVersion(int id, int version, string nombreTabla);
    }
}
