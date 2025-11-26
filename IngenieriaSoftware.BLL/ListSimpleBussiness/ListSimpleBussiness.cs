using IngenieriaSoftware.BEL.Common;
using IngenieriaSoftware.BEL.OrdenDeCompra.ViewModels;
using IngenieriaSoftware.DAL.ListSimpleDataAccess;
using IngenieriaSoftware.Servicios.DTOs.ListSimple;
using System.Collections.Generic;

namespace IngenieriaSoftware.BLL.ListSimpleBussiness
{
    public class ListSimpleBussiness
    {
        public List<ProveedorListSimpleModel> GetProveedoresListSimple()
        {
            return new ListSimpleDataAccess().GetProveedoresListSimple();
        }

        public List<SelectListSimple> GetOrdenCompraEstadosListSimple()
        {
            return new ListSimpleDataAccess().GetOrdenCompraEstadosListSimple();
        }

        public List<SelectListSimple> GetFacturaEstadosListSimple()
        {
            return new ListSimpleDataAccess().GetFacturaEstadosListSimple();
        }
    }
}
