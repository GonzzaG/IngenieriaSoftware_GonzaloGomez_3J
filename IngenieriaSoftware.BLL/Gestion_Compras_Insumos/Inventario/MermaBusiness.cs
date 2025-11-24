using IngenieriaSoftware.BEL.Gestion_Compras_Insumos;
using IngenieriaSoftware.DAL.Gestion_Compras_Insumos.ProductoInventario;
using IngenieriaSoftware.Servicios;
using System;

namespace IngenieriaSoftware.BLL.Gestion_Compras_Insumos.Inventario
{
    public class MermaBusiness
    {
        public void InsertEscasez(MermaInsertModel model)
        {
            // Validaciones de negocio
            if (model.CantidadMerma <= 0)
                throw new Exception("La cantidad de merma debe ser mayor que cero.");

            if (model.FechaMerma > DateTime.Now)
                throw new Exception("La fecha de merma no puede ser futura.");

            // Asignar el usuario que registra la merma
            model.RegistradoPor = SessionManager.GetInstance.Usuario.Id;

            new MermaDataAccess().InsertMerma(model);
        }
    }
}
