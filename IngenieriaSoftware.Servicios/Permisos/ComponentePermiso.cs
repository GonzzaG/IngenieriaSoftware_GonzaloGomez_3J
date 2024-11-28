using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IngenieriaSoftware.Servicios.Permisos
{
    public abstract class ComponentePermiso
    {
        string _nombre;

        public ComponentePermiso(string nombre)
        {
            _nombre = nombre;
        }

        public string Nombre { get { return _nombre; } }
        public abstract void AgregarHijo(ComponentePermiso c);
        public abstract IList<ComponentePermiso> ObtenerHijos();
        public abstract int ObtenerTamaño {  get; }




    }
}
