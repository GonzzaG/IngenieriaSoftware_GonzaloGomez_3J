using IngenieriaSoftware.BEL.Gestion_Compras_Insumos;
using System;
using System.Collections.Generic;
using System.Data;

namespace IngenieriaSoftware.DAL.Gestion_Compras_Insumos.ProductoInventario.Mapper
{
    internal static class EscasezMapper
    {
        public static List<EscasezModel> MapearEscasezDesdeDataSet(this DataSet ds)
        {
            var lista = new List<EscasezModel>();

            if (ds == null || ds.Tables.Count == 0)
                return lista;

            foreach (DataRow row in ds.Tables[0].Rows)
            {
                var item = new EscasezModel();

                item.IdProducto = (int)row["IdProducto"];

                item.CantidadRecomendada = row["CantidadRecomendada"] != DBNull.Value
                    ? (decimal?)row["CantidadRecomendada"]
                    : null;

                item.FechaRegistro = (DateTime)row["FechaRegistro"];

                item.RegistradoPor = row["RegistradoPor"] != DBNull.Value
                    ? (int?)row["RegistradoPor"]
                    : null;

                item.Observacion = row["Observacion"] != DBNull.Value
                    ? row["Observacion"].ToString()
                    : null;

                lista.Add(item);
            }

            return lista;
        }

    }
}
