using IngenieriaSoftware.BEL;
using IngenieriaSoftware.BEL.Negocio;
using IngenieriaSoftware.DAL.EntityDAL;
using IngenieriaSoftware.Servicios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace IngenieriaSoftware.BLL.Mesas
{
    public class MesaBLL
    {
        private readonly MesaDAL _mesaDAL;
        private readonly ComandaBLL _comandaBLL;
        private readonly FacturaBLL _facturaBLL;
        private List<Mesa> _mesas;

        public MesaBLL()
        {
            _mesaDAL = new MesaDAL();
            _comandaBLL = new ComandaBLL();
            _facturaBLL = new FacturaBLL();
        }
        public List<Mesa> Mesas()
        {
            if(_mesas == null)
            {
                _mesas = new List<Mesa>();
            }

            return _mesas;
        }

        public bool MesaOcupada(int mesaId)
        {
            var mesa = ObtenerMesaDisponiblePorId(mesaId);
            if (mesa.EstadoMesa == EstadoMesa.Estado.Ocupada)
                return true;
            else
                return false;

        }

        public void AsignarMesa(int mesaId)
        {
            int resultado = _mesaDAL.AsignarMesa(mesaId);

            if (resultado == 1) // No se pudo asignar la mesa
            {
                throw new MesaNoDisponibleException();
            }
            else //==0 se pudo asignar la mesa
            {
                var mesa = Mesas().Find(m => m.MesaId == mesaId);
                mesa.EstadoMesa = EstadoMesa.Estado.Ocupada;

                throw new MesaAsignadaException();
            }
        }

        public void CerrarMesa(int mesaId, decimal propina, decimal descuento, int medioDePagoId, int clienteId)
        {
            using (var transaction = new TransactionScope())
            {
                var comanda = _comandaBLL.ObtenerComandaPorMesaId(mesaId);

                _mesaDAL.CambiarEstadoMesaCerrada(mesaId);

                List<ComandaProducto> productosComanda = _comandaBLL.ObtenerComandaProductoPorComandaId(comanda.ComandaId);
                if (productosComanda == null || !productosComanda.Any())
                {
                    throw new Exception("No se encontraron productos para la comanda especificada.");
                }

                Factura factura = _facturaBLL.GenerarFactura(comanda.ComandaId, mesaId, propina, descuento, medioDePagoId, clienteId);
                
                transaction.Complete();
            }
        }

        public void CambiarEstadoMesaCerrada(int mesaId)
        {
            _mesaDAL.CambiarEstadoMesaCerrada(mesaId);
        }
        public void CambiarEstadoMesaDesocupada(int mesaId)
        {
            using(var transaction = new TransactionScope())
            {
                _mesaDAL.CambiarEstadoMesa(mesaId, (int)EstadoMesa.Estado.Desocupada);

                transaction.Complete();
            }
        }
        public List<Mesa> GuardarMesa(Mesa mesa)
        {
            _mesas = _mesaDAL.GuardarMesa(mesa);
            return _mesas;
        }
         
        public List<Mesa> ObtenerTodasLasMesas()
        {
            _mesas = _mesaDAL.ObtenerTodasLasMesas();
            return _mesas;
        }
        
        public List<Mesa> ObtenerMesasDisponibles()
        {
            _mesas = _mesaDAL.ObtenerMesasDisponibles((int)EstadoMesa.Estado.FueraDeServicio);
            return _mesas;
        }

        public List<Mesa> ObtenerMesasCerradas()
        {
            _mesas = _mesaDAL.ObtenerMesasPorEstado((int)EstadoMesa.Estado.Cerrada);
            return _mesas;
        }

        public Mesa ObtenerMesaDisponiblePorId(int mesaId)
        {
            return _mesaDAL.ObtenerMesaDisponiblePorId(mesaId, (int)EstadoMesa.Estado.FueraDeServicio);
        }

        public void EliminarMesa(int mesaId)
        {
            _mesaDAL.EliminarMesa(mesaId);
        }
    }
}
