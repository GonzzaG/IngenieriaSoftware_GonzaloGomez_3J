using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace IngenieriaSoftware.BEL
{
    public class AuditoriaModel
    {
        public string Tabla { get; set; }           
        public object Entidad { get; set; }         
        public string Accion { get; set; }          
        public string CambiadoPor { get; set; }     
        public DateTime FechaCambio { get; set; }   
        public int Version { get; set; }            
        public bool EsUltimaVersion { get; set; }   
    }
}
