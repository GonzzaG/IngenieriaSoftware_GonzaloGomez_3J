using IngenieriaSoftware.Servicios;
using IngenieriaSoftware.Servicios.Permisos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace IngenieriaSoftware.DAL
{
    public class PermisoMapper
    {
        public ComponentePermiso componentePermiso;

        public List<PermisoDTO> MapearPermisosDesdeDataSet(DataSet pDS)
        {
            var permisos = new List<PermisoDTO>();

            foreach (DataRow row in pDS.Tables[0].Rows)
            {
                var permiso = new PermisoDTO();

                permiso.Id = (int)row["id_permiso"];
                permiso.Nombre = row["nombre_permiso"].ToString();
                permiso.CodPermiso = row["permiso"].ToString();
                permiso.EsRol = (bool)row["es_rol"];
                permiso.Habilitado = (bool)row["habilitado"];
                if (pDS.Tables.Contains("id_permiso_padre"))
                    permiso.PermisoPadreId = row["id_permiso_padre"] != DBNull.Value ? (int?)row["id_permiso_padre"] : null;
                permisos.Add(permiso);

                // PermisosData.PermisosString.Add(row["permiso"].ToString());
            }

            return permisos;
        }

        public List<PermisoDTO> MapearPermisosUsuarioDesdeDataSet(DataSet pDS)
        {
            var permisos = new List<PermisoDTO>();

            foreach (DataRow row in pDS.Tables[0].Rows)
            {
                var permiso = new PermisoDTO();

                permiso.Id = (int)row["id_permiso"];
                permiso.Nombre = row["nombre_permiso"].ToString();

                permisos.Add(permiso);
            }

            return permisos;
        }

        public List<PermisoDTO> MapearPermisosDesdeDataSet2(DataSet pDS)
        {
            var permisos = new List<PermisoDTO>();
            var permisosDict = new Dictionary<int, PermisoDTO>();

            foreach (DataRow row in pDS.Tables[0].Rows)
            {
                var permiso = new PermisoDTO
                {
                    Id = (int)row["id_permiso"],
                    Nombre = row["nombre_permiso"].ToString(),
                    CodPermiso = row["permiso"].ToString(),
                    EsRol = (bool)row["es_rol"],
                    Habilitado = (bool)row["habilitado"],
                    PermisoPadreId = row["id_permiso_padre"] != DBNull.Value ? (int?)row["id_permiso_padre"] : null
                };

                permisosDict[permiso.Id] = permiso;
            }

            foreach (var permiso in permisosDict.Values)
            {
                if (permiso.PermisoPadreId.HasValue && permisosDict.ContainsKey(permiso.PermisoPadreId.Value))
                {
                    var padre = permisosDict[permiso.PermisoPadreId.Value];
                    if (padre.permisosHijos == null)
                    {
                        padre.permisosHijos = new List<PermisoDTO>();
                    }
                    padre.permisosHijos.Add(permiso);
                }
                else
                {
                    // Si no tiene padre, es un permiso raíz
                    permisos.Add(permiso);
                }
            }

            return permisos; // Devuelve la lista de permisos raíz con toda la jerarquía construida
        }

        public void AsignarPermisosHijos(List<PermisoDTO> permisos)
        {
            var permisosLookup = permisos.ToDictionary(p => p.Id);
            for (int i = permisos.Count - 1; i >= 0; i--)
            {
                var permiso = permisos[i];
                if (permiso.PermisoPadreId.HasValue && permisosLookup.ContainsKey(permiso.PermisoPadreId.Value))
                {
                    permisosLookup[permiso.PermisoPadreId.Value].permisosHijos.Add(permiso);
                    permisos.RemoveAt(i);
                }
            }
        }

        public List<PermisoDTO> ConstruirJerarquiaDePermisos(List<PermisoDTO> permisos)
        {
            var permisosPorId = permisos.ToDictionary(p => p.Id);
            foreach (var permiso in permisos)
            {
                permiso.permisosHijos = new List<PermisoDTO>();
            }
            foreach (var permiso in permisos)
            {
                if (permiso.PermisoPadreId.HasValue)
                {
                    if (permisosPorId.TryGetValue(permiso.PermisoPadreId.Value, out var permisoPadre))
                    {
                        permisoPadre.permisosHijos.Add(permiso);
                    }
                }
            }
            var permisosRaiz = permisos.Where(p => !p.PermisoPadreId.HasValue || !permisosPorId.ContainsKey(p.PermisoPadreId.Value)).ToList();
            foreach (var permiso in permisosRaiz)
            {
                EliminarHijosDePermisoRaiz(permisos, permiso);
            }

            return permisosRaiz;
        }

        private void EliminarHijosDePermisoRaiz(List<PermisoDTO> permisos, PermisoDTO permisoRaiz)
        {
            foreach (var hijo in permisoRaiz.permisosHijos)
            {
                permisos.Remove(hijo);
                EliminarHijosDePermisoRaiz(permisos, hijo);
            }
        }
    }
}