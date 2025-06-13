using IngenieriaSoftware.Abstracciones;
using IngenieriaSoftware.BEL.Auditoria;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IngenieriaSoftware.BEL
{
    public class AuditoriaModelTyperRegistry
    {
        private static readonly Dictionary<string, Type> _registry = new Dictionary<string, Type>(StringComparer.OrdinalIgnoreCase)
        {
            { TablesName.Usuario, typeof(UsuarioAuditoriaModel) },
            // Agregá más registros si agregás más auditorías
            // { TablesName.Cliente, typeof(ClienteAuditoriaModel) }
        };

        public static Type GetModelTypeOrThrow(string tableName)
        {
            string[] nombreTabla = tableName.Split('.');

            if(nombreTabla.Length > 1)
                tableName = nombreTabla[nombreTabla.Length - 1]; // Obtener solo el nombre de la tabla sin esquema

            if (!_registry.TryGetValue(tableName, out var type))
                throw new InvalidOperationException($"No se encontró modelo de auditoría para la tabla: {tableName}");

            return type;
        }
    }
}
