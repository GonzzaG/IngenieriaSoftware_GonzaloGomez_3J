namespace IngenieriaSoftware.Abstracciones
{
    public interface IIdiomaSuscriptor
    {
        string Tag { get; }

        void Actualizar(string nuevoTexto);
    }
}