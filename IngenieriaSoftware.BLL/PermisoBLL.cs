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
    public class PermisoBLL 
    {

        private readonly PermisoDAL _permisoDAL; //_permisoDAL = new PermisoDAL(); 
        private readonly Dictionary<int, List<Permiso>> _permisosPorUsuario = new Dictionary<int, List<Permiso>>();
        internal List<Permiso> _permisosGlobales; // Para almacenar todos los permisos
       
        public PermisoBLL() { _permisoDAL = new PermisoDAL(); }

        //MODIFICAR PARA QUE DEVUELVA LIST<PERMISOS>---------------
        public List<Permiso> CargarPermisosTreeView()
        {
            //vamos a obtener los permisos como treeview y a cargar usuarios y sus relaciones en memoria
            _permisosGlobales = _permisoDAL.ObtenerPermisosTreeView();
            new UsuarioBLL().CargarUsuariosPermisos();
            return _permisosGlobales;
        }

        public List<Permiso> ObtenerPermisos()
        {
            return new PermisoDAL().PermisosGlobales();
        }

        public Permiso ObtenerPermisoPorId(int permisoId)
        {
           return _permisoDAL.ObtenerPermisoPorId(permisoId);
        }

        public void AsignarPermiso(int usuarioId, int permisoId)
        {
            // Aquí puedes agregar lógica de negocio si es necesario
            _permisoDAL.AsignarPermiso(usuarioId, permisoId);
        }


      



    }
}
