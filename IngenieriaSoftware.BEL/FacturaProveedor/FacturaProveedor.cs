using System;
using System.Collections.Generic;

namespace IngenieriaSoftware.BEL.FacturaProveedor
{
    public class FacturaProveedor
    {
        public int IdFacturaProveedor { get; set; } 
        public string NumeroFactura { get; set; }
        public DateTime FechaEmision { get; set; }
        public int? IdOrdenCompra { get; set; }
        public int IdProveedor { get; set; }
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

        public List<FacturaProveedorDetalle> Detalles { get; set; } = new List<FacturaProveedorDetalle>();

    }

    public class FacturaProveedorGetListModel
    {
        public int IdFacturaProveedor { get; set; }
        public string NumeroFactura { get; set; }
        public DateTime FechaEmision { get; set; }
        public int? IdOrdenCompra { get; set; }
        public int IdProveedor { get; set; }
        public int IdUsuarioCreador { get; set; }
        public decimal Subtotal { get; set; }
        public decimal Impuestos { get; set; }
        public decimal Descuento { get; set; }
        public decimal Total { get; set; }
        public string MetodoPago { get; set; }
        public string EstadoFactura { get; set; }
        public string Observaciones { get; set; }
        public DateTime FechaRegistro { get; set; }
        public DateTime? FechaPago { get; set; }
    }

    public class FacturaProveedorGetListFilterModel
    {
        public int IdFacturaProveedor { get; set; }
        public string NumeroFactura { get; set; }
        public DateTime FechaEmision { get; set; }
        public int? IdOrdenCompra { get; set; }
        public string ProveedorNombre { get; set; }
        public string UsuarioNombre { get; set; }
        public decimal Subtotal { get; set; }
        public decimal Impuestos { get; set; }
        public decimal Descuento { get; set; }
        public decimal Total { get; set; }
        public string MetodoPago { get; set; }
        public string EstadoFactura { get; set; }
        public string Observaciones { get; set; }
        public DateTime FechaRegistro { get; set; }
        public DateTime? FechaPago { get; set; }
    }
}
