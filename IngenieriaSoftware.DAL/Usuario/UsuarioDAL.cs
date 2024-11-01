using IngenieriaSoftware.BEL;
using IngenieriaSoftware.Servicios;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;


namespace IngenieriaSoftware.DAL
{
    public class UsuarioDAL
    {
        private DAO _dao = new DAO();

        private List<Usuario> _usuarioGlobales = new List<Usuario>(); // Para almacenar todos los usuarios.
        private PermisoDAL _permisoDAL = new PermisoDAL();

        //dataset donde voy a almacenar usuarios, permisos, usuarios_permisos
        internal static DataSet UsuariosPermisosDataSet { get; set; } = new DataSet();

        static int mId;
        
        public UsuarioDAL()
        {

        }

        private static int ProximoId()
        {
            if (mId == 0)
                mId = (new DAO()).ObtenerUltimoId("usuarios", "id_usuario");
            mId += 1;
            return mId;
        }

        #region Eliminar Usuarios Metodos
        public void EliminarUsuario(int usuarioId)
        {
            try
            {
                SqlParameter[] parametros = new SqlParameter[]
                {
                    new SqlParameter("@usuario_id", usuarioId)
                };

                // Ejecutar el stored procedure
                _dao.ExecuteNonQuery("sp_EliminarUsuario", parametros);
            }
            catch (Exception ex)
            {
                // Manejar excepciones según sea necesario
                throw new Exception("Error al eliminar el usuario: " + ex.Message);
            }
        }

        #endregion


        #region Usuarios Permisos metodos
        public List<Usuario> UsuariosGlobales()
        {
            return _usuarioGlobales;
        }

        public List<IPermiso> PermisosTree()
        {
            return _permisoDAL.PermisosTree();
        }
        public List<IPermiso> PermisosGlobales()
        {
            return _permisoDAL.PermisosGlobales();
        }
        
        // Asignamos el permiso al usuario y retornamos la lista de permisos

        public List<IPermiso> ObtenerPermisosDelUsuarioEnMemoria(string pUsername)
        {
            Usuario usuario = _usuarioGlobales.Find(u => u.Username == pUsername);

            return usuario.Permisos;
        }

        public List<Usuario> ObtenerTodosLosUsuarios()
        {
            try
            {
                DataSet mDs = _dao.ExecuteStoredProcedure("sp_ObtenerTodosLosUsuarios", null);
                List<Usuario> usuarios = new UsuarioMapper().MapearUsuariosDesdeDataSet(mDs);

                return usuarios;

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public List<IPermiso> ObtenerPermisosDelUsuarioPorUsername(string pUsuarioNombre)
        {
            try
            {
                SqlParameter[] parametros = new SqlParameter[]
                {
                    new SqlParameter("@UserName", pUsuarioNombre)
                };

                DataSet mDs = _dao.ExecuteStoredProcedure("sp_ObtenerPermisosUsuarioPorUsername", parametros);
                List<IPermiso> permisosUsuario = new PermisoMapper().MapearPermisosDesdeDataSet(mDs);

                return permisosUsuario;

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        // Método para obtener un usuario por su nombre
        public Usuario ObtenerUsuarioPorNombre(string pUsuarioNombre)
        {
            try
            {
                SqlParameter[] parametros = new SqlParameter[]
                {
                    new SqlParameter("@UserName", pUsuarioNombre)
                };

                DataSet mDs = _dao.ExecuteStoredProcedure("sp_ObtenerUsuarioPorNombre", parametros);
                Usuario usuario = new UsuarioMapper().MapearUsuarioDesdeDataSet(mDs);

                return usuario;

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        public List<Usuario> CargarUsuariosPermisos()
        {
            try
            {
                // Obtendremos en la bd todos los usuarios, permisos, y relaciones entre ellos
                UsuariosPermisosDataSet = _dao.ExecuteStoredProcedure("sp_ObtenerPermisosTreeView", null);

                // Mapearemos los usuarios
                _usuarioGlobales = new UsuarioMapper().MapearUsuariosDesdeDataSet(UsuariosPermisosDataSet);

                // Mapearemos los permisos
                var permisosMapeados = _permisoDAL.MapearPermisos(UsuariosPermisosDataSet);
                 _permisoDAL.AsignarPermisosHijos(UsuariosPermisosDataSet);

                // Ahora establecemos la relacion usuarios_permisos
                RelacionarUsuariosPermisos(UsuariosPermisosDataSet);

                // Devolvemos solo los usuarios
                return _usuarioGlobales;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public void RelacionarUsuariosPermisos(DataSet pDs)
        {
            foreach (DataRow row in pDs.Tables[2].Rows)
            {
                int idUsuario = (int)row["id_usuario"];
                int idPermiso = (int)row["id_permiso"];

                // Obtener el usuario correspondiente
                Usuario usuario = _usuarioGlobales.FirstOrDefault(u => u.Id == idUsuario);

                // Obtener el permiso correspondiente
                Permiso permiso = (Permiso)_permisoDAL.ObtenerPermisoPorId(idPermiso);

                if (usuario != null && permiso != null)
                {
                    // Verificar si el permiso y sus hijos ya están asignados al usuario
                    if (!TienePermiso(usuario, permiso))
                    {
                        // Agregar el permiso al usuario
                        usuario.Permisos.Add(permiso);
                        permiso.Usuarios.Add(usuario);
                    }
                }
            }
        }

        public bool TienePermiso(Usuario usuario, IPermiso permiso)
        {
            // Verificar si el permiso está directamente en la lista de permisos del usuario
            if (usuario.Permisos.Contains(permiso))
            {
                return true;
            }

            // Buscar recursivamente en los permisos hijos de cada permiso del usuario
            foreach (var permisoAsignado in usuario.Permisos)
            {
                if (VerificarPermisoRecursivo(permisoAsignado, permiso))
                {
                    return true;
                }
            }

            return false; // Si no se encontró el permiso en la lista del usuario ni en sus hijos
        }

        // Método auxiliar recursivo para verificar permisos
        private bool VerificarPermisoRecursivo(IPermiso permisoActual, IPermiso permisoBuscado)
        {
            // Verificar si el permiso actual es el que estamos buscando
            if (permisoActual == permisoBuscado)
            {
                return true;
            }

            // Buscar en los permisos hijos del permiso actual
            foreach (IPermiso hijo in permisoActual.permisosHijos)
            {
                if (VerificarPermisoRecursivo(hijo, permisoBuscado))
                {
                    return true;
                }
            }

            return false; // Si no se encontró el permiso buscado en el permiso actual ni en sus hijos
        }

        public int GuardarUsuario(Usuario pUsuario, DateTime FechaInicio)
        {
            pUsuario.Id = ProximoId();

            SqlParameter[] parametros = new SqlParameter[]
            {
                new SqlParameter("@IdUsuario", pUsuario.Id),
                new SqlParameter("@Username", pUsuario.Username),
                new SqlParameter("@PasswordHash", pUsuario._passwordHash),
                new SqlParameter("@FechaCreacion", FechaInicio),
                new SqlParameter("@idioma_id", pUsuario.idioma_id)
            };

            return _dao.ExecuteNonQuery("sp_GuardarUsuario",  parametros);
        }
        public void AsignarPermiso(int usuarioId, int permisoId)
        {
            try
            {
                DataSet usuarios_permisos = _permisoDAL.AsignarPermiso(usuarioId, permisoId);

                
            }
            catch (Exception ex)
            {
                throw ex;
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

        public void DesasignarPermiso(string username, int permisoId)
        {         
            try
            {
                // Aquí puedes actualizar el estado de permisos del usuario en la lista global si es necesario
                Usuario usuario = _usuarioGlobales.Find(u => u.Username == username);

                // Define los parámetros para el procedimiento almacenado
                SqlParameter[] parametros = new SqlParameter[]
                {
                    new SqlParameter("@usuario_id", usuario.Id),
                    new SqlParameter("@permiso_id", permisoId)
                };

                // Ejecuta el procedimiento almacenado
                _dao.ExecuteStoredProcedure("sp_DesasignarPermiso", parametros);

                if (usuario != null)
                {
                    // Encuentra el permiso que deseas eliminar y quítalo
                    Permiso permisoAEliminar = (Permiso)usuario.Permisos.FirstOrDefault(p => p.Id == permisoId);
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
            }
            catch (Exception ex)
            {
                throw ex; // Considera manejar las excepciones de manera más específica o loguearlas
            }
        }



        #endregion
    }
}
