using IngenieriaSoftware.BEL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IngenieriaSoftware.Servicios
{
    public interface IPermisoService
    {
        void AsignarPermiso(int usuarioId, Permiso permiso);
        List<Permiso> ObtenerPermisosDelUsuario(Usuario pUsuario);
    }
}
