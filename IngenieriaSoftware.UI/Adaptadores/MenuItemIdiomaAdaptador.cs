using IngenieriaSoftware.Servicios.Interfaces;
using System.Text.RegularExpressions;
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
                //si es un textBox o un ComboBox, no lo modificamos
                //_menuItem.Text = string.Empty;
            }
            else
            {
                _menuItem.Text = nuevoTexto;
            }
        }
    }
}