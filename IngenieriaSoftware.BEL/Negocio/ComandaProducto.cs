using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IngenieriaSoftware.BEL.Negocio
{
    public class ComandaProducto : Producto
    {
        public int ComandaProductoId { get; set; }
        public int ComandaId { get; set; }
        
        public int ProductoId {  get; set; }
        public Producto Producto { get; set; }
        
        public int Cantidad { get; set; }
        public decimal PrecioUnitario { get; set; }
        public decimal Subtotal => Cantidad * PrecioUnitario;
    }
}
