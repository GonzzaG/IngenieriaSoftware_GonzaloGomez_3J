using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IngenieriaSoftware.BEL
{
    public class Producto
    {
        public int ProductoId { get; set; }
        public int Nombre { get; set; }
        public string Descripcion { get; set; }
        public decimal Precio { get; set; }
        public bool EsPostre { get; set; }
        public string Categoria { get; set; }
        public bool Disponibilidad { get; set; }
        public int TiempoPreparacion { get; set; }
        public bool Diponible { get; set; }
    }
}
