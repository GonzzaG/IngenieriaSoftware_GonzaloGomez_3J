using IngenieriaSoftware.BEL;
using System.Collections.Generic;

namespace IngenieriaSoftware.BLL
{
    public class UsuarioManager
    {
        private static UsuarioManager _instance;
        private static readonly object _lock = new object();

        private List<Usuario> _usuariosGlobales;

        private UsuarioManager()
        {
            _usuariosGlobales = new List<Usuario>(); // Inicializa la lista vacía
        }

        // Implementación del patrón Singleton
        public static UsuarioManager Instance
        {
            get
            {
                lock (_lock)
                {
                    if (_instance == null)
                    {
                        _instance = new UsuarioManager();
                    }
                    return _instance;
                }
            }
        }

        public List<Usuario> ObtenerUsuariosGlobales()
        {
            return _usuariosGlobales;
        }

        public Usuario ObtenerUsuarioPorNombre(string nombreUsuario)
        {
            return _usuariosGlobales.Find(u => u.Username == nombreUsuario);
        }

        public void CargarUsuarios(List<Usuario> usuarios)
        {
            _usuariosGlobales = usuarios;
        }
    }
}
