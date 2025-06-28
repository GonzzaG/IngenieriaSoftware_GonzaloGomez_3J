using IngenieriaSoftware.BEL.Auditoria;

namespace IngenieriaSoftware.BLL.Auditoria
{
    public interface IAuditoriaService
    {
        void RealizarPeticionRestauracion(string tabla, int idEntidad, int version, int idUsuarioActual, string comentario);
        object GetPorIdYVersion(int id, int version);
        IAuditableModel ObtenerUltimaVersionDeEntidadAuditable(string nombreTabla, int idEntidad);
        void AceptarPeticionDeRestauracion(int idEntidad, int version, int idPeticion, int IdEntidad);
        void RechazarPeticionDeRestauracion(int idPeticion, int IdEntidad);
    }
}
