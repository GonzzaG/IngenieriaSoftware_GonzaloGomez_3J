using IngenieriaSoftware.BEL;
using IngenieriaSoftware.DAL.EntityDAL;
using System.Collections.Generic;

namespace IngenieriaSoftware.BLL
{
    public class MedioDePagoBLL
    {
        private readonly MedioDePagoDAL _medioDePagoDAL = new MedioDePagoDAL();

        public MedioDePago ObtenerMedioDePagoPorId(int medioDePagoId)
        {
            return _medioDePagoDAL.ObtenerMedioDePagoPorId(medioDePagoId);
        }

        public List<MedioDePago> ObtenerMediosDePago()
        {
            return _medioDePagoDAL.ObtenerMediosDePago();
        }
    }
}