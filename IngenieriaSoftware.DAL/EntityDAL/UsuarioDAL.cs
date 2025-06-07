using IngenieriaSoftware.BEL;
using IngenieriaSoftware.Servicios;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

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

        public List<Usuario> GetAllUsuarios()
        {
            try
            {
                DataSet mDs = _dao.ExecuteStoredProcedure("sp_ObtenerTodosLosUsuarios", null);
                List<Usuario> usuarios = new UsuarioMapper().MapearUsuariosDesdeDataSetExtension(mDs);

                return usuarios;
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
                return new UsuarioMapper().MapearUsuarioDTODesdeDataSet(mDs);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener el usuario por nombre: " + ex.Message, ex);
            }
        }

        public UsuarioDTO ObtenerUsuarioDTOPorId(int id)
        {
            try
            {
                SqlParameter[] parametros = new SqlParameter[]
                {
                    new SqlParameter("@Id", id)
                };

                DataSet mDs = _dao.ExecuteStoredProcedure("sp_ObtenerUsuarioPorId", parametros);
                return new UsuarioMapper().MapearUsuarioDTODesdeDataSet(mDs);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener el usuario por nombre: " + ex.Message, ex);
            }
        }

        public Usuario ObtenerUsuarioPorId(int id)
        {
            try
            {
                SqlParameter[] parametros = new SqlParameter[]
                {
                    new SqlParameter("@Id", id)
                };

                DataSet mDs = _dao.ExecuteStoredProcedure("sp_ObtenerUsuarioPorId", parametros);
                return new UsuarioMapper().MapearUsuarioDesdeDataSet(mDs);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener el usuario por nombre: " + ex.Message, ex);
            }
        }

        public int GuardarUsuario(UsuarioDTO pUsuario, DateTime fechaInicio)
        {
            //pUsuario.Id = ProximoId();

            var parametroSalida = new SqlParameter("@nuevoUsuario_id", SqlDbType.Int)
            {
                Direction = ParameterDirection.Output
            };

            SqlParameter[] parametros = new SqlParameter[]
            {
               // new SqlParameter("@IdUsuario", pUsuario.Id),
                new SqlParameter("@Username", pUsuario.Username),
                new SqlParameter("@PasswordHash", pUsuario._passwordHash),
                new SqlParameter("@FechaCreacion", fechaInicio),
                new SqlParameter("@idioma_id", pUsuario.IdiomaId),
                parametroSalida,
            };

            _dao.ExecuteNonQuery("sp_GuardarUsuario", parametros);

            return parametroSalida.Value != DBNull.Value ? Convert.ToInt32(parametroSalida.Value) : throw new Exception("No se puedo retornar el id del nuevo usuario");
        }

        public int ModificarUsuario(UsuarioDVHDTO pUsuario)
        {
            try
            {
                SqlParameter[] parametros = new SqlParameter[]
           {
                new SqlParameter("@id", pUsuario.Id),
                new SqlParameter("@dvh", pUsuario.DVH),
           };
                return _dao.ExecuteNonQuery("sp_ModificarDVHDelUsuario", parametros);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al modificar el usuario: " + ex.Message, ex);
            }
        }

        public UsuarioDVHDTO ObtenerDVHDelUsuarioPorId(int id)
        {
            try
            {
                SqlParameter[] parametros = new SqlParameter[]
                {
                    new SqlParameter("@id", id)
                };

                DataSet mDs = _dao.ExecuteStoredProcedure("sp_ObtenerDVHDelUsuarioPorId", parametros);

                return new UsuarioDVHDTO { DVH = mDs.Tables[0].Columns["DVH"].DefaultValue.ToString() };
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener el usuario por nombre: " + ex.Message, ex);
            }
        }

        public bool AgregarVerificadorVertical(DigitoVerificadorVertical dvv)
        {
            try
            {
                SqlParameter[] parametros = new SqlParameter[]
                {
                    new SqlParameter("@nombreTabla", dvv.NombreTabla),
                };

                DataSet mDs = _dao.ExecuteStoredProcedure("sp_AgregarVerificadorVertical", parametros);

                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al agregar el verificador vertical: " + ex.Message, ex);
            }
        }

        #endregion Métodos para manejar usuarios

    }
}