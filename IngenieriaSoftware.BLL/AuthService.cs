using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IngenieriaSoftware.Servicios;

namespace IngenieriaSoftware.BLL
{
    public class AuthService
    {
        public void LogIn(string pNombreUsuario, string pContrasena)
        {
            Usuario _Usuario = new Usuario
            {
                Username = pNombreUsuario,
                Password = pContrasena
            };

            SessionManager.LogIn(_Usuario);
        }

        public void LogOut()
        {
            SessionManager.LogOut();
        }
    }
}
