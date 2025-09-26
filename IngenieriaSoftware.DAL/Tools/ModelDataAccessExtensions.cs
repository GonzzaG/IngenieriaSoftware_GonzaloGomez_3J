using System;

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
            if (value == null)
                return DBNull.Value;

            var s = value as string;
            if (s != null)
                if (s.Trim().Length == 0)
                    return DBNull.Value;
                else
                    return s;

            return value;
        }


    }
}
