using IngenieriaSoftware.BEL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IngenieriaSoftware.DAL.Mapper
{
    public class PeticionRestauracionMapper
    {
        public static List<PeticionRestauracion> MapearDesdeDataRow(DataSet ds)
        {
            List<PeticionRestauracion> peticiones = new List<PeticionRestauracion>();

            foreach (DataRow row in ds.Tables[0].Rows) 
            {
                peticiones.Add(new PeticionRestauracion
                {
                    IdPeticion = int.Parse(row["IdPeticion"].ToString()),
                    Tabla = row["Tabla"].ToString(),
                    IdCambioOrigen = Guid.Parse(row["IdCambio"].ToString()),
                    FechaSolicitud = Convert.ToDateTime(row["FechaSolicitud"]),
                    UsuarioSolicitante = row["UsuarioSolicitante"].ToString(),
                    Registro = int.Parse(row["Registro"].ToString()),
                    Comentario = row["Comentario"].ToString(),
                    Estado = row["Estado"].ToString(),

                });
            }
           
            return peticiones;
        }
    }
}
