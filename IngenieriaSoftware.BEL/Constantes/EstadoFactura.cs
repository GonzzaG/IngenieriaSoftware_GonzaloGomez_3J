using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IngenieriaSoftware.BEL.Constantes
{
    public class EstadoFactura
    {
        public enum Estado
        {
            Solicitada = 0,
            PendienteDePago = 1,
            Pagada = 2,
            Entregada = 3
        };

    }
}
