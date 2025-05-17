using IngenieriaSoftware.DAL.EntityDAL;
using IngenieriaSoftware.Servicios.DTOs;
using System.Collections.Generic;

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