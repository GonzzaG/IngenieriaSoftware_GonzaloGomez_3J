using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IngenieriaSoftware.BEL
{
    public class EstadoMesa
    {
        public enum Estado 
        {
            Desocupada = 0,
            Ocupada = 1,
            Cerrada = 2,
            FueraDeServicio = 3
        }
    }
}
