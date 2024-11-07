using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace IngenieriaSoftware.UI.Helpers
{
    public static class HelperExcepciones
    {
        public static Dictionary<string, IdiomaObservadorDTO> ListarExcepciones()
        {
            Dictionary<string, IdiomaObservadorDTO> excepciones = new Dictionary<string, IdiomaObservadorDTO>();
            int tagContador = 200;

            // Obtener todos los tipos de excepciones que heredan de ExcepcionTraducible
            var excepcionesTipos = Assembly.GetExecutingAssembly()
                .GetTypes()
                .Where(t => t.IsSubclassOf(typeof(Servicios.ExcepcionTraducible)) && !t.IsAbstract);
            
            foreach (var tipoExcepcion in excepcionesTipos)
            {
                int nuevoTag = tagContador++;

                excepciones[nuevoTag.ToString()] = new IdiomaObservadorDTO
                {
                    Tag = nuevoTag,
                    Name = tipoExcepcion.Name // Nombre de la excepción para identificarla
                };
            }

            return excepciones;
        }
    }
}
