using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IngenieriaSoftware.Servicios.DTOs
{
    public class TraduccionDTO
    {
        public int EtiquetaId { get; set; }
        public string Tag { get; set; }
        public string Texto { get; set; }
        public int IdiomaId {  get; set; }
    }
}
