using IngenieriaSoftware.DAL;
using IngenieriaSoftware.Servicios;
using IngenieriaSoftware.Servicios.DTOs;
using IngenieriaSoftware.Servicios.Interfaces;
using System;
using System.Collections.Generic;

namespace IngenieriaSoftware.BLL
{
    public class IdiomaBLL
    {
        private IdiomaDAL _idiomaDAL;

        public IdiomaBLL()
        {
            _idiomaDAL = new IdiomaDAL();
        }

        public void InsertarIdioma(string idiomaNombre)
        {
            _idiomaDAL.InsertarIdioma(idiomaNombre);
        }
        public void EliminarIdioma(int idiomaId)
        {
            _idiomaDAL.EliminarIdioma(idiomaId);
        }
        public Dictionary<EtiquetaDTO, TraduccionDTO> ObtenerEtiquetasConTraduccion(int idioma_id)
        {
            try
            {
                return _idiomaDAL.ObtenerEtiquetasConTraduccion(idioma_id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<EtiquetaDTO> ObtenerEtiquetasSinTraduccion(int idioma_id)
        {
            try
            {
                return _idiomaDAL.ObtenerEtiquetasSinTraduccion(idioma_id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<IdiomaDTO> ObtenerIdiomas()
        {
            return _idiomaDAL.ObtenerIdiomas();
        }

        public void AgregarEtiqueta(Dictionary<string, IIdiomaObservador> etiquetasEnMemoria)//(List<EtiquetaDTO> etiquetasEnMemoria)
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