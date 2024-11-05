using IngenieriaSoftware.DAL;
using IngenieriaSoftware.Servicios;
using System.Collections.Generic;

namespace IngenieriaSoftware.BLL
{
    public class TraduccionBLL : ITraduccionServicio
    {
        private readonly TraduccionDAL _traduccionDAL;
        //  private readonly ITraduccionServicio _traduccionServicio;

        public TraduccionBLL()
        {
            _traduccionDAL = new TraduccionDAL();
            //  _traduccionServicio = traduccionServicio;
        }

        public Dictionary<string, string> ObtenerTraduccionesPorIdioma(int idiomaId)
        {
            return _traduccionDAL.ObtenerTraduccionesPorIdioma(idiomaId);
        }
    }
}