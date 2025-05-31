using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IngenieriaSoftware.UI
{
    public class CustomMenuStripMDI : MenuStrip
    {
        protected override void InitLayout()
        {
            this.Renderer = new CustomMenuStripRenderer();
            this.BackColor = Color.FromArgb(56, 56, 56);
            base.InitLayout();
        }
    }
}
