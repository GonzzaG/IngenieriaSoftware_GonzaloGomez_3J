using IngenieriaSoftware.BEL.Gestion_Compras_Insumos;
using IngenieriaSoftware.DAL.Gestion_Compras_Insumos.UpdateProductoInventario;
using IngenieriaSoftware.Servicios;
using System;

namespace IngenieriaSoftware.BLL.Gestion_Compras_Insumos.Inventario
{
    public class EscasezBusiness
    {
        public void InsertEscasez(EscasezInsertModel model)
        {
            // validaciones 
            if(model.IdProducto <= 0)
                throw new ArgumentException("El Id del producto es inválido.");

            if(model.CantidadRecomendada == null || model.CantidadRecomendada <= 0)
                throw new ArgumentException("La cantidad recomendada debe ser mayor a cero.");

            // Coloacamos le usuario que registra la escasez    
            model.RegistradoPor = SessionManager.GetInstance.Usuario.Id;

            new EscasezDataAccess().InsertEscasez(model);    
        }
    }
}
