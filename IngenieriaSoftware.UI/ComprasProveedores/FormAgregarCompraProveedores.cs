using IngenieriaSoftware.BEL;
using IngenieriaSoftware.BLL;
using IngenieriaSoftware.Servicios.Tools;
using IngenieriaSoftware.UI.Gestion_Compras_Insumos;
using IngenieriaSoftware.UI.Interfaces;
using IngenieriaSoftware.UI.Common;
using System;
using System.Windows.Forms;

namespace IngenieriaSoftware.UI.ComprasProveedores
{
    public partial class FormAgregarCompraProveedores : Form, IActualizable
    {
        public FormAgregarCompraProveedores()
        {
            InitializeComponent();
            Incializar();
        }

        public void Incializar()
        {
            ////Le decimos al filtroNombre que use el metodo ListarProductos para filtrar
            //filtroNombre.InicializarFiltro(ListarProductos);

            Actualizar();
        }   
        public void Actualizar()
        {
            ListarProductos();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            var formMDI = this.MdiParent as FormMDI;
            new FormGestionarProductos().AbrirFormModal();

            Actualizar();
        }

        private void ListarProductos(string filtroNombre = null)
        {
            
            //if (filtroNombre.HasValue())
            //    grillaConFiltrosProductos.CargarDatos(new ProductoBLL().GetByNombre(filtroNombre));
            //else
            //    grillaConFiltrosProductos.CargarDatos(new ProductoBLL().GetAll());

        }
        private void ListarProductos()
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {



        }
    }
}
