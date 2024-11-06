using IngenieriaSoftware.Servicios.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IngenieriaSoftware.UI
{
    public class MenuItemIdiomaAdaptador : IIdiomaObservador
    {
        private readonly ToolStripMenuItem _menuItem;

        public int Tag { get; set; }
        public string Name { get; set; }

        public MenuItemIdiomaAdaptador(ToolStripMenuItem menuItem)
        {
            _menuItem = menuItem;
            Tag = int.Parse(menuItem.Tag?.ToString() ?? "0"); // Asume que el Tag del menú contiene el ID de traducción
        }

        public void Actualizar(string nuevoTexto)
        {

            if (Regex.IsMatch(_menuItem.Name, @"(txt)", RegexOptions.IgnoreCase))
            {
                _menuItem.Text = string.Empty;
            }
            else
            {
                _menuItem.Text = nuevoTexto;
            }
        }
    }
}
