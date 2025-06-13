using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IngenieriaSoftware.BEL.Auditoria
{
    public class PeticionRestauracionModel
    {
        public int Id { get; set; }
        public string Tabla { get; set; }
        public int IdEntidad { get; set; }
        public int Version { get; set; }
        public int SolicitadoPor { get; set; }
        public DateTime FechaSolicitud { get; set; }
        public string Estado { get; set; }
        public int? ProcesadoPor { get; set; }
        public DateTime? FechaProcesado { get; set; }
        public string Comentario { get; set; }
    }
}
