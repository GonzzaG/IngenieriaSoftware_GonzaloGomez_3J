using System;
using System.IO;

namespace IngenieriaSoftware.Servicios
{
    public class BackupService
    {
        public string BackupDirectory { get; set; } = AppDomain.CurrentDomain.BaseDirectory + @"\BackUps";

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