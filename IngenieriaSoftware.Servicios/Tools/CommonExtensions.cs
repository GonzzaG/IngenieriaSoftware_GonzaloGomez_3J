using System;
using System.Collections.Generic;
using System.Linq;

namespace IngenieriaSoftware.Servicios.Tools
{
    public static class CommonExtensions
    {
        public static void IsNull(this object objeto)
        {
            if (objeto is null)
                throw new ArgumentNullException($"{nameof(objeto)}, no validado correctamente");
        }

        public static bool HasValue(this string value)
        {
            return !string.IsNullOrWhiteSpace(value);
        }

        public static bool Empty(this string value)
        {
            return string.IsNullOrWhiteSpace(value);
        }

        public static bool IsPositive(this decimal value)
        {
            return value > 0;
        }
        public static bool IsPositive(this int value)
        {
            return value > 0;
        }

        public static bool Empty(this IEnumerable<object> lista)
        {
            return lista == null || !lista.Any();
               
        }   
    }
}
