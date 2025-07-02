using System;

namespace IngenieriaSoftware.DAL
{
    public class BackupRepository
    {
        private DAO _dao = new DAO();

        public void actionBD(string Command)
        {
            try
            {
                _dao.Execute(Command);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}