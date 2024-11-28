using IngenieriaSoftware.BEL;
using IngenieriaSoftware.BEL.Constantes;
using IngenieriaSoftware.BEL.Negocio;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IngenieriaSoftware.DAL.Mapper
{
    public class MedioDePagoMapper
    {
        public List<MedioDePago> MapearMedioDePagoDesdeDataSet(DataSet mDs)
        {
            List<MedioDePago> mediosDePago = new List<MedioDePago>();

            if (mDs.Tables.Count > 0 && mDs.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow row in mDs.Tables[0].Rows)
                {
                    mediosDePago.Add(new MedioDePago
                    {
                        MedioDePagoId = Convert.ToInt32(row["MedioDePagoId"]),
                        Nombre = row["Nombre"].ToString(),
                        Estado = (bool)row["Estado"]
                    });
                }
            }

            return mediosDePago;
        }
    }
}
