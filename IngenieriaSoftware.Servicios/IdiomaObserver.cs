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

        private readonly List<IIdiomaSuscriptor> Suscriptores = new List<IIdiomaSuscriptor>();

        public event Action<Dictionary<string, string>> IdiomaCambiado;

        private readonly ITraduccionServicio _traduccionServicio;


        public IdiomaObserver(int idiomaInicialId, ITraduccionServicio traduccionServicio)
        {
            idiomaId = idiomaInicialId;
            _traduccionServicio = traduccionServicio;
        }
        


        public void Suscribir(IIdiomaSuscriptor control)
        {
            if (!Suscriptores.Contains(control))
            {
                Suscriptores.Add(control);

            }
        }

        public void Notificar(int nuevoIdiomaId)
        {
            idiomaId = nuevoIdiomaId;
            var traducciones = _traduccionServicio.ObtenerTraduccionesPorIdioma(idiomaId);
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
