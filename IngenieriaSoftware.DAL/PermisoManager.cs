using IngenieriaSoftware.BEL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IngenieriaSoftware.DAL
{
    public class PermisoManager
    {
        // La instancia singleton
        private static PermisoManager _instance;

        // Objeto para bloqueo de hilos (thread-safety)
        private static readonly object _lock = new object();

        // Lista global de permisos
        private List<Permiso> _permisosGlobales;

        // Constructor privado para evitar instanciación directa
        private PermisoManager()
        {
            _permisosGlobales = new List<Permiso>();
        }

        // Propiedad para acceder a la instancia singleton
        public static PermisoManager Instance
        {
            get
            {
                // Bloquear para asegurar que solo un hilo acceda a la creación de la instancia a la vez
                lock (_lock)
                {
                    // Si la instancia es nula, la creamos
                    if (_instance == null)
                    {
                        _instance = new PermisoManager();
                    }
                    return _instance;
                }
            }
        }

        // Propiedad para obtener o establecer la lista de permisos globales
        public List<Permiso> PermisosGlobales
        {
            get { return _permisosGlobales; }
            set { _permisosGlobales = value; }
        }

        // Método para agregar permisos
        public void AgregarPermiso(Permiso permiso)
        {
            if (!_permisosGlobales.Contains(permiso))
            {
                _permisosGlobales.Add(permiso);
            }
        }

        // Método para limpiar los permisos
        public void LimpiarPermisos()
        {
            _permisosGlobales.Clear();
        }
    }
}
