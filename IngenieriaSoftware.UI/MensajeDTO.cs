using IngenieriaSoftware.Servicios.Interfaces;
using System;

namespace IngenieriaSoftware.UI
{
    internal class MensajeDTO : IIdiomaObservador
    {
        public int Tag { get; set; }
        public string Name { get; set; }

        public void Actualizar(string texto)
        {
            throw new NotImplementedException();
        }

        void IIdiomaObservador.Actualizar(string nuevoTexto)
        {
            throw new NotImplementedException();
        }
    }
}