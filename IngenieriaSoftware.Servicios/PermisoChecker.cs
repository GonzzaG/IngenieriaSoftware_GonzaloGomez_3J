using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IngenieriaSoftware.Servicios
{

    public class PermisoChecker 
    {

        public static bool TienePermiso(List<IPermiso> permisosUsuario, string codPermisoRequerido)
        {
            foreach (var permiso in permisosUsuario)
            {
                if (VerificarPermiso(permiso, codPermisoRequerido))
                {
                    return true;
                }
            }
            return false;
        }

        private static bool VerificarPermiso(IPermiso permiso, string codPermisoRequerido)
        {
            // Si el permiso es un rol o está habilitado y coincide con el código requerido, se concede el acceso.
            if (permiso.Habilitado && permiso.CodPermiso == codPermisoRequerido)
            {
                return true;
            }

            // Verificar permisos hijos si los hay
            foreach (var permisoHijo in permiso.permisosHijos)
            {
                if (VerificarPermiso(permisoHijo, codPermisoRequerido))
                {
                    return true;
                }
            }

            return false;
        }
    }
}
