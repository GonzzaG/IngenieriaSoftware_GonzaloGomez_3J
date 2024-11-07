using IngenieriaSoftware.Servicios;
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
        internal List<PermisoDTO> _permisosTree;
        internal List<PermisoDTO> _permisosGlobales;

        public PermisoDAL()
        {
            _permisosGlobales = new List<PermisoDTO>();
            _permisosTree = new List<PermisoDTO>();
        }

        public List<PermisoDTO> PermisosTree()
        {
            return _permisosTree;
        }

        public List<PermisoDTO> PermisosGlobales()
        {
            return _permisosGlobales;
        }

        public void AsignarPermisosHijos(DataSet pDs)
        {
            var permisosConHijos = new List<PermisoDTO>();
            var permisosPorId = _permisosTree.ToDictionary(p => p.Id);

            foreach (var permiso in _permisosTree)
            {
                permiso.permisosHijos.Clear();
            }

            foreach (DataRow row in pDs.Tables[3].Rows)
            {
                int idPermisoPadre = (int)row["id_permiso_padre"];
                int idPermisoHijo = (int)row["id_permiso_hijo"];

                if (permisosPorId.TryGetValue(idPermisoPadre, out PermisoDTO permisoPadre) &&
                    permisosPorId.TryGetValue(idPermisoHijo, out PermisoDTO permisoHijo))
                {
                    if (!permisoPadre.permisosHijos.Contains(permisoHijo))
                    {
                        permisoPadre.permisosHijos.Add(permisoHijo);
                    }
                }
            }

            foreach (var permiso in _permisosTree)
            {
                if (!permiso.PermisoPadreId.HasValue)
                {
                    permisosConHijos.Add(permiso);
                }
            }

            _permisosTree = permisosConHijos;
        }

        public PermisoDTO ObtenerPermisoPorId(int idPermiso)
        {
            var permiso = _permisosTree.FirstOrDefault(p => p.Id == idPermiso);

            if (permiso == null)
            {
                foreach (var p in _permisosTree)
                {
                    permiso = BuscarPermisoEnHijos(p, idPermiso);
                    if (permiso != null)
                    {
                        break;
                    }
                }
            }

            return permiso;
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

        public List<PermisoDTO> MapearPermisos(DataSet pDS)
        {
            _permisosGlobales = new PermisoMapper().MapearPermisosDesdeDataSet(pDS);
            _permisosTree = _permisosGlobales;

            return _permisosTree;
        }

        public DataSet AsignarPermiso(int usuarioId, int permisoId)
        {
            try
            {
                string nombreStoredProcedure = "sp_AsignarPermiso";

                SqlParameter[] parametros = new SqlParameter[]
                {
                    new SqlParameter("@usuario_id", usuarioId),
                    new SqlParameter("@permiso_id", permisoId)
                };

                var permisosUsuarioDataSet = _dao.ExecuteStoredProcedure(nombreStoredProcedure, parametros);

                return permisosUsuarioDataSet ?? null;
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
    }
}