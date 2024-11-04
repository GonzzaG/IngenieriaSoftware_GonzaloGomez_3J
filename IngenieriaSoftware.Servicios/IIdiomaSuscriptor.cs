using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IngenieriaSoftware.Servicios
{
    public interface IIdiomaSuscriptor
    {
        string Tag { get; set; }
        void Actualizar(string texto);
    }
}
