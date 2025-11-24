using System;

namespace IngenieriaSoftware.BEL.Gestion_Compras_Insumos
{
    public class MermaInsertModel
    {
        /*
            IdMerma INT IDENTITY PRIMARY KEY,
            IdProducto INT NOT NULL,
            CantidadMerma DECIMAL(18,2) NOT NULL,
            FechaMerma DATETIME NOT NULL DEFAULT GETDATE(),
            TipoMerma VARCHAR(50) NOT NULL,
            Descripcion VARCHAR(250) NULL,
            RegistradoPor INT NULL,
         */

        public int IdProducto { get; set; }
        public decimal CantidadMerma { get; set; }
        public DateTime FechaMerma { get; set; }
        public string Descripcion { get; set; }
        public int? RegistradoPor { get; set; }
    }
}
