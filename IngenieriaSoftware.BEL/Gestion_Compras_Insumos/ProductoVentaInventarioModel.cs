namespace IngenieriaSoftware.BEL.Gestion_Compras_Insumos
{
    public class ProductoVentaInventarioModel
    {
        public int IdRelacion { get; set; }
        public int IdProductoVenta { get; set; }
        public int IdProductoInventario { get; set; }
        public string NombreProductoInventario { get; set; }
        public int CantidadUsada { get; set; }

    }

}
