using IngenieriaSoftware.DAL;
using IngenieriaSoftware.Servicios.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IngenieriaSoftware.BLL
{
    public class IdiomaBLL
    {
        IdiomaDAL _idiomaDAL;
        public IdiomaBLL()
        {
            _idiomaDAL = new IdiomaDAL();
        }

        public List<IdiomaDTO> ObtenerIdiomas()
        {
            return _idiomaDAL.ObtenerIdiomas();
        }




        public void GuardarEtiquetas(Dictionary<string, string> etiquetas)     //(List<EtiquetaDTO> etiquetas)
        {
            try
            {
                _idiomaDAL.GuardarEtiquetas(etiquetas);
            }
            catch(Exception ex)
            {
                throw ex;   
            }
        }
















        public void AgregarEtiqueta(List<EtiquetaDTO> etiquetasEnMemoria)
        {
            try
            {
                //agrego a la bd las etiquetas que todavia no estan ahi
                _idiomaDAL.AgregarEtiqueta(etiquetasEnMemoria);
                
                //ahora deberia obtener todas las etiquetas que estan en bd, listarlas a la misma lista que tenia antes
                //lo que voy a traer de la base de datos lo voy a mapear a dictionary, de esa forma voy a obtener la etiquetaId, el nombredel contro (tag) y la traduccion
                //tam

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<EtiquetaDTO> ObtenerTodasLasEtiquetasEnBD()
        {
            var etiquetas = _idiomaDAL.etiquetas;
            if (etiquetas.Count == 0)
            {
                return _idiomaDAL.ObtenerTodasLasEtiquetasEnBD();
            }
            else
            {
                return etiquetas;
            }
   
        }
    }
}
