using IngenieriaSoftware.Servicios.DTOs;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IngenieriaSoftware.Servicios
{
    public class IdiomaData
    {
        public static Dictionary<string, string> TagTraducciones { get; set; }
        private static IdiomaDTO _idiomaActual;
        public static List<IdiomaDTO> Idiomas { get; set; } = new List<IdiomaDTO>();

        public static IdiomaDTO IdiomaActual {
            get
            {
                if (_idiomaActual == null)
                {
                    if(SessionManager.GetInstance.Usuario.IdiomaId == 0)
                        _idiomaActual = Idiomas.Find(i => i.Nombre == CultureInfo.CurrentCulture.DisplayName);

                    else
                        _idiomaActual = Idiomas.Find(i => i.Id == SessionManager.GetInstance.Usuario.IdiomaId);

                    if (_idiomaActual == null)
                        _idiomaActual = Idiomas.FirstOrDefault(); 
                }
                return _idiomaActual;
            }
            set
            {
                _idiomaActual = value;
            }
        }

        public static void CambiarIdioma(int nuevoIdiomaId)
        {
            if(IdiomaActual == null) { IdiomaActual = new IdiomaDTO(); }
            IdiomaActual = Idiomas.Find(i => i.Id == nuevoIdiomaId);
            
        }
        public static void CambiarIdioma(string nuevoIdiomaNombre)
        {
            //if (IdiomaActual == null) { IdiomaActual = new IdiomaDTO(); }
            IdiomaActual = Idiomas.Find(i => i.Nombre == nuevoIdiomaNombre);

        }
    }
}
