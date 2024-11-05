namespace IngenieriaSoftware.Abstracciones
{
    public interface IPermiso
    {
        int Id { get; set; }
        string Nombre { get; set; }
        string CodPermiso { get; set; }
        bool EsRol { get; set; }
        bool Habilitado { get; set; }
        string TipoPermiso { get; set; } //ver si dejarlo o sacarlo
        int? PermisoPadreId { get; set; }

        // List<IPermiso> permisosHijos { get; set; }
    }
}