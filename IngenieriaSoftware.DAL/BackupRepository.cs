using IngenieriaSoftware.BEL;
using IngenieriaSoftware.Servicios;
using System;
using System.Data.SqlClient;
using System.IO;

namespace IngenieriaSoftware.DAL
{
    public class BackupRepository
    {
        DAO _dao = new DAO();
        BackupService _fileBackupService = new BackupService();

        public bool GuardarRegistro(BackupRegistro backup)
        {
            try
            {
                SqlParameter[] parametros = new SqlParameter[]
                {
                    new SqlParameter("@NombreArchivo", backup.NombreArchivo),
                    new SqlParameter("@Ruta", backup.Ruta),
                    new SqlParameter("@Fecha", backup.Fecha),
                    new SqlParameter("@Usuario", backup.Usuario),
                    
                };
                _dao.ExecuteNonQuery("sp_InsertarBackupCatalogo", parametros);

                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool RealizarBackUpBD(string nombreBackUp, string rutaCompleta)
        {
            try
            {

                SqlParameter[] parametros = new SqlParameter[]
                {
                    new SqlParameter("@NombreBD", _dao.NombreBD),
                    new SqlParameter("@RutaCompleta", rutaCompleta),
                    new SqlParameter("@NombreBackup", nombreBackUp)
                };

                _dao.ExecuteNonQuery("sp_RealizarBackupBaseDatos", parametros);

                return true;
            }
            catch(Exception ex)
            {
                throw new Exception("Error al realizar el backup: " + ex.Message);
            }   
        }

        public bool RestaurarBackup(string nombreArchivo, string rutaBackup)
        {
            try
            {
                SqlParameter[] parametros = new SqlParameter[]
                {
                    new SqlParameter("@BackupFilePath", Path.Combine(rutaBackup, nombreArchivo)),
                    new SqlParameter("@DataDirectory", _dao.rutaBD),
                    new SqlParameter("@DatabaseName", _dao.NombreBD)
                };
                _dao.ExecuteNonQuery("sp_RestoreISProyecto", parametros);

                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void CreateBackup()
        {

        }

        
    }
}
