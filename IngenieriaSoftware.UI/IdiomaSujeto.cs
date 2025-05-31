using IngenieriaSoftware.Servicios;
using IngenieriaSoftware.Servicios.Interfaces;
using System;
using System.Collections.Generic;

namespace IngenieriaSoftware.UI
{
    public class IdiomaSujeto : IIdiomaSujeto
    {
        private readonly List<IIdiomaObservador> Suscriptores = new List<IIdiomaObservador>();

        private readonly ITraduccionServicio _traduccionServicio;

        public IdiomaSujeto(ITraduccionServicio traduccionServicio)//(int idiomaInicialId, ITraduccionServicio traduccionServicio)
        {
            //idiomaId = idiomaInicialId;

            _traduccionServicio = traduccionServicio;
        }

        public void CambiarEstado(int nuevoIdiomaId)
        {
            IdiomaData.CambiarIdioma(nuevoIdiomaId);
            Notificar();
        }

        protected void Notificar()
        {
            IdiomaData.TagTraducciones = _traduccionServicio.ObtenerTraduccionesPorIdioma(IdiomaData.IdiomaActual.Id) ?? new Dictionary<string, string>();

            if (IdiomaData.TagTraducciones == null || IdiomaData.TagTraducciones.Count == 0)
            {
                Console.WriteLine("No se han encontrado traducciones para el idioma actual.");
                return;
            }

            foreach (var suscriptor in Suscriptores)
            {
                if (suscriptor.Tag != 0)
                {
                    string traduccion;

                    if (IdiomaData.TagTraducciones.TryGetValue(suscriptor.Tag.ToString(), out traduccion) && traduccion != null)
                    {
                        suscriptor.Actualizar(traduccion);
                    }
                }
            }
        }

        #region Suscribir y Desuscribir

        public void Desuscribir(IIdiomaObservador suscriptor)
        {
            if (Suscriptores.Contains(suscriptor))
            {
                Suscriptores.Remove(suscriptor);
            }
        }

        public void Suscribir(IIdiomaObservador suscriptor)
        {
            if (!Suscriptores.Contains(suscriptor))
            {
                Suscriptores.Add(suscriptor);
            }
        }

        #endregion Suscribir y Desuscribir
    }
}