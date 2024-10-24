using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
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

        public List<BEL.Permiso> ObtenerPermisosDelUsuario(int pUsuarioId)
        {
            var permisos = new List<BEL.Permiso>();

            string mNombreStoredProcedure = "ObtenerPermisosDelUsuario";

            SqlParameter[] mParametros = new SqlParameter[]
            {
                new SqlParameter("@usuario_id", pUsuarioId)
            };

            DataSet mDs = _dao.ExecuteStoredProcedure(mNombreStoredProcedure, mParametros);

            foreach(DataRow row in mDs.Tables[0].Rows)
            {
                permisos.Add(new BEL.Permiso
                {
                    Id = (int)row["id"],
                    Nombre = row["nombre"].ToString(),
                    Descripcion = row["descripcion"].ToString()
                });
            }

            return permisos;
        }
    }
}
