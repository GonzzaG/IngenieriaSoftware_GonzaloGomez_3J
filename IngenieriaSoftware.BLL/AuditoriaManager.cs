using IngenieriaSoftware.BEL;
using IngenieriaSoftware.BEL.Auditoria;
using IngenieriaSoftware.DAL;
using IngenieriaSoftware.Servicios;
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
                BitacoraHelper.RegistrarActividad(SessionManager.GetInstance.Usuario.ToString(), "Obteniendo tablas auditadas", DateTime.Now, string.Empty, "AuditoriaManager", "ObtenerTablasAuditadas");   
                return _auditoriaRepository.ObtenerTablasAuditadas();
            }
            catch (Exception ex)
            {
                BitacoraHelper.RegistrarError(SessionManager.GetInstance.Usuario.ToString(), ex, "AuditoriaManager", "ObtenerTablasAuditadas");
                throw new Exception("Error al obtener las tablas auditadas: " + ex.Message);
            }
        }

        public List<UsuarioAuditoriaModel> ObtenerRegistroDeTabla(string nombreTabla)
        {
            try
            {
                BitacoraHelper.RegistrarActividad(SessionManager.GetInstance.Usuario.ToString(), "Obteniendo registro de tabla", DateTime.Now, string.Empty, "AuditoriaManager", "ObtenerRegistroDeTabla");
                return _auditoriaRepository.ObtenerRegistroDeTabla(nombreTabla);
            }
            catch (Exception ex)
            {
                BitacoraHelper.RegistrarError(SessionManager.GetInstance.Usuario.ToString(), ex, "AuditoriaManager", "ObtenerRegistroDeTabla");
                throw new Exception(ex.Message);
            }
        }

        public List<AuditoriaDetalle> ObtenerDetalleCambio(Guid idCambio)
        {
            try
            {
                BitacoraHelper.RegistrarActividad(SessionManager.GetInstance.Usuario.ToString(), "Obteniendo detalle de cambio", DateTime.Now, string.Empty, "AuditoriaManager", "ObtenerDetalleCambio");
                return _auditoriaRepository.ObtenerDetalleCambio(idCambio);
            }
            catch (Exception ex)
            {
                BitacoraHelper.RegistrarError(SessionManager.GetInstance.Usuario.ToString(), ex, "AuditoriaManager", "ObtenerDetalleCambio");
                throw new Exception(ex.Message);
            }
        }

        public List<AuditoriaDetalle> ObtenerDetalleCambio(string tabla, int registro)
        {
            try
            {
                BitacoraHelper.RegistrarActividad(SessionManager.GetInstance.Usuario.ToString(), "Obteniendo detalle de cambio por tabla y registro", DateTime.Now, string.Empty, "AuditoriaManager", "ObtenerDetalleCambio");
                return _auditoriaRepository.ObtenerDetalleCambio(tabla, registro);
            }
            catch (Exception ex)
            {
                BitacoraHelper.RegistrarError(SessionManager.GetInstance.Usuario.ToString(), ex, "AuditoriaManager", "ObtenerDetalleCambio");
                throw new Exception(ex.Message);
            }
        }

        public bool SolicitarRestauracion(PeticionRestauracion peticion)
        {
            try
            {
                BitacoraHelper.RegistrarActividad(SessionManager.GetInstance.Usuario.ToString(), "Solicitando restauración", DateTime.Now, string.Empty, "AuditoriaManager", "SolicitarRestauracion");
                return _auditoriaRepository.SolicitarRestauracion(peticion);
            }
            catch (Exception ex)
            {
                BitacoraHelper.RegistrarError(SessionManager.GetInstance.Usuario.ToString(), ex, "AuditoriaManager", "SolicitarRestauracion");
                throw new Exception(ex.Message);
            }
        }

        public bool AceptarPeticionDeRestauracion(int idPeticion, string usuarioAutorizador)
        {
            try
            {
                BitacoraHelper.RegistrarActividad(SessionManager.GetInstance.Usuario.ToString(), "Aceptando petición de restauración", DateTime.Now, string.Empty, "AuditoriaManager", "AceptarPeticionDeRestauracion");


                return _auditoriaRepository.AceptarPeticionDeRestauracion(idPeticion, usuarioAutorizador);
            }
            catch (Exception ex)
            {
                BitacoraHelper.RegistrarError(SessionManager.GetInstance.Usuario.ToString(), ex, "AuditoriaManager", "AceptarPeticionDeRestauracion");
                throw new Exception(ex.Message);
            }
        }

        public bool RechazarPeticionDeRestauracion(int idPeticion)
        {
            try
            {
                BitacoraHelper.RegistrarActividad(SessionManager.GetInstance.Usuario.ToString(), "Rechazando petición de restauración", DateTime.Now, string.Empty, "AuditoriaManager", "RechazarPeticionDeRestauracion");
                return _auditoriaRepository.RechazarPeticionDeRestauracion(idPeticion);
            }
            catch (Exception ex)
            {
                BitacoraHelper.RegistrarError(SessionManager.GetInstance.Usuario.ToString(), ex, "AuditoriaManager", "RechazarPeticionDeRestauracion");
                throw new Exception(ex.Message);
            }
        }

        public List<PeticionRestauracion> ObtenerPeticionesPendientes()
        {
            try
            {
                BitacoraHelper.RegistrarActividad(SessionManager.GetInstance.Usuario.ToString(), "Obteniendo peticiones pendientes", DateTime.Now, string.Empty, "AuditoriaManager", "ObtenerPeticionesPendientes");
                return _auditoriaRepository.ObtenerPeticionesPendientes();
            }
            catch (Exception ex)
            {
                BitacoraHelper.RegistrarError(SessionManager.GetInstance.Usuario.ToString(), ex, "AuditoriaManager", "ObtenerPeticionesPendientes");
                throw new Exception(ex.Message);
            }
        }
    }
}