﻿using IngenieriaSoftware.BEL;
using IngenieriaSoftware.DAL;
using System;
using System.Collections.Generic;
using System.IO;

namespace IngenieriaSoftware.BLL
{
    public class BitacoraBLL
    {
        private BitacoraDAL _bitacoraDAL;
        private string _rutaArchivoLog;

        public BitacoraBLL()
        {
            _bitacoraDAL = new BitacoraDAL();
            var rutaFallback = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "logs", "bitacora_fallback.log");
            _rutaArchivoLog = rutaFallback;
        }

        public void RegistrarActividad(string usuario, string actividad, DateTime fecha, string infoAdicional, string controller, string url, string area)
        {
            var registro = new Bitacora
            {
                FechaHora = fecha,
                Usuario = usuario,
                Actividad = actividad,
                InfoAdicional = infoAdicional,
                Controller = controller,
                Url = url,
                Area = area
            };

            try
            {
                if (!_bitacoraDAL.RegistrarActividad(registro))
                {
                    throw new Exception("Fallo al guardar en la base de datos.");
                }
            }
            catch (Exception ex)
            {
                // Ruta fallback en AppData
                var fallbackDir = Path.Combine(
                    Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData),
                    "IS Proyecto");

                if (!Directory.Exists(fallbackDir))
                {
                    Directory.CreateDirectory(fallbackDir);
                }

                var fallbackPath = Path.Combine(fallbackDir, "log_fallos.txt");

                File.AppendAllText(fallbackPath, $"Error al guardar bitácora: {ex.Message}\n");

                GuardarEnArchivo(registro);
            }
        }

        public void RegistrarError(string controller, Exception ex, string usuario, string area)
        {
            RegistrarActividad(usuario, ex.Message, DateTime.Now, $"ERROR: {ex.GetType().Name}", controller, ex.Source, "Mesas");
        }

        public List<Bitacora> ConsultarBitacora(DateTime desde, DateTime hasta, string modulo = null)
        {
            return _bitacoraDAL.ObtenerRegistros(desde, hasta, modulo);
        }

        public void GuardarEnArchivo(Bitacora registro)
        {
            try
            {
                Directory.CreateDirectory(Path.GetDirectoryName(_rutaArchivoLog));
                File.AppendAllText(_rutaArchivoLog, $"{registro.FechaHora} - {registro.Usuario} - {registro.Actividad} - {registro.InfoAdicional} - {registro.Controller}\n");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Fallo crítico al guardar bitácora: {ex.Message}");
                Console.WriteLine($"Registro perdido: {registro}");
            }
        }
    }
}