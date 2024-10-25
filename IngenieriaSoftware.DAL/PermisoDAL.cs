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
        private readonly DAO _dao;

        public PermisoDAL()
        {
            _dao = new DAO();
        }

        public List<Permiso> ObtenerPermisosDelUsuario(int pUsuarioId)
        {
            var permisos = new List<BEL.Permiso>();

            string mNombreStoredProcedure = "sp_ObtenerPermisosDelUsuario";

            SqlParameter[] mParametros = new SqlParameter[]
            {
                new SqlParameter("@usuario_id", pUsuarioId)
            };

            DataSet mDs = _dao.ExecuteStoredProcedure(mNombreStoredProcedure, mParametros);

            foreach(DataRow row in mDs.Tables[0].Rows)
            {
                permisos.Add(new Permiso
                {
                    Id = (int)row["id"],
                    Nombre = row["nombre"].ToString(),
                    CodPermiso = row["permiso"].ToString()
                });
            }

            return permisos;
        }

        public List<Permiso> ObtenerPermisos()
        {
            var permisos = new List<BEL.Permiso>();

            string mNombreStoredProcedure = "sp_ObtenerTodosLosPermisos";


            DataSet mDs = _dao.ExecuteStoredProcedure(mNombreStoredProcedure, null);

            foreach (DataRow row in mDs.Tables[0].Rows)
            {
                permisos.Add(new Permiso
                {
                    Id = (int)row["id_permiso"],
                    Nombre = row["nombre_permiso"].ToString(),
                    CodPermiso = row["permiso"].ToString(),
                    EsRol = (bool)row["es_rol"],
                    Habilitado = (bool)row["habilitado"],
                }) ;
            }

            return permisos;
        }


        //MODIFICAR PARA QUE DEVUELVA LIST<PERMISOS>
        public DataSet ObtenerPermisosTreeView()
        {
            string mNombreStoredProcedure = "sp_ObtenerPermisosTreeView";
            DataSet mDs = _dao.ExecuteStoredProcedure(mNombreStoredProcedure, null);

            return mDs;
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
