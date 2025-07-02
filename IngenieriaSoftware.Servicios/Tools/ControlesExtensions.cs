using System;
using System.Linq;
using System.Windows.Forms;

namespace IngenieriaSoftware.Servicios.Tools
{
    public static class ControlesExtensions
    {

        public static void LimpiarControles(this Control container, params Type[] tiposExcluidos)
        {
            if (container == null) throw new ArgumentNullException(nameof(container));

            foreach (var control in container.Controls.Cast<Control>())
            {
                if (tiposExcluidos.Any(t => t.IsInstanceOfType(control))) continue;

                switch (control)
                {
                    case TextBoxBase txt:
                        txt.Clear();
                        break;
                    case ComboBox cb:
                        cb.SelectedIndex = -1;
                        break;
                    case CheckBox chk:
                        chk.Checked = false;
                        break;
                    case RadioButton rb:
                        rb.Checked = false;
                        break;
                }
            }
        }
    }
}
