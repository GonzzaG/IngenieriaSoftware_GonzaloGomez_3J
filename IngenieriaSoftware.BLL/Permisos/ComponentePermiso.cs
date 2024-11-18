using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IngenieriaSoftware.BLL.Permisos
{
    public abstract class ComponentePermiso
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public int? PermisoPadreId { get; set; }

        protected ComponentePermiso(string nombre)
        {
            Nombre = nombre;
        }

        public abstract void AgregarHijo(ComponentePermiso c);
        public abstract IList<ComponentePermiso> ObtenerHijos();
        public abstract int ObtenerTamaño { get; }




    }
}
