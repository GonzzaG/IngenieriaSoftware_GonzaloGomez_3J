using System.Data;

namespace IngenieriaSoftware.DAL.Auditoria.Interfaces
{
    public interface IMapper<T> where T : class
    {
        T ConvertirDesdeRow(DataRow row);
    }
}
