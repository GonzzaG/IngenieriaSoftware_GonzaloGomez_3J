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
            Inicializar(producto);
        }

        private void Inicializar(Producto producto)
        {
            if (producto is null)
                throw new Exception("El producto no puede ser nulo");

            _ProductoSeleccionado = producto;
            lblProducto.Text = $"Producto: {_ProductoSeleccionado.Nombre}";
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAlertaEscasez_Click(object sender, EventArgs e)
        {
            try
            {
                var escasez = new EscasezModel
                {
                    IdProducto = _ProductoSeleccionado.Id,
                    FechaRegistro = DateTime.Now,
                    Observacion = txtObservaciones.Text,
                    CantidadRecomendada = nudCantidadRecomendada.Value,
                };

                // se acepta y se envia la alerta
                new EscasezBusiness().InsertEscasez(escasez);

                MessageBox.Show($"Se registró la escasez de {_ProductoSeleccionado.Nombre}");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al enviar la alerta de escasez: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
