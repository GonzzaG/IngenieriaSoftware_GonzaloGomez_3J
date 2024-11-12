using IngenieriaSoftware.BEL;
using IngenieriaSoftware.Servicios.DTOs;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IngenieriaSoftware.DAL.Mapper
{
    public class MesaMapper
    {
        public List<Mesa> MapearMesasDesdeDataSet(DataSet pDs)
        {
            List<Mesa> mesas = new List<Mesa>();
            foreach (DataRow row in pDs.Tables[0].Rows)
            {
                Mesa mesa = new Mesa();
                mesa.MesaId = (int)row["mesa_id"];
                mesa.CapacidadMaxima = (int)row["capacidadMaxima"];
                var numEstadoMesa = int.Parse(row["estado_mesa"].ToString());
                mesa.EstadoMesa = (EstadoMesa.Estado)numEstadoMesa;
                mesas.Add(mesa);
            }
            return mesas;
        }

    }
}
