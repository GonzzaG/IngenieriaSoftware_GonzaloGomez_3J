using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IngenieriaSoftware.Abstracciones
{
    public interface IBitacora
    {
        DateTime FechaHora { get; set; }
        string Usuario { get; set; }
        string Actividad { get; set; }
        string InfoAdicional { get; set; }
        string Controller { get; set; }
    }
}
