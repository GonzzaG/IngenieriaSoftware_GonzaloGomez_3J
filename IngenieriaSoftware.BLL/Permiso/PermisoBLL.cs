using IngenieriaSoftware.BEL;
using IngenieriaSoftware.DAL;
using IngenieriaSoftware.Servicios;
using System.Collections.Generic;

namespace IngenieriaSoftware.BLL
{
    public class PermisoBLL
    {
        private readonly PermisoDAL _permisoDAL;

        public PermisoBLL()
        {
            _permisoDAL = new PermisoDAL();
        }
        public List<PermisoDTO> ObtenerPermisosDelUsuario(string pUserName) // Cambiado a PermisoDTO
        {
            List<PermisoDTO> permisosUsuario = _permisoDAL.ObtenerPermisosDelUsuarioPorUsername(pUserName);
            return permisosUsuario;
        }
    }
}