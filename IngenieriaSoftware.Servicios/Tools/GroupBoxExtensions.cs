using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IngenieriaSoftware.Servicios.Tools
{
    public static class GroupBoxExtensions
    {

        public static void SetGroupBoxVisibilidad(this GroupBox groupBox, bool Mostrar)
        {
            if (groupBox is null)
                throw new ArgumentNullException(nameof(groupBox), "El GroupBox no puede ser nulo.");

            groupBox.Visible = Mostrar;
            groupBox.Enabled = Mostrar;

            foreach (Control control in groupBox.Controls)
            {
                control.Visible = Mostrar;
                control.Enabled = Mostrar;
            }
        } 
    }
}
