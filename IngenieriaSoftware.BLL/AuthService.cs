﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
                Password = pContrasena
            };

            if (new UsuarioBLL().LogIn(_Usuario.Username, _Usuario.Password))
            {
                SessionManager.LogIn(_Usuario);

                return true;
            }
            else
            {
                throw new Exception("Fallo en las credenciales.");
            }

            //new UsuarioBLL().RegistrarUsuario(_Usuario, SessionManager.GetInstance);
        }

        public void LogOut()
        {
            SessionManager.LogOut();
        }
    }
}
