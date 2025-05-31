using IngenieriaSoftware.BLL;

namespace IngenieriaSoftware.UI
{
    internal interface IActualizable
    {
        NotificacionService _notificacionService { get; }

        void Actualizar();

        void VerificarNotificaciones();
    }
}