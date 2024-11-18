using IngenieriaSoftware.Servicios;
using System;
using System.Collections.Generic;
using System.Data;

namespace IngenieriaSoftware.DAL
{
    public class UsuarioMapper
    {
        public List<UsuarioDTO> MapearUsuariosDesdeDataSet(DataSet pDS)
        {
            var permisos = new List<UsuarioDTO>();
            try
            {
                foreach (DataRow row in pDS.Tables[1].Rows)
                {
                    permisos.Add(new UsuarioDTO
                    {
                        Id = (int)row["id_usuario"],
                        Username = row["Username"].ToString(),
                        _passwordHash = row["PasswordHash"].ToString(),
                        FechaCreacion = (DateTime)row["FechaCreacion"],
                        IdiomaId = (int)row["idioma_id"]
                    });
                }
            }
            catch (Exception ex) //excepcion no encuentra table 1
            {
                foreach (DataRow row in pDS.Tables[0].Rows)
                {
                    permisos.Add(new UsuarioDTO
                    {
                        Id = (int)row["id_usuario"],
                        Username = row["Username"].ToString(),
                        _passwordHash = row["PasswordHash"].ToString(),
                        FechaCreacion = (DateTime)row["FechaCreacion"],
                        IdiomaId = (int)row["idioma_id"]
                    });
                }
            }
            return permisos;
        }

        public UsuarioDTO MapearUsuarioDesdeDataSet(DataSet pDS)
        {
            UsuarioDTO usuario = new UsuarioDTO();
            foreach (DataRow row in pDS.Tables[0].Rows)
            {
                usuario.Id = (int)row["id_usuario"];
                usuario.Username = row["Username"].ToString();
                usuario._passwordHash = row["PasswordHash"].ToString();
                usuario.FechaCreacion = (DateTime)row["FechaCreacion"];
                usuario.IdiomaId = (int)row["idioma_id"];
            }
            if (usuario.Id == 0) { return null; }
            return usuario;
        }

    }
}