using System;
using System.Collections.Generic;

namespace IngenieriaSoftware.BEL.FacturaProveedor
{
    public class FacturaProveedorWithDetalles
    {
        public int IdFacturaProveedor { get; set; }
        public string NumeroFactura { get; set; }
        public DateTime FechaEmision { get; set; }

        public int IdOrdenCompra { get; set; }

        public int IdProveedor { get; set; }
        public string RazonSocialProveedor { get; set; }

        public int IdUsuarioCreador { get; set; }

        public decimal Subtotal { get; set; }
        public decimal Impuestos { get; set; }
        public decimal Descuento { get; set; }
        public decimal Total { get; set; }

        public string MetodoPago { get; set; }

        public int IdFacturaProveedorEstado { get; set; }

        public string Observaciones { get; set; }

        public DateTime FechaRegistro { get; set; }
        public DateTime? FechaPago { get; set; }

        public bool Anulada { get; set; }

       
        public List<FacturaProveedorDetalleModel> Detalles { get; set; }
    }
}
