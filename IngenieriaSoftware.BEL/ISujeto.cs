using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IngenieriaSoftware.BEL
{
    internal interface ISujeto
    {
        void Agregar(IObserver usuario);
        void Quitar(IObserver usuario);
        void Notificar();
    }
}
