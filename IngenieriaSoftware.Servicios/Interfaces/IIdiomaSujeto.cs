namespace IngenieriaSoftware.Servicios.Interfaces
{
    public interface IIdiomaSujeto
    {
        void Suscribir(IIdiomaObservador suscriptor);

        void Desuscribir(IIdiomaObservador suscriptor);

        void CambiarEstado(int nuevoIdiomaId);
    }
}