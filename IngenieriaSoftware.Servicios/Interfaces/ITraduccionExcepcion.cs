namespace IngenieriaSoftware.Servicios.Interfaces
{
    public interface ITraduccionExcepcion : IIdiomaObservador
    {
        int CodigoError { get; }
        string Mensajes { get; set; }
    }
}