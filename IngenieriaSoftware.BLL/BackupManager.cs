using IngenieriaSoftware.DAL;
using IngenieriaSoftware.Servicios;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;

namespace IngenieriaSoftware.BLL
{
    public class BackupManager
    {
        private BackupRepository _backupRepository = new BackupRepository();

        public string BackupsDirectory { get; set; } = Path.Combine(ConfigurationManager.AppSettings["Directorio"]);
        string connectionString = ConfigurationManager.ConnectionStrings["ConnectionStringBD"].ConnectionString;

        public void Backup()
        {
            var directorio = ConfigurationManager.AppSettings["Directorio"];
            var archivo = ConfigurationManager.AppSettings["NombreArchivo"];

            var builder = new SqlConnectionStringBuilder(connectionString);
            string databaseName = builder.InitialCatalog;

            if (!Directory.Exists(directorio))
            {
                Directory.CreateDirectory(directorio);
                Console.WriteLine("El directorio fue creado.");
            }
            else
            {
                Console.WriteLine("El directorio ya existe.");
            }

            // Obtener la fecha y hora actuales
            DateTime ahora = DateTime.Now;

            // Formatear la fecha y la hora
            string fechaFormateada = ahora.ToString("ddMMyyyy");
            string horaFormateada = ahora.ToString("HHmmss"); // Formato de 24 horas

            // Concatenar la fecha y la hora con un guion bajo
            string fechaHoraFormateada = $"{fechaFormateada}_{horaFormateada}";

            string copiaDeSeguridad = $@"
                USE master;
                BACKUP DATABASE [{databaseName}] 
                TO DISK = N'{directorio}\\{archivo}_{fechaHoraFormateada}.bak' 
                WITH INIT, COMPRESSION;
                ";

            _backupRepository.actionBD(copiaDeSeguridad);

            _backupRepository.actionBD(copiaDeSeguridad);

        }
        public void Restore(string nombreBackup)
        {
            var builder = new SqlConnectionStringBuilder(connectionString);
            string databaseName = builder.InitialCatalog;
            string servidor = builder.DataSource;

            string backupFilePath = Path.Combine(BackupsDirectory, nombreBackup);
            if (string.IsNullOrEmpty(backupFilePath) || !File.Exists(backupFilePath))
                throw new FileNotFoundException("El backup especificado no existe.", backupFilePath);

            // 1️ Conexión temporal a master (no a la base destino)
            string connMaster = $"Data Source={servidor};Initial Catalog=master;Integrated Security=True;TrustServerCertificate=True";

            // 2️ Obtener rutas de datos y logs desde master
            (string dataPath, string logPath) = GetDefaultPaths(connMaster);

            if (string.IsNullOrEmpty(dataPath) || string.IsNullOrEmpty(logPath))
                throw new Exception("No se pudieron obtener las rutas de datos y logs de SQL Server.");

            // 3️ Rutas de destino
            string dataFile = Path.Combine(dataPath, $"{databaseName}.mdf");
            string logFile = Path.Combine(logPath, $"{databaseName}_log.ldf");

            // 4️ Construir script
            var cmd = new StringBuilder();
            cmd.AppendLine("USE master;");
            cmd.AppendLine($"IF DB_ID('{databaseName}') IS NOT NULL");
            cmd.AppendLine("BEGIN");
            cmd.AppendLine($"    ALTER DATABASE [{databaseName}] SET SINGLE_USER WITH ROLLBACK IMMEDIATE;");
            cmd.AppendLine("END");
            cmd.AppendLine($"RESTORE DATABASE [{databaseName}] FROM DISK = N'{backupFilePath}' WITH REPLACE,");
            cmd.AppendLine($"MOVE '{databaseName}' TO N'{dataFile}',");
            cmd.AppendLine($"MOVE '{databaseName}_log' TO N'{logFile}';");
            cmd.AppendLine($"ALTER DATABASE [{databaseName}] SET MULTI_USER;");

            // 5️ Ejecutar usando master
            using (var conn = new SqlConnection(connMaster))
            {
                conn.Open();
                using (var sqlCmd = new SqlCommand(cmd.ToString(), conn))
                {
                    sqlCmd.CommandTimeout = 0;
                    sqlCmd.ExecuteNonQuery();
                }
            }

            Console.WriteLine($"✅ Base de datos '{databaseName}' restaurada correctamente.");
        }


        // Método auxiliar para obtener rutas
        private (string DataPath, string LogPath) GetDefaultPaths(string connectionString)
        {
            const string query = @"
                SELECT 
                    CAST(SERVERPROPERTY('InstanceDefaultDataPath') AS NVARCHAR(200)) AS DataPath,
                    CAST(SERVERPROPERTY('InstanceDefaultLogPath') AS NVARCHAR(200)) AS LogPath;
            ";

            using (var conn = new SqlConnection(connectionString))
            using (var cmd = new SqlCommand(query, conn))
            {
                conn.Open();
                using (var reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return (reader["DataPath"].ToString(), reader["LogPath"].ToString());
                    }
                }
            }

            return (null, null);
        }




        public List<string> GetBackUps()
        {
            try
            {
                if (!Directory.Exists(BackupsDirectory))
                    Directory.CreateDirectory(BackupsDirectory);

                var usuario = SessionManager.GetInstance?.Usuario;
                if (usuario == null) throw new Exception("Usuario no definido");

                var backups = Directory.GetFiles(BackupsDirectory, "*.bak")
                                       .Select(Path.GetFileName)
                                       .ToList();

                BitacoraHelper.RegistrarActividad(usuario.ToString(), "Obteniendo backups", DateTime.Now, string.Empty, nameof(BackupManager), nameof(GetBackUps));

                return backups;
            }
            catch (Exception ex)
            {
                var usuario = SessionManager.GetInstance?.Usuario?.ToString() ?? "Usuario desconocido";
                BitacoraHelper.RegistrarError(usuario, ex, nameof(BackupManager), nameof(GetBackUps));

                throw new Exception("Error al obtener los backups", ex);
            }
        }

        public void DeleteBackup(string backupNombre)
        {
            try
            {
                string backupPath = Path.Combine(BackupsDirectory, backupNombre);

                if (File.Exists(backupPath))
                {
                    File.Delete(backupPath);
                }
                else
                {
                    throw new FileNotFoundException("El archivo de backup no existe.");
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Ocurrio un error eliminando el backup: ", ex);
            }
        }


    }
}
