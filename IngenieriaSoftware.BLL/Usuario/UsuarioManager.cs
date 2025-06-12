using IngenieriaSoftware.BEL;
using IngenieriaSoftware.BLL.Excepciones;
using IngenieriaSoftware.DAL;
using IngenieriaSoftware.Servicios;
using System;
using System.Collections.Generic;

namespace IngenieriaSoftware.BLL
{
    public class UsuarioManager
    {
        private static UsuarioManager _instance;
        private static readonly object _lock = new object();

        private List<Usuario> _usuariosGlobales;

        private readonly UsuarioDAL _usuarioDAL = new UsuarioDAL();

        public UsuarioManager()
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

        public bool VerificarIntegridad()
        {
            try
            {
                //busco todos los usuarios
                List<UsuarioDTO> usuarios = _usuarioDAL.ObtenerTodosLosUsuarios();
                string dvh;
                foreach (var user in usuarios)
                {
                    //calculo el dvh de cada usuario segun los valores de sus campos
                    dvh = user.GenerarDVHExtension();

                    //comparo el dvh calculado con el almacenado en la bd
                    if (!user.VerificarIntegridad(dvh))
                    {
                        //si no coinciden, lanzo la excepcion
                        throw new VerificarIntegridadException($"Hubo un error de integridad en la tabla: ", user.NombreTabla);
                    }
                }

                return true;
            }
            catch (VerificarIntegridadException ex)
            {
                throw new VerificarIntegridadException(ex.Message, ex.NombreTabla);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        /// <summary>
        /// metodo para crear un digito verificador horizontal
        /// </summary>
        /// <param name="usuario">Entidad para calcular su DVH</param>
        /// <returns>El DVH del usuario</returns>
        // Debo agregarlo al metood que guarda el usuario********
        public string GenerarDVHUsuario(Usuario usuario)
        {
            try
            {
                return usuario.GenerarDVHExtension();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        /// <summary>
        /// Metodo de prueba(SE DEBE BORRAR)
        /// </summary>
        /// <param name="usuario"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public bool GenerarDVHDeTodosLosUsuarios()
        {
            try
            {
                var usuarios = _usuarioDAL.GetAllUsuarios();
                foreach (var user in usuarios)
                {
                    string dvh = user.GenerarDVHExtension();

                    UsuarioDVHDTO usuario = new UsuarioDVHDTO
                    {
                        Id = user.Id,
                        DVH = dvh
                    };
                    _usuarioDAL.ModificarUsuario(usuario);
                }

                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}