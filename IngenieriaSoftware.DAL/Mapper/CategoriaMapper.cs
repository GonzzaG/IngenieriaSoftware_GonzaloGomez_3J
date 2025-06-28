using IngenieriaSoftware.BEL.Gestion_Compras_Insumos;
using IngenieriaSoftware.DAL.Auditoria.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IngenieriaSoftware.DAL.Mapper
{
    public class CategoriaMapper : IMapper<Categoria>
    {
        public Categoria ConvertirDesdeRow(DataRow row)
        {
            var categoria = new Categoria
            {
                Id = int.Parse(row["Id"].ToString()),
                Nombre = row["Nombre"].ToString(),
            };

            return categoria;
        }
    }
}
