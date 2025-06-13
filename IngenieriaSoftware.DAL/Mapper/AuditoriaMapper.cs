using IngenieriaSoftware.BEL;
using System;
using System.Collections.Generic;
using System.Data;

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
                    Registro = Convert.ToInt32(row["Registro"]),
                    IdCambio = Guid.Parse(row["id_cambio"].ToString()),
                    Fecha = Convert.ToDateTime(row["Fecha"]),
                    Usuario = row["Entidad"].ToString(),
                    Tipo = row["Tipo"].ToString()
                });
            }

            return cambios;
        }
    }
}