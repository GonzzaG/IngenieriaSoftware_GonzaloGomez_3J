using IngenieriaSoftware.BEL;
using IngenieriaSoftware.DAL;
using IngenieriaSoftware.Servicios;
using System;
using System.Collections.Generic;
using System.IO;

namespace IngenieriaSoftware.BLL
{
    public class BackupManager
    {
        private BackupRepository _backupRepository = new BackupRepository();
        public string BackupDirectory { get; set; } = AppDomain.CurrentDomain.BaseDirectory + @"\BackUps";

        public void RealizarBackup()
        {
            try
            {
                if (!Directory.Exists(BackupDirectory))
                    Directory.CreateDirectory(BackupDirectory);

                var nombreBackup = $"{new DAO().NombreBD}_{DateTime.Now:yyyyMMdd_HHmmss}.bak";
                var rutaCompleta = Path.Combine(BackupDirectory, nombreBackup);
                if (_backupRepository.RealizarBackUpBD(nombreBackup, rutaCompleta))
                {
                    BackupRegistro backup = new BackupRegistro
                    {
                        NombreArchivo = nombreBackup,
                        Ruta = rutaCompleta,
                        Fecha = DateTime.Now,
                        Usuario = SessionManager.GetInstance.Usuario.Username
                    };
                    _backupRepository.GuardarRegistro(backup);
                    BitacoraHelper.RegistrarActividad(SessionManager.GetInstance.Usuario.ToString(), "Backup realizado", DateTime.Now, string.Empty, "BackupManager", "RealizarBackup");
                }
            }
            catch (Exception ex)
            {
                BitacoraHelper.RegistrarError(SessionManager.GetInstance.Usuario.ToString(), ex, "BackupManager", "RealizarBackup");
                throw new Exception("Error al realizar el backup: " + ex.Message);
            }
        }

        public List<string> ObtenerBackUps()
        {
            try
            {
                List<string> backups = new List<string>();

                if (Directory.Exists(BackupDirectory))
                {
                    var archivos = Directory.GetFiles(BackupDirectory, "*.bak");
                    foreach (var archivo in archivos)
                    {
                        backups.Add(Path.GetFileName(archivo));
                    }

                    BitacoraHelper.RegistrarActividad(SessionManager.GetInstance.Usuario.ToString(), "Obteniendo backups", DateTime.Now, string.Empty, "BackupManager", "ObtenerBackUps");
                    return backups;
                }
                else
                {
                    throw new DirectoryNotFoundException("El directorio de backups no existe.");
                }
            }
            catch (Exception ex)
            {
                BitacoraHelper.RegistrarError(SessionManager.GetInstance.Usuario.ToString(), ex, "BackupManager", "ObtenerBackUps");
                throw new Exception("Error al obtener los backups: " + ex.Message);
            }
        }

        public bool RestaurarBackup(string nombreArchivo)
        {
            try
            {
                var rutaBackup = Path.Combine(BackupDirectory, nombreArchivo);
                if (_backupRepository.RestaurarBackup(rutaBackup))
                {
                    File.Delete(rutaBackup);
                    BitacoraHelper.RegistrarActividad(SessionManager.GetInstance.Usuario.ToString(), "Restaurando backup", DateTime.Now, string.Empty, "BackupManager", "RestaurarBackup");
                    return true;
                }
                else
                {
                    throw new Exception("No se pudo realizar la restauracion.");
                }
            }
            catch (Exception ex)
            {
                BitacoraHelper.RegistrarError(SessionManager.GetInstance.Usuario.ToString(), ex, "BackupManager", "RestaurarBackup");
                throw new Exception("Error al restaurar el backup: " + ex.Message);
            }
        }
    }
}