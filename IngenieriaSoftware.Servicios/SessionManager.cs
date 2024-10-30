using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IngenieriaSoftware.Servicios
{
    public class SessionManager 
    {
        public static object _lock = new Object();

        private static SessionManager _Session;

        public IUsuario Usuario { get; set; }

        public DateTime FechaInicio { get; set; }
        public static IUsuario UsuarioActual
        {
            get
            {
                if (_Session == null) throw new Exception("Sesión no iniciada.");
                return _Session.Usuario;
            }
        }

        public static SessionManager GetInstance
        {
            get
            {
                if (_Session == null) throw new Exception("Sesion no iniciada.");

                return _Session;
            }

        }

        public static void LogIn(IUsuario pUsuario)
        {
            lock (_lock)
            {
                if (_Session == null)
                {
                    _Session = new SessionManager
                    {
                        Usuario = pUsuario,
                        FechaInicio = DateTime.Now
                    };
                }
                else
                {
                    //throw new Exception("Sesion ya iniciada.");
                }
            }


        }

        public static void LogOut()
        {
            lock (_lock)
            {
                if (_Session != null)
                {
                    _Session = null;
                }
                else
                {
                    throw new Exception("Sesion no iniciada.");
                }
            }
        }

        private SessionManager()
        {

        }

    }
}
