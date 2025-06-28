using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
