using IngenieriaSoftware.BEL;
using IngenieriaSoftware.Servicios.DTOs;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                etiqueta.Id = (int)row["etiqueta_id"];
                etiqueta.Nombre = row["nombre"].ToString();

                etiquetas.Add(etiqueta);
            }
            
            return etiquetas;
        }

    }
}
