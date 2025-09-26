using IngenieriaSoftware.BEL.Common;
using IngenieriaSoftware.BEL.OrdenDeCompra.Models;
using IngenieriaSoftware.BLL.Gestion_Compras_Insumos;
using IngenieriaSoftware.BLL.ListSimpleBussiness;
using IngenieriaSoftware.Servicios.Tools;
using IngenieriaSoftware.UI.Interfaces;
using System;
using System.Collections.Generic;
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
            //Buscar los nombres de los estados y ponerlo en el datasource del combo
            Actualizar();
            List<SelectListSimple> ordenCompraEstados = GetOrdenesCompraEstados();

            cbEstado.DataSource = ordenCompraEstados;

            cbEstado.DisplayMember = "Nombre";
            cbEstado.ValueMember = "Id";

            if (grillaConFiltros.CantidadElementos > 0)
            {
                //grillaConFiltros.OcultarColumnas("IdProducto","Cantidad", "PrecioUnitarioEsperado");
            }
        }

        private static List<SelectListSimple> GetOrdenesCompraEstados()
        {
            var ordenCompraEstados = new ListSimpleBussiness().GetOrdenCompraEstadosListSimple();
            ordenCompraEstados.Insert(0, new SelectListSimple { Id = 0, Nombre = "Todos" });

            return ordenCompraEstados;
        }

        public void Actualizar()
        {
            ListarOrdenCompras();
        }
        private void ListarOrdenCompras()
        {
            var lista = new OrdenCompraBussiness().GetOrdenesCompra();
            grillaConFiltros.CargarDatos(lista);
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            var formMDI = this.MdiParent as FormMDI;
            formMDI.AbrirFormHijo(new FormAgregarOrdenCompra());
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            ListarOrdenCompras();  
        }

        private void btnAgregar_Click_1(object sender, EventArgs e)
        {
            var formMDI = this.MdiParent as FormMDI;
            formMDI.AbrirFormHijo(new FormAgregarOrdenCompra());
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtCodigo.Text = string.Empty;
            dtpFechaDesde.Value = DateTime.Now;
            cbEstado.Text = string.Empty;
            grillaConFiltros.LimpiarControles();
        }

        private void btnBuscar_Click_1(object sender, EventArgs e)
        {
            try
            {
                var filtro = new OrdenCompraQuery
                {
                    NumOrdenCompra = txtCodigo.Text,
                    FechaDesde = dtpFechaDesde.Value,
                    IdEstado = int.Parse(cbEstado.SelectedValue.ToString()),
                };

                grillaConFiltros.CargarDatos(new OrdenCompraBussiness().GetOrdenesCompra(filtro));
              
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
