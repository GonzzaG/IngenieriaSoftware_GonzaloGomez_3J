using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IngenieriaSoftware.UI.ControlesPersonalizados.Inputs
{
    public class ComboBoxCustom : ComboBox
    {
        public ComboBoxCustom()
        {
            InitializeComponent();
            Inicializar();
        }

        private void Inicializar()
        {
            this.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // ComboBoxCustom
            // 
            this.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SelectedIndexChanged += new System.EventHandler(this.ComboBoxCustom_SelectedIndexChanged);
            this.ResumeLayout(false);

        }



        private void ComboBoxCustom_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(this.SelectedIndex < 0)
            {
                this.SelectedIndex = 0;
            }
        }
    }
}
