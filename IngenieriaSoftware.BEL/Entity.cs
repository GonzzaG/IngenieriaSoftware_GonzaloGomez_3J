namespace IngenieriaSoftware.BEL
{
    public abstract class Entity : IEntity
    {
        public int Id { get; set; }

        public abstract string getNombreTabla();
    }
}