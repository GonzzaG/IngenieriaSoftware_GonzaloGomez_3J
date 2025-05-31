using IngenieriaSoftware.BEL;
using IngenieriaSoftware.Servicios;
using System;
using System.Collections.Generic;
using System.Data;

namespace IngenieriaSoftware.DAL.Mapper
{
    public static class DVMapper
    {
        public static DigitoVerificadorVertical MapearDVV(DataSet dataSet)
        {
            DigitoVerificadorVertical DVV = new DigitoVerificadorVertical();
            foreach (DataRow row in dataSet.Tables[0].Rows)
            {
                DigitoVerificadorVertical dvv = new DigitoVerificadorVertical
                {
                    NombreTabla = row["NombreTabla"].ToString(),
                    DVV = row["DVV"].ToString(),
                    FechaGeneracion = DateTime.Parse(row["FechaGeneracion"].ToString())
                };
                DVV = dvv;
            }
            return DVV;
        }

        public static string GenerarDVH(DataRow dataRow)
        {
            List<string> listaValores = new List<string>();

            foreach (DataColumn columna in dataRow.Table.Columns)
            {
                if (columna.ColumnName == "DVH") continue;
                // Concatenar los valores de las columnas que no son DVH
                listaValores.Add(dataRow[columna].ToString());
            }

            // Concatenar todos los valores en un solo string
            string concatenacion = string.Concat(listaValores);

            // Obtener hash MD5 de la concatenación
            return Encriptador.GetMd5Hash(concatenacion);
        }


        /// <summary>
        /// Metodo que genera digito verificador Vertical de una tabla
        /// </summary>
        /// <param name="dataSet"></param>
        /// <returns></returns>
        public static string GenerarDVV(DataSet dataSet)
        {
            List<string> listaDVH = new List<string>();

            foreach (DataRow row in dataSet.Tables[0].Rows)
            {
                // Obtener el DVH de cada fila
                string dvh = row["DVH"].ToString();
                listaDVH.Add(dvh);
            }
            // Concatenar todos los DVs
            string concatenacion = string.Concat(listaDVH);

            // Obtener hash MD5 de la concatenación
            return Encriptador.GetMd5Hash(concatenacion);
        }
    }
}