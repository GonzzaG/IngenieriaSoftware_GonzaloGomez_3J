using IngenieriaSoftware.BEL.Auditoria;
using System.Collections.Generic;

namespace IngenieriaSoftware.DAL
{
    public interface IAuditoriaEntityRepository<T> where T : IAuditableModel
    {
        /// <summary>
        /// Registra un cambio en la auditoría.
        /// </summary>
        /// <param name="entidad">Entidad auditada con los datos actuales.</param>
        /// <param name="accion">Tipo de acción realizada (INSERT, UPDATE, DELETE).</param>
        /// <param name="cambiadoPor">Entidad que realizó el cambio.</param>
        void RegistrarCambio(T entidad);

        /// <summary>
        /// Obtiene todas las auditorías registradas.
        /// </summary>
        /// <returns>Lista de todos los registros auditados.</returns>
        IEnumerable<T> GetAll();

        /// <summary>
        /// Obtiene un registro de auditoría por su ID.
        /// </summary>
        /// <param name="id">El id del registro de auditoría.</param>
        /// <returns>Registro auditado o null si no se encontró.</returns>
        T GetPorIdYVersion(int id, int version);

        void RestaurarEstadoEntidad(int idEntidad, int version);

        void RealizarPeticion(string tabla, int idEntidad, int version, int idUsuarioActual, string comentario = null);
    }
}
