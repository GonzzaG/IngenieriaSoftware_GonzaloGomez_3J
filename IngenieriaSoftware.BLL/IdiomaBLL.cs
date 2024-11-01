using IngenieriaSoftware.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IngenieriaSoftware.BLL
{
    public class IdiomaBLL
    {
        IdiomaDAL _idiomaDAL;
        public IdiomaBLL()
        {
            _idiomaDAL = new IdiomaDAL();
        }


        public void AgregarEtiqueta(List<string> etiquetasEnMemoria)
        {
            try
            {
                _idiomaDAL.AgregarEtiqueta(etiquetasEnMemoria);

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
