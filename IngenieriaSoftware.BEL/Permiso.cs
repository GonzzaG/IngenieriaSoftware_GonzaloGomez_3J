using IngenieriaSoftware.Servicios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IngenieriaSoftware.BEL
{
    public class Permiso : IPermiso
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string CodPermiso { get; set; }
        public bool EsRol {  get; set; }    
        public bool Habilitado {  get; set; }    

        public string TipoPermiso { get; set; } // Podría usar un enum
        public int? PermisoPadreId { get; set; } // Permiso padre (opcional)

        // Composicion donde un permiso puede tener muchos permisos
        //public List<Permiso> permisosHijos { get; set; } = new List<Permiso>();

        public List<IPermiso> permisosHijos { get; set; } = new List<IPermiso>();

        //relacion de muchos a muchos con usuarios
        public List<Usuario> Usuarios { get; set; } = new List<Usuario>();
    }
}
