using IngenieriaSoftware.Abstracciones;
using IngenieriaSoftware.Servicios.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace IngenieriaSoftware.Servicios
{
    public class IdiomaObserver
    {
        public int idiomaId;

        private readonly List<IdiomaSuscriptorDTO> Suscriptores = new List<IdiomaSuscriptorDTO>();

        public event Action<Dictionary<string, string>> IdiomaCambiado;

        private readonly ITraduccionServicio _traduccionService;




        public IdiomaObserver(int idiomaInicialId, ITraduccionServicio traduccionService)
        {
            idiomaId = idiomaInicialId;
            _traduccionService = traduccionService;
        }
        


        public void Suscribir(IdiomaSuscriptorDTO control)
        {
            if (!Suscriptores.Contains(control))
            {
                Suscriptores.Add(control);

            }
        }

        public void Notificar(int nuevoIdiomaId)
        {
            idiomaId = nuevoIdiomaId;
            var traducciones = _traduccionService.ObtenerTraduccionesPorIdioma(idiomaId);
            foreach (var suscriptor in Suscriptores)
            {
                if (traducciones.ContainsKey(suscriptor.Tag))
                {
                    suscriptor.Actualizar(traducciones[suscriptor.Tag]);
                }
            }     
        }


    }
}
