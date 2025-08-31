using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IngenieriaSoftware.BEL.OrdenDeCompra
{
    /// <summary>
    /// Modelo de BD de la tabla OrdenCompraDetalle
    /// </summary>
    public class OrdenDeCompraDetalleModel
    {
		public int IdDetalle { get; set; }
		public int IdOrdenCompra { get; set; }
		public int IdProducto { get; set; }
		public decimal Cantidad { get; set; }
		public decimal PrecioUnitarioEsperado { get; set; }
		public decimal DescuentoLinea { get; set; }
		public string NotasLinea { get; set; }
		public decimal? Subtotal { get; set; }


		//Auditoria
		public DateTime FechaCreacion { get; set; }
		public string UsuarioCreacion { get; set; }
		public DateTime? FechaModificacion { get; set; }
		public string UsuarioModificacion { get; set; }
    }
}
