using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IngenieriaSoftware.Servicios.Interfaces
{
    public interface ITraduccionExcepcion : IIdiomaObservador
    {
        int CodigoError { get; }
        string Mensajes { get; set; }
    }
}
