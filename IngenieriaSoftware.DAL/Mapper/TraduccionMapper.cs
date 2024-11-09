using IngenieriaSoftware.Servicios.DTOs;
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
                    // Suponiendo que la tabla tiene columnas "EtiquetaId" y "Name"
                    int etiquetaId = Convert.ToInt32(fila["etiqueta_id"]);
                    string texto = Convert.ToString(fila["traduccion"]);

                    // Agregar al diccionario
                    traducciones.Add(etiquetaId.ToString(), texto);
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