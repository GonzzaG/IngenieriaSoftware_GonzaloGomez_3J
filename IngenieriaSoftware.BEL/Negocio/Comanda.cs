using IngenieriaSoftware.BEL.Constantes;
using System;
using System.Collections.Generic;

namespace IngenieriaSoftware.BEL.Negocio
{
    public class Comanda
    {
        public int ComandaId { get; set; }
        public int MesaId { get; set; }
        public DateTime FechaHoraCreacion { get; set; }
        public EstadoComanda.Estado EstadoComanda { get; set; }
        public List<ComandaProducto> Productos { get; set; } = new List<ComandaProducto>();
    }
}
