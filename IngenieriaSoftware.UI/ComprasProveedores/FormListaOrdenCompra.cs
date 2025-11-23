using IngenieriaSoftware.BEL.Common;
using IngenieriaSoftware.BEL.Constantes;
using IngenieriaSoftware.BEL.OrdenDeCompra.Models;
using IngenieriaSoftware.BEL.OrdenDeCompra.ViewModels;
using IngenieriaSoftware.BLL.Gestion_Compras_Insumos;
using IngenieriaSoftware.BLL.ListSimpleBussiness;
using IngenieriaSoftware.Servicios.Tools;
using IngenieriaSoftware.UI.ComprasProveedores.Facturas;
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
            Actualizar();
        }

        public FormListaOrdenCompra(OrdenCompraEstadoEnum estado)
        {

            try
            {
                InitializeComponent();
                Inicializar();

                var filtro = new OrdenCompraQuery
                {
                    NumOrdenCompra = string.Empty,
                    FechaDesde = DateTime.Now,
                    IdEstado = (int)estado,
                };

                // Seleccionamos el estado que se pasa como parametro
                cbEstado.SelectedIndex = (int)estado;

                // Ponemos visible el boton de generar factura ya que estamos buscando las aprobadas
                if(estado.Equals(OrdenCompraEstadoEnum.Aprobada))
                    btnGenerarFactura.Visible = true;

                //  Buscamos las orden de compra segun el estado del parametro
                grillaConFiltros.CargarDatos(new OrdenCompraBussiness().GetOrdenesCompra(filtro));


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Actualizar();
            }
          

        }

        private void Inicializar()
        {
            //Buscar los nombres de los estados y ponerlo en el datasource del combo

            List<SelectListSimple> ordenCompraEstados = GetOrdenesCompraEstados();

            cbEstado.DataSource = ordenCompraEstados;

            cbEstado.DisplayMember = "Nombre";
            cbEstado.ValueMember = "Id";
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
            cbEstado.SelectedIndex = 0;
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

                //  Si el estado seleccionado es Aprobado, habilitaremos la opcion de generar facturas 
                if(cbEstado.Text.Equals(OrdenCompraEstadoEnum.Aprobada.ToString()))
                    btnGenerarFactura.Visible = true;
                else
                    btnGenerarFactura.Visible = false;
              
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Le pasamos a la pantalla de generar factura la orden de compra seleccionada
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnGenerarFactura_Click(object sender, EventArgs e)
        {
            try
            {
                var ordenCompra = (OrdenCompraGetListaModel)grillaConFiltros.ElementoSeleccionado;

                if (ordenCompra == null || ordenCompra.IdOrdenCompra <= 0) 
                    throw new Exception("Debe seleccionar una orden de compra");

                var formMDI = this.MdiParent as FormMDI;
                formMDI
                    .AbrirFormHijo(new FormAgregarFactura(ordenCompra.IdOrdenCompra));


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cbEstado_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbEstado.SelectedIndex == -1)
            {
                cbEstado.SelectedIndex = 0;
            }
        }

        private void cbEstado_TextChanged(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(cbEstado.Text))
            {
                cbEstado.SelectedIndex = 0;
            }
            
        }
    }
}
