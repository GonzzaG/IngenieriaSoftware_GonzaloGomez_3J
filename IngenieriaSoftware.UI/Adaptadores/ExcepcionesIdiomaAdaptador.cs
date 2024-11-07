using IngenieriaSoftware.Servicios.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IngenieriaSoftware.UI.Adaptadores
{
    public class ExcepcionesIdiomaAdaptador
    {
        private readonly IIdiomaSujeto _idiomaSujeto;
        private readonly List<ExcepcionTraducible> _excepciones = new List<ExcepcionTraducible>();

        public ExcepcionesIdiomaAdaptador(IIdiomaSujeto idiomaSujeto)
        {
            _idiomaSujeto = idiomaSujeto;
        }

        public void RegistrarExcepcion(ExcepcionTraducible excepcion)
        {
            _excepciones.Add(excepcion);
            _idiomaSujeto.Suscribir(excepcion);
        }

        public void DesuscribirExcepcion(ExcepcionTraducible excepcion)
        {
            _excepciones.Remove(excepcion);
            _idiomaSujeto.Desuscribir(excepcion);
        }
    }

}
