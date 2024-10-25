using IngenieriaSoftware.BEL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IngenieriaSoftware.Servicios
{
    public class PermisoService : IPermisoService
    {
        private readonly IPermisoService _permisoManager;

        public PermisoService(IPermisoService permisoService)
        {
            _permisoManager = permisoService;
        }

        // Método para asignar un permiso a un usuario
        public void AsignarPermiso(int usuarioId, Permiso permiso)
        {
            _permisoManager.AsignarPermiso(usuarioId, permiso);
        }

        public List<Permiso> ObtenerPermisosDelUsuario(Usuario pUsuario)
        {
            return _permisoManager.ObtenerPermisosDelUsuario(pUsuario);
        }

  

    }
}
