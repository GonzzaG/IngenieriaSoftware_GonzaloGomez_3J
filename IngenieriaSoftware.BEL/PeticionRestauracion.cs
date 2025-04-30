using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IngenieriaSoftware.BEL
{
    public class PeticionRestauracion
    {
        public int IdPeticion { get; set; }
        public string Tabla { get; set; }
        public DateTime FechaSolicitud { get; set; }
        public string UsuarioSolicitante { get; set; }
        public string Estado { get; set; }
        public int Registro { get; set; }
        public string Comentario { get; set; }
        public Guid IdCambioOrigen { get; set; }
    }
}
