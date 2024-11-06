using IngenieriaSoftware.Servicios.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IngenieriaSoftware.Servicios
{
    public class IdiomaData
    {
        public static Dictionary<EtiquetaDTO, TraduccionDTO> EtiquetaTraducciones { get; set; }
        public static List<IdiomaDTO> Idiomas { get; set; } = new List<IdiomaDTO>();

        public static IdiomaDTO IdiomaActual { get; set; } = new IdiomaDTO();

        public static void CambiarIdioma(int nuevoIdiomaId)
        {
            if(IdiomaActual == null) { IdiomaActual = new IdiomaDTO(); }
            IdiomaActual = Idiomas.Find(i => i.Id == nuevoIdiomaId);
            
        }
        public static void CambiarIdioma(string nuevoIdiomaNombre)
        {
            if (IdiomaActual == null) { IdiomaActual = new IdiomaDTO(); }
            IdiomaActual = Idiomas.Find(i => i.Nombre == nuevoIdiomaNombre);

        }
    }
}
