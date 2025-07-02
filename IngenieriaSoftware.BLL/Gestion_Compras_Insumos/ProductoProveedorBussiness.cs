using IngenieriaSoftware.BEL;
using IngenieriaSoftware.DAL.Proveedores;
using System;
using System.Collections.Generic;

namespace IngenieriaSoftware.BLL.Gestion_Compras_Insumos
{
    public class ProductoProveedorBussiness
    {
        public List<Producto> GetById(int Id)
        {
            if (Id.Equals(0))
                throw new ArgumentException("El Id del proveedor no puede ser cero.");

            return new ProductoProveedorDataAccess().GetById(Id);
        }
    }
}
