using IngenieriaSoftware.BEL.Auditoria;
using IngenieriaSoftware.DAL.Auditoria;
using System;

namespace IngenieriaSoftware.BLL.Auditoria.Services
{
    public class AuditoriaRepositoryFactory
    {
        public static object CreateRepositoryForType(Type type)
        {
            if (type == typeof(UsuarioAuditoriaModel))
            {
                return new UsuarioAuditoriaRepository();
            }

            throw new InvalidOperationException($"No hay repositorio para el tipo {type.Name}");
        }

    }
}
