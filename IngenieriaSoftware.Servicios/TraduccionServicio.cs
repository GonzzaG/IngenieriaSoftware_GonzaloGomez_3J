using System.Collections.Generic;

namespace IngenieriaSoftware.Servicios
{
    public class TraduccionServicio : ITraduccionServicio
    {
        private readonly ITraduccionServicio _traduccionRepositorio;

        public TraduccionServicio(ITraduccionServicio traduccionRepositorio)
        {
            _traduccionRepositorio = traduccionRepositorio;
        }

        public Dictionary<string, string> ObtenerTraduccionesPorIdioma(int idiomaId)
        {
            return _traduccionRepositorio.ObtenerTraduccionesPorIdioma(idiomaId);
        }
    }
}