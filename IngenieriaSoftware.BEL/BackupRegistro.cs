using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
