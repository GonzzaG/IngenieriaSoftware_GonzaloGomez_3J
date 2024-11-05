using IngenieriaSoftware.Servicios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IngenieriaSoftware.UI
{
    internal class MensajeDTO : IIdiomaObservador
    {
        public string Tag { get; set; }
        public string Name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        string Mensaje {  get; set; }

        public void Actualizar(string texto)
        {
            throw new NotImplementedException();
        }
    }
}
