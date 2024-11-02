using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IngenieriaSoftware.Servicios
{
    public class UsuarioDTO
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string _passwordHash;
        public DateTime FechaCreacion { get; set; }
        public List<PermisoDTO> Permisos { get; set; } = new List<PermisoDTO>();
        public int IdiomaId { get; set; }

    }
}
