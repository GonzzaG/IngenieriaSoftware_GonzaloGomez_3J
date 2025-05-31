using IngenieriaSoftware.Abstracciones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IngenieriaSoftware.Servicios
{
    public class AuditoriaServicio
    {

        public void VerificarAuditoria(string nombreTabla)
        {
            try
            {
               
            }
            catch (Exception ex)
            {
                // Manejo de excepciones
                throw new Exception("Error al verificar la auditoría: " + ex.Message);
            }
        }

    }
}
