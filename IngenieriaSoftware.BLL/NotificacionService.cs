using IngenieriaSoftware.BEL.Negocio;
using IngenieriaSoftware.DAL.EntityDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
