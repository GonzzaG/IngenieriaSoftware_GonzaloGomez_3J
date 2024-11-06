using IngenieriaSoftware.Abstracciones;
using System.Collections.Generic;

namespace IngenieriaSoftware.Servicios.DTOs
{
    public class IdiomaDTO : IIdioma
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Codigo { get; set; }
        public Dictionary<string, string> Traducciones { get; set; }
        public bool Habilitado { get; set; }
    }
}