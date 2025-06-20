﻿using IngenieriaSoftware.Servicios.Interfaces;
using System;

namespace IngenieriaSoftware.Servicios
{
    public abstract class ExcepcionTraducible : Exception, IIdiomaObservador
    {
        public int Tag { get; set; }
        public string Name { get; set; } //no es necesario

        protected ExcepcionTraducible(int tag, string name)
        {
            Tag = tag;
            Name = name;
        }

        public virtual void Actualizar(string nuevoMensaje)
        {
            // Actualizamos el mensaje traducido utilizando HelpLink para no sobrescribir Message directamente
            HelpLink = nuevoMensaje;
        }

        public override string Message => HelpLink ?? base.Message;
    }
}