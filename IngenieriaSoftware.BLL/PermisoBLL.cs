using IngenieriaSoftware.BEL;
using IngenieriaSoftware.DAL;
using IngenieriaSoftware.Servicios;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IngenieriaSoftware.BLL
{
    public class PermisoBLL : IPermisoService
    {
        private readonly IPermisoService _permisoService;

        private readonly PermisoDAL _permisoDAL;
        private readonly Dictionary<int, List<Permiso>> _permisosPorUsuario = new Dictionary<int, List<Permiso>>();
        private List<Permiso> _permisosGlobales; // Para almacenar todos los permisos

        public PermisoBLL(IPermisoService permisoService)
        {
            _permisoService = permisoService;
        }


        public List<Permiso> ObtenerPermisosDelUsuario(Usuario pUsuario)
        {
            
            pUsuario.Permisos = ListarPermisosDelUsuario(pUsuario.Id);

            return pUsuario.Permisos;    
        }

        private List<Permiso> ListarPermisosDelUsuario(int pUsuarioId)
        {
            List<Permiso> permisos = _permisoDAL.ObtenerPermisosDelUsuario(pUsuarioId);

            return permisos;
        }



        //MODIFICAR PARA QUE DEVUELVA LIST<PERMISOS>---------------
        public DataSet ObtenerPermisosTreeView()
        {
            return _permisoDAL.ObtenerPermisosTreeView();
        }

        public List<Permiso> ObtenerPermisos()
        {
            return _permisoDAL.ObtenerPermisos();
        }

        public void AsignarPermiso(int usuarioId, Permiso permiso)
        {
            // Aquí puedes agregar lógica de negocio si es necesario
            _permisoDAL.AsignarPermiso(usuarioId, permiso.Id);
        }


        private void CargarPermisosEnMemoria()
        {
            _permisosGlobales = _permisoDAL.ObtenerPermisos();
            // Opcional: cargar los permisos asignados a usuarios
        }



        // Caché de permisos en memoria
        private static List<Permiso> _permisosCache;
        private static DateTime _cacheTimestamp;
        private static readonly TimeSpan CacheDuration = TimeSpan.FromMinutes(10);

        // Inicializar o actualizar la lista de permisos en memoria
        public static List<Permiso> ObtenerPermisosEnMemoria()
        {
            // Verificar si el caché está vacío o ha caducado
            if (_permisosCache == null || DateTime.Now - _cacheTimestamp > CacheDuration)
            {
                // Llamar a la DAL para obtener el conjunto de permisos y almacenar en caché
                _permisosCache = ObtenerPermisosTreeView(); 
                _cacheTimestamp = DateTime.Now;
            }
            return _permisosCache;
        }

        // Método para limpiar el caché manualmente (si es necesario)
        public static void LimpiarCachePermisos()
        {
            _permisosCache = null;
        }

    

    }
}
