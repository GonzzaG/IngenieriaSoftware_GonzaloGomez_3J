using IngenieriaSoftware.BEL;
using IngenieriaSoftware.Servicios;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;

namespace IngenieriaSoftware.BLL
{
    public static class BitacoraHelper
    {
        private static readonly BitacoraBLL _instance = new BitacoraBLL();

        public static void RegistrarActividad(string usuario, string actividad, DateTime fecha, string infoAdicional, string controller, string url, string area = "General")
        {
            try
            {
                var stackTrace = new StackTrace();
                var frame = stackTrace.GetFrame(1); // 1 para obtener el método que llamó a este
                var method = frame.GetMethod();

                string clase = method.DeclaringType.FullName;
                string metodo = method.Name;

                string ubicacion = $"{clase}.{metodo}";

                var mUsuario = SessionManager.GetInstance.Usuario?.Username ?? "Sistema";
                _instance.RegistrarActividad(mUsuario, actividad, DateTime.Now, infoAdicional, clase, ubicacion, area);
            }
            catch (Exception ex)
            {
                // Puedes registrar en un archivo de log como fallback
                File.AppendAllText("log_fallos.txt", $"Error al guardar bitácora: {ex.Message}\n");
            }
        }

        public static void RegistrarError(string controller, Exception ex, string area, string usuario)
        {
            var stackTrace = new StackTrace();
            var frame = stackTrace.GetFrame(1); // 1 para obtener el método que llamó a este
            var method = frame.GetMethod();

            string clase = method.DeclaringType.FullName;
            string metodo = method.Name;

            string ubicacion = $"{clase}.{metodo}";

            var mUsuario = SessionManager.GetInstance.Usuario?.Username ?? "Sistema";
            _instance.RegistrarActividad(mUsuario, $"ERROR: {ex.InnerException}", DateTime.Now, ex.StackTrace, clase, ubicacion, area);
        }

        public static List<Bitacora> ConsultarBitacora(DateTime desde, DateTime hasta, string modulo = null)
        {
            return _instance.ConsultarBitacora(desde, hasta, modulo);
        }
    }
}