namespace IngenieriaSoftware.BEL
{
    public interface IEntity
    {
        int Id { get; set; }

        string getNombreTabla();
    }
}