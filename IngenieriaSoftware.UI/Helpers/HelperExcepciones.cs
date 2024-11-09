using IngenieriaSoftware.Servicios;
using IngenieriaSoftware.Servicios.Interfaces;
using IngenieriaSoftware.UI.Adaptadores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace IngenieriaSoftware.UI.Helpers
{
    public class HelperExcepciones
    {
        private readonly IIdiomaSujeto _idiomaSujeto;

        public HelperExcepciones(IIdiomaSujeto idiomaSujeto)
        {
            _idiomaSujeto = idiomaSujeto;
        }

        public static Dictionary<string, ExcepcionesIdiomaAdaptador> ListarExcepciones()
        {
            Dictionary<string, ExcepcionesIdiomaAdaptador> excepciones = new Dictionary<string, ExcepcionesIdiomaAdaptador>();

            var excepcionesTipos = new ExcepcionesServicio().ObtenerEtiquetas();

            foreach (var tipoExcepcion in excepcionesTipos)
            {
                // Obtener el atributo Tag de la clase de excepción
                var tagAttribute = (TagAtributo)Attribute.GetCustomAttribute(tipoExcepcion, typeof(TagAtributo));

                if (tagAttribute == null)
                {
                    continue; // Si no tiene el atributo Tag, saltamos esta excepción
                }

                int tag = tagAttribute.Tag; // Obtener el tag desde el atributo

                string nameExcepcion;
                try
                {
                    var excepcion = (ExcepcionTraducible)Activator.CreateInstance(tipoExcepcion);
                    nameExcepcion = excepcion.Name;
                }
                catch (Exception ex)
                {
                    nameExcepcion = ex.Source;
                }

                // Crear el adaptador para la excepción y añadirlo al diccionario
                var excepcionAdaptador = new ExcepcionesIdiomaAdaptador(tag, nameExcepcion);
                excepciones[tag.ToString()] = excepcionAdaptador;
            }

            return excepciones;
        }

        public void SuscribirExcepciones()
        {
            var ExcepcionesEtiqueta = ListarExcepciones();

            foreach (var e in ExcepcionesEtiqueta.Values)
            {
                _idiomaSujeto.Suscribir(e);
            }
        }

    }
}
