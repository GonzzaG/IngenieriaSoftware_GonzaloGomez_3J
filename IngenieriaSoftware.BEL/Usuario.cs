using IngenieriaSoftware.Servicios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IngenieriaSoftware.BEL
{
    public class Usuario : IUsuario
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string _passwordHash;
        public DateTime FechaCreacion { get; set; } 

        public Constantes.Categoria Categoria { get; set; } = Constantes.Categoria.Ninguna;

        public List<IPermiso> Permisos { get; set; } = new List<IPermiso>();
    }
}
