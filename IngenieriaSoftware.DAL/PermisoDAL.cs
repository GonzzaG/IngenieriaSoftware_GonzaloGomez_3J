using IngenieriaSoftware.BEL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IngenieriaSoftware.DAL
{
    public class PermisoDAL
    {
        private readonly DAO _dao = new DAO();
        internal List<Permiso> _permisosGlobales; 
        public PermisoDAL()
        {
            _permisosGlobales = new List<Permiso>(); // Para almacenar todos los permisos.

        }

        public List<Permiso> PermisosGlobales()
        {
            return _permisosGlobales;
        }

        //public List<Permiso> ObtenerPermisosDelUsuario(int pUsuarioId)
        //{
        //    string mNombreStoredProcedure = "sp_ObtenerPermisosDelUsuario";

        //    SqlParameter[] mParametros = new SqlParameter[]
        //    {
        //        new SqlParameter("@usuario_id", pUsuarioId)
        //    };

        //    DataSet mDs = _dao.ExecuteStoredProcedure(mNombreStoredProcedure, mParametros);

        //    PermisoMapper mapper = new PermisoMapper();
        //    return mapper.MapearPermisosDesdeDataSet(mDs);
        //}
        


        public void AsignarPermisosHijos(DataSet pDs)
        {
            // Limpiar la lista de permisos hijos antes de asignar nuevos permisos (opcional)
            foreach (var permiso in _permisosGlobales)
            {
                permiso.permisosHijos = new List<Permiso>();
            }

            // Asignar permisos hijos a sus respectivos permisos padres
            foreach (var permiso in _permisosGlobales)
            {
                // Si el permiso tiene un PermisoPadreId, intentamos asignarlo
                if (permiso.PermisoPadreId.HasValue)
                {
                    // Encontrar el permiso que actúa como padre
                    var permisoPadre = PermisosGlobales()
                        .FirstOrDefault(p => p.Id == permiso.PermisoPadreId.Value);

                    permisoPadre.permisosHijos.Add(permiso);
                }
            }
        }

        public Permiso ObtenerPermisoPorId(int idPermiso)
        {
            Permiso permiso = _permisosGlobales.FirstOrDefault(p => p.Id == idPermiso);

            return permiso;
        }

        public List<Permiso> MapearPermisos(DataSet pDS)
        {
            // Mapearemos los permisos LO OY A HACER EN PERMISODAL
           _permisosGlobales = new PermisoMapper().MapearPermisosTreeViewDesdeDataSet(pDS);
            return _permisosGlobales;
        }


        //MODIFICAR PARA QUE DEVUELVA LIST<PERMISOS>
        public List<Permiso> ObtenerPermisosTreeView()
        {
            string mNombreStoredProcedure = "sp_ObtenerPermisosTreeView";
            DataSet mDs = _dao.ExecuteStoredProcedure(mNombreStoredProcedure, null);

            PermisoMapper permmisoMapper = new PermisoMapper();
            UsuarioMapper usuarioMapper = new UsuarioMapper();
            List<Permiso> permisos = permmisoMapper.MapearPermisosDesdeDataSet(mDs);
         
            return permisos;
        }

        public void AsignarPermiso(int usuarioId, int permisoId)
        {
            string nombreStoredProcedure = "sp_AsignarPermiso";

            SqlParameter[] parametros = new SqlParameter[]
            {
                new SqlParameter("@usuario_id", usuarioId),
                new SqlParameter("@permiso_id", permisoId)
            };

            _dao.ExecuteStoredProcedure(nombreStoredProcedure, parametros);
        }




    }
}
