using IngenieriaSoftware.BEL;
using System.Collections.Generic;

namespace IngenieriaSoftware.BLL
{
    public class PermisoBLL
    {
        private readonly Dictionary<int, List<Permiso>> _permisosPorUsuario = new Dictionary<int, List<Permiso>>();
    }
}