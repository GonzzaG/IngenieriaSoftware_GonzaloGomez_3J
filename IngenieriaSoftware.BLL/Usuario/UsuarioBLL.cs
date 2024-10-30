using IngenieriaSoftware.DAL;
using IngenieriaSoftware.BEL;
using IngenieriaSoftware.Servicios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;


namespace IngenieriaSoftware.BLL
{
    public class UsuarioBLL
    {
        private UsuarioDAL _usuarioDAL = new UsuarioDAL();
        private List<Permiso> _permisoRaiz = new List<Permiso>();

        #region Eliminar Usuarios Metodos
        public List<Usuario> EliminarUsuario(List<Usuario> usuarios, string usuarioAEliminarNombre)
        {
            try
            {
                Usuario usuarioAEliminar = usuarios.Find(u => u.Username == usuarioAEliminarNombre);
                //eliminar usuario en bd
                _usuarioDAL.EliminarUsuario(usuarioAEliminar.Id);

                //eliminar usuario de lista
                usuarios.Remove(usuarioAEliminar);
                return usuarios;

            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        #endregion


        #region Usuarios permisos Metodos
        public List<Permiso> ObtenerPermisosDelUsuarioEnMemoria(string pUserName)
        {
           // var permisos;
            var permisosUsuario = _usuarioDAL.ObtenerPermisosDelUsuarioEnMemoria(pUserName);

            return permisosUsuario;
        }

        public List<Permiso> CargarPermisosDelUsuario(string pUserName)
        {
            
            // var permisos;
            var permisosUsuario = _usuarioDAL.ObtenerPermisosDelUsuarioEnMemoria(pUserName);

            return permisosUsuario;
        }

        public List<Permiso> ObtenerPermisosDelUsuario(string pUserName)
        {
            List<Permiso> permisosUsuario= _usuarioDAL.ObtenerPermisosDelUsuarioPorUsername(pUserName);

            return permisosUsuario;
        }

        public List<Usuario> CargarUsuarios()
        {
            List<Usuario> _usuariosGlobales = _usuarioDAL.ObtenerTodosLosUsuarios();

            if (_usuariosGlobales == null)
            {
                throw new Exception("No hay usuarios almacenados");
            }
            else
            {
                return _usuariosGlobales;
            }
        }

        // Metodo para obtener los usuarios con sus permisos
        public List<Usuario> CargarUsuariosPermisos()
        {
            List<Usuario> _usuariosGlobales = _usuarioDAL.CargarUsuariosPermisos();

            if (_usuariosGlobales == null)
            {
                throw new Exception("No hay usuarios almacenados");
            }
            else
            {
                return _usuariosGlobales;
            }
          
        }
        public List<Permiso> ObtenerPermisosGlobales()
        {
            return _usuarioDAL.PermisosTree();

        }

        public List<Permiso> AsignarPermisoUsuario(int permisoId, string username)
        {
            var permisosGlobales = _usuarioDAL.PermisosGlobales();
            
            Permiso permiso = permisosGlobales.Find(p => p.Id == permisoId);

            var usuario = _usuarioDAL.UsuariosGlobales().Find(u => u.Username == username);

            if(_usuarioDAL.TienePermiso(usuario, permiso))
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
                catch(Exception ex)
                {
                    throw ex;   
                }
            

            }

            return usuario.Permisos;
        }

        public void DesasignarPermisoUsuario (string username, int permisoId)
        {
            try
            {
                _usuarioDAL.DesasignarPermiso(username, permisoId);

            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        #endregion


        #region Login LogOut
        // Método para registrar un nuevo usuario
        public bool RegistrarUsuario(Usuario pUsuario, DateTime FechaInicio)
        {
            //Obtener el usuario por su nombre
            Usuario mUsuario = _usuarioDAL.ObtenerUsuarioPorNombre(pUsuario.Username);

            if (mUsuario == null)
            {
                // Si no encuentra el usuario en la bd, lo guarda en la base de datos
                int resultado = _usuarioDAL.GuardarUsuario(pUsuario, FechaInicio);

                // Retorna true si el registro fue exitoso
                return resultado > 0;
            }
            else
            {
                throw new Exception($"El username {pUsuario.Username} ya existe");
            }

        }

        // Método para iniciar sesión
        public bool LogIn(string username, string password)
        {
            //Obtener el usuario por su nombre
            Usuario mUsuario = _usuarioDAL.ObtenerUsuarioPorNombre(username);

            if (mUsuario != null)
            {
                // Verificar si la contraseña coincide
                string storedHash = mUsuario._passwordHash;

                if (HashingManager.VerificarHash(password, storedHash))
                {
                   // Contraseña correcta, iniciar sesión
                   Usuario usuario = new Usuario { Username = username };
                    SessionManager.LogIn(usuario);
                    return true; // Login exitoso
                }
            }

            return false; // Usuario no encontrado o contraseña incorrecta
        }

        // Método para cerrar sesión
        public void LogOut()
        {
            SessionManager.LogOut();
        }
        #endregion
    }
}
