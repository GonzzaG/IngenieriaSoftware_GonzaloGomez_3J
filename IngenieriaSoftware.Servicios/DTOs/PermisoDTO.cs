using System.Collections.Generic;

namespace IngenieriaSoftware.Servicios
{
    public class PermisoDTO
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string CodPermiso { get; set; }
        public bool EsRol { get; set; }
        public bool Habilitado { get; set; }
        public string TipoPermiso { get; set; } //ver si dejarlo o sacarlo
        public int? PermisoPadreId { get; set; }
        public List<PermisoDTO> permisosHijos { get; set; } = new List<PermisoDTO>();
        public List<UsuarioDTO> Usuarios { get; set; } = new List<UsuarioDTO>();
    }
}