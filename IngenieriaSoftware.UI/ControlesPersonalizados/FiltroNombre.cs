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
    public partial class InputNombreFiltro : UserControl, UserControlCustom
    {
        public string Texto
        {
            get { return txtFiltroNombre.Text ; }
            set { txtFiltroNombre.Text = value; }
        }   

        public InputNombreFiltro()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Suscribe a un evento que se dispara cuando cambia el texto del filtro.
        /// </summary>
        /// <remarks>Pasar metodo de argumento que se ejecuta al ocurrir el evento</remarks>
        /// <param name="onTextChanged">Metodo ejecutado al ocurrir el evento</param>
        public void InicializarFiltro(Action metodoAlCambiarTexto)
        {
            txtFiltroNombre.TextChanged += (s, e) => metodoAlCambiarTexto();
        }

    }
}
