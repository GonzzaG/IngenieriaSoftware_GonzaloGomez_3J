using IngenieriaSoftware.BEL.Common;
using IngenieriaSoftware.BEL.Constantes;
using IngenieriaSoftware.BEL.OrdenDeCompra.Models;
using IngenieriaSoftware.BLL.Facturas;
using IngenieriaSoftware.BLL.Gestion_Compras_Insumos;
using IngenieriaSoftware.BLL.ListSimpleBussiness;
using IngenieriaSoftware.UI.Interfaces;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace IngenieriaSoftware.UI.ComprasProveedores.Facturas
{
    public partial class FormListaFacturas : Form, IActualizable
    {
        public FormListaFacturas()
        {
            InitializeComponent();
            Inicializar();
        }

        private void Inicializar()
        {
            //Buscar los nombres de los estados y ponerlo en el datasource del combo

            List<SelectListSimple> ordenCompraEstados = GetFacturaEstados();

            cbEstado.DataSource = ordenCompraEstados;

            cbEstado.DisplayMember = "Nombre";
            cbEstado.ValueMember = "Id";

        }

        private static List<SelectListSimple> GetFacturaEstados()
        {
            var facturaEstados = new ListSimpleBussiness().GetFacturaEstadosListSimple();
            facturaEstados.Insert(0, new SelectListSimple { Id = 0, Nombre = "Todos" });

            return facturaEstados;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                BusquedaFiltrada();

                //  Si el estado seleccionado es Aprobado, habilitaremos la opcion de generar facturas 
                if (cbEstado.Text.Equals(FacturaEstadoEnum.Pendiente.ToString()))
                    btnAnular.Visible = true;
                else
                    btnAnular.Visible = false;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void BusquedaFiltrada()
        {
            var filtro = new ObjectQuery
            {
                Numero = txtNumFactura.Text,
                FechaDesde = dtpFechaDesde.Value,
                IdEstado = int.Parse(cbEstado.SelectedValue.ToString()),
            };

            dgvFacturas.CargarDatos(new FacturaProveedorBusiness().GetListFacturas(filtro)) ;
        }

        private void btnRechazarOrden_Click(object sender, EventArgs e)
        {

        }

        public void Actualizar()
        {
            ListarOrdenCompras();
        }

        private void ListarOrdenCompras()
        {
            var lista = new FacturaProveedorBusiness().GetListFacturas(new ObjectQuery());
            dgvFacturas.CargarDatos(lista);
        }
    }
}
