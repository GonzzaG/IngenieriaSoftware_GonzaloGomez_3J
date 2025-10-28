using IngenieriaSoftware.DAL;

namespace IngenieriaSoftware.BLL.ConnectionManager
{
    public static class ProductoService
    {
        public static bool TestConnection(out string errorMessage)
        {
            return DAO.TestConnection(out errorMessage);
        }
    }
}
