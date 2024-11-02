using IngenieriaSoftware.BEL;
using IngenieriaSoftware.Servicios;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace IngenieriaSoftware.DAL
{
    public class UsuarioDAL
    {
        private readonly DAO _dao = new DAO();
        private List<UsuarioDTO> _usuarioGlobales = new List<UsuarioDTO>(); // Almacena todos los usuarios.
        private readonly PermisoDAL _permisoDAL = new PermisoDAL();

        // DataSet donde se almacenan usuarios, permisos, y relaciones entre ellos.
        internal static DataSet UsuariosPermisosDataSet { get; set; } = new DataSet();
        private static int mId;

        public UsuarioDAL()
        {
        }

        private static int ProximoId()
        {
            if (mId == 0)
                mId = (new DAO()).ObtenerUltimoId("usuarios", "id_usuario");
            return ++mId;
        }

        #region Métodos para manejar usuarios


        public List<UsuarioDTO> ObtenerUsuariosGlobales()
        {
            return _usuarioGlobales;
        }
        
        public void EliminarUsuario(int usuarioId)
        {
            try
            {
                SqlParameter[] parametros = new SqlParameter[]
                {
                    new SqlParameter("@usuario_id", usuarioId)
                };

                // Ejecutar el stored procedure para eliminar el usuario.
                _dao.ExecuteNonQuery("sp_EliminarUsuario", parametros);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al eliminar el usuario: " + ex.Message, ex);
            }
        }

        public List<UsuarioDTO> ObtenerTodosLosUsuarios()
        {
            try
            {
                DataSet mDs = _dao.ExecuteStoredProcedure("sp_ObtenerTodosLosUsuarios", null);
                return new UsuarioMapper().MapearUsuariosDesdeDataSet(mDs);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener todos los usuarios: " + ex.Message, ex);
            }
        }

        public UsuarioDTO ObtenerUsuarioPorNombre(string pUsuarioNombre)
        {
            try
            {
                SqlParameter[] parametros = new SqlParameter[]
                {
                    new SqlParameter("@UserName", pUsuarioNombre)
                };

                DataSet mDs = _dao.ExecuteStoredProcedure("sp_ObtenerUsuarioPorNombre", parametros);
                return new UsuarioMapper().MapearUsuarioDesdeDataSet(mDs);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener el usuario por nombre: " + ex.Message, ex);
            }
        }

        public int GuardarUsuario(UsuarioDTO pUsuario, DateTime fechaInicio)
        {
            pUsuario.Id = ProximoId();

            SqlParameter[] parametros = new SqlParameter[]
            {
                new SqlParameter("@IdUsuario", pUsuario.Id),
                new SqlParameter("@Username", pUsuario.Username),
                new SqlParameter("@PasswordHash", pUsuario._passwordHash),
                new SqlParameter("@FechaCreacion", fechaInicio),
                new SqlParameter("@idioma_id", pUsuario.IdiomaId)
            };

            return _dao.ExecuteNonQuery("sp_GuardarUsuario", parametros);
        }

        #endregion

        #region Métodos para manejar permisos

        public List<PermisoDTO> PermisosTree()
        {
            return _permisoDAL.PermisosTree();
        }

        public List<PermisoDTO> PermisosGlobales()
        {
            return _permisoDAL.PermisosGlobales();
        }

        public List<PermisoDTO> ObtenerPermisosDelUsuarioEnMemoria(string pUsername)
        {
            UsuarioDTO usuario = _usuarioGlobales.Find(u => u.Username == pUsername);
            return usuario.Permisos.Select(p => new PermisoDTO
            {
                Id = p.Id,
                Nombre = p.Nombre,
                // Otros campos que necesites
            }).ToList();
        }

        public List<PermisoDTO> ObtenerPermisosDelUsuarioPorUsername(string pUsuarioNombre)
        {
            try
            {
                SqlParameter[] parametros = new SqlParameter[]
                {
                    new SqlParameter("@UserName", pUsuarioNombre)
                };

                DataSet mDs = _dao.ExecuteStoredProcedure("sp_ObtenerPermisosUsuarioPorUsername", parametros);
                return new PermisoMapper().MapearPermisosDesdeDataSet(mDs);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener permisos del usuario: " + ex.Message, ex);
            }
        }
        public void AsignarPermisoPorCod(string username, string permisoCod)
        {
            try
            {
                _permisoDAL.AsignarPermisoPorCod(username, permisoCod);
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public void AsignarPermiso(int usuarioId, int permisoId)
        {
            try
            {
                _permisoDAL.AsignarPermiso(usuarioId, permisoId);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al asignar permiso: " + ex.Message, ex);
            }
        }

        public void DesasignarPermiso(string username, int permisoId)
        {
            try
            {
                UsuarioDTO usuario = _usuarioGlobales.Find(u => u.Username == username);
                if (usuario == null) return;

                // Definir los parámetros para el procedimiento almacenado.
                SqlParameter[] parametros = new SqlParameter[]
                {
                    new SqlParameter("@usuario_id", usuario.Id),
                    new SqlParameter("@permiso_id", permisoId)
                };

                // Ejecutar el procedimiento almacenado.
                _dao.ExecuteStoredProcedure("sp_DesasignarPermiso", parametros);

                // Eliminar el permiso de la lista del usuario.
                PermisoDTO permisoAEliminar = usuario.Permisos.FirstOrDefault(p => p.Id == permisoId);
                if (permisoAEliminar != null)
                {
                    usuario.Permisos.Remove(permisoAEliminar);
                    Console.WriteLine("Permiso desasignado correctamente.");
                }
                else
                {
                    Console.WriteLine("El permiso no está asignado a este usuario.");
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al desasignar permiso: " + ex.Message, ex);
            }
        }

        #endregion

        #region Métodos para cargar usuarios y permisos

        public List<UsuarioDTO> CargarUsuariosPermisos()
        {
            try
            {
                // Obtener todos los usuarios, permisos y relaciones entre ellos.
                UsuariosPermisosDataSet = _dao.ExecuteStoredProcedure("sp_ObtenerPermisosTreeView", null);
                _usuarioGlobales = new UsuarioMapper().MapearUsuariosDesdeDataSet(UsuariosPermisosDataSet);
                var permisosMapeados = _permisoDAL.MapearPermisos(UsuariosPermisosDataSet);
                _permisoDAL.AsignarPermisosHijos(UsuariosPermisosDataSet);

                // Establecer la relación usuarios_permisos.
                RelacionarUsuariosPermisos(UsuariosPermisosDataSet);

                return _usuarioGlobales;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al cargar usuarios y permisos: " + ex.Message, ex);
            }
        }

        private void RelacionarUsuariosPermisos(DataSet pDs)
        {
            foreach (DataRow row in pDs.Tables[2].Rows)
            {
                int idUsuario = (int)row["id_usuario"];
                int idPermiso = (int)row["id_permiso"];

                UsuarioDTO usuario = _usuarioGlobales.FirstOrDefault(u => u.Id == idUsuario);
                PermisoDTO permiso = _permisoDAL.ObtenerPermisoPorId(idPermiso);

                if (usuario != null && permiso != null)
                {
                    // Verificar si el permiso ya está asignado al usuario.
                    if (!TienePermiso(usuario, permiso))
                    {
                        // Agregar el permiso al usuario.
                        usuario.Permisos.Add(permiso);
                        permiso.Usuarios.Add(usuario);
                    }
                }
            }
        }

        public bool TienePermiso(UsuarioDTO usuario, PermisoDTO permiso)
        {
            // Verificar si el permiso está directamente en la lista de permisos del usuario.
            if (usuario.Permisos.Contains(permiso))
            {
                return true;
            }

            // Buscar recursivamente en los permisos hijos de cada permiso del usuario.
            foreach (var permisoAsignado in usuario.Permisos)
            {
                if (VerificarPermisoRecursivo(permisoAsignado, permiso))
                {
                    return true;
                }
            }

            return false; // Si no se encontró el permiso en la lista del usuario ni en sus hijos.
        }

        // Método auxiliar recursivo para verificar permisos.
        private bool VerificarPermisoRecursivo(PermisoDTO permisoActual, PermisoDTO permisoBuscado)
        {
            // Verificar si el permiso actual es el que estamos buscando.
            if (permisoActual == permisoBuscado)
            {
                return true;
            }

            // Buscar en los permisos hijos del permiso actual.
            foreach (PermisoDTO hijo in permisoActual.permisosHijos)
            {
                if (VerificarPermisoRecursivo(hijo, permisoBuscado))
                {
                    return true;
                }
            }

            return false; // Si no se encontró el permiso buscado en el permiso actual ni en sus hijos.
        }

        #endregion
    }
}
