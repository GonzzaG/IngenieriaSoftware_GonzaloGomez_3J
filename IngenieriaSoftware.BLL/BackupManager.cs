using IngenieriaSoftware.BEL;
using IngenieriaSoftware.DAL;
using IngenieriaSoftware.Servicios;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;

namespace IngenieriaSoftware.BLL
{
    public class BackupManager
    {
        private BackupRepository _backupRepository = new BackupRepository();

        public string BackupsDirectory { get; set; } = Path.Combine(ConfigurationManager.AppSettings["Directorio"]); 

        public void Backup()
        {
            String copiaDeSeguridad = null;
            var directorio = ConfigurationManager.AppSettings["Directorio"];
            var archivo = ConfigurationManager.AppSettings["NombreArchivo"];


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

            // Crear la línea de comando
            copiaDeSeguridad = $"USE MASTER BACKUP DATABASE ISProyecto TO DISK = '{directorio}\\{archivo}_{fechaHoraFormateada}.bak'";

            _backupRepository.actionBD(copiaDeSeguridad);

        }
        public void Restore(string nombreBackup)
        {
            string backupFilePath = Path.Combine(BackupsDirectory, nombreBackup);

            if (string.IsNullOrEmpty(backupFilePath) ||
                !File.Exists(backupFilePath))
            {
                throw new FileNotFoundException("El backup especificado no existe.", backupFilePath);
            }

            string dataFile = Path.Combine(BackupsDirectory, "ISProyecto.mdf");

            string logFile = Path.Combine(BackupsDirectory, "ISProyecto_log.ldf");

            var cmd = new StringBuilder();

            cmd.AppendLine("USE MASTER;");
            cmd.AppendLine("ALTER DATABASE ISProyecto SET SINGLE_USER WITH ROLLBACK IMMEDIATE;");
            cmd.AppendLine($"RESTORE DATABASE ISProyecto FROM DISK = N'{backupFilePath}' WITH REPLACE,");

            cmd.AppendLine($"MOVE 'ISProyecto' TO N'{dataFile}',");

            cmd.AppendLine($"MOVE 'ISProyecto_log' TO N'{logFile}';");

            cmd.AppendLine("ALTER DATABASE ISProyecto SET MULTI_USER;");

            _backupRepository.actionBD(cmd.ToString()); 
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
