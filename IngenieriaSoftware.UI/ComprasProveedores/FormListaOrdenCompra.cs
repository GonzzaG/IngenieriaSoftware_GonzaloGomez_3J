using IngenieriaSoftware.BLL;
using IngenieriaSoftware.BLL.Gestion_Compras_Insumos;
using IngenieriaSoftware.Servicios.DTOs;
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
            Inicializar();
        }

        private void Inicializar()
        {

            Actualizar();
            if(grillaConFiltros.CantidadElementos > 0)
            {
                grillaConFiltros.OcultarColumnas("Cantidad", "PrecioUnitarioEsperado");
            }
        }
        public void Actualizar()
        {
            ListarProductos();
        }
        private void ListarProductos()
        {
            var lista = new ProductoOrdenCompraBussiness().GetProductosToOrdenCompra();
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
