using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IngenieriaSoftware.BLL.Permisos
{
    public class CompositePermiso : ComponentePermiso
    {
        private List<ComponentePermiso> _hijos;

        public CompositePermiso(int id, string nombre, int? permisoPadreId = null) : base(nombre)
        {
            Id = id;
            PermisoPadreId = permisoPadreId;
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
                return _hijos.Sum(h => h.ObtenerTamaño);
            }
        }


    }
}
