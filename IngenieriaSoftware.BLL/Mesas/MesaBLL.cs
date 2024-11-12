using IngenieriaSoftware.BEL;
using IngenieriaSoftware.DAL.EntityDAL;
using IngenieriaSoftware.Servicios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IngenieriaSoftware.BLL.Mesas
{
    public class MesaBLL
    {
        private readonly MesaDAL _mesaDAL = new MesaDAL();
        private List<Mesa> _mesas;

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
