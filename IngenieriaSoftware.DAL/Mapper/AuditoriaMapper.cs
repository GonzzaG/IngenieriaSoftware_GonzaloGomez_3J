using IngenieriaSoftware.BEL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IngenieriaSoftware.DAL.Mapper
{
    public class AuditoriaMapper
    {
        public List<AuditoriaRegistro> MapearDesdeDataSet(DataSet ds)
        {
            List<AuditoriaRegistro> cambios = new List<AuditoriaRegistro>();

            foreach (DataRow row in ds.Tables[0].Rows)
            {
                cambios.Add(new AuditoriaRegistro
                {
                    IdCambio = Guid.Parse(row["id_cambio"].ToString()),
                    Fecha = Convert.ToDateTime(row["Fecha"]),
                    Usuario = row["Usuario"].ToString(),
                    Tipo = row["Tipo"].ToString()
                });
            }

            return cambios;
        }
    }
}
