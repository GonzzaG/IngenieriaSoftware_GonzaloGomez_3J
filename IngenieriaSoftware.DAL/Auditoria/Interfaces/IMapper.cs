using IngenieriaSoftware.BEL.Gestion_Compras_Insumos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IngenieriaSoftware.DAL.Auditoria.Interfaces
{
    public interface IMapper<T> where T : class
    {
        T ConvertirDesdeRow(DataRow row);
    }
}
