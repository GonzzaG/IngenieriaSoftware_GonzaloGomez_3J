using IngenieriaSoftware.Abstracciones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace IngenieriaSoftware.Servicios.DTOs
{
    public class IdiomaSuscriptorDTO : IIdiomaSuscriptor
    {
        public string Tag { get; set; }
        public string Traduccion { get; set; }

        public void Actualizar(string nuevoTexto)
        {
            Traduccion = nuevoTexto;    
        }
    }
}
