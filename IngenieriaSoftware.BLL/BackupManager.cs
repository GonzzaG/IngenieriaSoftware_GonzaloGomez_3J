using IngenieriaSoftware.BEL;
using IngenieriaSoftware.DAL;
using IngenieriaSoftware.Servicios;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IngenieriaSoftware.BLL
{
    public class BackupManager
    {
        BackupRepository _backupRepository = new BackupRepository();
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
                }

            }
            catch (Exception ex)
            {
                throw new Exception("Error al realizar el backup: " + ex.Message);
            }
        }

        public List<string> ObtenerBackUps()
        {
            try
            {
                List<string> backups = new List<string>();

                if(Directory.Exists(BackupDirectory))
                {
                    var archivos = Directory.GetFiles(BackupDirectory, "*.bak");
                    foreach (var archivo in archivos)
                    {
                        backups.Add(Path.GetFileName(archivo));
                    }

                    return backups;
                }
                else
                {
                    throw new DirectoryNotFoundException("El directorio de backups no existe.");
                }
            }
            catch(Exception ex)
            {
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
                    return true;
                }
                else
                {
                    throw new Exception("No se pudo realizar la restauracion.");
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al restaurar el backup: " + ex.Message);
            }
        }




    }   
}
