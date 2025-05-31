namespace IngenieriaSoftware.BEL.Negocio
{
    public class Cliente
    {
        public int ClienteId { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Email { get; set; }
        public string Telefono { get; set; }
        public string Direccion { get; set; }
        public string numeroTarjetaUltimos4 { get; set; }
        public string TipoTarjeta { get; set; }
        public string BancoEmisor { get; set; }

        public Cliente()
        {
        }
    }
}