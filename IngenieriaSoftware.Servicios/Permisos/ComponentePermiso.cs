using System.Collections.Generic;

namespace IngenieriaSoftware.Servicios.Permisos
{
    public abstract class ComponentePermiso
    {
        private string _nombre;

        public ComponentePermiso(string nombre)
        {
            _nombre = nombre;
        }

        public string Nombre
        { get { return _nombre; } }

        public abstract void AgregarHijo(ComponentePermiso c);

        public abstract IList<ComponentePermiso> ObtenerHijos();

        public abstract int ObtenerTamaño { get; }
    }
}