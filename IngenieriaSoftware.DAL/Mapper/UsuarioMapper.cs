using IngenieriaSoftware.BEL;
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
            var usuarios = new List<UsuarioDTO>();
            try
            {
                foreach (DataRow row in pDS.Tables[1].Rows)
                {
                    var usuario = new UsuarioDTO();
                    usuario.Id = (int)row["id_usuario"];
                    usuario.Username = row["Username"].ToString();
                    usuario._passwordHash = row["PasswordHash"].ToString();
                    usuario.FechaCreacion = (DateTime)row["FechaCreacion"];
                    if (pDS.Tables.Contains("id_rol"))
                        usuario.id_rol = (int)row["id_rol"];
                    usuario.IdiomaId = (int)row["idioma_id"];
                    usuarios.Add(usuario);
                }
            }
            catch (Exception ex) //excepcion no encuentra table 1
            {
                foreach (DataRow row in pDS.Tables[0].Rows)
                {
                    var usuario = new UsuarioDTO();
                    usuario.Id = (int)row["id_usuario"];
                    usuario.Username = row["Username"].ToString();
                    usuario._passwordHash = row["PasswordHash"].ToString();
                    usuario.FechaCreacion = (DateTime)row["FechaCreacion"];
                    usuario.id_rol = row["id_rol"] != DBNull.Value ? (int)row["id_rol"] : 0;
                    usuario.IdiomaId = (int)row["idioma_id"];
                    usuarios.Add(usuario);
                }
            }
            return usuarios;
        }

        public UsuarioDTO MapearUsuarioDTODesdeDataSet(DataSet pDS)
        {
            UsuarioDTO usuario = new UsuarioDTO();
            foreach (DataRow row in pDS.Tables[0].Rows)
            {
                usuario.Id = (int)row["id_usuario"];
                usuario.Username = row["Username"].ToString();
                usuario._passwordHash = row["PasswordHash"].ToString();
                usuario.FechaCreacion = (DateTime)row["FechaCreacion"];
                if (pDS.Tables.Contains("id_rol"))
                    usuario.id_rol = (int)row["id_rol"];
                usuario.IdiomaId = (int)row["idioma_id"];
            }
            if (usuario.Id == 0) { return null; }
            return usuario;
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
                usuario.id_rol = (int)row["id_rol"];
                usuario.IdiomaId = (int)row["idioma_id"];
                usuario.DVH = row["DVH"] == DBNull.Value ? null : row["DVH"].ToString();
                usuario.Email = row["Email"] == DBNull.Value ? null : row["Email"].ToString();

            }
            if (usuario.Id == 0) { return null; }
            return usuario;
        }

        public List<Usuario> MapearUsuariosDesdeDataSetExtension(DataSet pDS)
        {
            var usuarios = new List<Usuario>();
            try
            {
                foreach (DataRow row in pDS.Tables[1].Rows)
                {
                    var usuario = new Usuario();
                    usuario.Id = (int)row["id_usuario"];
                    usuario.Username = row["Username"].ToString();
                    usuario._passwordHash = row["PasswordHash"].ToString();
                    usuario.FechaCreacion = (DateTime)row["FechaCreacion"];
                    if (pDS.Tables.Contains("id_rol"))
                        usuario.id_rol = (int)row["id_rol"];
                    usuario.IdiomaId = (int)row["idioma_id"];
                    usuario.DVH = row["DVH"].ToString();
                    usuario.Email = row["Email"].ToString();
                    usuarios.Add(usuario);
                }
            }
            catch (Exception ex) //excepcion no encuentra table 1
            {
                foreach (DataRow row in pDS.Tables[0].Rows)
                {
                    var usuario = new Usuario();
                    usuario.Id = (int)row["id_usuario"];
                    usuario.Username = row["Username"].ToString();
                    usuario._passwordHash = row["PasswordHash"].ToString();
                    usuario.FechaCreacion = (DateTime)row["FechaCreacion"];
                    usuario.id_rol = row["id_rol"] != DBNull.Value ? (int)row["id_rol"] : 0;
                    usuario.IdiomaId = (int)row["idioma_id"];
                    usuario.DVH = row["DVH"].ToString();
                    usuario.Email = row["Email"].ToString();
                    usuarios.Add(usuario);
                }
            }
            return usuarios;
        }
    }
}