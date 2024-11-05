using System.Collections.Generic;

namespace IngenieriaSoftware.Servicios
{
    public interface ITraduccionServicio
    {
        Dictionary<string, string> ObtenerTraduccionesPorIdioma(int idiomaId);
    }
}