using IngenieriaSoftware.BEL;
using IngenieriaSoftware.BEL.Constantes;
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
        private readonly NotificacionDAL _notificacionDAL = new NotificacionDAL();
        public List<ComandaProducto> _comandaProductos = new List<ComandaProducto>();

        public List<Comanda> ObtenerComandasPendientes()
        {
            return _comandaDAL.ObtenerComandasPendientes();
        }

        public void MarcarProductosEnPreparacion(List<ComandaProducto> productos)
        {
            _comandaDAL.ActualizarEstadoComandaProducto(productos, (int)EstadoComandaProductos.Estado.En_Preparacion);
        }

        public void MarcarProductoslistos(List<ComandaProducto> productos)
        {
            _comandaDAL.ActualizarEstadoComandaProducto(productos, (int)EstadoComandaProductos.Estado.Lista);
        }

        public void NotificarComandaLista(Comanda comanda)
        {
            //Voy a insertar una nueva notificacion con los datos de la comanda
            _notificacionDAL.InsertarNotificacion(comanda.MesaId, comanda.ComandaId);
        }
        public void NuevoComandaProducto(Producto producto, int comandaId, int cantidad)
        {
            var comandaProducto = new ComandaProducto
            {
                ComandaId = comandaId,
                Producto = producto,
                Cantidad = cantidad,
                EstadoProducto = BEL.Constantes.EstadoComandaProductos.Estado.Propuesta,
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

        public void InsertarComandaProductos(List<ComandaProducto> comandaProductos)
        {
            _comandaDAL.InsertarComandaProductos(comandaProductos);    
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

        public List<ComandaProducto> ObtenerComandaProductosPendientes(int mesaId, int comandaId)
        {
            return _comandaDAL.ObtenerComandaProductosPendientes(mesaId, comandaId);
        }

        private void ObtenerNotificacionesNoVistas(int mesaId, int comandaId)
        {
            _notificacionDAL.ObtenerNotificacionesNoVistas(mesaId, comandaId);
        }
    }
}
