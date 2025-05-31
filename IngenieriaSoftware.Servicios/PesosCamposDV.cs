using System.Collections.Generic;

namespace IngenieriaSoftware.Servicios
{
    public static class PesosCamposDV
    {
        public static readonly Dictionary<string, Dictionary<string, int>> PesosPorEntidad = new Dictionary<string, Dictionary<string, int>>()
        {
            { "Usuario", new Dictionary<string, int>
                {
                    { "id_usuario", 1 },
                    { "Username", 5 },
                    { "Email", 10 },
                    { "PasswordHash", 15 },
                    { "idioma_id", 1 },
                    { "id_rol", 1 },
                }
            },
           //se pueden agregar mas cuentas
        };

        public static int ObtenerPeso(string entidad, string campo)
        {
            return PesosPorEntidad.ContainsKey(entidad) && PesosPorEntidad[entidad].ContainsKey(campo)
                ? PesosPorEntidad[entidad][campo]
                : 1; // Peso por defecto
        }
    }
}