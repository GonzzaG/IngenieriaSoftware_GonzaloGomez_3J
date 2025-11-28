using System;

namespace IngenieriaSoftware.BEL.Gestion_Compras_Insumos
{
    public class EscasezModel
    {
        public int IdProducto { get; set; }
        public decimal? CantidadRecomendada { get; set; }
        public DateTime FechaRegistro { get; set; }
        public int? RegistradoPor { get; set; }
        public string Observacion { get; set; }
    }
}
