using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IngenieriaSoftware.Servicios.Interfaces
{
    public interface IIdiomaObservador
    {
        int Tag { get; set; }
        string Name { get; set; }
        void Actualizar(string nuevoTexto);
    }
}
