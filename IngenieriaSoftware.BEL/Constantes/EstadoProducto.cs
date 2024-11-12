using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IngenieriaSoftware.BEL.Constantes
{
    public class EstadoProducto
    {
        public enum Estado
        {
            Propuesta = 0,
            Pendiente = 1,
            En_Preparacion = 2,
            Lista = 3,
            Entregada = 4
        };
    }
}
