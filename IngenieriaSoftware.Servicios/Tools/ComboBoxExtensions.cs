using System.Collections.Generic;
using System.Windows.Forms;

namespace IngenieriaSoftware.Servicios.Tools
{
    public static class ComboBoxExtensions
    {
        public static void ActualizarComboBox<T>(this ComboBox combo, IEnumerable<T> data)
        {
            combo.Items.Clear();

            if (data is null) return;

            foreach (T item in data)
            {
                combo.Items.Add(item.ToString());
            }
        }
    }
}
