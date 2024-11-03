using IngenieriaSoftware.Abstracciones;
using IngenieriaSoftware.Servicios.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace IngenieriaSoftware.Servicios
{
    public class IdiomaObserver
    {
        private int idiomaId;

        private readonly List<IdiomaSuscriptorDTO> Suscriptores = new List<IdiomaSuscriptorDTO>();

        public event Action<IdiomaSuscriptorDTO> IdiomaCambiado;


        public IdiomaObserver(int idiomaInicialId)
        {
            idiomaId = idiomaInicialId;
        }

        public void Suscribir(IdiomaSuscriptorDTO control)
        {
            if (!Suscriptores.Contains(control))
            {
                Suscriptores.Add(control);

            }
        }

        public void Notificar (IdiomaSuscriptorDTO languageChangeDto)
        {
            foreach (var suscriptor in Suscriptores)
            {
                if (suscriptor.Tag == languageChangeDto.Tag)
                {
                    suscriptor.Actualizar(languageChangeDto.Traduccion);
                }
            }
        }

        public void CambiarIdioma(int nuevoIdiomaId)
        {
            idiomaId = nuevoIdiomaId;

            var traducciones = ObtenerTraducciones(idiomaId);
            foreach (var traduccion in traducciones)
            {
     
                IdiomaCambiado?.Invoke(new IdiomaSuscriptorDTO { Tag = traduccion.Key, Traduccion = traduccion.Value });
            }
        }











        private Dictionary<string, string> ObtenerTraducciones(int idiomaId)
        {
            var traducciones = new List<TraduccionDTO>
            {
                new TraduccionDTO { EtiquetaId = 1, IdiomaId = idiomaId, Texto = idiomaId == 1 ? "Nombre" : "Name" },
                new TraduccionDTO { EtiquetaId = 2, IdiomaId = idiomaId, Texto = idiomaId == 1 ? "Apellido" : "Surname" }
            };

            return traducciones.ToDictionary(t => t.EtiquetaId.ToString(), t => t.Texto);
        }
    }
}
