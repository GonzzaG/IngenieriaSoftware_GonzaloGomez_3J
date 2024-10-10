﻿using IngenieriaSoftware.DAL;
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

        // Método para registrar un nuevo usuario
        public bool RegistrarUsuario(Usuario pUsuario)
        {       
            // Guardar el nuevo usuario en la base de datos
            int resultado = _usuarioDAL.GuardarUsuario(pUsuario);

            // Retorna true si el registro fue exitoso
            return resultado > 0;
        }

        // Método para iniciar sesión
        public bool LogIn(string username, string password)
        {
            // Obtener el usuario por su nombre
            var userRow = _usuarioDAL.ObtenerUsuarioPorNombre(username);

            if (userRow != null)
            {
                // Verificar si la contraseña coincide
                string storedHash = userRow["PasswordHash"].ToString();

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
