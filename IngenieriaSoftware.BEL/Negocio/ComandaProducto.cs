using IngenieriaSoftware.BEL.Constantes;

namespace IngenieriaSoftware.BEL.Negocio
{
    public class ComandaProducto : Producto
    {
        public int ComandaId { get; set; }
        public Producto Producto { get; set; }
        public new int ProductoId { get; set; }
        public new string Nombre { get; set; }
        public ComandaProductosEstado EstadoProducto { get; set; } = ComandaProductosEstado.Propuesta;
        public int Cantidad { get; set; }
        public decimal PrecioUnitario { get; set; }
        public decimal Subtotal => Cantidad * PrecioUnitario;
    }
}