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
        private List<UsuarioDTO> _usuariosGlobales = new List<UsuarioDTO>();

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
            return _usuariosGlobales;
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
                _usuariosGlobales = new UsuarioMapper().MapearUsuariosDesdeDataSet(mDs);

                return _usuariosGlobales;
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

        #endregion Métodos para manejar usuarios     
    }
}