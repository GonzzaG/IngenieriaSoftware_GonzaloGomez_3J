using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IngenieriaSoftware.BEL
{
    public class Empleado
    {
        public string Nombre { get; set; }
        public string Password { get; set; }

        public Constantes.TipoEmpleado TipoEmpleado { get; set; }
    }
}
