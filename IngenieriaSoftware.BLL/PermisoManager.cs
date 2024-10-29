using IngenieriaSoftware.BEL;
using System.Collections.Generic;

namespace IngenieriaSoftware.BLL
{
    public class PermisoManager
    {
        private static PermisoManager _instance;
        private static readonly object _lock = new object();

        private List<Permiso> _permisosGlobales;

        private PermisoManager()
        {
            _permisosGlobales = new List<Permiso>(); // Inicializa la lista vacía
        }

        // Implementación del patrón Singleton
        public static PermisoManager Instance
        {
            get
            {
                lock (_lock)
                {
                    if (_instance == null)
                    {
                        _instance = new PermisoManager();
                    }
                    return _instance;
                }
            }
        }

        public List<Permiso> ObtenerPermisosGlobales()
        {
            return _permisosGlobales;
        }

        public Permiso ObtenerPermisoPorId(int idPermiso)
        {
            return _permisosGlobales.Find(p => p.Id == idPermiso);
        }

        public void CargarPermisos(List<Permiso> permisos)
        {
            _permisosGlobales = permisos;
        }
    }
}
