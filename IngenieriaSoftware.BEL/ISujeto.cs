namespace IngenieriaSoftware.BEL
{
    internal interface ISujeto
    {
        void Agregar(IObserver usuario);

        void Quitar(IObserver usuario);

        void Notificar();
    }
}