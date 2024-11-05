using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IngenieriaSoftware.Servicios
{
    public interface IIdiomaSujeto
    {
        void Suscribir(IIdiomaObservador suscriptor);
        void Notificar(int nuevoIdiomaId);
    }
}
