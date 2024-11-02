using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
