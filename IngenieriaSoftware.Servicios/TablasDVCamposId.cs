using IngenieriaSoftware.Abstracciones;
using System;
using System.Collections.Generic;

namespace IngenieriaSoftware.Servicios
{
    /// <summary>
    /// Clase que contiene los campos ID de las tablas con Dígitos Verificadores.
    /// </summary>
    public static class TablasDVCamposId
    {
        private static readonly Dictionary<string, string> ClavesPrimarias = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase)
        {
            { TablesName.Usuario, "id_usuario" }  // Usa el valor constante desde TablesName
            // Si agregás más tablas con DVH, simplemente añadilas acá.
        };

        /// <summary>
        /// Obtiene el nombre del campo ID (clave primaria) para una tabla con DVH.
        /// </summary>
        public static string ObtenerCampoId(string nombreTabla)
        {
            if (!ClavesPrimarias.TryGetValue(nombreTabla, out var campoId))
                throw new KeyNotFoundException($"No se encontró un campo ID para la tabla '{nombreTabla}'.");

            return campoId;
        }

        /// <summary>
        /// Verifica si la tabla tiene un campo ID registrado para DVH.
        /// </summary>
        public static bool TieneCampoId(string nombreTabla) => ClavesPrimarias.ContainsKey(nombreTabla);
        public static bool ImplementaIDVHCalculo(string nombreTabla)
        {
            Type tipo;
            if (!TablesMap.TryGetType(nombreTabla, out tipo))
                return false;

            return typeof(IVerificable).IsAssignableFrom(tipo);
        }
    }
}
