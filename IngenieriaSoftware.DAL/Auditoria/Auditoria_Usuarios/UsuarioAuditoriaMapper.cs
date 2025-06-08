using IngenieriaSoftware.BEL;
using IngenieriaSoftware.BEL.Auditoria;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IngenieriaSoftware.DAL.Auditoria.Auditoria_Usuarios
{
    public class UsuarioAuditoriaMapper: IAuditoriaMapper
    {
        public IAuditableModel ConvertirDesdeRow(DataRow row)
        {
            if (row == null) return null;

            var usuario = new Usuario
            {
                Id = row.Field<int>("Id_Usuario"),
                Username = row.Field<string>("Username"),
                _passwordHash = row.Field<string>("PasswordHash"),
                FechaCreacion = row.Field<DateTime>("FechaCreacion"),
                IdiomaId = row.Field<int>("idioma_id"),
                id_rol = row.Field<int>("id_rol"),
                DVH = row.Field<string>("DVH"),
                Email = row.Field<string>("Email")
            };

            return new UsuarioAuditoriaModel
            {
                Usuario = usuario,
                Version = row.Field<int>("Version"),
                Accion = row.Field<string>("Accion"),
                CambiadoPor = row.Field<string>("CambiadoPor"),
                FechaCambio = row.Field<DateTime>("FechaCambio"),
                EsUltimaVersion = row.Field<bool>("EsUltimaVersion")
            };
        }
    }

}
