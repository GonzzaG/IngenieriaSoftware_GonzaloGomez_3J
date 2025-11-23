using System;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

namespace IngenieriaSoftware.UI.ControlesPersonalizados.Inputs
{
    public class InputNumericTextBox : TextBox
    {
        private readonly CultureInfo _cultura = new CultureInfo("es-AR");
        private bool _internalUpdate = false;
        private const int MAX_DECIMAL_DIGITS = 2;

        [Browsable(false)]
        public string ValorFormateado => this.Text;

        [Browsable(false)]
        public string ValorNumerico => this.Text.Replace(".", "").Replace(",", ".");

        public InputNumericTextBox()
        {
            this.TextAlign = HorizontalAlignment.Right;
        }

        protected override void OnCreateControl()
        {
            base.OnCreateControl();
            // Formatear el texto inicial si ya viene relleno
            if (!string.IsNullOrWhiteSpace(this.Text))
            {
                FormatAndPreserveCaret(formatDecimalsIfPresent: false);
            }
        }

        protected override void OnKeyPress(KeyPressEventArgs e)
        {
            base.OnKeyPress(e);

            char decimalSeparator = _cultura.NumberFormat.NumberDecimalSeparator[0];

            if (char.IsControl(e.KeyChar)) return;

            if (char.IsDigit(e.KeyChar)) return;

            // aceptar . o ,
            if (e.KeyChar == '.' || e.KeyChar == ',')
            {
                // si ya existe coma -> bloquear
                if (this.Text.Contains(decimalSeparator))
                {
                    e.Handled = true;
                    return;
                }

                // transformar a coma para el texto
                e.KeyChar = decimalSeparator;

                // Mover el cursor automáticamente a la derecha de la coma
                this.BeginInvoke((Action)(() =>
                {
                    if (this.Text.Contains(decimalSeparator))
                    {
                        int pos = this.Text.IndexOf(decimalSeparator) + 1;
                        if (pos <= this.Text.Length)
                            this.SelectionStart = pos;
                    }
                }));

                return;
            }

            e.Handled = true;
        }


        protected override void OnTextChanged(EventArgs e)
        {
            if (_internalUpdate)
            {
                base.OnTextChanged(e);
                return;
            }

            // Si el texto está vacío, dejarlo (no formatear)
            if (string.IsNullOrEmpty(this.Text))
            {
                base.OnTextChanged(e);
                return;
            }

            // Si el usuario acaba de teclear una coma al final, queremos permitir verla (no formatear aún)
            char decSep = _cultura.NumberFormat.NumberDecimalSeparator[0];
            if (this.Text == decSep.ToString())
            {
                base.OnTextChanged(e);
                return;
            }

            // Si el texto termina en coma (como "123,"), permitimos que siga escribiendo decimales (no forzamos padding).
            // Pero igual formateamos la parte entera con miles.
            FormatAndPreserveCaret(formatDecimalsIfPresent: false);

            base.OnTextChanged(e);
        }

        private void FormatAndPreserveCaret(bool formatDecimalsIfPresent)
        {
            try
            {
                _internalUpdate = true;

                int selectionStart = this.SelectionStart;

                string raw = this.Text.Replace(".", "");

                char decSep = _cultura.NumberFormat.NumberDecimalSeparator[0];
                bool hasDecimal = raw.Contains(decSep);

                string integerPart;
                string decimalPart = "";

                if (hasDecimal)
                {
                    var parts = raw.Split(decSep);
                    integerPart = parts.Length > 0 ? parts[0] : "0";
                    decimalPart = parts.Length > 1 ? parts[1] : "";
                }
                else
                {
                    integerPart = raw;
                }

                integerPart = new string(integerPart.Where(c => char.IsDigit(c)).ToArray());
                decimalPart = new string(decimalPart.Where(c => char.IsDigit(c)).ToArray());

                if (decimalPart.Length > MAX_DECIMAL_DIGITS)
                    decimalPart = decimalPart.Substring(0, MAX_DECIMAL_DIGITS);

                if (string.IsNullOrEmpty(integerPart))
                    integerPart = "0";

                if (!long.TryParse(integerPart, out long intVal))
                {
                    intVal = 0;
                }

                string formattedInt = intVal.ToString("N0", _cultura);

                string newText;
                if (hasDecimal)
                {
                    newText = formattedInt + decSep + decimalPart;

                    if (formatDecimalsIfPresent)
                    {
                        if (decimal.TryParse(integerPart + decSep + decimalPart, NumberStyles.Any, _cultura, out decimal valor))
                        {
                            newText = valor.ToString("N2", _cultura);
                        }
                    }
                }
                else
                {
                    newText = formattedInt;
                }

                // ---> SOLUCIÓN <---
                // Si después de formatear el texto termina en coma, mantener el cursor al final
                if (newText.EndsWith(decSep.ToString()))
                {
                    this.Text = newText;
                    this.SelectionStart = newText.Length;
                    return;
                }

                // --- POSICIÓN DEL CURSOR ---

                int digitsBeforeCursorInRaw = CountDigitsBeforeCursorInRaw(this.Text, selectionStart);
                int totalDigitsInRaw = raw.Count(char.IsDigit);
                int digitsRightInRaw = totalDigitsInRaw - digitsBeforeCursorInRaw;

                string newRaw = newText.Replace(".", "");
                int newTotalDigits = newRaw.Count(char.IsDigit);

                int newDigitsBeforeCursor = newTotalDigits - digitsRightInRaw;
                if (newDigitsBeforeCursor < 0) newDigitsBeforeCursor = 0;
                if (newDigitsBeforeCursor > newTotalDigits) newDigitsBeforeCursor = newTotalDigits;

                int newCursorPos = MapDigitsCountToTextIndex(newText, newDigitsBeforeCursor);

                if (newCursorPos < 0) newCursorPos = 0;
                if (newCursorPos > newText.Length) newCursorPos = newText.Length;

                this.Text = newText;
                this.SelectionStart = newCursorPos;
            }
            finally
            {
                _internalUpdate = false;
            }
        }


        private int CountDigitsBeforeCursorInRaw(string textWithDots, int selectionStart)
        {
            // En textWithDots el cursor está en selectionStart; contamos cuántas cifras hay antes del cursor,
            // ignorando los puntos de miles.
            int count = 0;
            for (int i = 0; i < selectionStart && i < textWithDots.Length; i++)
            {
                if (char.IsDigit(textWithDots[i])) count++;
            }
            return count;
        }

        private int MapDigitsCountToTextIndex(string formattedText, int digitsBeforeCursor)
        {
            // Recorremos formattedText y contamos dígitos; cuando alcanzamos digitsBeforeCursor devolvemos el index siguiente.
            int count = 0;
            for (int i = 0; i < formattedText.Length; i++)
            {
                if (char.IsDigit(formattedText[i]))
                {
                    count++;
                    if (count == digitsBeforeCursor)
                    {
                        // Cursor debería ubicarse después de este dígito (i+1),
                        // pero si el siguiente carácter es separador decimal y el usuario estaba justo antes de la coma,
                        // dejar al cursor en i+1 es correcto.
                        return i + 1;
                    }
                }
            }
            // Si no alcanzamos la cuenta, posicionar al final
            return formattedText.Length;
        }

        protected override void OnLeave(EventArgs e)
        {
            base.OnLeave(e);

            if (string.IsNullOrWhiteSpace(this.Text))
            {
                this.Text = "0"; // ahora no forzamos ",00" salvo que el usuario haya digitado la coma
                return;
            }

            // Si existía coma, hacer formato a 2 decimales; si no, dejar solo la parte entera formateada
            char decSep = _cultura.NumberFormat.NumberDecimalSeparator[0];
            bool hasDecimal = this.Text.Contains(decSep);

            if (hasDecimal)
            {
                // parsear y formatear a N2
                string sinPuntos = this.Text.Replace(".", "");
                if (decimal.TryParse(sinPuntos, NumberStyles.Any, _cultura, out decimal valor))
                {
                    this.Text = valor.ToString("N2", _cultura);
                }
                else
                {
                    this.Text = "0,00";
                }
            }
            else
            {
                // solo parte entera: formatear con miles, sin decimales
                string sinPuntos = this.Text.Replace(".", "");
                sinPuntos = new string(sinPuntos.Where(c => char.IsDigit(c)).ToArray());
                if (string.IsNullOrEmpty(sinPuntos)) sinPuntos = "0";
                if (long.TryParse(sinPuntos, out long intVal))
                {
                    this.Text = intVal.ToString("N0", _cultura);
                }
                else
                {
                    this.Text = "0";
                }
            }
        }
    }
}
