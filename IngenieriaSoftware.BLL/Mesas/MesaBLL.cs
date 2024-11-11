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

        public void AsignarMesa(int mesaId)
        {
            var mesa = _mesas.Find(m => m.MesaId == mesaId);
            if (mesa.EstadoMesa == EstadoMesa.Estado.Ocupada)
            {
                throw new MesaNoDisponibleException();
            }
            else 
            {
                mesa.EstadoMesa = EstadoMesa.Estado.Ocupada;
                throw new MesaAsignadaException();
            }
        }
        public List<Mesa> GuardarMesa(Mesa mesa)
        {
            _mesas = _mesaDAL.GuardarMesa(mesa);
            return _mesas;
        }
        public List<Mesa> ObtenerMesasDisponibles()
        {
            _mesas = _mesaDAL.ObtenerMesasDisponibles((int)EstadoMesa.Estado.FueraDeServicio);
            return _mesas;
        }
        public List<Mesa> ObtenerTodasLasMesas()
        {
            _mesas = _mesaDAL.ObtenerTodasLasMesas();
            return _mesas;
        }
        public void EliminarMesa(int mesaId)
        {
            _mesaDAL.EliminarMesa(mesaId);
        }
        public void ModificarMesa(Mesa mesa)
        {
            _mesaDAL.ModificarMesa(mesa);
        }
    }
}
