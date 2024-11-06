using IngenieriaSoftware.Servicios;
using IngenieriaSoftware.Servicios.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        //protected void Notificar()
        //{
        //    var traducciones = _traduccionServicio.ObtenerTraduccionesPorIdioma(IdiomaData.IdiomaActual.Id);
        //    foreach (var suscriptor in Suscriptores)
        //    {
        //        if (traducciones.ContainsKey(suscriptor.Tag.ToString()))
        //        {
        //            suscriptor.Actualizar(traducciones[suscriptor.Tag.ToString()]);
        //        }
        //    }
        //}

        protected void Notificar()
        {
            var traducciones = _traduccionServicio.ObtenerTraduccionesPorIdioma(IdiomaData.IdiomaActual.Id);

            if (traducciones == null || traducciones.Count == 0)
            {
                Console.WriteLine("No se han encontrado traducciones para el idioma actual.");
                return;
            }

            foreach (var suscriptor in Suscriptores)
            {
                if (suscriptor.Tag != 0)
                {
                    string traduccion;

                    // Se intenta obtener la traduccion del diccionario de traducciones
                    if (traducciones.TryGetValue(suscriptor.Tag.ToString(), out traduccion) && traduccion != null)
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

        #endregion
    }
}
