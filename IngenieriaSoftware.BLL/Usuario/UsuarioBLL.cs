using IngenieriaSoftware.DAL;
using IngenieriaSoftware.Servicios;
using System;
using System.Collections.Generic;

namespace IngenieriaSoftware.BLL
{
    public class UsuarioBLL
    {
        private UsuarioDAL _usuarioDAL = new UsuarioDAL();
        private List<PermisoDTO> _permisoRaiz = new List<PermisoDTO>(); // Cambiado a PermisoDTO

        #region Eliminar Usuarios Metodos

        public List<UsuarioDTO> EliminarUsuario(List<UsuarioDTO> usuarios, string usuarioAEliminarNombre)
        {
            try
            {
                UsuarioDTO usuarioAEliminar = usuarios.Find(u => u.Username == usuarioAEliminarNombre);
                //eliminar usuario en bd
                _usuarioDAL.EliminarUsuario(usuarioAEliminar.Id);

                //eliminar usuario de lista
                usuarios.Remove(usuarioAEliminar);
                return usuarios;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion Eliminar Usuarios Metodos

        #region Usuarios permisos Metodos

        public List<PermisoDTO> ObtenerPermisosDelUsuarioEnMemoria(string pUserName) // Cambiado a PermisoDTO
        {
            var permisosUsuario = _usuarioDAL.ObtenerPermisosDelUsuarioEnMemoria(pUserName);
            return permisosUsuario;
        }

        public List<PermisoDTO> CargarPermisosDelUsuario(string pUserName) // Cambiado a PermisoDTO
        {
            List<PermisoDTO> permisosUsuario = _usuarioDAL.ObtenerPermisosDelUsuarioEnMemoria(pUserName);
            return permisosUsuario;
        }

        public List<PermisoDTO> ObtenerPermisosDelUsuario(string pUserName) // Cambiado a PermisoDTO
        {
            List<PermisoDTO> permisosUsuario = _usuarioDAL.ObtenerPermisosDelUsuarioPorUsername(pUserName);
            return permisosUsuario;
        }

        public List<UsuarioDTO> CargarUsuarios()
        {
            List<UsuarioDTO> _usuariosGlobales = _usuarioDAL.ObtenerTodosLosUsuarios();

            if (_usuariosGlobales == null)
            {
                throw new Exception("No hay usuarios almacenados");
            }
            else
            {
                return _usuariosGlobales;
            }
        }

        public List<UsuarioDTO> CargarUsuariosPermisos()
        {
            List<UsuarioDTO> _usuariosGlobales = _usuarioDAL.CargarUsuariosPermisos();

            if (_usuariosGlobales == null)
            {
                throw new Exception("No hay usuarios almacenados");
            }
            else
            {
                return _usuariosGlobales;
            }
        }

        public List<PermisoDTO> ObtenerPermisosGlobales() // Cambiado a PermisoDTO
        {
            return _usuarioDAL.PermisosTree();
        }

        public List<PermisoDTO> AsignarPermisoUsuario(int permisoId, string username) // Cambiado a PermisoDTO
        {
            var permisosGlobales = _usuarioDAL.PermisosGlobales();

            PermisoDTO permiso = permisosGlobales.Find(p => p.Id == permisoId); // Cambiado a PermisoDTO

            var usuario = _usuarioDAL.ObtenerUsuariosGlobales().Find(u => u.Username == username);

            if (_usuarioDAL.TienePermiso(usuario, permiso)) // Este método debería adaptarse para usar PermisoDTO
            {
                throw new Exception($"{username} ya tiene el permiso {permiso.Nombre}");
            }
            else
            {
                try
                {
                    // Si no tiene el permiso, se lo asignamos en base de datos
                    _usuarioDAL.AsignarPermiso(usuario.Id, permisoId);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }

            return usuario.Permisos; // Este debería ser adaptado para que devuelva permisos de tipo PermisoDTO
        }

        public void AsignarPermisoPorCod(string username, string permisoCod)
        {
            try
            {
                _usuarioDAL.AsignarPermisoPorCod(username, permisoCod);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void DesasignarPermisoUsuario(string username, int permisoId)
        {
            try
            {
                _usuarioDAL.DesasignarPermiso(username, permisoId);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion Usuarios permisos Metodos

        #region Login LogOut

        public bool RegistrarUsuario(UsuarioDTO pUsuario, DateTime FechaInicio)
        {
            UsuarioDTO mUsuario = _usuarioDAL.ObtenerUsuarioPorNombre(pUsuario.Username);

            if (mUsuario == null)
            {
                int resultado = _usuarioDAL.GuardarUsuario(pUsuario, FechaInicio);
                return resultado > 0;
            }
            else
            {
                throw new Exception($"El username {pUsuario.Username} ya existe");
            }
        }

        public bool LogIn(string username, string password)
        {
            UsuarioDTO mUsuario = _usuarioDAL.ObtenerUsuarioPorNombre(username);

            if (mUsuario != null)
            {
                string storedHash = mUsuario._passwordHash;

                if (HashingManager.VerificarHash(password, storedHash))
                {
                    UsuarioDTO usuario = new UsuarioDTO 
                    { 
                        Id = mUsuario.Id, Username = mUsuario.Username,
                        FechaCreacion = mUsuario.FechaCreacion,
                        IdiomaId = mUsuario.IdiomaId,
                        Permisos = mUsuario.Permisos,   
                        _passwordHash = mUsuario._passwordHash
                    };
                    SessionManager.LogIn(usuario);
                    return true; // Login exitoso
                }
            }

            return false; // Usuario no encontrado o contraseña incorrecta
        }

        public void LogOut()
        {
            SessionManager.LogOut();
        }

        #endregion Login LogOut
    }
}