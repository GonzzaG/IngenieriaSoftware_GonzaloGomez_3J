using IngenieriaSoftware.BEL.Auditoria;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IngenieriaSoftware.DAL.Auditoria
{
    internal interface IAuditoriaMapper
    {
        IAuditableModel ConvertirDesdeRow(DataRow row);
    }
}
