using System;

namespace IngenieriaSoftware.BEL
{
    public class DigitoVerificadorVertical
    {
        public string NombreTabla { get; set; }
        public string DVV { get; set; }
        public DateTime FechaGeneracion { get; set; }

        public override string ToString()
        {
            return $"{NombreTabla} - {DVV} - {FechaGeneracion}";
        }
    }
}