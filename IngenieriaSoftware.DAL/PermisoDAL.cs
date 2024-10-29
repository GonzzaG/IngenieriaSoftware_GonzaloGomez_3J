using IngenieriaSoftware.BEL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IngenieriaSoftware.DAL
{
    public class PermisoDAL
    {
        private readonly DAO _dao = new DAO();
        internal List<Permiso> _permisosGlobales; 
        public PermisoDAL(List<Permiso> permisoGlobal)
        {
            _permisosGlobales = permisoGlobal;// Para almacenar todos los permisos.

        }
        public PermisoDAL() { }

        public List<Permiso> PermisosGlobales()
        {
            return _permisosGlobales;
        }

        public void AsignarPermisosHijos(DataSet pDs)
        {
            // Crear una lista nueva para almacenar los permisos jerárquicos
            var permisosConHijos = new List<Permiso>();

            // Crear un diccionario para facilitar la búsqueda de permisos por ID
            var permisosPorId = _permisosGlobales.ToDictionary(p => p.Id);

            // Limpiar la lista de permisos hijos de cada permiso en _permisosGlobales
            foreach (var permiso in _permisosGlobales)
            {
                permiso.permisosHijos.Clear(); // Limpiar la lista de permisos hijos
            }

            // Asignar permisos hijos a sus respectivos permisos padres
            foreach (DataRow row in pDs.Tables[3].Rows)
            {
                int idPermisoPadre = (int)row["id_permiso_padre"];
                int idPermisoHijo = (int)row["id_permiso_hijo"];

                // Verificar si los permisos existen en el diccionario
                if (permisosPorId.TryGetValue(idPermisoPadre, out Permiso permisoPadre) &&
                    permisosPorId.TryGetValue(idPermisoHijo, out Permiso permisoHijo))
                {
                    // Solo agregar el permiso hijo si no está ya en la lista de hijos
                    if (!permisoPadre.permisosHijos.Contains(permisoHijo))
                    {
                        permisoPadre.permisosHijos.Add(permisoHijo);
                    }
                }
            }

            // Agregar solo los permisos que no tienen padre (permisos raíz) a la lista de resultados
            foreach (var permiso in _permisosGlobales)
            {
                // Solo agregar permisos que no tienen un PermisoPadreId (permisos raíz)
                if (!permiso.PermisoPadreId.HasValue)
                {
                    permisosConHijos.Add(permiso);
                }
            }

            // Retornar la nueva lista de permisos que incluye sus hijos
            _permisosGlobales = permisosConHijos;
        }






        public Permiso ObtenerPermisoPorId(int idPermiso)
        {
            // Buscar el permiso directamente en la lista
            var permiso = _permisosGlobales.FirstOrDefault(p => p.Id == idPermiso);

            // Si no se encuentra, buscar recursivamente en los permisos hijos
            if (permiso == null)
            {
                foreach (var p in _permisosGlobales)
                {
                    permiso = BuscarPermisoEnHijos(p, idPermiso);
                    if (permiso != null)
                    {
                        break; // Salir si se encontró el permiso
                    }
                }
            }

            return permiso;
        }
        // Método auxiliar para buscar permisos en los hijos de un permiso
        private Permiso BuscarPermisoEnHijos(Permiso permiso, int idPermiso)
        {
            if (permiso.permisosHijos != null && permiso.permisosHijos.Count > 0)
            {
                foreach (var hijo in permiso.permisosHijos)
                {
                    if (hijo.Id == idPermiso)
                    {
                        return hijo; // Se encontró el permiso hijo
                    }

                    // Llamada recursiva para seguir buscando en los hijos de los hijos
                    var resultado = BuscarPermisoEnHijos(hijo, idPermiso);
                    if (resultado != null)
                    {
                        return resultado; // Se encontró el permiso en la jerarquía
                    }
                }
            }

            return null; // No se encontró el permiso
        }

        public List<Permiso> MapearPermisos(DataSet pDS)
        {
            // Mapearemos los permisos LO OY A HACER EN PERMISODAL
           _permisosGlobales = new PermisoMapper().MapearPermisosTreeViewDesdeDataSet(pDS);
            return _permisosGlobales;
        }


        //MODIFICAR PARA QUE DEVUELVA LIST<PERMISOS>
        public List<Permiso> ObtenerPermisosTreeView()
        {
            string mNombreStoredProcedure = "sp_ObtenerPermisosTreeView";
            DataSet mDs = _dao.ExecuteStoredProcedure(mNombreStoredProcedure, null);

            PermisoMapper permmisoMapper = new PermisoMapper();
            UsuarioMapper usuarioMapper = new UsuarioMapper();
            List<Permiso> permisos = permmisoMapper.MapearPermisosDesdeDataSet(mDs);
         
            return permisos;
        }

        public void AsignarPermiso(int usuarioId, int permisoId)
        {
            string nombreStoredProcedure = "sp_AsignarPermiso";

            SqlParameter[] parametros = new SqlParameter[]
            {
                new SqlParameter("@usuario_id", usuarioId),
                new SqlParameter("@permiso_id", permisoId)
            };

            _dao.ExecuteStoredProcedure(nombreStoredProcedure, parametros);
        }




    }
}
