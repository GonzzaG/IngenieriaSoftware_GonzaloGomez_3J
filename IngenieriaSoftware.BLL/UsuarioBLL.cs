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

        public List<Permiso> ObtenerPermisosDelUsuario(string pUserName)
        {
            var permisosUsuario = _usuarioDAL.ObtenerPermisosDelUsuario(pUserName);

            return permisosUsuario;
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

        public Permiso ObtenerPermisoPorId(int permisoId, string username)
        {
            var permisosGlobales = _usuarioDAL.PermisosGlobales();
            
            Permiso permiso = permisosGlobales.Find(p => p.Id == permisoId);

//            var usuario = _usuarioDAL.UsuariosGlobales().Find(u => u.Username == username);
                // encontre el usuario y el permiso, deberia verificar si el permiso ya se encuentra en el usuario para asi asignarlo en bd

            var permisosUsuario = _usuarioDAL.ObtenerPermisosDelUsuario(username);

            return permiso;
        }


        #region Login LogOut
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
        #endregion
    }
}
