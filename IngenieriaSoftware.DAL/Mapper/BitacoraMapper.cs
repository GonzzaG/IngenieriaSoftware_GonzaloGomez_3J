using IngenieriaSoftware.BEL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IngenieriaSoftware.DAL.Mapper
{
    public class BitacoraMapper
    {
        public List<Bitacora> MapearBitacoraDesdeDataSet(DataSet pDS)
        {
            List<Bitacora> lista = new List<Bitacora>();
            if (pDS != null && pDS.Tables.Count > 0)
            {
                foreach (DataRow row in pDS.Tables[0].Rows)
                {
                    Bitacora bitacora = new Bitacora
                    {
                        FechaHora = Convert.ToDateTime(row["FechaHora"]),
                        Usuario = row["Usuario"].ToString(),
                        Actividad = row["Actividad"].ToString(),
                        InfoAdicional = row["InfoAdicional"].ToString(),
                        Controller = row.IsNull("Controller") ? null : row["Controller"].ToString()
                    };
                    lista.Add(bitacora);
                }
            }
            return lista;
        }
    }
}
