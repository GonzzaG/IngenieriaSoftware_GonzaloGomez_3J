using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IngenieriaSoftware.Servicios
{

    //NO ES NECESARIA ESTA INTERFAZ/////////////////////////
    public interface IPermiso
    {
        int Id { get; }
        string Nombre { get; }
        string CodPermiso { get; }
        bool EsRol { get; }
        bool Habilitado { get; }
        int? PermisoPadreId { get; }

        // Composición jerárquica de permisos
        List<IPermiso> permisosHijos { get; set; }
    }
}
