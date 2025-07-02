using System;

namespace IngenieriaSoftware.BEL.Auditoria
{
    public interface IAuditableModel
    {
        IEntity Entidad { get; }
        int Version { get; set; }
        string Accion { get; set; }
        string CambiadoPor { get; set; }
        DateTime FechaCambio { get; set; }
        bool EsUltimaVersion { get; set; }
    }
}
