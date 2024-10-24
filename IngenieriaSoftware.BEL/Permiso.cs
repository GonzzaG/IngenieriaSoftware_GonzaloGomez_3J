using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IngenieriaSoftware.BEL
{
    public class Permiso
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public string TipoPermiso { get; set; } // Podrías usar un enum si deseas
        public bool Estado { get; set; } // Activo o inactivo
        public int? PermisoPadreId { get; set; } // Permiso padre (opcional)
    }
}
