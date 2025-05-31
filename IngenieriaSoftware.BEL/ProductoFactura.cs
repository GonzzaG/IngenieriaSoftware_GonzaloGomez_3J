namespace IngenieriaSoftware.BEL
{
    public class ProductoFactura
    {
        public int ProductoId { get; set; }
        public string NombreProducto { get; set; }
        public int Cantidad { get; set; }
        public decimal PrecioUnitario { get; set; }
        public decimal Descuento { get; set; }

        public decimal Subtotal
        {
            get { return (PrecioUnitario * Cantidad) - Descuento; }
        }
    }
}