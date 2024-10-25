using IngenieriaSoftware.BEL;
using System;
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

        static int mId;
        private static int ProximoId()
        {
            if (mId == 0)
                mId = (new DAO()).ObtenerUltimoId("usuarios", "id_usuario");
            mId += 1;
            return mId;
        }

        // Método para obtener un usuario por su nombre
        public Usuario ObtenerUsuarioPorNombre(string pUsuarioNombre)
        {
            SqlParameter[] parametros = new SqlParameter[]
            {
                new SqlParameter("@UserName", pUsuarioNombre)
            };

            DataSet mDs = _dao.ExecuteStoredProcedure("sp_ObtenerUsuarioPorNombre", parametros);

            if (mDs.Tables.Count > 0 && mDs.Tables[0].Rows.Count > 0)
            {
                Usuario mUsuario = new Usuario();
                ValorizarEntidad(mUsuario, mDs.Tables[0].Rows[0]);

                return mUsuario;
            }
            else
            {
                return null;
            }

        }

        public int GuardarUsuario(Usuario pUsuario, DateTime FechaInicio)
        {
            pUsuario.Id = ProximoId();

            SqlParameter[] parametros = new SqlParameter[]
            {
                new SqlParameter("@IdUsuario", pUsuario.Id),
                new SqlParameter("@Username", pUsuario.Username),
                new SqlParameter("@PasswordHash", pUsuario._passwordHash),
                new SqlParameter("@FechaCreacion", FechaInicio)
            };

            return _dao.ExecuteNonQuery("sp_GuardarUsuario", parametros);
        }

        private static void ValorizarEntidad(Usuario pUsuario, DataRow pDr)
        {
            pUsuario.Username = pDr["Username"].ToString();
            pUsuario._passwordHash = (pDr["PasswordHash"].ToString());
            pUsuario.Id = (int)pDr["Id_usuario"];

        }
    }
}
