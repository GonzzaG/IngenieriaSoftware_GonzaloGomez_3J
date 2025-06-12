using IngenieriaSoftware.BEL;
using IngenieriaSoftware.BEL.Auditoria;
using IngenieriaSoftware.BLL.Auditoria.Services;
using IngenieriaSoftware.DAL;
using IngenieriaSoftware.DAL.Auditoria;
using IngenieriaSoftware.Servicios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IngenieriaSoftware.BLL.Auditoria
{
    public class AuditoriaService<T>: IAuditoriaService where T : IAuditableModel, new()
    {
        readonly IAuditoriaEntityRepository<T> _auditoriaRepository;
        readonly PeticionesRestauracionRepository _peticionesRestauracionRepository;

        public AuditoriaService()
        {
            _peticionesRestauracionRepository = new PeticionesRestauracionRepository();
            _auditoriaRepository = (IAuditoriaEntityRepository<T>)AuditoriaRepositoryFactory.CreateRepositoryForType(typeof(T));
        }


        public void RealizarPeticionRestauracion(string tabla, int idEntidad, int version, int idUsuarioActual, string comentario = null)
        {
            _auditoriaRepository.RealizarPeticion(tabla, idEntidad, version, idUsuarioActual, comentario);  
        }

        public object GetPorIdYVersion(int id, int version)
        {
            return _auditoriaRepository.GetPorIdYVersion(id, version);
        }

        public IAuditableModel ObtenerUltimaVersionDeEntidadAuditable(string nombreTabla, int idEntidad)
        {
            return _peticionesRestauracionRepository.ObtenerUltimaVersionDeEntidadAuditable(nombreTabla, idEntidad);
        }

        public void AceptarPeticionDeRestauracion(int idEntidad, int version, int idPeticion, int IdEntidad)
        {
            
           _auditoriaRepository.RestaurarEstadoEntidad(idEntidad, version);

            _peticionesRestauracionRepository.CambiarEstadoPeticion(idPeticion, "Aprobada", IdEntidad);

            // Registrar la restauración en la auditoría
            var entidad = _auditoriaRepository.GetPorIdYVersion(idEntidad, version);

            if (entidad != null)
            {
                entidad.FechaCambio = DateTime.Now;
                entidad.CambiadoPor = SessionManager.GetInstance.Usuario.Username; // O el usuario que corresponda
                _auditoriaRepository.RegistrarCambio(entidad);
            }
            else
            {
                throw new Exception($"No se encontró la entidad con ID {idEntidad} y versión {version} en la tabla");
            }
        }

        public void RechazarPeticionDeRestauracion(int idPeticion, int IdEntidad)
        {
            _peticionesRestauracionRepository.CambiarEstadoPeticion(idPeticion, "Rechazada",IdEntidad);
        }
    }
}
