using IngenieriaSoftware.Servicios;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace IngenieriaSoftware.DAL
{
    public class PermisoDAL
    {
        private readonly DAO _dao = new DAO();
        internal PermisoMapper _permisoMapper;
        internal List<PermisoDTO> _permisosGlobales;

        public PermisoDAL()
        {
            _permisoMapper = new PermisoMapper();
        }

        public List<PermisoDTO> PermisosGlobales()
        {
            return _permisosGlobales;
        }

        public List<PermisoDTO> CargarPermisosTreeView2()
        {
            try
            {
                var permisosDataSet = _dao.ExecuteStoredProcedure("sp_ObtenerTodosLosPermisos", null);
                _permisosGlobales = new PermisoMapper().MapearPermisosDesdeDataSet(permisosDataSet);
                new PermisoMapper().ConstruirJerarquiaDePermisos(_permisosGlobales);

                return _permisosGlobales;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al cargar los permisos para el TreeView: " + ex.Message, ex);
            }
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
                var permisosUsuario = _permisoMapper.MapearPermisosDesdeDataSet2(mDs);
                //_permisoMapper.AsignarPermisosHijos(permisosUsuario);

                return permisosUsuario;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener permisos del usuario: " + ex.Message, ex);
            }
        }

        public List<PermisoDTO> ObtenerPermisosUsuario(int usuarioId)
        {
            try
            {
                SqlParameter[] parametros = new SqlParameter[]
                {
                    new SqlParameter("@id_usuario", usuarioId)
                };

                DataSet mDs = _dao.ExecuteStoredProcedure("sp_ObtenerPermisosUsuario", parametros);
                var permisosUsuario = _permisoMapper.MapearPermisosUsuarioDesdeDataSet(mDs);
                //_permisoMapper.AsignarPermisosHijos(permisosUsuario);

                return permisosUsuario;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener permisos del usuario: " + ex.Message, ex);
            }
        }

        public List<PermisoDTO> ObtenerPermisosDelRol(string nombreRol)
        {
            try
            {
                SqlParameter[] parametros = new SqlParameter[]
                {
                    new SqlParameter("@nombre_rol", nombreRol)
                };

                DataSet mDs = _dao.ExecuteStoredProcedure("sp_ObtenerPermisosDelRol", parametros);
                var permisosUsuario = _permisoMapper.MapearPermisosDesdeDataSet2(mDs);

                return permisosUsuario;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener permisos del usuario: " + ex.Message, ex);
            }
        }

        public List<PermisoDTO> ObtenerPermisosDelRolPorId(int rolId)
        {
            try
            {
                SqlParameter[] parametros = new SqlParameter[]
                {
                    new SqlParameter("@rolId", rolId)
                };

                DataSet mDs = _dao.ExecuteStoredProcedure("sp_ObtenerPermisosDelRolPorId", parametros);
                var permisosUsuario = _permisoMapper.MapearPermisosDesdeDataSet2(mDs);

                return permisosUsuario;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener permisos del usuario: " + ex.Message, ex);
            }
        }

        public List<PermisoDTO> ObtenerTodosLosRoles()
        {
            try
            {
                DataSet mDs = _dao.ExecuteStoredProcedure("sp_ObtenerTodosLosRoles", null);
                var permisosUsuario = _permisoMapper.MapearPermisosDesdeDataSet(mDs);
                //_permisoMapper.ConstruirJerarquiaDePermisos(permisosUsuario);

                return permisosUsuario;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener permisos del usuario: " + ex.Message, ex);
            }
        }

        public List<PermisoDTO> ObtenerTodosLosPermisos()
        {
            try
            {
                DataSet mDs = _dao.ExecuteStoredProcedure("sp_ObtenerTodosLosPermisos", null);
                var permisosUsuario = _permisoMapper.MapearPermisosDesdeDataSet(mDs);
                //_permisoMapper.ConstruirJerarquiaDePermisos(permisosUsuario);

                return permisosUsuario;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener permisos del usuario: " + ex.Message, ex);
            }
        }

        public void CrearRol(string nombreRol)
        {
            try
            {
                SqlParameter[] parametros = new SqlParameter[]
                {
                    new SqlParameter("@NombreRol", nombreRol)
                };
                _dao.ExecuteNonQuery("sp_CrearRol", parametros);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener permisos del usuario: " + ex.Message, ex);
            }
        }

        public string EliminarRol(int rolId)
        {
            try
            {
                SqlParameter[] parametros = new SqlParameter[]
                {
                    new SqlParameter("@IdRol ", rolId)
                };

                DataSet ds = _dao.ExecuteStoredProcedure("sp_EliminarRol", parametros);

                if (ds != null && ds.Tables.Count > 0)
                {
                    DataTable resultado = ds.Tables[0];
                    string mensaje = resultado.Rows[0]["Mensaje"].ToString();

                    int codigoResultado = Convert.ToInt32(resultado.Rows[0]["Resultado"]);
                    if (codigoResultado == 0)
                    {
                        throw new Exception(mensaje);
                    }

                    return mensaje;
                }
                else
                {
                    throw new Exception("No se pudo obtener el resultado de la operación.");
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error: " + ex.Message, ex);
            }
        }

        public void AsignarRolARol(int rolPadreId, int rolHijoId)
        {
            try
            {
                SqlParameter[] parametros = new SqlParameter[]
                {
                    new SqlParameter("@idRolPadre ", rolPadreId),
                    new SqlParameter("@idRolHijo ", rolHijoId)
                };
                _dao.ExecuteNonQuery("sp_AsignarRolARol", parametros);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al asignar el rol: " + ex.Message, ex);
            }
        }

        public string AsignarPermisoARol(int rolId, int permisoId)
        {
            try
            {
                SqlParameter[] parametros = new SqlParameter[]
                {
                    new SqlParameter("@idRol", rolId),
                    new SqlParameter("@idPermiso", permisoId)
                };
                DataSet ds = _dao.ExecuteStoredProcedure("sp_AsignarPermisoARol", parametros);

                if (ds != null && ds.Tables.Count > 0)
                {
                    DataTable resultado = ds.Tables[0];
                    string mensaje = resultado.Rows[0]["Mensaje"].ToString();
                    int codigoResultado = Convert.ToInt32(resultado.Rows[0]["Resultado"]);
                    if (codigoResultado == 0)
                    {
                        throw new Exception(mensaje);
                    }

                    return mensaje;
                }
                else
                {
                    throw new Exception("No se pudo obtener el resultado de la operación.");
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al asignar el permiso: " + ex.Message, ex);
            }
        }

        public string AsignarRolAUsuario(int usuarioId, int rolId)
        {
            try
            {
                SqlParameter[] parametros = new SqlParameter[]
                {
                    new SqlParameter("@usuario_id", usuarioId),
                    new SqlParameter("@permiso_id", rolId)
                };

                DataSet ds = _dao.ExecuteStoredProcedure("sp_AsignarRolAUsuario", parametros);

                if (ds != null && ds.Tables.Count > 0)
                {
                    DataTable resultado = ds.Tables[0];
                    string mensaje = resultado.Rows[0]["Mensaje"].ToString();
                    int codigoResultado = Convert.ToInt32(resultado.Rows[0]["Resultado"]);
                    if (codigoResultado == 0)
                    {
                        throw new Exception(mensaje);
                    }

                    return mensaje;
                }
                else
                {
                    throw new Exception("No se pudo obtener el resultado de la operación.");
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al asignar el permiso: " + ex.Message, ex);
            }
        }

        public string DesasignarRolAUsuario(int usuarioId)
        {
            try
            {
                SqlParameter[] parametros = new SqlParameter[]
                {
                    new SqlParameter("@usuario_id", usuarioId)
                };

                DataSet ds = _dao.ExecuteStoredProcedure("sp_DesasignarRolAUsuario", parametros);

                if (ds != null && ds.Tables.Count > 0)
                {
                    DataTable resultado = ds.Tables[0];
                    string mensaje = resultado.Rows[0]["Mensaje"].ToString();
                    int codigoResultado = Convert.ToInt32(resultado.Rows[0]["Resultado"]);
                    if (codigoResultado == 0)
                    {
                        throw new Exception(mensaje);
                    }

                    return mensaje;
                }
                else
                {
                    throw new Exception("No se pudo obtener el resultado de la operación.");
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al asignar el permiso: " + ex.Message, ex);
            }
        }

        public string DesasignarRolARol(int rolPadreId, int rolHijoId)
        {
            try
            {
                SqlParameter[] parametros = new SqlParameter[]
                {
                    new SqlParameter("@idRolPadre", rolPadreId),
                    new SqlParameter("@idRolHijo ", rolHijoId)
                };
                DataSet ds = _dao.ExecuteStoredProcedure("sp_DesasignarRolARol", parametros);

                if (ds != null && ds.Tables.Count > 0)
                {
                    DataTable resultado = ds.Tables[0];
                    string mensaje = resultado.Rows[0]["Mensaje"].ToString();
                    int codigoResultado = Convert.ToInt32(resultado.Rows[0]["Resultado"]);
                    if (codigoResultado == 0)
                    {
                        throw new Exception(mensaje);
                    }

                    return mensaje;
                }
                else
                {
                    throw new Exception("No se pudo obtener el resultado de la operación.");
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al asignar el permiso: " + ex.Message, ex);
            }
        }

        public string DesasignarPermisoDeRol(int rolPadreId, int rolHijoId)
        {
            try
            {
                SqlParameter[] parametros = new SqlParameter[]
                {
                    new SqlParameter("@idRol", rolPadreId),
                    new SqlParameter("@idPermiso", rolHijoId)
                };
                DataSet ds = _dao.ExecuteStoredProcedure("sp_DesasignarPermisoDeRol", parametros);

                if (ds != null && ds.Tables.Count > 0)
                {
                    DataTable resultado = ds.Tables[0];
                    string mensaje = resultado.Rows[0]["Mensaje"].ToString();
                    int codigoResultado = Convert.ToInt32(resultado.Rows[0]["Resultado"]);
                    if (codigoResultado == 0)
                    {
                        throw new Exception(mensaje);
                    }

                    return mensaje;
                }
                else
                {
                    throw new Exception("No se pudo obtener el resultado de la operación.");
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al asignar el permiso: " + ex.Message, ex);
            }
        }

        private PermisoDTO BuscarPermisoEnHijos(PermisoDTO permiso, int idPermiso)
        {
            if (permiso.permisosHijos != null && permiso.permisosHijos.Count > 0)
            {
                foreach (PermisoDTO hijo in permiso.permisosHijos)
                {
                    if (hijo.Id == idPermiso)
                    {
                        return hijo;
                    }

                    var resultado = BuscarPermisoEnHijos(hijo, idPermiso);
                    if (resultado != null)
                    {
                        return resultado;
                    }
                }
            }

            return null;
        }

        public PermisoDTO BuscarPermisoPorId(List<PermisoDTO> permisos, int permisoBuscadoId)
        {
            foreach (var permiso in permisos)
            {
                if (permiso.Id == permisoBuscadoId)
                {
                    return permiso;
                }

                var hijos = permiso.permisosHijos;
                if (hijos != null)
                {
                    var permisoEncontrado = BuscarPermisoPorId(hijos, permisoBuscadoId);
                    if (permisoEncontrado != null)
                    {
                        return permisoEncontrado;
                    }
                }
            }
            return null;
        }

        public void AsignarPermiso(int usuarioId, int permisoId)
        {
            try
            {
                string nombreStoredProcedure = "sp_AsignarPermiso";

                SqlParameter[] parametros = new SqlParameter[]
                {
                    new SqlParameter("@usuario_id", usuarioId),
                    new SqlParameter("@permiso_id", permisoId)
                };

                _dao.ExecuteNonQuery(nombreStoredProcedure, parametros);
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
                string nombreStoredProcedure = "sp_AsignarPermisoPorCod";

                SqlParameter[] parametros = new SqlParameter[]
                {
                    new SqlParameter("@usuario_nombre", username),
                    new SqlParameter("@cod_permiso", permisoCod)
                };

                _dao.ExecuteStoredProcedure(nombreStoredProcedure, parametros);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void DesasignarPermiso(int usuarioId, int permisoId)
        {
            try
            {
                string nombreStoredProcedure = "sp_DesasignarPermiso";

                SqlParameter[] parametros = new SqlParameter[]
                {
                    new SqlParameter("@usuario_id", usuarioId),
                    new SqlParameter("@permiso_id", permisoId)
                };

                _dao.ExecuteNonQuery(nombreStoredProcedure, parametros);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}