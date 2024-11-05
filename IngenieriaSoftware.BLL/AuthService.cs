using IngenieriaSoftware.Servicios;
using System;

namespace IngenieriaSoftware.BLL
{
    public class AuthService
    {
        public bool LogIn(string pNombreUsuario, string pContrasena)
        {
            UsuarioDTO _Usuario = new UsuarioDTO
            {
                Username = pNombreUsuario,
                _passwordHash = HashingManager.GenerarHash(pContrasena)
            };

            if (new UsuarioBLL().LogIn(_Usuario.Username, _Usuario._passwordHash))
            {
                // SessionManager.LogIn(_Usuario);

                return true;
            }
            else
            {
                throw new Exception("Fallo en las credenciales.");
            }
        }

        public void LogOut()
        {
            SessionManager.LogOut();
        }

        public bool RegistrarUsuario(string pNombreUsuario, string pContrasena) //string categoria)
        {
            UsuarioDTO _Usuario = new UsuarioDTO
            {
                Username = pNombreUsuario,
                _passwordHash = HashingManager.GenerarHash(pContrasena)
            };

            if (new UsuarioBLL().RegistrarUsuario(_Usuario, DateTime.Now))
            {
                //SessionManager.LogIn(_Usuario);

                return true;
            }
            else
            {
                throw new Exception("Fallo en las credenciales.");
            }
        }
    }
}