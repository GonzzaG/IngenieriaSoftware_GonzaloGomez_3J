using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IngenieriaSoftware.BEL
{
    public class Mesa
    {
        public Mesa() { }
        public Mesa(int mesaId, int cantComensales, EstadoMesa.Estado estadoMesa)
        {
            MesaId = mesaId;
            CantComensales = cantComensales;
            EstadoMesa = estadoMesa;
        }

        public int MesaId { get; set; }
        public int CantComensales {  get; set; }
        
        public EstadoMesa.Estado EstadoMesa { get; set; }


    }
}
