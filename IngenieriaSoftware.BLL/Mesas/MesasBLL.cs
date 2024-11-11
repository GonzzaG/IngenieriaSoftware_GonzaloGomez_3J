using IngenieriaSoftware.BEL;
using IngenieriaSoftware.Servicios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IngenieriaSoftware.BLL.Mesas
{
    public class MesasBLL
    {
        private List<Mesa> _mesas;

        public List<Mesa> ObtenerMesas()
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

    }
}
