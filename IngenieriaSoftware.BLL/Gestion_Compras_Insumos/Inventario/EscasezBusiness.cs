using IngenieriaSoftware.BEL.Gestion_Compras_Insumos;
using IngenieriaSoftware.DAL.Gestion_Compras_Insumos.ProductoInventario;

namespace IngenieriaSoftware.BLL.Gestion_Compras_Insumos.Inventario
{
    public class EscasezBusiness
    {
        public void InsertEscasez(EscasezInsertModel model)
        {

            var parametros = new EscasezInsertModel()
            {
                IdProducto = model.IdProducto,
                CantidadRecomendada = model.CantidadRecomendada,
                FechaRegistro = model.FechaRegistro,
                RegistradoPor = model.RegistradoPor,
                Observacion = model.Observacion
            };

            new EscasezDataAccess().InsertEscasez(model);    
        }
    }
}
