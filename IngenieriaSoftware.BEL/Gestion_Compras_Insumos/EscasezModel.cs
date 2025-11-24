using System;

namespace IngenieriaSoftware.BEL.Gestion_Compras_Insumos
{
    public class EscasezInsertModel
    {
        /*
            IdEscasez INT IDENTITY(1,1) PRIMARY KEY,
            IdProducto INT NOT NULL,
            CantidadActual DECIMAL(18,2) NULL,     -- Cantidad existente al momento del aviso
            CantidadRecomendada DECIMAL(18,2) NULL,     -- Cantidad mínima recomendada
            FechaRegistro DATETIME NOT NULL DEFAULT GETDATE(),
            RegistradoPor INT NULL,
            Observacion VARCHAR(250) NULL,         -- Ej: “Se están terminando”, “Quedan pocas cajas”, etc.

            -- Relaciones
            FOREIGN KEY (IdProducto) REFERENCES producto(producto_id),
            FOREIGN KEY (RegistradoPor)  REFERENCES usuarios(id_usuario)
        */

        public int IdProducto { get; set; }
        public decimal? CantidadRecomendada { get; set; }
        public DateTime FechaRegistro { get; set; }
        public int? RegistradoPor { get; set; }
        public string Observacion { get; set; }
    }
}
