using IngenieriaSoftware.BEL.Constantes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IngenieriaSoftware.BEL.Negocio
{
    public class ComandaProducto : Producto
    {
        public int ComandaId { get; set; }
        public Producto Producto { get; set; }
        public new int ProductoId { get; set; }
        public new string Nombre { get; set; }
        public EstadoComandaProductos.Estado EstadoProducto { get; set; } = Constantes.EstadoComandaProductos.Estado.Propuesta;
        public int Cantidad { get; set; }
        public decimal PrecioUnitario { get; set; }
        public decimal Subtotal => Cantidad * PrecioUnitario;
    }
}
