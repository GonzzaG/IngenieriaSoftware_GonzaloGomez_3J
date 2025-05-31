using IngenieriaSoftware.BEL.Negocio;
using System.Collections.Generic;

namespace IngenieriaSoftware.BLL
{
    public class NotificacionService
    {
        private readonly ComandaBLL _comandaBLL = new ComandaBLL();

        public List<Notificacion> ObtenerNotificaciones()
        {
            var notificaciones = _comandaBLL.ObtenerNotificacionesNoVistas();
            if (notificaciones != null)
            {
                return notificaciones;
            }

            return null;
        }
    }
}