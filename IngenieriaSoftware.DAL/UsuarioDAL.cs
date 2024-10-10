using IngenieriaSoftware.BEL;
using IngenieriaSoftware.Servicios;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IngenieriaSoftware.DAL
{
    public class UsuarioDAL
    {
        private DAO _dao = new DAO();

        // Método para obtener un usuario por su nombre
        public DataRow ObtenerUsuarioPorNombre(BEL.Usuario pUsuario)
        {
            string query = $"SELECT * FROM [ISProyecto].[dbo].[User] WHERE UserName = '{pUsuario.Username}'";
            DataSet ds = _dao.ExecuteDataSet(query);

            if (ds.Tables[0].Rows.Count > 0)
            {
                return ds.Tables[0].Rows[0]; // Devuelve la primera fila que corresponde al usuario
            }

            return null; // Retorna null si no encuentra al usuario
        }

        public int GuardarUsuario(BEL.Usuario pUsuario)
        {
            string query = $"INSERT INTO [ISProyecto].[dbo].[User] (UserName, PasswordHash, FechaCreacion) " +
                           $"VALUES ('{pUsuario.Username}', '{pUsuario._passwordHash}', GETDATE())";
            return _dao.ExecuteNonQuery(query); // Devuelve 1 si la inserción fue exitosa
        }

      
    }
}
