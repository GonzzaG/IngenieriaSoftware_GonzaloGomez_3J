using IngenieriaSoftware.BEL;
using IngenieriaSoftware.Servicios.DTOs;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace IngenieriaSoftware.DAL
{
    public class TraduccionDAL
    {
        private readonly DAO _dao;
        TraduccionMapper _traduccionMapper = new TraduccionMapper();
        EtiquetaMapper _etiquetaMapper = new EtiquetaMapper();
        public Dictionary<string, string> _traducciones;

        public TraduccionDAL()
        {
            _dao = new DAO();
            _traducciones = new Dictionary<string, string>();
        }

        #region Traduccion

        public List<TraduccionDTO> ObtenerTraduccionesPorEtiquetas(List<int> listaEtiquetas, int idiomaId)
        {
            try
            {            
                DataTable dtEtiquetas = _traduccionMapper.ConvertirListaEtiquetasATabla(listaEtiquetas);

                var parameters = new SqlParameter[]
                {
                    new SqlParameter("@ListaEtiquetas", SqlDbType.Structured) { Value = dtEtiquetas },
                    new SqlParameter("@IdiomaId", SqlDbType.Int) { Value = idiomaId } 
                };

                DataSet mDs = _dao.ExecuteStoredProcedure("sp_ObtenerTraduccionesPorEtiquetas", parameters);
                List<TraduccionDTO> traducciones = _traduccionMapper.MapearTraduccionesDesdeDataSet(mDs);

                return traducciones;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener traducciones por idioma.", ex);
            }
        }


        public Dictionary<string, string> ObtenerTraduccionesPorIdioma(int idiomaId)
        {
            try
            {
                SqlParameter[] parametros = new SqlParameter[]
                {
                    new SqlParameter("@idiomaId", idiomaId)
                };

                DataSet mDs = _dao.ExecuteStoredProcedure("sp_ObtenerTraduccionesPorIdioma", parametros);
                _traducciones = new TraduccionMapper().MapearTraduccionesPorIdiomaDesdeDataSet(mDs);

                return _traducciones;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener traducciones por idioma.", ex);
            }
        }

        public void InsertarTraduccion(TraduccionDTO traduccion)
        {
            try
            {
                SqlParameter[] parametros = new SqlParameter[]
                {
                    new SqlParameter("@idiomaId", traduccion.IdiomaId),
                    new SqlParameter("@etiqueta_id", traduccion.EtiquetaId),
                    new SqlParameter("@texto", traduccion.Texto)

                };

                _dao.ExecuteNonQuery("sp_AsignarTraduccion", parametros);

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion Traduccion
    }
}