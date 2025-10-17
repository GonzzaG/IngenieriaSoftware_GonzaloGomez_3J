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
    public class ConvertirDetallesAprobacionDataSet
    {
		public int IdDetalle { get; set; }
		public int IdOrdenCompra { get; set; }
		public int IdProducto { get; set; }
		public int Cantidad { get; set; }
		public decimal? PrecioUnitarioEsperado { get; set; }
		public decimal? DescuentoLinea { get; set; }
		public string NotasLinea { get; set; }
		public decimal? Subtotal 
		{ 
			get => PrecioUnitarioEsperado != null 
					? Cantidad * PrecioUnitarioEsperado 
					: 0; 
		}

    }

	public class OrdenDeCompraDetalleAprobacionModel : ConvertirDetallesAprobacionDataSet
    {
		public string NombreProducto { get; set; }

    }
}
