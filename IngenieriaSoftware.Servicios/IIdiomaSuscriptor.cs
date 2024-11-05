namespace IngenieriaSoftware.Servicios
{
    public interface IIdiomaSuscriptor
    {
        string Tag { get; set; }
        string Name { get; set; }   
        void Actualizar(string texto);
    }
}