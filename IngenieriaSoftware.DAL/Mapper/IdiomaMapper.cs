using IngenieriaSoftware.Servicios.DTOs;
using System;
using System.Collections.Generic;
using System.Data;

namespace IngenieriaSoftware.DAL
{
    internal class IdiomaMapper
    {
        public List<IdiomaDTO> MapearIdiomasDesdeDataSet(DataSet pDS)
        {
            List<IdiomaDTO> etiquetas = new List<IdiomaDTO>();
            foreach (DataRow row in pDS.Tables[0].Rows)
            {
                IdiomaDTO etiqueta = new IdiomaDTO();
                etiqueta.Id = (int)row["idioma_id"];
                etiqueta.Nombre = row["nombre"].ToString();
                etiqueta.Habilitado = (row["habilitado"] != DBNull.Value) && (Convert.ToInt32(row["habilitado"]) == 1);

                etiquetas.Add(etiqueta);
            }

            return etiquetas;
        }
    }
}