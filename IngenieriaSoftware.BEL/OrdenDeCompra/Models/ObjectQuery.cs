using System;

namespace IngenieriaSoftware.BEL.OrdenDeCompra.Models
{
    public class ObjectQuery
    {
        public string Numero { get; set; }
        public DateTime? FechaDesde { get; set; }
        public int? IdEstado { get; set; }
    }
}
