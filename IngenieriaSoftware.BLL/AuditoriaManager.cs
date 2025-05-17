using IngenieriaSoftware.BEL;
using IngenieriaSoftware.DAL;
using System;
using System.Collections.Generic;

namespace IngenieriaSoftware.BLL
{
    public class AuditoriaManager
    {
        private AuditoriaRepository _auditoriaRepository = new AuditoriaRepository();

        public List<string> ObtenerTablasAuditadas()
        {
            try
            {
                return _auditoriaRepository.ObtenerTablasAuditadas();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener las tablas auditadas: " + ex.Message);
            }
        }

        public List<AuditoriaRegistro> ObtenerRegistroDeTabla(string nombreTabla)
        {
            try
            {
                return _auditoriaRepository.ObtenerRegistroDeTabla(nombreTabla);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<AuditoriaDetalle> ObtenerDetalleCambio(Guid idCambio)
        {
            try
            {
                return _auditoriaRepository.ObtenerDetalleCambio(idCambio);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<AuditoriaDetalle> ObtenerDetalleCambio(string tabla, int registro)
        {
            try
            {
                return _auditoriaRepository.ObtenerDetalleCambio(tabla, registro);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public bool SolicitarRestauracion(PeticionRestauracion peticion)
        {
            try
            {
                return _auditoriaRepository.SolicitarRestauracion(peticion);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public bool AceptarPeticionDeRestauracion(int idPeticion, string usuarioAutorizador)
        {
            try
            {
                return _auditoriaRepository.AceptarPeticionDeRestauracion(idPeticion, usuarioAutorizador);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public bool RechazarPeticionDeRestauracion(int idPeticion)
        {
            try
            {
                return _auditoriaRepository.RechazarPeticionDeRestauracion(idPeticion);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<PeticionRestauracion> ObtenerPeticionesPendientes()
        {
            try
            {
                return _auditoriaRepository.ObtenerPeticionesPendientes();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}