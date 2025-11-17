namespace IngenieriaSoftware.Servicios.DTOs
{
    public class ProductoSelectionModel
    {
        public int IdProducto { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; } 
        public string Categoria { get;set; }
        public string Tipo { get; set; }
        public int Cantidad { get; set; }  
        public decimal? PrecioUnitarioEsperado { get; set; }
    }

    
}
