using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IngenieriaSoftware.DAL.Tools
{
    public static class ModelDataAccessExtensions
    {
        /// <summary>
        /// Evalua si el valor es null y lo convierte a DBNull para pasarlo a la base de datos
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static object ToDbValue(this object value)
        {
            return value ?? DBNull.Value;
        }
    }
}
