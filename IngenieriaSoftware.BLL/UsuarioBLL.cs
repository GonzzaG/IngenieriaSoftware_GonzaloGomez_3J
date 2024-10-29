using IngenieriaSoftware.DAL;
using IngenieriaSoftware.BEL;
using IngenieriaSoftware.Servicios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace IngenieriaSoftware.BLL
{
    public class UsuarioBLL
    {
        private UsuarioDAL _usuarioDAL = new UsuarioDAL();
        private List<Permiso> _permisoRaiz = new List<Permiso>();

        public List<Permiso> ConstruirJerarquiaPermisosRaiz(List<Permiso> permisos)
        {
            // Filtrar y devolver solo los permisos que no tienen un padre (PermisoPadreId es null)
            _permisoRaiz = permisos.Where(p => p.PermisoPadreId == null).ToList();
            return _permisoRaiz;
        }
        public List<Permiso> ObtenerPermisosDelUsuario(string pUserName)
        {
            var permisosUsuario = _usuarioDAL.ObtenerPermisosDelUsuario(pUserName);

            return ConstruirJerarquiaPermisosRaiz(permisosUsuario);
        }

        public List<Permiso> ConstruirJerarquiaPermisos(List<Permiso> permisos)
        {
            // Filtrar y devolver solo los permisos que no tienen un padre (PermisoPadreId es null)
            _permisoRaiz = permisos.Where(p => p.PermisoPadreId == null).ToList();
            return _permisoRaiz;
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
            return _usuarioDAL.PermisosGlobales();

        }
        
      
            // Método para registrar un nuevo usuario
            public bool RegistrarUsuario(Usuario pUsuario, DateTime FechaInicio)
        {
            //Obtener el usuario por su nombre
            Usuario mUsuario = _usuarioDAL.ObtenerUsuarioPorNombre(pUsuario.Username);

            if (mUsuario == null)
            {
                //pUsuario.Password

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
    }
}
