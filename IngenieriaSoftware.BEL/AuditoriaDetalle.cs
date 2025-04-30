using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IngenieriaSoftware.BEL
{
    public class AuditoriaDetalle
    {
        public int IdAuditoria { get; set; }
        public string Tipo { get; set; }
        public string Tabla { get; set; }
        public int Registro { get; set; }
        public string Campo { get; set; }
        public string ValorAntes { get; set; }
        public string ValorDespues { get; set; }
        public DateTime Fecha { get; set; }
        public string Usuario { get; set; }
        public string PC { get; set; }
        public Guid IdCambio { get; set; }
    }
}
