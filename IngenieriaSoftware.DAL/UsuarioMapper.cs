using IngenieriaSoftware.BEL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IngenieriaSoftware.DAL
{
    public class UsuarioMapper
    {
        public List<Usuario> MapearUsuariosDesdeDataSet(DataSet pDS)
        {
            var permisos = new List<Usuario>();

            foreach (DataRow row in pDS.Tables[1].Rows)
            {
                permisos.Add(new Usuario
                {
                    Id = (int)row["id_usuario"],
                    Username = row["Username"].ToString(),
                    _passwordHash = row["PasswordHash"].ToString(),
                    FechaCreacion = (DateTime)row["FechaCreacion"]
                });
            }

            return permisos;
        }

    }
}
