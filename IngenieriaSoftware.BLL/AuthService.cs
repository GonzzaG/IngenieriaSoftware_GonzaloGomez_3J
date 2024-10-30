using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IngenieriaSoftware.BEL;
using IngenieriaSoftware.Servicios;

namespace IngenieriaSoftware.BLL
{
    public class AuthService
    {
        public bool LogIn(string pNombreUsuario, string pContrasena)
        {
            Usuario _Usuario = new Usuario
            {
                Username = pNombreUsuario,
                _passwordHash = HashingManager.GenerarHash(pContrasena)
            };

            if (new UsuarioBLL().LogIn(_Usuario.Username, _Usuario._passwordHash))
            {
                SessionManager.LogIn(_Usuario);

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
            Usuario _Usuario = new Usuario
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
