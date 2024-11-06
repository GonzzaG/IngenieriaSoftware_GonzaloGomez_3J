using System;

namespace IngenieriaSoftware.Abstracciones
{
    public interface IUsuario
    {
        int Id { get; set; }
        string Username { get; set; }
        DateTime FechaCreacion { get; set; }
        int IdiomaId { get; set; }

        // List<IPermiso> Permisos { get; set; }
    }
}