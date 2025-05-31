using IngenieriaSoftware.Abstracciones;
using IngenieriaSoftware.BEL;
using System;
using System.Linq;
using System.Reflection;
using System.Text;

namespace IngenieriaSoftware.Servicios
{
    public static class DVHService
    {
        public static string GenerarDVH(IEntity entity)
        {
            return GenerarDVHInterno(entity);
        }

        public static string GenerarDVHExtension(this IEntity entity)
        {
            return GenerarDVHInterno(entity);
        }

        private static string GenerarDVHInterno(IEntity entity)
        {
            if (entity == null)
                throw new ArgumentNullException(nameof(entity));

            Type t = entity.GetType();
            StringBuilder dvhBuilder = new StringBuilder();
            var props = t.GetProperties(BindingFlags.Public | BindingFlags.Instance);

            var verificable = t.GetCustomAttributes(typeof(VerificableAttribute), false)
                               .Cast<VerificableAttribute>()
                               .FirstOrDefault();

            if (verificable != null)
                dvhBuilder.Append($"{verificable.Prefix}_");

            foreach (var prop in props)
            {
                object value = prop.GetValue(entity);

                if (value == null)
                    continue;

                if (value is DateTime dateTime)
                {
                    dvhBuilder.Append(dateTime.ToString("ddMMyyyyHHmmss"));
                }
                else
                {
                    dvhBuilder.Append(value.ToString());
                }
            }

            return Encriptador.GetMd5Hash(dvhBuilder.ToString());
        }
    }
}