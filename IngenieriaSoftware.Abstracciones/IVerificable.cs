namespace IngenieriaSoftware.Abstracciones
{
    public interface IVerificable
    {
        int Id { get; set; }
        string DVH { get; set; }

        bool VerificarIntegridad(string dvhBD);
    }
}