using IngenieriaSoftware.Servicios;
using IngenieriaSoftware.Servicios.Permisos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

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
                permisos.Add(new PermisoDTO
                {
                    Id = (int)row["id_permiso"],
                    Nombre = row["nombre_permiso"].ToString(),
                    CodPermiso = row["permiso"].ToString(),
                    PermisoPadreId = row["id_permiso_padre"] != DBNull.Value ? (int?)row["id_permiso_padre"] : null,
                    EsRol = (bool)row["es_rol"],
                    Habilitado = (bool)row["habilitado"]
                  
                });
                PermisosData.Permisos.Add(row["permiso"].ToString());
            }

            return permisos;
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