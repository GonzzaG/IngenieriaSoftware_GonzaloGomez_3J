using IngenieriaSoftware.Abstracciones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IngenieriaSoftware.BEL.Auditoria
{
    public class UsuarioAuditoriaModel : IAuditableModel, IVerificable
    {
        public UsuarioAuditoriaModel()
        {
        }

        public int Version { get; set; }
        public string Accion { get; set; }
        public string CambiadoPor { get; set; }
        public DateTime FechaCambio { get; set; }
        public bool EsUltimaVersion { get; set; }
        public Usuario Entidad { get; set; }
        public string DVH { get; set; }
        public int Id { get; set; }

        IEntity IAuditableModel.Entidad => Entidad;

        public bool VerificarIntegridad(string dvhBD)
        {
            return DVH == dvhBD;
        }
    }
}
