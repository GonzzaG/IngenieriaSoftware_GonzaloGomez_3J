using IngenieriaSoftware.Abstracciones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IngenieriaSoftware.BEL
{
    public class Etiqueta : IEtiqueta
    {
        public int Id {  get; set; }
        public string Tag { get; set; }
        public string Nombre { get; set; }  
    }
}
