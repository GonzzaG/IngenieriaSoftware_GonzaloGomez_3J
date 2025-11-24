using IngenieriaSoftware.BEL;
using IngenieriaSoftware.BEL.Gestion_Compras_Insumos;
using IngenieriaSoftware.BLL.Gestion_Compras_Insumos.Inventario;
using System;
using System.Windows.Forms;

namespace IngenieriaSoftware.UI.Gestion_Compras_Insumos.Gestion_Inventario
{
    public partial class ModalEscasez : Form
    {
        private Producto _ProductoSeleccionado;
        public ModalEscasez(Producto producto)
        {
            InitializeComponent();
            if(producto is null)
                throw new Exception("El producto no puede ser nulo");

            _ProductoSeleccionado = producto;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAlertaEscasez_Click(object sender, EventArgs e)
        {
            try
            {
                var nuevaMerma = new EscasezInsertModel
                {
                    IdProducto = _ProductoSeleccionado.Id,
                    FechaRegistro = DateTime.Now,
                    Observacion = txtObservaciones.Text,
                    CantidadActual = nudCantidadRecomendada.Value,

                };
                // se acepta y se envia la alerta
                new EscasezBusiness.InsertEscasez(nuevaMerma);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al enviar la alerta de escasez: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
