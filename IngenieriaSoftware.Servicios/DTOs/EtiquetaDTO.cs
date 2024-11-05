using IngenieriaSoftware.Abstracciones;

namespace IngenieriaSoftware.Servicios.DTOs
{
    public class EtiquetaDTO : IEtiqueta
    {
       // public int Id { get; set; }
        public int Tag { get; set; }
        public string Nombre { get; set; }
    }
}