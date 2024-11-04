using IngenieriaSoftware.Servicios.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IngenieriaSoftware.Servicios
{
    public interface ITraduccionServicio
    {
        Dictionary<string, string> ObtenerTraduccionesPorIdioma(int idiomaId);

    }
}
