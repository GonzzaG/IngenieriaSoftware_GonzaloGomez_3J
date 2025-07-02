using IngenieriaSoftware.Abstracciones;

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

        public override string ToString()
        {
            return this.Nombre;
        }
    }
}
