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
            try
            {
                foreach (DataRow row in pDS.Tables[1].Rows)
                {
                    permisos.Add(new Usuario
                    {
                        Id = (int)row["id_usuario"],
                        Username = row["Username"].ToString(),
                        _passwordHash = row["PasswordHash"].ToString(),
                        FechaCreacion = (DateTime)row["FechaCreacion"],
                        idioma_id = (int)row["idioma_id"]
                    });
                }
            }
            catch(Exception ex) //excepcion no encuentra table 1
            {
                foreach (DataRow row in pDS.Tables[0].Rows)
                {
                    permisos.Add(new Usuario
                    {
                        Id = (int)row["id_usuario"],
                        Username = row["Username"].ToString(),
                        _passwordHash = row["PasswordHash"].ToString(),
                        FechaCreacion = (DateTime)row["FechaCreacion"],
                        idioma_id = (int)row["idioma_id"]
                    });
                }
            }
            return permisos;
        }

        public Usuario MapearUsuarioDesdeDataSet(DataSet pDS)
        {
            Usuario usuario = new Usuario();
            foreach (DataRow row in pDS.Tables[0].Rows)
            {
                  usuario.Id = (int)row["id_usuario"];
                  usuario.Username = row["Username"].ToString();
                  usuario._passwordHash = row["PasswordHash"].ToString();
                  usuario.FechaCreacion = (DateTime)row["FechaCreacion"];
                usuario.idioma_id = (int)row["idioma_id"];
            }
            if (usuario.Id == 0) {return null;}
            return usuario;
        }

    }
}
