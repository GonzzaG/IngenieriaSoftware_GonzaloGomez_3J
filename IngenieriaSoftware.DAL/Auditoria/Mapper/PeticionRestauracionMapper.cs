using IngenieriaSoftware.BEL.Auditoria;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IngenieriaSoftware.DAL.Auditoria
{
    public static class PeticionRestauracionMapper
    {
        public static List<PeticionRestauracionModel> MappearDesdeDataSet(DataSet mds)
        {
            List<PeticionRestauracionModel> lista = new List<PeticionRestauracionModel>();

            if (mds != null && mds.Tables.Count > 0)
            {
                foreach (DataRow row in mds.Tables[0].Rows)
                {
                    PeticionRestauracionModel peticion = new PeticionRestauracionModel
                    {
                        Id = row["Id"] != DBNull.Value ? Convert.ToInt32(row["Id"]) : 0,
                        Tabla = row["Tabla"].ToString(),
                        IdEntidad = Convert.ToInt32(row["IdEntidad"]),
                        Version = Convert.ToInt32(row["Version"]),
                        SolicitadoPor = Convert.ToInt32(row["SolicitadoPor"]),
                        FechaSolicitud = Convert.ToDateTime(row["FechaSolicitud"]),
                        Estado = row["Estado"].ToString(),
                        ProcesadoPor = row.IsNull("ProcesadoPor") ? (int?)null : Convert.ToInt32(row["ProcesadoPor"]),
                        FechaProcesado = row.IsNull("FechaProcesado") ? (DateTime?)null : Convert.ToDateTime(row["FechaProcesado"]),
                        Comentario = row["Comentario"].ToString()
                    };
                    lista.Add(peticion);
                }
            }
            return lista;
        }
        
    }
}
