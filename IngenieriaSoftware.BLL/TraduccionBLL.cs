using IngenieriaSoftware.DAL;
using IngenieriaSoftware.Servicios;
using IngenieriaSoftware.Servicios.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

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
