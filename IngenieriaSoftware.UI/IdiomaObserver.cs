using IngenieriaSoftware.Servicios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IngenieriaSoftware.UI
{
    public class IdiomaObserver : IIdiomaSujeto
    {
        public int idiomaId;

        private readonly List<IIdiomaObservador> Suscriptores = new List<IIdiomaObservador>();

        private readonly ITraduccionServicio _traduccionServicio;

        public IdiomaObserver(ITraduccionServicio traduccionServicio)//(int idiomaInicialId, ITraduccionServicio traduccionServicio)
        {
            //idiomaId = idiomaInicialId;

            _traduccionServicio = traduccionServicio;

        }

        public void Suscribir(IIdiomaObservador control)
        {
            if (!Suscriptores.Contains(control))
            {
                Suscriptores.Add(control);
            }
        }

        public void Notificar(int nuevoIdiomaId)
        {
            //cambio el idioma 
            IdiomaData.CambiarIdioma(nuevoIdiomaId);
            var idiomaId = IdiomaData.IdiomaActual.Id;

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
