using IngenieriaSoftware.BLL;
using IngenieriaSoftware.UI.Interfaces;
using System;
using System.Windows.Forms;

namespace IngenieriaSoftware.UI.ComprasProveedores
{
    public partial class FormListaOrdenCompra : Form, IActualizable
    {
        public FormListaOrdenCompra()
        {
            InitializeComponent();
            Actualizar();
        }

        public void Actualizar()
        {
            ListarProductos();
        }
        private void ListarProductos()
        {
            var lista = new ProductoBLL().GetAll();
            grillaConFiltros.CargarDatos(lista);
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            var formMDI = this.MdiParent as FormMDI;
            formMDI.AbrirFormHijo(new FormAgregarOrdenCompra());
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            ListarProductos();  
        }

        private void btnAgregar_Click_1(object sender, EventArgs e)
        {
            var formMDI = this.MdiParent as FormMDI;
            formMDI.AbrirFormHijo(new FormAgregarOrdenCompra());
        }
    }
}
