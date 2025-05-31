using IngenieriaSoftware.Servicios.DTOs;
using IngenieriaSoftware.Servicios.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace IngenieriaSoftware.DAL
{
    public class IdiomaDAL
    {
        private readonly DAO _dao;
        public List<EtiquetaDTO> etiquetas;
        private EtiquetaMapper _etiquetaMapper;
        private TraduccionMapper _traduccionMapper;

        public IdiomaDAL()
        {
            _dao = new DAO();
            etiquetas = new List<EtiquetaDTO>();
            _etiquetaMapper = new EtiquetaMapper();
            _traduccionMapper = new TraduccionMapper();
        }

        #region Idioma

        public List<IdiomaDTO> ObtenerIdiomas()
        {
            try
            {
                DataSet mDs = _dao.ExecuteStoredProcedure("sp_ObtenerTodosLosIdiomas", null);
                return new IdiomaMapper().MapearIdiomasDesdeDataSet(mDs);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void InsertarIdioma(string idiomaNombre)
        {
            try
            {
                SqlParameter[] parametros = new SqlParameter[]
                {
                    new SqlParameter("@Nombre", idiomaNombre)
                };

                _dao.ExecuteNonQuery("sp_InsertarIdioma", parametros);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void EliminarIdioma(int idiomaId)
        {
            try
            {
                SqlParameter[] parametros = new SqlParameter[]
                {
                    new SqlParameter("@IdiomaId", idiomaId)
                };

                _dao.ExecuteNonQuery("sp_EliminarIdioma", parametros);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion Idioma

        #region Etiqueta

        public int AgregarEtiqueta(Dictionary<string, IIdiomaObservador> etiquetasEnMemoria)
        {
            List<EtiquetaDTO> etiquetasBD = ObtenerTodasLasEtiquetasEnBD();

            // Convertir el diccionario de suscriptores a una lista de EtiquetaDTO, asegurando que `Name` no esté vacío o nulo
            List<EtiquetaDTO> etiquetasMemoria = etiquetasEnMemoria
                .Where(e => !string.IsNullOrEmpty(e.Value.Name))  // Filtrar suscriptores con Name válido
                .Select(e => new EtiquetaDTO
                {
                    Tag = int.Parse(e.Key),
                    Name = e.Value.Name
                })
                .ToList();

            // Comparar y modificar etiquetasMemoria
            CompararEtiquetas(etiquetasMemoria, etiquetasBD);

            // Guardar las etiquetas restantes en la base de datos
            foreach (EtiquetaDTO etiqueta in etiquetasMemoria)
            {
                if (!string.IsNullOrEmpty(etiqueta.Name))
                {
                    GuardarEtiquetas(etiqueta.Tag, etiqueta.Name);
                }
            }

            return etiquetasMemoria.Count;
        }

        private void CompararEtiquetas(List<EtiquetaDTO> etiquetasMemoria, List<EtiquetaDTO> etiquetasBD)
        {
            // Obtener una lista de los nombres de las etiquetas en la base de datos
            var nombresEtiquetasBD = etiquetasBD.Select(e => e.Tag).ToList();

            for (int i = etiquetasMemoria.Count - 1; i >= 0; i--)
            {
                if (nombresEtiquetasBD.Contains(etiquetasMemoria[i].Tag))
                {
                    etiquetasMemoria.RemoveAt(i);
                }
            }
        }

        private void GuardarEtiquetas(int etiqueta_id, string nombre)
        {
            try
            {
                SqlParameter[] parametros = new SqlParameter[]
                {
                    new SqlParameter("@etiquetaId", etiqueta_id),
                    new SqlParameter("@nombre", nombre)
                };

                _dao.ExecuteNonQuery("sp_InsertarEtiqueta", parametros);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<EtiquetaDTO> ObtenerTodasLasEtiquetasEnBD()
        {
            try
            {
                DataSet mDs = _dao.ExecuteStoredProcedure("sp_ObtenerTodasLasEtiquetas", null);

                return new EtiquetaMapper().MapearEtiquetasDesdeDataSet(mDs); ;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Dictionary<EtiquetaDTO, TraduccionDTO> ObtenerEtiquetasConTraduccion(int idioma_id)
        {
            try
            {
                SqlParameter[] parametros = new SqlParameter[]
                {
                    new SqlParameter("@idioma_id", idioma_id)
                };

                DataSet mDs = _dao.ExecuteStoredProcedure("sp_ObtenerEtiquetasConTraduccion", parametros);

                List<EtiquetaDTO> etiquetas = _etiquetaMapper.MapearEtiquetasDesdeDataSet(mDs);
                List<TraduccionDTO> traducciones = _traduccionMapper.MapearTraduccionesDesdeDataSet(mDs);

                Dictionary<EtiquetaDTO, TraduccionDTO> etiquetasTraduccion = new Dictionary<EtiquetaDTO, TraduccionDTO>();

                foreach (var etiqueta in etiquetas)
                {
                    var traduccion = traducciones.FirstOrDefault(t => t.EtiquetaId == etiqueta.Tag);

                    if (traduccion != null)
                    {
                        etiquetasTraduccion[etiqueta] = traduccion;
                    }
                }

                return etiquetasTraduccion;
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
                SqlParameter[] parametros = new SqlParameter[]
                {
                    new SqlParameter("@idioma_id", idioma_id)
                };

                DataSet mDs = _dao.ExecuteStoredProcedure("sp_ObtenerEtiquetasSinTraduccion", parametros);
                List<EtiquetaDTO> etiquetas = _etiquetaMapper.MapearEtiquetasDesdeDataSet(mDs);

                return etiquetas;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion Etiqueta
    }
}