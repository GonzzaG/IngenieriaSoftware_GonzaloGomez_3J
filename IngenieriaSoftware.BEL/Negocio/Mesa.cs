namespace IngenieriaSoftware.BEL
{
    public class Mesa
    {
        public Mesa()
        { }

        public Mesa(int mesaId, int cantComensales, EstadoMesa.Estado estadoMesa)
        {
            MesaId = mesaId;
            CapacidadMaxima = cantComensales;
            EstadoMesa = estadoMesa;
        }

        public int MesaId { get; set; }
        public int CapacidadMaxima { get; set; }
        public EstadoMesa.Estado EstadoMesa { get; set; } = BEL.EstadoMesa.Estado.Desocupada;
    }
}