using System.Collections.Generic;

namespace IngenieriaSoftware.Servicios
{
    public class PermisoChecker
    {
        public static bool TienePermiso(List<PermisoDTO> permisosUsuario, string codPermisoRequerido)
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

        private static bool VerificarPermiso(PermisoDTO permiso, string codPermisoRequerido)
        {
            // Si el permiso está habilitado y coincide con el código requerido, se concede el acceso.
            if (permiso.Habilitado && permiso.CodPermiso == codPermisoRequerido)
            {
                return true;
            }

            // Verificar permisos hijos si los hay
            if (permiso.permisosHijos != null)
            {
                foreach (var permisoHijo in permiso.permisosHijos)
                {
                    if (VerificarPermiso(permisoHijo, codPermisoRequerido))
                    {
                        return true;
                    }
                }
            }

            return false;
        }
    }
}