using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IngenieriaSoftware.Servicios.DTOs
{
    public class ProductoOrdenCompraViewModel
    {
        public int IdProducto { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; } 
        public string Categoria { get;set; }
        public string Tipo { get; set; }
        public int Cantidad { get; set; }   
    }
}
