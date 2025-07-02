using IngenieriaSoftware.Abstracciones;
using IngenieriaSoftware.DAL.Auditoria.Auditoria_Usuarios;
using System;
using System.Collections.Generic;

namespace IngenieriaSoftware.DAL.Auditoria
{
    internal class AuditoriaMapperRegistry
    {
        private static readonly Dictionary<string, IAuditoriaMapper> _mappers = new Dictionary<string, IAuditoriaMapper>(StringComparer.OrdinalIgnoreCase)
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
