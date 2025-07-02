using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IngenieriaSoftware.Servicios.Tools
{
    public static class CommonExtensions
    {
        public static void ValidarObjetoNoNulo(this object objeto)
        {
            if (objeto is null)
                throw new ArgumentNullException($"{nameof(objeto)}, no validado correctamente");
            
        }



    }
}
