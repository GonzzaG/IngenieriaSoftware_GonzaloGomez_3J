using IngenieriaSoftware.BEL.Negocio;
using System;
using System.Collections.Generic;
using System.Data;

namespace IngenieriaSoftware.DAL.Mapper
{
    public class NotificacionMapper
    {
        public List<Notificacion> MapearComandasDesdeDataSet(DataSet mDs)
        {
            List<Notificacion> notificaciones = new List<Notificacion>();

            if (mDs.Tables.Count > 0 && mDs.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow row in mDs.Tables[0].Rows)
                {
                    notificaciones.Add(new Notificacion
                    {
                        NotificacionId = Convert.ToInt32(row["notificacion_id"]),
                        ComandaId = Convert.ToInt32(row["comanda_id"]),
                        MesaId = Convert.ToInt32(row["mesa_id"]),
                        Visto = (bool)row["visto"]
                    });
                }
            }

            return notificaciones;
        }
    }
}