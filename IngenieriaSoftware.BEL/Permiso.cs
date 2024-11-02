using IngenieriaSoftware.Abstracciones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IngenieriaSoftware.BEL
{
    public class Permiso: IPermiso
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string CodPermiso { get; set; }
        public bool EsRol { get; set; }
        public bool Habilitado { get; set; }
        public string TipoPermiso { get; set; } // ver si dejar o sacar
        public int? PermisoPadreId { get; set; } 

        public List<Permiso> permisosHijos { get; set; } = new List<Permiso>();

        public List<Usuario> Usuarios { get; set; } = new List<Usuario>();
    }
}
