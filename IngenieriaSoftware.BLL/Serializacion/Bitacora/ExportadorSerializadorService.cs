using System;
using System.IO;
using Newtonsoft.Json;

namespace IngenieriaSoftware.BLL.Serializacion.Bitacora
{
    public class ExportadorSerializadorService
    {
        private readonly string _basePath;

        public ExportadorSerializadorService()
        {
            // Ruta segura para todas las PCs
            var appData = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);

            _basePath = Path.Combine(appData, "PuercoArana", "exports");

            if (!Directory.Exists(_basePath))
                Directory.CreateDirectory(_basePath);
        }

        public string ExportarObjeto(object data, string nombreArchivoSinExtension)
        {
            var fileName = nombreArchivoSinExtension + ".json";
            var fullPath = Path.Combine(_basePath, fileName);

            // NEWTONSOFT CONFIGURACIÓN
            var settings = new JsonSerializerSettings
            {
                Formatting = Formatting.Indented // equivalente a WriteIndented = true
            };

            string contenido = JsonConvert.SerializeObject(data, settings);
            File.WriteAllText(fullPath, contenido);

            return fullPath;
        }
    }
}
