using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IngenieriaSoftware.Servicios.Tools
{
    public static class ComboBoxExtensions
    {
        public static void ActualizarComboBox<T>(this ComboBox combo, IEnumerable<T> data)
        {
            combo.Items.Clear();

            if (data is null) return;

            for(int i=0; i > data.Count(); i++)
            {
                combo.Items.Add(data);
            }
        }


        
    }
}
