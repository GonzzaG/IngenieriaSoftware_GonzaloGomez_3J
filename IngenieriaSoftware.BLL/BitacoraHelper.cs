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
    public static class BitacoraHelper
    {
        private static readonly BitacoraBLL _instance = new BitacoraBLL();

        public static void RegistrarActividad(string usuario, string actividad, DateTime fecha, string infoAdicional, string controller, string url, string area)
        {
            var mUsuario = SessionManager.GetInstance.Usuario?.Username ?? "Sistema";
            _instance.RegistrarActividad(usuario, actividad, DateTime.Now, infoAdicional, controller, url, area);
        }

        public static void RegistrarError(string controller, Exception ex, string area, string usuario )
        {
            _instance.RegistrarActividad(usuario, $"ERROR: {ex.InnerException}", DateTime.Now, ex.StackTrace, controller, ex.Source, area);
        }

        public static List<Bitacora> ConsultarBitacora(DateTime desde, DateTime hasta, string modulo = null)
        {
            return _instance.ConsultarBitacora(desde, hasta, modulo);
        }
    }
}
