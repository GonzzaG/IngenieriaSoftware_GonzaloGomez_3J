using System;
using System.Collections.Generic;
using System.Data;

namespace IngenieriaSoftware.DAL
{
    public class TraduccionMapper
    {
        public Dictionary<string, string> MapearTraduccionesPorIdiomaDesdeDataSet(DataSet dataSet)
        {
            var traducciones = new Dictionary<string, string>();

            // Suponiendo que los datos vienen en la primera tabla del DataSet
            if (dataSet.Tables.Count > 0)
            {
                DataTable tabla = dataSet.Tables[0];

                foreach (DataRow fila in tabla.Rows)
                {
                    // Suponiendo que la tabla tiene columnas "EtiquetaId" y "Texto"
                    int etiquetaId = Convert.ToInt32(fila["etiqueta_id"]);
                    string texto = Convert.ToString(fila["traduccion"]);

                    // Agregar al diccionario
                    traducciones.Add(etiquetaId.ToString(), texto);
                }
            }

            return traducciones;
        }

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
    }
}