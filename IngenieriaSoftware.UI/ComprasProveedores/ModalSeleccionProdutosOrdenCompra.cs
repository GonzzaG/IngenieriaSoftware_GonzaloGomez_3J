using IngenieriaSoftware.UI.Common;
using IngenieriaSoftware.UI.Gestion_Compras_Insumos;
using IngenieriaSoftware.UI.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IngenieriaSoftware.UI.ComprasProveedores
{
    public partial class ModalSeleccionProdutosOrdenCompra : Form, IActualizable
    {
        public ModalSeleccionProdutosOrdenCompra()
        {
            InitializeComponent();
        }

        public void Actualizar()
        {
            throw new NotImplementedException();
        }

        private void btnAgregarNuevo_Click(object sender, EventArgs e)
        {
            var formMDI = this.MdiParent as FormMDI;
            new FormGestionarProductos().AbrirFormModal();

            Actualizar();
        }
    }
}
