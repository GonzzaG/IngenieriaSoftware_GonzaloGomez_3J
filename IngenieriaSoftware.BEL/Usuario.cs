using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IngenieriaSoftware.BEL
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string _passwordHash;

        public Constantes.Categoria Categoria { get; set; } = Constantes.Categoria.Ninguna;

        public List<Permiso> Permisos { get; set; }
    }
}
