using IngenieriaSoftware.Servicios.DTOs;
using System;
using System.Collections.Generic;
using System.Data;

namespace IngenieriaSoftware.DAL
{
    public class TraduccionMapper
    {
        public DataTable ConvertirListaEtiquetasATabla(List<int> listaEtiquetasId)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Value", typeof(int));

            foreach (var etiqueta in listaEtiquetasId)
            {
                dt.Rows.Add(etiqueta);
            }

            return dt;
        }

        public Dictionary<string, string> MapearTraduccionesPorIdiomaDesdeDataSet(DataSet dataSet)
        {
            var traducciones = new Dictionary<string, string>();
            if (dataSet.Tables.Count > 0)
            {
                DataTable tabla = dataSet.Tables[0];

                foreach (DataRow fila in tabla.Rows)
                {
                    int etiquetaId = Convert.ToInt32(fila["etiqueta_id"]);
                    string texto = Convert.ToString(fila["traduccion"]);
                    string clave = etiquetaId.ToString();

                    if (traducciones.ContainsKey(clave))
                    {
                        traducciones[clave] = texto;
                    }
                    else
                    {
                        traducciones.Add(clave, texto);
                    }
                }
            }

            return traducciones;
        }

        public List<TraduccionDTO> MapearTraduccionesDesdeDataSet(DataSet dataSet)
        {
            var traducciones = new List<TraduccionDTO>();

            if (dataSet != null && dataSet.Tables.Count > 0)
            {
                DataTable table = dataSet.Tables[0];

                foreach (DataRow row in table.Rows)
                {
                    var traduccion = new TraduccionDTO()
                    {
                        EtiquetaId = (int)row["etiqueta_id"],
                        IdiomaId = (int)row["idioma_id"],
                        Texto = row["Texto"].ToString()
                    };

                    traducciones.Add(traduccion);
                }
            }

            return traducciones;
        }
    }
}