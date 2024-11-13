using IngenieriaSoftware.BEL;
using IngenieriaSoftware.BEL.Negocio;
using IngenieriaSoftware.DAL.EntityDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IngenieriaSoftware.BLL
{
    public class ComandaBLL
    {
        private readonly ComandaDAL _comandaDAL = new ComandaDAL();
        public List<ComandaProducto> _comandaProductos = new List<ComandaProducto>();

        public void NuevoComandaProducto(Producto producto, int comandaId, int cantidad)
        {
            var comandaProducto = new ComandaProducto
            {
                ComandaId = comandaId,
                Producto = producto,
                Cantidad = cantidad,
                EstadoProducto = BEL.Constantes.EstadoProducto.Estado.Propuesta,
                PrecioUnitario = producto.Precio
            };
            
            //verificamos si el producto ya existe en la lista de comandaProducto, para reordenarlo si es asi 
            var productoComanda = _comandaProductos.Find(cp => cp.Producto == comandaProducto.Producto);
            if(productoComanda != null)
            {
                productoComanda.Cantidad += cantidad;
            }
            else
            {
                _comandaProductos.Add(comandaProducto);
            }

        }

        public int InsertarComanda(int mesaId)
        {
            return _comandaDAL.InsertarComanda(mesaId);
        }

        public List<ComandaProducto> ObtenerComandaProducto(int mesaId)
        {
            return ObtenerComandaProductoPorMesaId(mesaId);
            
        }

        private List<ComandaProducto> ObtenerComandaProductoPorMesaId(int mesaId)
        {
            return _comandaDAL.ObtenerComandaProductoPorMesaId(mesaId);
        }
    }
}
