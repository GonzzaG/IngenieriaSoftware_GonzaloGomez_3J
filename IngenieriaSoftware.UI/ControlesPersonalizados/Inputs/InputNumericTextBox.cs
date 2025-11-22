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
        private readonly CultureInfo _cultura = new CultureInfo("es-AR");
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
        public InputNumericTextBox()
        {
            this.TextAlign = HorizontalAlignment.Right;
        }

        protected override void OnKeyPress(KeyPressEventArgs e)
        {
            base.OnKeyPress(e);

            char decimalSeparator = _cultura.NumberFormat.NumberDecimalSeparator[0];

            // Permitir teclas de control
            if (char.IsControl(e.KeyChar))
                return;

            // Permitir dígitos
            if (char.IsDigit(e.KeyChar))
                return;

            // Permitir UNA coma decimal
            if (e.KeyChar == decimalSeparator && !this.Text.Contains(decimalSeparator))
                return;

            // Bloquear cualquier otro caracter
            e.Handled = true;
        }

        protected override void OnTextChanged(EventArgs e)
        {
            // OJO: NO FORMATEAR ACÁ
            // Sólo validación suave
            base.OnTextChanged(e);
        }

        protected override void OnLeave(EventArgs e)
        {
            base.OnLeave(e);

            // Si está vacío, dejar un valor estándar
            if (string.IsNullOrWhiteSpace(this.Text))
            {
                this.Text = "0,00";
                return;
            }

            // Sacar posibles separadores de miles si el usuario pegó algo
            string texto = this.Text
                .Replace(".", "")
                .Replace(" ", "");

            if (decimal.TryParse(texto, NumberStyles.Any, _cultura, out decimal valor))
            {
                // Formato solo al perder foco
                this.Text = valor.ToString("N2", _cultura);
            }
            else
            {
                this.Text = "0,00";
            }
        }



    }
}
