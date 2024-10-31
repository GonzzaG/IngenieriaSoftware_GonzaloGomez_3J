﻿using IngenieriaSoftware.BEL;
using IngenieriaSoftware.Servicios;
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
        internal List<IPermiso> _permisosTree; 
        internal List<IPermiso> _permisosGlobales; 
   
        public PermisoDAL()
        {
            _permisosGlobales = new List<IPermiso>();
            _permisosTree = new List<IPermiso>();   
        }

        public List<IPermiso> PermisosTree()
        {
            return _permisosTree;
        }
        public List<IPermiso> PermisosGlobales()
        {
            return _permisosGlobales;
        }


        public void AsignarPermisosHijos(DataSet pDs)
        {
            // Crear una lista nueva para almacenar los permisos jerárquicos
            var permisosConHijos = new List<IPermiso>();

            // Crear un diccionario para facilitar la búsqueda de permisos por ID
            var permisosPorId = _permisosTree.ToDictionary(p => p.Id);

            // Limpiar la lista de permisos hijos de cada permiso en _permisosTree
            foreach (var permiso in _permisosTree)
            {
                permiso.permisosHijos.Clear(); // Limpiar la lista de permisos hijos
            }

            // Asignar permisos hijos a sus respectivos permisos padres
            foreach (DataRow row in pDs.Tables[3].Rows)
            {
                int idPermisoPadre = (int)row["id_permiso_padre"];
                int idPermisoHijo = (int)row["id_permiso_hijo"];

                // Verificar si los permisos existen en el diccionario
                if (permisosPorId.TryGetValue(idPermisoPadre, out IPermiso permisoPadre) &&
                    permisosPorId.TryGetValue(idPermisoHijo, out IPermiso permisoHijo))
                {
                    // Solo agregar el permiso hijo si no está ya en la lista de hijos
                    if (!permisoPadre.permisosHijos.Contains(permisoHijo))
                    {
                        permisoPadre.permisosHijos.Add(permisoHijo);
                    }
                }
            }

            // Agregar solo los permisos que no tienen padre (permisos raíz) a la lista de resultados
            foreach (var permiso in _permisosTree)
            {
                // Solo agregar permisos que no tienen un PermisoPadreId (permisos raíz)
                if (!permiso.PermisoPadreId.HasValue)
                {
                    permisosConHijos.Add(permiso);
                }
            }

            // Retornar la nueva lista de permisos que incluye sus hijos
            _permisosTree = permisosConHijos;
        }






        public IPermiso ObtenerPermisoPorId(int idPermiso)
        {
            // Buscar el permiso directamente en la lista
            var permiso = _permisosTree.FirstOrDefault(p => p.Id == idPermiso);

            // Si no se encuentra, buscar recursivamente en los permisos hijos
            if (permiso == null)
            {
                foreach (var p in _permisosTree)
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
        private IPermiso BuscarPermisoEnHijos(IPermiso permiso, int idPermiso)
        {
            if (permiso.permisosHijos != null && permiso.permisosHijos.Count > 0)
            {
                foreach (Permiso hijo in permiso.permisosHijos)
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

        public List<IPermiso> MapearPermisos(DataSet pDS)
        {
            // Mapearemos los permisos LO OY A HACER EN PERMISODAL
            _permisosGlobales = new PermisoMapper().MapearPermisosDesdeDataSet(pDS);
            _permisosTree = _permisosGlobales;

            return _permisosTree;
        }

        public DataSet AsignarPermiso(int usuarioId, int permisoId)
        {
            try
            {
                string nombreStoredProcedure = "sp_AsignarPermiso";

                SqlParameter[] parametros = new SqlParameter[]
                {
                    new SqlParameter("@usuario_id", usuarioId),
                    new SqlParameter("@permiso_id", permisoId)
                };

                var permisosUsuarioDataSet = _dao.ExecuteStoredProcedure(nombreStoredProcedure, parametros);

                if(permisosUsuarioDataSet != null)
                    return permisosUsuarioDataSet;
                else
                    return null;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        //Asigna un permiso a un usuario a partir del codigo del permiso
        public void AsignarPermisoPorCod(string username, string permisoCod)
        {
            try
            {
                string nombreStoredProcedure = "sp_AsignarPermisoPorCod";

                SqlParameter[] parametros = new SqlParameter[]
                {
                    new SqlParameter("@usuario_nombre", username),
                    new SqlParameter("@cod_permiso", permisoCod)
                };

                _dao.ExecuteStoredProcedure(nombreStoredProcedure, parametros);

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }




    }
}
