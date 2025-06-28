using IngenieriaSoftware.Abstracciones;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IngenieriaSoftware.BEL.Gestion_Compras_Insumos
{
    public class Categoria : IEntity
    {
        public int Id { get; set; } 
        public string Nombre { get; set; }

        public string getNombreTabla()
        {
            return TablesName.Categoria;
        }
    }
}
