using IngenieriaSoftware.DAL;

namespace IngenieriaSoftware.BLL
{
    public class DatabaseService
    {
        private DAO _dao = new DAO();

        public void InicializarBase()
        {
            _dao.CrearBaseSiNoExiste();
        }
    }
}
