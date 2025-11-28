namespace IngenieriaSoftware.BEL.FacturaProveedor
{
    public class FacturaProveedorDetalleModel
    {
        public int IdDetalleFacturaProveedor { get; set; }
        public int IdFacturaProveedor { get; set; }
        public int IdProducto { get; set; }

        public string NombreProducto { get; set; }
        public string Descripcion { get; set; }

        public decimal Cantidad { get; set; }
        public decimal PrecioUnitario { get; set; }
        public decimal Descuento { get; set; }
        public decimal Impuesto { get; set; }
        public decimal TotalLinea { get; set; }

        public int? IdOrdenCompraDetalle { get; set; }
    }
}
