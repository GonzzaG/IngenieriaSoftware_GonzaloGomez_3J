using IngenieriaSoftware.BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IngenieriaSoftware.UI
{
    internal interface IActualizable
    {
        NotificacionService _notificacionService { get; }
        void Actualizar();

        void VerificarNotificaciones();
    }
}
