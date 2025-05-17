using IngenieriaSoftware.BEL.Constantes;
using IngenieriaSoftware.BEL.Negocio;
using System;
using System.Collections.Generic;
using System.Data;

namespace IngenieriaSoftware.DAL.Mapper
{
    public class ComandaMapper
    {
        public List<Comanda> MapearComandasDesdeDataSet(DataSet mDs)
        {
            List<Comanda> comandas = new List<Comanda>();

            if (mDs.Tables.Count > 0 && mDs.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow row in mDs.Tables[0].Rows)
                {
                    comandas.Add(new Comanda
                    {
                        ComandaId = Convert.ToInt32(row["comanda_id"]),
                        MesaId = Convert.ToInt32(row["mesa_id"]),
                        FechaHoraCreacion = (DateTime)row["fecha_hora_creacion"],
                        EstadoComanda = (EstadoComanda.Estado)(int)row["estado"]
                    });
                }
            }

            return comandas;
        }
    }
}