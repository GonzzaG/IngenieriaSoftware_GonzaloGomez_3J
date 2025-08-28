using IngenieriaSoftware.BLL;
using IngenieriaSoftware.UI.Interfaces;

namespace IngenieriaSoftware.UI
{
    internal interface IVerificoNotificaciones : IActualizable
    {
        NotificacionService _notificacionService { get; }
          
        void VerificarNotificaciones();
    }
}