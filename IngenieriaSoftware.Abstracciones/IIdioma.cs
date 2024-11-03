using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IngenieriaSoftware.Abstracciones
{
    public interface IIdioma
    {
       int Id { get; set; }
       string Nombre { get; set; }
       string Codigo { get; set; }
       bool Habilitado { get; set; }
       Dictionary<string, string> Traducciones { get; set; }

    }
}
