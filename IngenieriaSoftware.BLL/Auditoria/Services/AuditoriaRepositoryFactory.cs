using IngenieriaSoftware.Abstracciones;
using IngenieriaSoftware.BEL.Auditoria;
using IngenieriaSoftware.DAL;
using IngenieriaSoftware.DAL.Auditoria;
using IngenieriaSoftware.DAL.Auditoria.Auditoria_Usuarios;
using IngenieriaSoftware.DAL.Mapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
