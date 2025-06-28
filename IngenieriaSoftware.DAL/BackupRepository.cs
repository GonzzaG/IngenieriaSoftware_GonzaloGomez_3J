using IngenieriaSoftware.BEL;
using IngenieriaSoftware.Servicios;
using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.IO;

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