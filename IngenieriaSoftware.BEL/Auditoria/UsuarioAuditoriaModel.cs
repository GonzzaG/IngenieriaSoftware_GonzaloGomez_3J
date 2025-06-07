using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IngenieriaSoftware.BEL.Auditoria
{
    public class UsuarioAuditoriaModel : IAuditableModel
    {
        public UsuarioAuditoriaModel()
        {
        }

        public int Version { get; set; }
        public string Accion { get; set; }
        public string CambiadoPor { get; set; }
        public DateTime FechaCambio { get; set; }
        public bool EsUltimaVersion { get; set; }
        public Usuario Usuario { get; set; }
        IEntity IAuditableModel.Entidad => Usuario;
    }
}
