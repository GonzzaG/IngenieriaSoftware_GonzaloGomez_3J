using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IngenieriaSoftware.BEL.QueryModels
{
    /// <summary>
    /// Modelo que representa los filtros de búsqueda para consultas.
    /// </summary>
    public class FiltroQueryModel
    {
        public int? Id { get; set; } = 0;
        public string Nombre { get; set; } = string.Empty;
        public int? Estado { get; set; } 

    }
}
