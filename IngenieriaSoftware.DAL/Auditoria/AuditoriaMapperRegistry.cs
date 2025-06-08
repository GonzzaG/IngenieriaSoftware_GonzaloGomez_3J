using IngenieriaSoftware.Abstracciones;
using IngenieriaSoftware.DAL.Auditoria.Auditoria_Usuarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IngenieriaSoftware.DAL.Auditoria
{
    internal class AuditoriaMapperRegistry
    {
        private static readonly Dictionary<string, IAuditoriaMapper> _mappers = new Dictionary<string, IAuditoriaMapper>(StringComparer.OrdinalIgnoreCase)
        {
            { TablesName.Usuario, new UsuarioAuditoriaMapper() }
            // Aca se pueden agregar más mappers para otras tablas de auditoría
        };

        public static bool TryGetMapper(string tableName, out IAuditoriaMapper mapper)
        {
            return _mappers.TryGetValue(tableName, out mapper);
        }
    }
}
