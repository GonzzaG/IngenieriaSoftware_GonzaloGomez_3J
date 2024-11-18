using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IngenieriaSoftware.Servicios.Permisos
{
    public class CompositePermiso : ComponentePermiso
    {
        private List<ComponentePermiso> _hijos;
        public CompositePermiso(string nombre) : base(nombre)
        {
            _hijos = new List<ComponentePermiso>();
        }

        public override void AgregarHijo(ComponentePermiso c)
        {
            _hijos.Add(c);
        }

        public override IList<ComponentePermiso> ObtenerHijos()
        {
            return _hijos.ToArray();
        }

        public override int ObtenerTamaño
        {
            get
            {
                int t = 0;

                foreach (var item in _hijos)
                {
                    t += item.ObtenerTamaño;
                }

                return t;
            }

        }


    }
}
