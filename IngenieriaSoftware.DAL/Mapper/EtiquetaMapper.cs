﻿using IngenieriaSoftware.Servicios.DTOs;
using System.Collections.Generic;
using System.Data;

namespace IngenieriaSoftware.DAL
{
    internal class EtiquetaMapper
    {
        public List<EtiquetaDTO> MapearEtiquetasDesdeDataSet(DataSet pDS)
        {
            List<EtiquetaDTO> etiquetas = new List<EtiquetaDTO>();
            foreach (DataRow row in pDS.Tables[0].Rows)
            {
                EtiquetaDTO etiqueta = new EtiquetaDTO();
                etiqueta.Tag = (int)row["etiqueta_id"];
                etiqueta.Name = row["nombre"].ToString();

                etiquetas.Add(etiqueta);
            }

            return etiquetas;
        }
    }
}