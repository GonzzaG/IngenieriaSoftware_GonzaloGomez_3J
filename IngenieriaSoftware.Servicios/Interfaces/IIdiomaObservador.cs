namespace IngenieriaSoftware.Servicios.Interfaces
{
    public interface IIdiomaObservador
    {
        int Tag { get; set; }
        string Name { get; set; }

        void Actualizar(string nuevoTexto);
    }
}