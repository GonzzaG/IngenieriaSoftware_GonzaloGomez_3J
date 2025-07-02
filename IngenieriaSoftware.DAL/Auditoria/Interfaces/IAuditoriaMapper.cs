using IngenieriaSoftware.BEL.Auditoria;
using System.Data;

namespace IngenieriaSoftware.DAL.Auditoria
{
    internal interface IAuditoriaMapper
    {
        IAuditableModel ConvertirDesdeRow(DataRow row);
    }
}
