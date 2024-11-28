using IngenieriaSoftware.DAL;
using IngenieriaSoftware.Servicios;
using IngenieriaSoftware.Servicios.Interfaces;
using System;
using System.Collections.Generic;

namespace IngenieriaSoftware.BLL
{
    public class AuthService
    {
        private readonly PermisoBLL _permisoBLL;

        private readonly UsuarioBLL _usuarioBLL;
        private static List<PermisoDTO> _permisos { get; set; }
        public static List<PermisoDTO> PermisosUsuario {  get { return _permisos; } set { _permisos = value; } }
        public AuthService()
        {
            _usuarioBLL = new UsuarioBLL();
            _permisos = new List<PermisoDTO>();
            _permisoBLL = new PermisoBLL();
        }

        public bool LogIn(string pNombreUsuario, string pContrasena)
        {
            try
            {
                UsuarioDTO _Usuario = new UsuarioDTO
                {
                    Username = pNombreUsuario,
                    _passwordHash = HashingManager.GenerarHash(pContrasena)
                };

                if (new UsuarioBLL().LogIn(_Usuario.Username, _Usuario._passwordHash))
                {
                    // SessionManager.LogIn(_Usuario);
                    _permisos = _permisoBLL.ObtenerPermisosDelUsuario(_Usuario.Username);
                

                    return true;
                }
                else
                {
                    throw new FalloCredencialesException();
                }
            }
            catch(Exception e)
            {
                throw e;
            }
        }

        public void LogOut()
        {
            try
            {
                SessionManager.LogOut();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool RegistrarUsuario(string pNombreUsuario, string pContrasena) //string categoria)
        {
            try
            {
                UsuarioDTO _Usuario = new UsuarioDTO
                {
                    Username = pNombreUsuario,
                    _passwordHash = HashingManager.GenerarHash(pContrasena),
                    IdiomaId = IdiomaData.IdiomaActual.Id
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
            catch(Exception ex)
            {
                throw ex;
            }
        }
    }
}