using IngenieriaSoftware.Servicios.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IngenieriaSoftware.Servicios
{
    public abstract class ExcepcionTraducible : Exception, IIdiomaObservador
    {
        public int Tag { get; set; }
        public string Name { get; set; } //no es necesario

        protected ExcepcionTraducible(int tag, string mensaje) : base(mensaje)
        {
            Tag = tag;
            Name = this.Name;
        }

        public virtual void Actualizar(string nuevoMensaje)
        {
            // Actualizamos el mensaje traducido utilizando HelpLink para no sobrescribir Message directamente
            HelpLink = nuevoMensaje;
        }

        public override string Message => HelpLink ?? base.Message;

    }
}
