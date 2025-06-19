using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IngenieriaSoftware.BEL.Auditoria
{
    internal interface IAuditoriaMapper
    {
        IAuditableModel ConvertirDesdeRow(DataRow row);
    }
}
