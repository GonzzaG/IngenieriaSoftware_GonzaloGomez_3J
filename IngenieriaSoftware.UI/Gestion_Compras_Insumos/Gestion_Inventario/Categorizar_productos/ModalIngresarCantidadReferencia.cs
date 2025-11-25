using System;
using System.Windows.Forms;

namespace IngenieriaSoftware.UI.Gestion_Compras_Insumos.Gestion_Inventario.Categorizar_productos
{
    public partial class ModalIngresarCantidadReferencia : Form
    {
        private Action<int> _CantidadSeleccionada;
        public ModalIngresarCantidadReferencia(Action<int> accion)
        {
            InitializeComponent();
            _CantidadSeleccionada += accion;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAlertaEscasez_Click(object sender, EventArgs e)
        {
            _CantidadSeleccionada.Invoke((int)nudCantidad.Value);
            this.Close();
        }
    }
}
