using IngenieriaSoftware.BEL.Auditoria;
using IngenieriaSoftware.DAL.Auditoria.Interfaces;
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
