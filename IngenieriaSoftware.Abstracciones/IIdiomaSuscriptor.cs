﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IngenieriaSoftware.Abstracciones
{
    public interface IIdiomaSuscriptor
    {
        string Tag { get; }
        void Actualizar(string nuevoTexto);
    }
}