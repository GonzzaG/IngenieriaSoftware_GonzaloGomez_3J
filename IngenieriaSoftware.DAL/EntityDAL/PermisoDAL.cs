using IngenieriaSoftware.Servicios;
using IngenieriaSoftware.Servicios.Permisos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

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
                var permisosUsuario = _permisoMapper.MapearPermisosDesdeDataSet(mDs);
                _permisoMapper.AsignarPermisosHijos(permisosUsuario);
                
                
                return permisosUsuario;
                 
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener permisos del usuario: " + ex.Message, ex);
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