using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IngenieriaSoftware.DAL.Auditoria
{
    public interface IAuditoriaRepository
    {
        void RegistrarCambio(
            string tabla,
            string operacion,
            string usuario,
            string oldValuesJson,
            string newValuesJson,
            DateTime fecha
        );
    }
}
