namespace IngenieriaSoftware.BEL.Negocio
{
    public class Notificacion
    {
        public int NotificacionId { get; set; }
        public int ComandaId { get; set; }
        public int MesaId { get; set; }
        public bool Visto { get; set; }
    }
}