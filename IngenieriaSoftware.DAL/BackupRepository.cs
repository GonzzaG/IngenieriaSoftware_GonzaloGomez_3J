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

        public bool RestaurarBackup(string rutaBackup)
        {
            try
            {
                string cadenaConexion = ConfigurationManager.AppSettings["ConnectionString"];

                SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder(cadenaConexion);
                builder.InitialCatalog = "master";
                string cadenaMaster = builder.ConnectionString;

                using (SqlConnection conexion = new SqlConnection(cadenaMaster))
                {
                    conexion.Open();

                    SqlCommand comando = new SqlCommand("sp_RestoreISProyecto", conexion);
                    comando.CommandType = CommandType.StoredProcedure;
                    comando.Parameters.AddWithValue("@BackupFilePath", rutaBackup);
                    comando.Parameters.AddWithValue("@DataDirectory", _dao.rutaBD);
                    comando.Parameters.AddWithValue("@DatabaseName", _dao.NombreBD);
                    comando.ExecuteNonQuery();
                }

                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

       

        
    }
}
