using IngenieriaSoftware.BEL;
using IngenieriaSoftware.BEL.Auditoria;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IngenieriaSoftware.BLL.Auditoria
{
    public static class UsuarioAuditoriaFactory
    {
        public static UsuarioAuditoriaModel CrearParaInsert(Usuario usuario, string cambiadoPor)
        {
            return new UsuarioAuditoriaModel
            {
                Usuario = usuario,
                Accion = "INSERT",
                CambiadoPor = cambiadoPor,
                FechaCambio = DateTime.Now,
                EsUltimaVersion = true
            };
        }

        public static UsuarioAuditoriaModel CrearParaDelete(Usuario usuario, string cambiadoPor)
        {
            return new UsuarioAuditoriaModel
            {
                Usuario = usuario,
                Accion = "DELETE",
                CambiadoPor = cambiadoPor,
                FechaCambio = DateTime.Now,
                EsUltimaVersion = true
            };
        }

        public static UsuarioAuditoriaModel CrearParaRestore(Usuario usuario, string cambiadoPor)
        {
            return new UsuarioAuditoriaModel
            {
                Usuario = usuario,
                Accion = "RESTORE",
                CambiadoPor = cambiadoPor,
                FechaCambio = DateTime.Now,
                EsUltimaVersion = true
            };
        }
    }
}
