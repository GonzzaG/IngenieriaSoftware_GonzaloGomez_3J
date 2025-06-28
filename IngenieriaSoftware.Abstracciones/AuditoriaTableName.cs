using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IngenieriaSoftware.Abstracciones
{
    public class AuditoriaTableName
    {
        private static readonly Dictionary<string, string> _entitiesAuditoria = new Dictionary<string, string>
        {
            { TablesName.Usuario, "Audit.Usuarios_Historial" }
            // Aca se pueden agregar más mappers para otras tablas de auditoría
        };

        public static string[] GetAuditoryTableNameOrThrow(string tableName)
        {
            string[] nombreTabla = tableName.Split('.');

            if(nombreTabla.Length > 1)
                tableName = nombreTabla[nombreTabla.Length - 1]; // Obtener solo el nombre de la tabla sin esquema

            if (!_entitiesAuditoria.TryGetValue(tableName, out var entityAuditoria))
                throw new InvalidOperationException($"No se encontró una tabla de auditoría para la tabla: {tableName}");

            return entityAuditoria.Split('.');
        }
        public static bool TryGetAuditoryTableName(string tableName, out string entityAuditoria)
        {
            return _entitiesAuditoria.TryGetValue(tableName, out entityAuditoria);
        }
    }
}
