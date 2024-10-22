using IngenieriaSoftware.BEL;
using IngenieriaSoftware.Servicios;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace IngenieriaSoftware.DAL
{
    public class UsuarioDAL
    {
        private DAO _dao = new DAO();

        // Método para obtener un usuario por su nombre
        public Servicios.Usuario ObtenerUsuarioPorNombre(string pUsuarioNombre)
        {
            string query = $"SELECT * FROM usuarios WHERE UserName = '{pUsuarioNombre}'";
            DataSet mDs = new DAO().ExecuteDataSet(query);
            if (mDs.Tables.Count > 0 && mDs.Tables[0].Rows.Count > 0)
            {
                Servicios.Usuario mUsuario = new Servicios.Usuario();
                ValorizarEntidad(mUsuario, mDs.Tables[0].Rows[0]);
                return mUsuario;
            }
            else
            {
                return null;
            }
        }

        public int GuardarUsuario(Servicios.Usuario pUsuario, SessionManager pSession)
        {
            string query = $"INSERT INTO usuarios (UserName, PasswordHash, FechaCreacion) " +
                           $"VALUES ('{pUsuario.Username}', '{pUsuario.Password}', '{pSession.FechaInicio}')";
            return _dao.ExecuteNonQuery(query); // Devuelve 1 si la inserción fue exitosa
        }

        private static void ValorizarEntidad(Servicios.Usuario pUsuario, DataRow pDr)
        {
            pUsuario.Username = pDr["Username"].ToString();
            pUsuario.AsignarPassword(pDr["PasswordHash"].ToString());
            pUsuario.Id = (int)pDr["Id"];

        }
    }
}
