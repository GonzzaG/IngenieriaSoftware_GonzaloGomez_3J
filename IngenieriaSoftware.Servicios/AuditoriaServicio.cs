using System;

namespace IngenieriaSoftware.Servicios
{
    public class AuditoriaServicio
    {

        public void VerificarAuditoria(string nombreTabla)
        {
            try
            {

            }
            catch (Exception ex)
            {
                // Manejo de excepciones
                throw new Exception("Error al verificar la auditoría: " + ex.Message);
            }
        }

    }
}
