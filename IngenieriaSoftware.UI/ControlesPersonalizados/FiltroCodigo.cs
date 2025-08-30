using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IngenieriaSoftware.UI.ControlesPersonalizados
{
    public partial class InputFiltroCodigo : UserControl, UserControlCustom
    {
        private int TextoNumerico;
        public int? Texto
        {
            get { return GetTextoNumerico(); }
        }
        public InputFiltroCodigo()
        {
            InitializeComponent();
        }

        private int? GetTextoNumerico()
        {
            if (int.TryParse(txtFiltroCodigo.Text, out TextoNumerico))
                return TextoNumerico;
            else
                return null;

        }

        /// <summary>
        /// Suscribe a un evento que se dispara cuando cambia el texto del filtro.
        /// </summary>
        /// <remarks>Pasar metodo de argumento que se ejecuta al ocurrir el evento</remarks>
        /// <param name="onTextChanged">Metodo ejecutado al ocurrir el evento</param>
        public void InicializarFiltro(Action metodoAlCambiarTexto)
        {
            txtFiltroCodigo.TextChanged += (s, e) => metodoAlCambiarTexto();
        }

    }
}
