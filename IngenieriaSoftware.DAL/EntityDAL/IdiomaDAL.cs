﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IngenieriaSoftware.BEL;
using IngenieriaSoftware.Servicios.DTOs;

namespace IngenieriaSoftware.DAL
{
    public class IdiomaDAL
    {
        DAO _dao;
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

        #endregion



        #region Etiqueta

        public int AgregarEtiqueta(List<EtiquetaDTO> etiquetasMemoria)
        {
            List<EtiquetaDTO> etiquetasBD = ObtenerTodasLasEtiquetasEnBD();

            // Llamar al método que compara y modifica etiquetasMemoria
            CompararEtiquetas(etiquetasMemoria, etiquetasBD);

            // Guardar las etiquetas restantes en la base de datos
            foreach (EtiquetaDTO etiqueta in etiquetasMemoria)
            {
                if (etiqueta.Nombre.Length > 0)
                    AgregarEtiquetaEnBD(etiqueta.Nombre);
            }

            return etiquetasMemoria.Count; // O el número de etiquetas que se agregaron a la base de datos
        }

        private void CompararEtiquetas(List<EtiquetaDTO> etiquetasMemoria, List<EtiquetaDTO> etiquetasBD)
        {
            // Obtener una lista de los nombres de las etiquetas en la base de datos
            var nombresEtiquetasBD = etiquetasBD.Select(e => e.Nombre).ToList();

            // Remover etiquetas de memoria que ya existen en la base de datos
            etiquetasMemoria.RemoveAll(etiqueta => nombresEtiquetasBD.Contains(etiqueta.Nombre));
        }


        private int AgregarEtiquetaEnBD(string nombre)
        {
            try
            {
                SqlParameter[] parametros = new SqlParameter[]
                {
                new SqlParameter("@Nombre", nombre)
                };

                DataSet mDs = _dao.ExecuteStoredProcedure("sp_AgregarEtiqueta", parametros);
                int id = int.Parse(mDs.Tables[0].Rows[0]["etiqueta_id"].ToString());

                return id;

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

        #endregion

    }
}