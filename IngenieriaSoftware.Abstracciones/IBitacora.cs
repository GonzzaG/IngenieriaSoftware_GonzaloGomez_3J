using System;

namespace IngenieriaSoftware.Abstracciones
{
    public interface IBitacora
    {
        DateTime FechaHora { get; set; }
        string Usuario { get; set; }
        string Actividad { get; set; }
        string InfoAdicional { get; set; }
        string Controller { get; set; }
    }
}