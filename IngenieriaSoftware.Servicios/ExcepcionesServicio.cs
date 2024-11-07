using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IngenieriaSoftware.Servicios
{
    public class FalloCredencialesException : ExcepcionTraducible
    {
        public FalloCredencialesException() : base(100, "Fallo en las credenciales.") { }
    }
    public class UsuarioNoEncontradoException : ExcepcionTraducible
    {
        public UsuarioNoEncontradoException() : base(101, "Usuario no encontrado.") { }
    }
}
