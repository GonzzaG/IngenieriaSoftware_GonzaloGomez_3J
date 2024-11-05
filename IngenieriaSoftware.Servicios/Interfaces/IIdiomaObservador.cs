namespace IngenieriaSoftware.Servicios
{
    public interface IIdiomaObservador
    {
        string Tag { get; set; }
        string Name { get; set; }   
        void Actualizar(string texto);
    }
}