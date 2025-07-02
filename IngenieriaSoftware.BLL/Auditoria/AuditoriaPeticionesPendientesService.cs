using IngenieriaSoftware.BEL.Auditoria;
using IngenieriaSoftware.DAL.Auditoria;
using System;
using System.Collections.Generic;
using System.Linq;

namespace IngenieriaSoftware.BLL.Auditoria
{
    public class AuditoriaPeticionesPendientesService
    {
        private readonly PeticionesRestauracionRepository _peticionesRestauracionRepository;

        public AuditoriaPeticionesPendientesService()
        {
            _peticionesRestauracionRepository = new PeticionesRestauracionRepository();
        }

        public PeticionRestauracionModel GetById(int id)
        {
            return _peticionesRestauracionRepository.GetById(id);
        }

        public List<PeticionRestauracionModel> ObtenerPeticionesPendientes()
        {
            var peticiones = _peticionesRestauracionRepository.ObtenerPeticionesPendientes();

            if (peticiones == null || !peticiones.Any())
            {
                throw new Exception("No hay peticiones pendientes.");
            }

            return peticiones;
        }

        public void CambiarEstadoPeticion(int idPeticion, string estado, int IdEntidad)
        {
            _peticionesRestauracionRepository.CambiarEstadoPeticion(idPeticion, estado, IdEntidad);
        }
    }
}
