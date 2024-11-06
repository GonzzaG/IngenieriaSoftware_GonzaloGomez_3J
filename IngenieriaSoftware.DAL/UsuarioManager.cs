using System;
using System.Collections.Generic;
using IngenieriaSoftware.BEL;
using IngenieriaSoftware.DAL;

namespace IngenieriaSoftware.BLL
{
    public class UsuarioManager
    {
        private readonly UsuarioDAL _usuarioDAL;
        private static UsuarioManager _instance;
        private static readonly object _lock = new object();

        // Propiedades estáticas para listas de usuarios y permisos globales (Singletons)
        private static List<Usuario> _usuariosGlobales;
        private static List<Permiso> _permisosGlobales;

        // Constructor privado para el patrón Singleton
        private UsuarioManager()
        {
            _usuarioDAL = new UsuarioDAL();
            _usuariosGlobales = _usuarioDAL.CargarUsuariosPermisos(); // Carga inicial
            _permisosGlobales = _usuarioDAL.PermisosGlobales();
        }

        public static List<Usuario> ObtenerUsuarios()
        {
            // Retorna la lista de usuarios globales
            return _usuariosGlobales;
        }

        public static void ActualizarUsuariosGlobales(List<Usuario> usuarios)
        {
            // Actualiza la lista de usuarios globales con la nueva lista
            _usuariosGlobales = usuarios;
        }

        public static void AgregarUsuarioGlobal(Usuario usuario)
        {
            // Agrega un usuario a la lista global
            _usuariosGlobales.Add(usuario);
        }
        // Método para obtener la instancia única de UsuarioManager
        public static UsuarioManager Instance
        {
            get
            {
                if (_instance == null)
                {
                    lock (_lock)
                    {
                        if (_instance == null)
                        {
                            _instance = new UsuarioManager();
                        }
                    }
                }
                return _instance;
            }
        }

        // Propiedad de acceso a la lista de usuarios globales
        public List<Usuario> UsuariosGlobales
        {
            get
            {
                if (_usuariosGlobales == null)
                {
                    _usuariosGlobales = _usuarioDAL.CargarUsuariosPermisos();
                }
                return _usuariosGlobales;
            }
        }

        // Propiedad de acceso a la lista de permisos globales
        public List<Permiso> PermisosGlobales
        {
            get
            {
                if (_permisosGlobales == null)
                {
                    _permisosGlobales = _usuarioDAL.PermisosGlobales();
                }
                return _permisosGlobales;
            }
        }

        // Método para obtener permisos de un usuario específico
        public List<Permiso> ObtenerPermisosDelUsuario(string nombreUsuario)
        {
            var usuario = UsuariosGlobales.Find(u => u.Username == nombreUsuario);
            return usuario?.Permisos ?? new List<Permiso>();
        }

        // Método para guardar usuario
        public bool GuardarUsuario(Usuario usuario, DateTime fechaInicio)
        {
            var resultado = _usuarioDAL.GuardarUsuario(usuario, fechaInicio);
            if (resultado > 0)
            {
                _usuariosGlobales.Add(usuario); // Actualiza el Singleton de usuarios
                return true;
            }
            return false;
        }

        // Método para asignar permiso a usuario
        public void AsignarPermisoAUsuario(string nombreUsuario, Permiso permiso)
        {
            var usuario = UsuariosGlobales.Find(u => u.Username == nombreUsuario);
            if (usuario != null && !usuario.Permisos.Contains(permiso))
            {
                usuario.Permisos.Add(permiso);
                _usuarioDAL.RelacionarUsuariosPermisos(UsuarioDAL.UsuariosPermisosDataSet);
            }
        }
    }
}
