using IngenieriaSoftware.BEL.Gestion_Compras_Insumos;

namespace IngenieriaSoftware.BEL
{
    public class Producto
    {
        public int? ProductoId { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public decimal Precio { get; set; }
        public int TiempoPreparacion { get; set; }
        public bool Diponible { get; set; }
        public bool EsPostre { get; set; }
        public Constantes.TipoProducto.Tipo IdCategoria { get; set; } = Constantes.TipoProducto.Tipo.SinAsignar;
        public Categoria oCategoria { get; set; }
    }
}