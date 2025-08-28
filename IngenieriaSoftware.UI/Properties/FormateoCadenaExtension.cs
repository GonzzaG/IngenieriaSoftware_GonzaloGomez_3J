using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Navigation;
using IngenieriaSoftware.Servicios.Tools;

namespace IngenieriaSoftware.UI.Properties
{
    internal static class FormateoCadenaExtension
    { 
        private static string _cadena;
        private static string Cadena {
            get => _cadena.HasValue() ? _cadena : _cadena = Resources.PRECIO_DECIMAL; 
            set => _cadena = value; }

        internal static string FormatearCadenaPrecioDecimal(this decimal precio)
        {
            return string.Format(Cadena, precio);
        }
    }
}
