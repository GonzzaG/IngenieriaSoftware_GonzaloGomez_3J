using System;

namespace IngenieriaSoftware.BEL
{
    public class AuditoriaRegistro
    {
        public int Registro { get; set; }
        public Guid IdCambio { get; set; }
        public DateTime Fecha { get; set; }
        public string Usuario { get; set; }
        public string Tipo { get; set; } // Insert (I), Update (U), Delete (D), Restore (R)
    }
}