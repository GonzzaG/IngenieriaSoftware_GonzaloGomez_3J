using IngenieriaSoftware.BEL;
using IngenieriaSoftware.DAL;
using IngenieriaSoftware.Servicios;
using System;
using System.Collections.Generic;

namespace IngenieriaSoftware.BLL
{
    public class UsuarioBLL
    {
        private UsuarioDAL _usuarioDAL = new UsuarioDAL();

        #region Eliminar Usuarios Metodos

        public List<UsuarioDTO> EliminarUsuario(List<UsuarioDTO> usuarios, string usuarioAEliminarNombre)
        {
            try
            {
                UsuarioDTO usuarioAEliminar = usuarios.Find(u => u.Username == usuarioAEliminarNombre);
                //eliminar usuario en bd
                _usuarioDAL.EliminarUsuario(usuarioAEliminar.Id);

                //eliminar usuario de lista
                usuarios.Remove(usuarioAEliminar);
                return usuarios;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public UsuarioDTO ObtenerUsuarioPorNombre(string pUsername)
        {
            var usuario = _usuarioDAL.ObtenerUsuariosGlobales().Find(u => u.Username == pUsername);
            return usuario;
        }

        #endregion Eliminar Usuarios Metodos

        public List<UsuarioDTO> CargarUsuarios()
        {
            List<UsuarioDTO> _usuariosGlobales = _usuarioDAL.ObtenerTodosLosUsuarios();

            if (_usuariosGlobales == null)
            {
                throw new Exception("No hay usuarios almacenados");
            }
            else
            {
                return _usuariosGlobales;
            }
        }

        public UsuarioDTO ObtenerUsuarioDTOPorId(int id)
        {
            try
            {
                var usuario = _usuarioDAL.ObtenerUsuarioDTOPorId(id);
                if (usuario == null)
                {
                    throw new Exception("No se encontró el usuario");
                }
                else return usuario;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public Usuario ObtenerUsuarioPorId(int id)
        {
            try
            {
                var usuario = _usuarioDAL.ObtenerUsuarioPorId(id);
                if (usuario == null)
                {
                    throw new Exception("No se encontró el usuario");
                }
                else return usuario;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        #region Login LogOut

        public bool RegistrarUsuario(UsuarioDTO pUsuario, DateTime FechaInicio)
        {
            UsuarioDTO mUsuario = _usuarioDAL.ObtenerUsuarioPorNombre(pUsuario.Username);

            if (mUsuario == null)
            {
                int resultado = _usuarioDAL.GuardarUsuario(pUsuario, FechaInicio);

                if (resultado == 0) throw new Exception("Error al guardar el usuario en la base de datos");

                pUsuario.Id = resultado;

                return resultado > 0;
            }
            else
            {
                throw new Exception($"El username {pUsuario.Username} ya existe");
            }
        }

        public bool LogIn(string username, string password)
        {
            UsuarioDTO mUsuario = _usuarioDAL.ObtenerUsuarioPorNombre(username);

            if (mUsuario != null)
            {
                string storedHash = mUsuario._passwordHash;

                if (HashingManager.VerificarHash(password, storedHash))
                {
                    UsuarioDTO usuario = new UsuarioDTO
                    {
                        Id = mUsuario.Id,
                        Username = mUsuario.Username,
                        FechaCreacion = mUsuario.FechaCreacion,
                        IdiomaId = mUsuario.IdiomaId,
                        Permisos = mUsuario.Permisos,
                        _passwordHash = mUsuario._passwordHash
                    };
                    SessionManager.LogIn(usuario);
                    return true;
                }
            }

            return false;
        }

        public void LogOut()
        {
            SessionManager.LogOut();
        }

        #endregion Login LogOut
    }
}