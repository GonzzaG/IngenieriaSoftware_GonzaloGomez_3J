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
                Id = row.Field<int>("Id"),
                Username = row.Field<string>("Username") ?? null,
                _passwordHash = row.Field<string>("PasswordHash") ?? null,
                FechaCreacion = row.Field<DateTime>("FechaCreacion"),
                IdiomaId = row.Field<int?>("idioma_id") ?? 0, // 0 si es null
                id_rol = row.Field<int?>("id_rol") ?? 0,
                DVH = row.Field<string>("DVH") ?? null,
                Email = row.Field<string>("Email") ?? null
            };

            return new UsuarioAuditoriaModel
            {
                Entidad = usuario,
                Version = row.Field<int>("Version"),
                Accion = row.Field<string>("Accion"),
                CambiadoPor = row.Field<string>("CambiadoPor"),
                FechaCambio = row.Field<DateTime>("FechaCambio"),
                EsUltimaVersion = row.Field<bool>("EsUltimaVersion")
            };
        }
    }

}
