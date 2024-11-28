using IngenieriaSoftware.DAL;
using IngenieriaSoftware.Servicios;
using IngenieriaSoftware.Servicios.DTOs;
using System;
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

        public List<TraduccionDTO> ObtenerTraduccionesPorEtiquetas(List<int> listaEtiquetas, int idiomaId)
        {
            return _traduccionDAL.ObtenerTraduccionesPorEtiquetas(listaEtiquetas, idiomaId);
        }

        public Dictionary<string, string> ObtenerTraduccionesPorIdioma(int idiomaId)
        {
            try
            {
                return _traduccionDAL.ObtenerTraduccionesPorIdioma(idiomaId);
            }
            catch( Exception ex)
            {
                throw ex;
            }

        }

        public void InsertarTraduccion (TraduccionDTO traduccion)
        {
            try
            {
               _traduccionDAL.InsertarTraduccion(traduccion);
            }
            catch (Exception ex)
            {
                throw ex;   
            }
        }
    }
}