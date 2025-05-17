using System;

namespace IngenieriaSoftware.BEL
{
    public class BackupRegistro
    {
        public int Id { get; set; }
        public string NombreArchivo { get; set; }
        public string Ruta { get; set; }
        public DateTime Fecha { get; set; }
        public string Usuario { get; set; }
    }
}