using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace IngenieriaSoftware.DAL
{
    public class TraduccionMapper
    {
        public Dictionary<string, string> MapearTraduccionesDesdeDataSet(DataSet dataSet)
        {
            var traducciones = new Dictionary<string, string>();

            if (dataSet != null && dataSet.Tables.Count > 0)
            {
                DataTable table = dataSet.Tables[0];

                foreach (DataRow row in table.Rows)
                {
                    var nombreEtiqueta = row["NombreEtiqueta"].ToString();
                    var texto = row["Texto"].ToString();

                    if (!traducciones.ContainsKey(nombreEtiqueta))
                    {
                        traducciones.Add(nombreEtiqueta, texto);
                    }
                }
            }

            return traducciones;
        }

        public Dictionary<string, string> MapearTraduccionesPorIdiomaDesdeDataSet(DataSet dataSet)
        {
            Dictionary<string, string> traducciones = new Dictionary<string, string>();

            if (dataSet != null && dataSet.Tables.Count > 0)
            {
                DataTable table = dataSet.Tables[0];

                foreach (DataRow row in dataSet.Tables[0].Rows)
                {
                    string etiquetaId = row["etiqueta_id"].ToString();
                    string nombreEtiqueta = row["nombre"].ToString();
                    string textoTraduccion = row["traduccion"].ToString();

                    string claveUnica = $"{etiquetaId}_{nombreEtiqueta}";
                    traducciones[claveUnica] = textoTraduccion;

                }
            }

            return traducciones;

        }

    }
}
