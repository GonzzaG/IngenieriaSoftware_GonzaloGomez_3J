using System;
using System.Collections.Generic;
using System.Linq;

namespace IngenieriaSoftware.Servicios.Tools
{
    public static class CommonExtensions
    {
        public static void ValidarObjetoNoNulo(this object objeto)
        {
            if (objeto is null)
                throw new ArgumentNullException($"{nameof(objeto)}, no validado correctamente");
        }

        public static bool HasValue(this string value)
        {
            return !string.IsNullOrWhiteSpace(value);
        }

        public static bool HasPositiveValue(this decimal value)
        {
            return value > 0;
        }
        public static bool HasPositiveValue(this int value)
        {
            return value > 0;
        }

        public static bool isEmpty(this IEnumerable<object> lista)
        {
            return lista == null || !lista.Any();
               
        }   
    }
}
