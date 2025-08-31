using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IngenieriaSoftware.BEL.OrdenDeCompra
{
    public class OrdenDeCompraModel
    {
		public string NumOrdenCompra { get; set; }
        public int IdOrdenCompra { get; set; }
		public int IdProveedor { get; set; }
		public DateTime Fecha { get; set; }
		public DateTime? FechaEntregaEsperada { get; set; }
		public string CondicionesPago { get; set; }
		public string Moneda { get; set; }
		public decimal? TipoCambio { get; set; }
        // Estado puede ser: Pendiente, Aprobada, Rechazada, Recibida, Cancelada
        // Se va cambiando durante el proceso, pero puede los usuairos pueden ir aprobandolo, rechazandolo, etc.
        //Cuando se quiere asignar una orden de compra a la factura, la orden debe estar en estado "Aprobada"
        public string Estado { get; set; }
		public decimal TotalEsperado { get; set; }
		public string Observaciones { get; set; }
		public List<OrdenDeCompraDetalleModel> Detalles { get; set; }

        // Auditoria
        // Estos se van a ir cargando automaticamente
        public DateTime FechaCreacion { get; set; }
		public string UsuarioCreacion { get; set; }
		public DateTime? FechaModificacion { get; set; }
		public string UsuarioModificacion { get; set; }

	

    }
}
