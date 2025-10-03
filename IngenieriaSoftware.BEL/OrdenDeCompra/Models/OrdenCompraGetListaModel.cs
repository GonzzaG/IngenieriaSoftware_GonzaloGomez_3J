using IngenieriaSoftware.BEL.Constantes;
using System;
using System.Collections.Generic;

namespace IngenieriaSoftware.BEL.OrdenDeCompra.ViewModels
{
    public class OrdenCompraGetListaModel
    {
        public string NumOrdenCompra { get; set; }
        public string RazonSocialProveedor { get; set; }
        public DateTime Fecha { get; set; }
        public DateTime? FechaEntregaEsperada { get; set; }
        public string CondicionesPago { get; set; }
        //Tipo de cambio respecto a la moneda base de la empresa
        public decimal? TipoCambio { get; set; }
        public string Moneda { get; set; }

        // ComandaEstado puede ser: Pendiente, Aprobada, Rechazada, Recibida, Cancelada
        // Se va cambiando durante el proceso, pero puede los usuairos pueden ir aprobandolo, rechazandolo, etc.
        //Cuando se quiere asignar una orden de compra a la factura, la orden debe estar en estado "Aprobada"
        public OrdenCompraEstadoEnum Estado { get; set; }
        public decimal TotalEsperado { get; set; }
        public string Observaciones { get; set; }
        // Auditoria
        // Estos se van a ir cargando automaticamente
        public DateTime FechaCreacion { get; set; }
        public string UsuarioCreacion { get; set; }
    }

    public class OrdenCompraGetDetalles : OrdenCompraGetListaModel
    {
        public int IdOrdenCompra { get; set; }  
        public List<OrdenDeCompraDetalleModel> Detalles { get; set; }
    }
}
