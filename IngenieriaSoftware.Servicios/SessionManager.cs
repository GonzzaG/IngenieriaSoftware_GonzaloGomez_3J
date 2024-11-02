using System;

namespace IngenieriaSoftware.Servicios
{
    public class SessionManager
    {
        public static object _lock = new Object();
        private static SessionManager _Session;

        // Cambia la propiedad para usar UsuarioDTO en lugar de IUsuario
        public UsuarioDTO Usuario { get; private set; }

        public DateTime FechaInicio { get; private set; }

        public UsuarioDTO ObtenerUsuarioActual()
        {
            if (_Session == null || _Session.Usuario == null)
                throw new Exception("Sesión no iniciada.");

            // Retorna el UsuarioDTO actual
            return _Session.Usuario;
        }

        public static UsuarioDTO UsuarioActual
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
                if (_Session == null) throw new Exception("Sesión no iniciada.");
                return _Session;
            }
        }

        public static void LogIn(UsuarioDTO pUsuario)
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
                    throw new Exception("Sesión ya iniciada.");
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
                    throw new Exception("Sesión no iniciada.");
                }
            }
        }

        private SessionManager()
        {
        }
    }
}
