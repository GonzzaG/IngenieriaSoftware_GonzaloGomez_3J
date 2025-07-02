using IngenieriaSoftware.BEL;
using IngenieriaSoftware.BEL.Auditoria;
using System;

namespace IngenieriaSoftware.BLL.Auditoria
{
    public static class UsuarioAuditoriaFactory
    {
        public static UsuarioAuditoriaModel CrearParaInsert(Usuario usuario, string cambiadoPor)
        {
            return new UsuarioAuditoriaModel
            {
                Entidad = usuario,
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
                Entidad = usuario,
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
                Entidad = usuario,
                Accion = "RESTORE",
                CambiadoPor = cambiadoPor,
                FechaCambio = DateTime.Now,
                EsUltimaVersion = true
            };
        }
    }
}
