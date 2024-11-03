using IngenieriaSoftware.Abstracciones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IngenieriaSoftware.Servicios.DTOs
{
    public class IdiomaDTO : IIdioma
    {
        public int Id {  get; set; }
        public string Nombre { get; set; }
        public string Codigo { get; set; }
        public Dictionary<string, string> Traducciones { get; set; }
        public bool Habilitado { get; set; }
    }
}
