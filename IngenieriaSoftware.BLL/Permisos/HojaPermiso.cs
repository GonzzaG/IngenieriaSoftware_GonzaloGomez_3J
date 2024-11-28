using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IngenieriaSoftware.BLL.Permisos
{
    public class HojaPermiso : ComponentePermiso
    {
        private readonly int _tamaño;

        public HojaPermiso(int id, string nombre, int tamaño, int? permisoPadreId = null) : base(nombre)
        {
            Id = id;
            PermisoPadreId = permisoPadreId;
            _tamaño = tamaño;
        }

        public override void AgregarHijo(ComponentePermiso c)
        {
            throw new InvalidOperationException("No se pueden agregar hijos a un permiso hoja.");
        }

        public override IList<ComponentePermiso> ObtenerHijos()
        {
            return null;
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
