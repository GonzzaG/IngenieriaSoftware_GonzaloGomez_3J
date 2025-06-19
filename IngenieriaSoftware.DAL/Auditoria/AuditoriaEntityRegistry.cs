using IngenieriaSoftware.Abstracciones;
using IngenieriaSoftware.DAL.Auditoria.Auditoria_Usuarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IngenieriaSoftware.DAL.Auditoria
{
    public class AuditoriaEntityRegistry
    {
        private static readonly Dictionary<string, string> _entitiesAuditoria = new Dictionary<string, string>
        {
            { TablesName.Usuario, new UsuarioAuditoriaMapper() }
            // Aca se pueden agregar más mappers para otras tablas de auditoría
        };

        public static IAuditoriaMapper GetMapperOrThrow(string tableName)
        {
            string[] nombreTabla = tableName.Split('.');

            if (nombreTabla.Length > 1)
                tableName = nombreTabla[nombreTabla.Length - 1]; // Obtener solo el nombre de la tabla sin esquema

            if (!_mappers.TryGetValue(tableName, out var mapper))
                throw new InvalidOperationException($"No se encontró un mapper de auditoría para la tabla: {tableName}");

            return mapper;
        }
        public static bool TryGetMapper(string tableName, out IAuditoriaMapper mapper)
        {
            return _mappers.TryGetValue(tableName, out mapper);
        }
    }
}
