﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IngenieriaSoftware.Servicios.Interfaces
{
    public interface IIdiomaSujeto
    {
        void Suscribir(IIdiomaObservador suscriptor);
        void Desuscribir(IIdiomaObservador suscriptor);
        void CambiarEstado(int nuevoIdiomaId);
    }
}
