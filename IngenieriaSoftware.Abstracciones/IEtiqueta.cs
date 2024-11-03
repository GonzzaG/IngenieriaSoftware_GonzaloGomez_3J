using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IngenieriaSoftware.Abstracciones
{
    public interface IEtiqueta
    {
        int Id { get; set; }
        string Tag { get; set; }
        string Nombre { get; set; }
    }
}
