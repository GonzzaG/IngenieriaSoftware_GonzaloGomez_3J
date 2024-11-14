using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IngenieriaSoftware.BEL.Negocio
{
    public class Notificacion
    {
        public int NotificacionId { get; set; }
        public int ComandaId { get; set; }
        public int MesaId { get; set; }
        public bool Visto { get; set; } 
    }
}
