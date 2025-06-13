using IngenieriaSoftware.BEL;
using IngenieriaSoftware.DAL;
using IngenieriaSoftware.Servicios;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace IngenieriaSoftware.BLL
{
    public class BackupManager
    {
        private BackupRepository _backupRepository = new BackupRepository();
        public string BackupDirectory { get; set; } = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "BackUps");

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
                    var usuario = SessionManager.GetInstance?.Usuario;
                    if (usuario == null) throw new Exception("Usuario no definido");

                    BackupRegistro backup = new BackupRegistro
                    {
                        NombreArchivo = nombreBackup,
                        Ruta = rutaCompleta,
                        Fecha = DateTime.Now,
                        Usuario = usuario.Username
                    };

                    _backupRepository.GuardarRegistro(backup);
                    BitacoraHelper.RegistrarActividad(usuario.ToString(), "Backup realizado", DateTime.Now, string.Empty, nameof(BackupManager), nameof(RealizarBackup));
                }
            }
            catch (Exception ex)
            {
                var usuario = SessionManager.GetInstance?.Usuario?.ToString() ?? "Usuario desconocido";
                BitacoraHelper.RegistrarError(usuario, ex, nameof(BackupManager), nameof(RealizarBackup));
                throw new Exception("Error al realizar el backup", ex);
            }
        }

        public List<string> ObtenerBackUps()
        {
            try
            {
                if (!Directory.Exists(BackupDirectory))
                    throw new DirectoryNotFoundException("El directorio de backups no existe.");

                var usuario = SessionManager.GetInstance?.Usuario;
                if (usuario == null) throw new Exception("Usuario no definido");

                var backups = Directory.GetFiles(BackupDirectory, "*.bak")
                                       .Select(Path.GetFileName)
                                       .ToList();

                BitacoraHelper.RegistrarActividad(usuario.ToString(), "Obteniendo backups", DateTime.Now, string.Empty, nameof(BackupManager), nameof(ObtenerBackUps));

                return backups;
            }
            catch (Exception ex)
            {
                var usuario = SessionManager.GetInstance?.Usuario?.ToString() ?? "Usuario desconocido";
                BitacoraHelper.RegistrarError(usuario, ex, nameof(BackupManager), nameof(ObtenerBackUps));
                throw new Exception("Error al obtener los backups", ex);
            }
        }

        public bool RestaurarBackup(string nombreArchivo)
        {
            try
            {
                var rutaBackup = Path.Combine(BackupDirectory, nombreArchivo);

                if (_backupRepository.RestaurarBackup(rutaBackup))
                {
                    // Antes de eliminar el archivo, podrías moverlo a una carpeta de respaldo
                    File.Delete(rutaBackup);

                    var usuario = SessionManager.GetInstance?.Usuario;
                    if (usuario == null) throw new Exception("Usuario no definido");

                    BitacoraHelper.RegistrarActividad(usuario.ToString(), "Restaurando backup", DateTime.Now, string.Empty, nameof(BackupManager), nameof(RestaurarBackup));

                    return true;
                }
                else
                {
                    throw new Exception("No se pudo realizar la restauración.");
                }
            }
            catch (Exception ex)
            {
                var usuario = SessionManager.GetInstance?.Usuario?.ToString() ?? "Usuario desconocido";
                BitacoraHelper.RegistrarError(usuario, ex, nameof(BackupManager), nameof(RestaurarBackup));
                throw new Exception("Error al restaurar el backup", ex);
            }
        }
    }
}