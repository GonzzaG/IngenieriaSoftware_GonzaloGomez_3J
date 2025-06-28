using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IngenieriaSoftware.Abstracciones
{
    public class AuditoriaModelTyperRegistry
    {
        private static readonly Dictionary<string, Type> _registry = new()
        {
            { TablesName.Usuario, typeof(UsuarioAuditoriaModel) },
            // Agregá más registros si agregás más auditorías
            // { TablesName.Cliente, typeof(ClienteAuditoriaModel) }
        };

        public static Type GetModelTypeOrThrow(string tableName)
        {
            if (!_registry.TryGetValue(tableName, out var type))
                throw new InvalidOperationException($"No se encontró modelo de auditoría para la tabla: {tableName}");

            return type;
        }
    }
}
