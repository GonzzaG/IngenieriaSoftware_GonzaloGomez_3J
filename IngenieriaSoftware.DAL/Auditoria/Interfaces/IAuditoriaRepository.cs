namespace IngenieriaSoftware.DAL.Auditoria
{
    public interface IAuditoriaRepository
    {
        void RealizarPeticion(string tabla, int idEntidad, int version, int idUsuarioActual, string comentario);
        object GetPorIdYVersion(int id, int version, string nombreTabla);
    }
}
