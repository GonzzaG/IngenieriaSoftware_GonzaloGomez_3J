using IngenieriaSoftware.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
