using IngenieriaSoftware.BEL;
using IngenieriaSoftware.BEL.Auditoria;
using IngenieriaSoftware.DAL.Auditoria.Auditoria_Usuarios;
using IngenieriaSoftware.DAL.Mapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IngenieriaSoftware.DAL.Auditoria
{
    public class UsuarioAuditoriaRepository : IAuditoriaRepository<UsuarioAuditoriaModel>
    {
        private readonly DAO _dao;
            
        public UsuarioAuditoriaRepository()
        {   
            _dao = new DAO();
        }


        public void RegistrarCambio(UsuarioAuditoriaModel entidad)
        {
            try
            {
                int version = 1;
                int idUsuario = entidad.Usuario.Id;

                var parametrosVersion = new SqlParameter[]
                {
                    new SqlParameter("@Id_Usuario", idUsuario)
                };

                var dt = _dao.ExecuteStoredProcedure("audit.sp_ObtenerUltimaVersionUsuario", parametrosVersion);

                if (dt.Tables[0].Rows.Count > 0)
                {
                    version = Convert.ToInt32(dt.Tables[0].Rows[0]["Version"]) + 1;

                    // Invalidar última versión anterior (¡nuevos parámetros!)
                    var parametrosInvalidar = new SqlParameter[]
                    {
                        new SqlParameter("@Id_Usuario", idUsuario)
                    };

                    _dao.ExecuteStoredProcedure("audit.sp_InvalidarUltimaVersionUsuario", parametrosInvalidar);
                }

                var usuario = entidad.Usuario as Usuario;

                var parametrosInsert = new SqlParameter[]
                {
                    new SqlParameter("@Id_Usuario", usuario.Id),
                    new SqlParameter("@Username", usuario.Username),
                    new SqlParameter("@PasswordHash", usuario._passwordHash),
                    new SqlParameter("@FechaCreacion", usuario.FechaCreacion),
                    new SqlParameter("@idioma_id", usuario.IdiomaId),
                    new SqlParameter("@id_rol", usuario.id_rol),
                    new SqlParameter("@DVH", usuario.DVH),
                    new SqlParameter("@Email", usuario.Email),
                    new SqlParameter("@Version", version),
                    new SqlParameter("@Accion", entidad.Accion),
                    new SqlParameter("@CambiadoPor", entidad.CambiadoPor),
                    new SqlParameter("@FechaCambio", DateTime.Now),
                    new SqlParameter("@EsUltimaVersion", true)
                };

                _dao.ExecuteStoredProcedure("audit.sp_InsertarAuditoriaUsuario", parametrosInsert);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al registrar auditoría de usuario", ex);
            }
        }

        public IEnumerable<UsuarioAuditoriaModel> GetAll()
        {
            try
            {
                throw new NotImplementedException("Este método no está implementado en la versión actual.");
                //var dt = _dao.ExecuteStoredProcedure("audit.sp_ObtenerAuditoriaUsuarios", null);
                //var lista = new List<UsuarioAuditoriaModel>();

                //foreach (DataRow row in dt.Tables[0].Rows)
                //{
                //    lista.Add(new UsuarioAuditoriaMapper().ConvertirDesdeRow(row));
                //}

                //return lista;
            }
            catch
            {
                return new List<UsuarioAuditoriaModel>();
            }
        }

        public UsuarioAuditoriaModel GetById(int id)
        {
            try
            {
                var parametros = new SqlParameter[]
                {
                    new SqlParameter("@Id", id)
                };

                var dt = _dao.ExecuteStoredProcedure("audit.sp_ObtenerAuditoriaUsuarioPorId", parametros);

                if (dt.Tables[0].Rows.Count == 0)
                    return null;

                return UsuarioAuditoriaMapper.ConvertirDesdeRow(dt.Tables[0].Rows[0]);
            }
            catch
            {
                return null;
            }
        }

        public void RestaurarEstadoEntidad(int idEntidad, int version)
        {
            try
            {
                var parametros = new SqlParameter[]
                {
                    new SqlParameter("@id_usuario", idEntidad),
                    new SqlParameter("@Version", version)
                };

                _dao.ExecuteStoredProcedure("audit.sp_RestaurarUsuarioDesdeAuditoria", parametros);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al restaurar el estado de la entidad desde auditoría", ex);
            }
        }

    }
}
