using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IngenieriaSoftware.BEL
{
    public class AuditoriaRegistro
    {
        public Guid IdCambio { get; set; }
        public DateTime Fecha { get; set; }
        public string Usuario { get; set; }
        public string Tipo { get; set; } // Insert (I), Update (U), Delete (D), Restore (R)

    }
}
