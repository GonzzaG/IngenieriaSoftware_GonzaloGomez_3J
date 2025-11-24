namespace IngenieriaSoftware.BEL.Gestion_Compras_Insumos
{
    public class ProductoInventario : Producto
    {
        public bool Modificado { get; set; } = false;

        public ProductoInventario Clone()
        {
            return new ProductoInventario
            {
                Id = this.Id,
                Nombre = this.Nombre,
                Cantidad = this.Cantidad,
                Modificado = this.Modificado
            };
        }
    }
}
