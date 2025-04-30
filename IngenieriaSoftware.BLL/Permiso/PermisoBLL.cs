using IngenieriaSoftware.BEL;
using IngenieriaSoftware.DAL;
using IngenieriaSoftware.Servicios;
using System;
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

        public List<PermisoDTO> ObtenerTodosLosRoles()
        {
            return _permisoDAL.ObtenerTodosLosRoles();
        }
        public List<PermisoDTO> ObtenerTodosLosPermisos()
        {
            return _permisoDAL.ObtenerTodosLosPermisos();
        }

        public void CrearRol(string nombreRol)
        {
            _permisoDAL.CrearRol(nombreRol);
            new BackupManager().RealizarBackup();
        }
        public string EliminarRol(int rolId)
        {
            string mensaje = _permisoDAL.EliminarRol(rolId);
            new BackupManager().RealizarBackup();
            return mensaje;
        }
        public void AsignarRolARol(int rolPadreId, int rolHijoId)
        {
            _permisoDAL.AsignarRolARol(rolPadreId, rolHijoId);     
            new BackupManager().RealizarBackup();
        }
        public void AsignarPermisoARol(int rolId, int permisoId)
        {
            _permisoDAL.AsignarPermisoARol(rolId, permisoId);   
        }
        public string DesasignarRolAUsuario(int usuarioId)
        {
            return _permisoDAL.DesasignarRolAUsuario(usuarioId); 
        }
        public string DesasignarRolARol(int rolPadreId, int rolHijoId)
        {
            return _permisoDAL.DesasignarRolARol(rolPadreId, rolHijoId);
        }
        public string DesasignarPermisoDeRol(int rolPadreId, int rolHijoId)
        {
            return _permisoDAL.DesasignarPermisoDeRol(rolPadreId, rolHijoId);
        }
        public string AsignarRolAUsuario(int usuarioId, int rolId)
        {
            string mensaje = _permisoDAL.AsignarRolAUsuario(usuarioId, rolId);
            new BackupManager().RealizarBackup();
            return mensaje;
        }
        public List<PermisoDTO> ObtenerPermisosDelUsuario(string pUserName) 
        {
            List<PermisoDTO> permisosUsuario = _permisoDAL.ObtenerPermisosDelUsuarioPorUsername(pUserName);
            return permisosUsuario;
        }
        public List<PermisoDTO> ObtenerPermisosUsuario(int usuarioId) 
        {
            return _permisoDAL.ObtenerPermisosUsuario(usuarioId);          
        }

        public List<PermisoDTO> ObtenerPermisosDelRol(string nombreRol)
        {
            return _permisoDAL.ObtenerPermisosDelRol(nombreRol);
        }
        public List<PermisoDTO> ObtenerPermisosDelRolPorId(int rolId)
        {
            return _permisoDAL.ObtenerPermisosDelRolPorId(rolId);
        }

        public List<PermisoDTO> CargarPermisos()
        {
            var permisos = _permisoDAL.CargarPermisosTreeView2();
      
            if (permisos == null)
            {
                throw new Exception("No hay usuarios almacenados");
            }
            else
            {
                return permisos;
            }
        }

        public void AsignarPermisoPorCod(string username, string permisoCod)
        {
            try
            {
                _permisoDAL.AsignarPermisoPorCod(username, permisoCod);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<PermisoDTO> AsignarPermisoUsuario(int permisoId, UsuarioDTO usuario)
        {      
            var permiso = _permisoDAL.BuscarPermisoPorId(usuario.Permisos, permisoId);

            if (permiso != null)
            {
                throw new Exception($"{usuario.Username} ya tiene el permiso {permiso.Nombre}");
            }
            else
            {
                try
                {
                    _permisoDAL.AsignarPermiso(usuario.Id, permisoId);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }

            return usuario.Permisos;
        }
        public void DesasignarPermisoUsuario(int usuarioId, int permisoId)
        {
            try
            {
                _permisoDAL.DesasignarPermiso(usuarioId, permisoId);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool TienePermiso(UsuarioDTO usuario, PermisoDTO permisoAAsignar)
        {
            if (usuario == null || usuario.Permisos == null)
                return false;
            bool PermisoEnJerarquia(List<PermisoDTO> permisos, int permisoId)
            {
                foreach (var permiso in permisos)
                {
                    if (permiso.Id == permisoId)
                        return true;

                    if (permiso.permisosHijos != null && PermisoEnJerarquia(permiso.permisosHijos, permisoId))
                        return true;
                }
                return false;
            }

            return PermisoEnJerarquia(usuario.Permisos, permisoAAsignar.Id);
        }

    }
}