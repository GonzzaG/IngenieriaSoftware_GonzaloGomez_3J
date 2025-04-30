using IngenieriaSoftware.Abstracciones;
using System;

namespace IngenieriaSoftware.BEL
{
    public class Bitacora : IBitacora
    {
        public DateTime FechaHora { get; set; }
        public string Usuario { get; set; }
        public string Actividad { get; set; }
        public string InfoAdicional { get; set; }
        public string Controller { get; set; }
        public string Url { get; set; }
        public string Area { get; set; }
    }
}
