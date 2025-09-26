using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IngenieriaSoftware.BEL.OrdenDeCompra.Models
{
    public class OrdenCompraQuery
    {
        public string NumOrdenCompra { get; set; }
        public DateTime? FechaDesde { get; set; }
        public int? IdEstado { get; set; }
    }
}
