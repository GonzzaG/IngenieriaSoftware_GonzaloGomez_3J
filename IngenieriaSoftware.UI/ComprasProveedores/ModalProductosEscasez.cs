using IngenieriaSoftware.BLL.Gestion_Compras_Insumos.Inventario;
using System.Windows.Forms;

namespace IngenieriaSoftware.UI.ComprasProveedores
{
    public partial class ModalProductosEscasez : Form
    {
        public ModalProductosEscasez()
        {
            InitializeComponent();
            Inicializar();
        }

        public void Inicializar()
        {
            var productos = new EscasezBusiness().GetProductosEscasez();
            dgvProductosEscasez.CargarDatos(productos);
        }

    }
}
