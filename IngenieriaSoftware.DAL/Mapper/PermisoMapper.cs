using IngenieriaSoftware.BEL;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IngenieriaSoftware.Servicios;

namespace IngenieriaSoftware.DAL
{
    public class PermisoMapper
    {
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
            }

            return permisos;
        }

    }
}
