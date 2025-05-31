using System;
using System.IO;

namespace IngenieriaSoftware.Servicios
{
    public class BackupService
    {
        public string BackupDirectory { get; set; } = AppDomain.CurrentDomain.BaseDirectory + @"\BackUps";

        public string CreateBackup(string sourcePath, string tableName)
        {
            try
            {
                if (!Directory.Exists(BackupDirectory))
                    Directory.CreateDirectory(BackupDirectory);

                string backupPath = Path.Combine(BackupDirectory, $"{tableName}_{DateTime.Now:yyyyMMdd}.bak");

                File.Copy(sourcePath, backupPath, true);

                return backupPath;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al crear el backup.", ex);
            }
        }

        public long GetFileSize(string filePath)
        {
            try
            {
                if (File.Exists(filePath))
                {
                    FileInfo fileInfo = new FileInfo(filePath);
                    return fileInfo.Length;
                }
                else
                {
                    throw new FileNotFoundException("El archivo no existe.", filePath);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener el tamaño del archivo.", ex);
            }
        }

        public void RestoreBackup(string backupPath, string destinationPath)
        {
            try
            {
                if (!File.Exists(backupPath))
                {
                    throw new FileNotFoundException("El archivo de backup ");
                }

                // Eliminar el archivo de destino si existe
                if (!File.Exists(destinationPath))
                {
                    throw new FileNotFoundException("El archivo de destino no existe.");
                }

                File.Copy(backupPath, destinationPath, true);

                // Eliminar el archivo de backup que ya fue copiado en el destino
                File.Delete(backupPath);
            }
            catch (Exception ex)
            {
                throw new Exception("Ocurrio un error restaurando el backup: ", ex);
            }
        }

        public void DeleteBackup(string backupNombre)
        {
            try
            {
                string backupPath = Path.Combine(BackupDirectory, backupNombre);
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