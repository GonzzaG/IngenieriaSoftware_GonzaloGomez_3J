using IngenieriaSoftware.BEL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IngenieriaSoftware.DAL.Auditoria
{
    public static class AuditoriaMapper
    {
        public static AuditoriaModel ConvertirDesdeRow(DataRow row)
        {
            return new AuditoriaModel
            {
                Id = Convert.ToInt32(row["Id"]),
                Tabla = row["Tabla"].ToString(),
                Operacion = row["Operacion"].ToString(),
                Usuario = row["Usuario"].ToString(),
                OldValues = row["OldValues"]?.ToString(),
                NewValues = row["NewValues"]?.ToString(),
                Fecha = Convert.ToDateTime(row["Fecha"]),
                RegistroId = Convert.ToInt32(row["RegistroId"])
            };
        }
    }
}
