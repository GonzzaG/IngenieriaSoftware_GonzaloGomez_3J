using IngenieriaSoftware.DAL.ListSimpleDataAccess;
using IngenieriaSoftware.Servicios.DTOs.ListSimple;
using System.Collections.Generic;

namespace IngenieriaSoftware.BLL.ListSimpleBussiness
{
    public class ListSimpleBussiness
    {
        public List<ProveedorListSimpleViewModel> GetProveedoresListSimple()
        {
            return new ListSimpleDataAccess().GetProveedoresListSimple();
        }
    }
}
