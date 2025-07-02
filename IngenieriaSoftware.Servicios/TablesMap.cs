using IngenieriaSoftware.Abstracciones;
using System;
using System.Collections.Generic;

namespace IngenieriaSoftware.Servicios
{
    public class TablesMap
    {
        private static readonly Dictionary<string, Type> _tableToType = new Dictionary<string, Type>(StringComparer.OrdinalIgnoreCase)
        {
            { TablesName.Usuario, typeof(IUsuario) },
            { TablesName.Idioma, typeof(IIdioma) },
            { TablesName.Permiso, typeof(IPermiso) },
        };

        public static bool TryGetType(string tableName, out Type type)
        {
            return _tableToType.TryGetValue(tableName, out type);
        }

        public static Type GetTypeFromTable(string tableName)
        {
            Type type;
            if (!_tableToType.TryGetValue(tableName, out type))
                throw new KeyNotFoundException($"No se encontró un tipo para la tabla '{tableName}'.");
            return type;
        }
    }
}
