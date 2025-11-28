using IngenieriaSoftware.BEL;
using IngenieriaSoftware.BEL.Gestion_Compras_Insumos;
using IngenieriaSoftware.BLL.Gestion_Compras_Insumos.Inventario;
using System;
using System.Windows.Forms;

namespace IngenieriaSoftware.UI.Gestion_Compras_Insumos.Gestion_Inventario
{
    public partial class ModalMerma : Form
    {
        private Producto _ProductoSeleccionado;
        public ModalMerma(Producto producto)
        {
            InitializeComponent();

            Inicializar(producto);
        }

        private void Inicializar(Producto producto)
        {
            if (producto is null)
                throw new Exception("El producto no puede ser nulo");

            _ProductoSeleccionado = producto;
            lblProducto.Text = $"Producto: {producto.Nombre}";
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardarMerma_Click(object sender, EventArgs e)
        {
            try
            {
                var merma = new MermaInsertModel
                {
                    IdProducto = _ProductoSeleccionado.Id,
                    CantidadMerma = nudMerma.Value,
                    FechaMerma = DateTime.Now,
                    Descripcion = txtObservaciones.Text
                };

                new MermaBusiness().InsertEscasez(merma);

                MessageBox.Show($"Se registró la escasez de {_ProductoSeleccionado.Nombre}");

                this.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error al registrar la merma: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }   
        }
    }
}
