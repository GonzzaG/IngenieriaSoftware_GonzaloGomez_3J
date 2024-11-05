﻿using IngenieriaSoftware.Servicios;
using IngenieriaSoftware.Servicios.DTOs;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace IngenieriaSoftware.DAL
{
    public class IdiomaDAL
    {
        private DAO _dao;
        public List<EtiquetaDTO> etiquetas;

        public IdiomaDAL()
        {
            _dao = new DAO();
            etiquetas = new List<EtiquetaDTO>();
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

        #endregion Idioma

        #region Etiqueta

        public void GuardarEtiquetas(Dictionary<string, string> etiquetas)     //(List<EtiquetaDTO> etiquetas)
        {
            try
            {
                foreach (var etiqueta in etiquetas)
                {
                    SqlParameter[] parametros = new SqlParameter[]
                    {
                        new SqlParameter("@etiquetaId", int.Parse(etiqueta.Key)),
                        new SqlParameter("@nombre", etiqueta.Value)
                    };

                    DataSet mDs = _dao.ExecuteStoredProcedure("sp_InsertarEtiqueta", parametros);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int AgregarEtiqueta(Dictionary<string, IIdiomaSuscriptor> etiquetasEnMemoria)
        {
            List<EtiquetaDTO> etiquetasBD = ObtenerTodasLasEtiquetasEnBD();

            // Convertir el diccionario de suscriptores a una lista de EtiquetaDTO, asegurando que `Name` no esté vacío o nulo
            List<EtiquetaDTO> etiquetasMemoria = etiquetasEnMemoria
                .Where(e => !string.IsNullOrEmpty(e.Value.Name))  // Filtrar suscriptores con Name válido
                .Select(e => new EtiquetaDTO
                {
                    Tag = int.Parse(e.Key),
                    Nombre = e.Value.Name
                })
                .ToList();

            // Comparar y modificar etiquetasMemoria
            CompararEtiquetas(etiquetasMemoria, etiquetasBD);

            // Guardar las etiquetas restantes en la base de datos
            foreach (EtiquetaDTO etiqueta in etiquetasMemoria)
            {
                if (!string.IsNullOrEmpty(etiqueta.Nombre))
                {
                    GuardarEtiquetas(etiqueta.Tag, etiqueta.Nombre);
                }
            }

            return etiquetasMemoria.Count;
        }

        private void CompararEtiquetas(List<EtiquetaDTO> etiquetasMemoria, List<EtiquetaDTO> etiquetasBD)
        {
            // Obtener una lista de los nombres de las etiquetas en la base de datos
            var nombresEtiquetasBD = etiquetasBD.Select(e => e.Tag).ToList();

            for(int i = etiquetasMemoria.Count - 1; i>=0; i--)
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

        #endregion Etiqueta
    }
}