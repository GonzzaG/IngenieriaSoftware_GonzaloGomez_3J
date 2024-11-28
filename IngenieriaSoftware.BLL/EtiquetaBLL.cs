using IngenieriaSoftware.DAL.EntityDAL;
using IngenieriaSoftware.Servicios.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IngenieriaSoftware.BLL
{
    public class EtiquetaBLL
    {
         private readonly EtiquetaDAL _etiquetaDAL;
        //  private readonly ITraduccionServicio _traduccionServicio;

        public EtiquetaBLL()
        {
            _etiquetaDAL = new EtiquetaDAL();
            //  _traduccionServicio = traduccionServicio;
        }

        public List<EtiquetaDTO> ObtenerTodasLasEtiquetas()
        {
            return _etiquetaDAL.ObtenerTodasLasEtiquetas();
        }

        public List<EtiquetaDTO> ObtenerEtiquetasPorPalabra(string palabra)
        {
            return _etiquetaDAL.ObtenerEtiquetasPorPalabra(palabra);
        }

    }
}
