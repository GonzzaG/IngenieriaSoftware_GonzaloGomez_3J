using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IngenieriaSoftware.BEL.Negocio
{
    public class Comanda
    {
        public int ComandaId { get; set; }
        public int MesaId { get; set; }
        public DateTime FechaHoraCreacion { get; set; }
        public List<ComandaProducto> Productos { get; set; } = new List<ComandaProducto>();
    }
}
