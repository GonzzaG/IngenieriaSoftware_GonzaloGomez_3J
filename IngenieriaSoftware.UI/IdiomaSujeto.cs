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
            //cambio el idioma 
           
             IdiomaData.CambiarIdioma(nuevoIdiomaId);
             Notificar();   

            
        }


        public void Desuscribir(IIdiomaObservador suscriptor)
        {
            if (Suscriptores.Contains(suscriptor))
            {
                Suscriptores.Remove(suscriptor);
            }
        }

        public void Notificar()
        {
            var traducciones = _traduccionServicio.ObtenerTraduccionesPorIdioma(IdiomaData.IdiomaActual.Id);
            foreach (var suscriptor in Suscriptores)
            {
                if (traducciones.ContainsKey(suscriptor.Tag.ToString()))
                {
                    suscriptor.Actualizar(traducciones[suscriptor.Tag.ToString()]);
                }
            }
        }
        #region Suscribir
        public void Suscribir(IIdiomaObservador suscriptor)
        {
            if (!Suscriptores.Contains(suscriptor))
            {
                Suscriptores.Add(suscriptor);
            }
        }
        public void Suscribir(Control control)
        {
            Suscribir(new ControlIdiomaAdaptador(control));
        }

        public void Suscribir(ToolStripMenuItem menuItem)
        {
            Suscribir(new MenuItemIdiomaAdaptador(menuItem));
        }




        #endregion
    }
}
