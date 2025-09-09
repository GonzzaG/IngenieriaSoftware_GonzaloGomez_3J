using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IngenieriaSoftware.UI.ControlesPersonalizados.Inputs
{
    public class InputNumericTextBox : TextBox
    {
        // Cultura para el formato con separador de miles
        private readonly CultureInfo _cultura = new CultureInfo("es-ES");

        public InputNumericTextBox()
        {
            this.TextAlign = HorizontalAlignment.Right;
        }

        protected override void OnKeyPress(KeyPressEventArgs e)
        {
            base.OnKeyPress(e);

            // Permitir control como backspace
            if (char.IsControl(e.KeyChar))
            {
                return;
            }

            // Permitir solo dígitos
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        protected override void OnTextChanged(EventArgs e)
        {
            base.OnTextChanged(e);

            if (string.IsNullOrWhiteSpace(this.Text))
                return;

            int selStart = this.SelectionStart;

            // Eliminar puntos existentes
            string sinSeparadores = this.Text.Replace(".", "");

            if (decimal.TryParse(sinSeparadores, out decimal valor))
            {
                // Reaplicar formato con separadores de miles
                this.Text = string.Format(_cultura, "{0:N0}", valor);
                this.SelectionStart = Math.Min(selStart + 1, this.Text.Length);
            }
        }

        /// <summary>
        /// Devuelve el texto con formato (con puntos).
        /// </summary>
        [Browsable(false)]
        public string ValorFormateado
        {
            get => this.Text;
        }

        /// <summary>
        /// Devuelve solo los dígitos, sin separadores.
        /// </summary>
        [Browsable(false)]
        public string ValorNumerico
        {
            get => this.Text.Replace(".", "");
        }
    }
}
