using IngenieriaSoftware.BEL;
using System;

namespace IngenieriaSoftware.Abstracciones
{
    public interface IUsuario : IVerificable, IEntity
    {
        string Username { get; set; }
        DateTime FechaCreacion { get; set; }
        int IdiomaId { get; set; }

        int id_rol { get; set; }
        // List<IPermiso> Permisos { get; set; }
    }
}