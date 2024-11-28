using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IngenieriaSoftware.Servicios.Permisos
{
    public class HojaPermiso : ComponentePermiso
    {
        int _tamaño;
        public HojaPermiso(string nombre, int tamaño) : base(nombre)
        {
            _tamaño = tamaño;
        }
        public int Tamaño { get { return _tamaño; } }

        public override IList<ComponentePermiso> ObtenerHijos()
        {
            return null;
        }

        public override void AgregarHijo(ComponentePermiso c)
        {
        
        }

        public override int ObtenerTamaño
        {
            get
            {
                return _tamaño;
            }
        }

    }
}
