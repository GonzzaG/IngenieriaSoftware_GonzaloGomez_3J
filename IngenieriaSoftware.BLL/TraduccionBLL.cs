using IngenieriaSoftware.DAL;
using IngenieriaSoftware.Servicios.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace IngenieriaSoftware.BLL
{
    public class TraduccionBLL
    {
        private readonly TraduccionDAL _traduccionDAL;

        public TraduccionBLL()
        {
            _traduccionDAL = new TraduccionDAL();
        }

        public Dictionary<string, string> ObtenerTraducciones(string idiomaNombre)
        {
            var traducciones = _traduccionDAL._traducciones;
            if (traducciones.Count == 0)
            {
                return _traduccionDAL.ObtenerTraduccionesPorIdioma(idiomaNombre);
            }
            else
            {
                return traducciones;
            }
        }

    }
}
