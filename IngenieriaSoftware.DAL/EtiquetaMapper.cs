using IngenieriaSoftware.BEL;
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
        public List<Etiqueta> MapearEtiquetasDesdeDataSet(DataSet pDS)
        {
            List<Etiqueta> etiquetas = new List<Etiqueta>();
            foreach (DataRow row in pDS.Tables[0].Rows)
            {
                Etiqueta etiqueta = new Etiqueta();
                etiqueta.Id = (int)row["etiqueta_id"];
                etiqueta.Nombre = row["nombre"].ToString();

                etiquetas.Add(etiqueta);
            }
            
            return etiquetas;
        }

    }
}
