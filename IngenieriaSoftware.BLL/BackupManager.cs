using IngenieriaSoftware.DAL;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.IO;
using System.Linq;

namespace IngenieriaSoftware.BLL
{
    public class BackupManager
    {
        private BackupRepository _backupRepository = new BackupRepository();
        private readonly string connectionString = ConfigurationManager.ConnectionStrings["ConnectionStringBD"].ConnectionString;

        // Carpeta real de backups = misma carpeta DATA + \Backup
        public string BackupsDirectory => GetBackupPath();

        // Obtiene carpeta DATA real de la instancia
        private string GetInstanceDataPath()
        {
            string query = @"
                SELECT 
                    SUBSTRING(physical_name,1,
                        LEN(physical_name) - CHARINDEX('\', REVERSE(physical_name))
                    ) AS DataPath
                FROM master.sys.master_files
                WHERE database_id = 1 AND file_id = 1; -- master.mdf
            ";

            using (var conn = new SqlConnection(connectionString))
            using (var cmd = new SqlCommand(query, conn))
            {
                conn.Open();
                return cmd.ExecuteScalar().ToString();
            }
        }

        // Carpeta Backup = DATA\Backup
        private string GetBackupPath()
        {
            string dataPath = GetInstanceDataPath();
            string backupPath = Path.Combine(dataPath, "Backup");

            if (!Directory.Exists(backupPath))
                Directory.CreateDirectory(backupPath);

            return backupPath;
        }

        #region BACKUP
        public void Backup()
        {
            var builder = new SqlConnectionStringBuilder(connectionString);
            string databaseName = builder.InitialCatalog;

            string fechaHora = DateTime.Now.ToString("yyyyMMdd_HHmmss");
            string archivoFinal = Path.Combine(BackupsDirectory, $"{databaseName}_{fechaHora}.bak");

            string script = $@"
                USE master;
                BACKUP DATABASE [{databaseName}]
                TO DISK = N'{archivoFinal}'
                WITH INIT;   
            ";

            _backupRepository.actionBD(script);

            Console.WriteLine($"Backup generado correctamente en {archivoFinal}");
        }
        #endregion

        #region RESTORE
        private (string LogicalData, string LogicalLog) GetLogicalNames(string backupFile, string connMaster)
        {
            string query = $@"
                RESTORE FILELISTONLY 
                FROM DISK = N'{backupFile.Replace("'", "''")}' ;
            ";

            using (var conn = new SqlConnection(connMaster))
            using (var cmd = new SqlCommand(query, conn))
            {
                conn.Open();
                using (var reader = cmd.ExecuteReader())
                {
                    string dataName = null;
                    string logName = null;

                    while (reader.Read())
                    {
                        var logical = reader["LogicalName"]?.ToString();
                        var type = reader["Type"]?.ToString(); // "D" = data, "L" = log

                        if (type == "D" && dataName == null) dataName = logical;
                        if (type == "L" && logName == null) logName = logical;
                    }

                    return (dataName, logName);
                }
            }
        }

        public void Restore(string nombreBackup)
        {
            var builder = new SqlConnectionStringBuilder(connectionString);
            string databaseName = builder.InitialCatalog;
            string servidor = builder.DataSource;

            string backupPath = Path.Combine(BackupsDirectory, nombreBackup);
            if (!File.Exists(backupPath))
                throw new FileNotFoundException("Backup no encontrado", backupPath);

            string connMaster = $"Data Source={servidor};Initial Catalog=master;Integrated Security=True;TrustServerCertificate=True";

            // 1) obtener logical names del bak
            var logical = GetLogicalNames(backupPath, connMaster);
            if (string.IsNullOrEmpty(logical.LogicalData) || string.IsNullOrEmpty(logical.LogicalLog))
            {
                throw new Exception("No se pudieron obtener los nombres lógicos (LogicalName) del backup. Asegurate que el .bak sea válido.");
            }

            // 2) Obtener ruta DATA real de la instancia
            string dataPath = GetInstanceDataPath();
            if (string.IsNullOrWhiteSpace(dataPath))
                throw new Exception("No se pudo obtener la ruta DATA de la instancia SQL.");

            // Asegurar que la ruta termine con separador
            if (!dataPath.EndsWith(Path.DirectorySeparatorChar.ToString()))
                dataPath = dataPath + Path.DirectorySeparatorChar;

            // 3) Construir rutas finales (literales)
            string dataFile = Path.Combine(dataPath, $"{databaseName}.mdf");
            string logFile = Path.Combine(dataPath, $"{databaseName}_log.ldf");

            // Escapar comillas simples (por si hay alguna)
            string safeBackupPath = backupPath.Replace("'", "''");
            string safeLogicalData = logical.LogicalData.Replace("'", "''");
            string safeLogicalLog = logical.LogicalLog.Replace("'", "''");
            string safeDataFile = dataFile.Replace("'", "''");
            string safeLogFile = logFile.Replace("'", "''");

            // 4) Construir script T-SQL (sin concatenaciones dentro del T-SQL)
            string script = $@"
        USE master;

        IF DB_ID(N'{databaseName.Replace("'", "''")}') IS NOT NULL
        BEGIN
            ALTER DATABASE [{databaseName.Replace("]", "]]").Replace("[", "")}] SET SINGLE_USER WITH ROLLBACK IMMEDIATE;
        END

        RESTORE DATABASE [{databaseName.Replace("]", "]]").Replace("[", "")}]
        FROM DISK = N'{safeBackupPath}'
        WITH REPLACE,
             MOVE N'{safeLogicalData}' TO N'{safeDataFile}',
             MOVE N'{safeLogicalLog}'  TO N'{safeLogFile}',
             RECOVERY;

        ALTER DATABASE [{databaseName.Replace("]", "]]").Replace("[", "")}] SET MULTI_USER;
    ";

            // 5) Ejecutar
            using (var conn = new SqlConnection(connMaster))
            {
                conn.Open();
                using (var cmd = new SqlCommand(script, conn))
                {
                    cmd.CommandTimeout = 0;
                    cmd.ExecuteNonQuery();
                }
            }

            Console.WriteLine("Restore completado correctamente (ruta normal).");
        }


        #endregion

        #region LISTAR BACKUPS
        public List<string> GetBackUps()
        {
            if (!Directory.Exists(BackupsDirectory))
                Directory.CreateDirectory(BackupsDirectory);

            return Directory.GetFiles(BackupsDirectory, "*.bak")
                            .Select(Path.GetFileName)
                            .ToList();
        }
        #endregion

        #region ELIMINAR BACKUP
        public void DeleteBackup(string backupNombre)
        {
            string path = Path.Combine(BackupsDirectory, backupNombre);

            if (File.Exists(path))
                File.Delete(path);
            else
                throw new FileNotFoundException("Backup no encontrado", path);
        }
        #endregion
    }
}
