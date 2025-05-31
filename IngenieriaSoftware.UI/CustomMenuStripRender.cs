using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IngenieriaSoftware.UI
{
    public class CustomMenuStripRenderer : ToolStripProfessionalRenderer
    {
        protected override void OnRenderMenuItemBackground(ToolStripItemRenderEventArgs e)
        {
            if (e.Item.Selected)
            {
                // Cambia el color de fondo cuando el elemento está seleccionado
                e.Graphics.FillRectangle(Brushes.DarkGray, e.Item.ContentRectangle);
            }
            else
            {
                //e.Graphics.FillRectangle(Brushes.DarkGray, e.Item.ContentRectangle);
               
            }
        }

        protected override void OnRenderItemText(ToolStripItemTextRenderEventArgs e)
        {
            if (e.Item.Selected)
            {
                // Cambia el color del texto cuando el elemento está seleccionado
                e.TextColor = Color.Black;
            }
            else
            {
                // Cambia el color del texto cuando el elemento no está seleccionado
                e.TextColor = Color.White;
            }

            base.OnRenderItemText(e);
        }
        protected override void OnRenderToolStripBackground(ToolStripRenderEventArgs e)
        {
            // Cambia el color de fondo de los subitems
            e.Graphics.FillRectangle(Brushes.Black, e.ConnectedArea);
        }
    }

}
