using IngenieriaSoftware.BEL.Common;
using IngenieriaSoftware.BEL.Constantes;
using IngenieriaSoftware.BEL.FacturaProveedor;
using IngenieriaSoftware.BEL.OrdenDeCompra.Models;
using IngenieriaSoftware.BLL.Facturas;
using IngenieriaSoftware.BLL.Gestion_Compras_Insumos;
using IngenieriaSoftware.BLL.ListSimpleBussiness;
using IngenieriaSoftware.BLL.PDF.Factura;
using IngenieriaSoftware.UI.Common.ModalCommon;
using IngenieriaSoftware.UI.Interfaces;
using System;
using System.Collections.Generic;
using System.Diagnostics;
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

            ListarFacturas();

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
                if (cbEstado.Text.Equals(FacturaEstadoEnum.Anulada.ToString()))
                    btnAnular.Visible = false;
                else
                    btnAnular.Visible = true;
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

            dgvFacturas.CargarDatos(new FacturaProveedorBusiness().GetListFacturas(filtro));

            ConfigurarColumnas();

        }

        private void ConfigurarColumnas()
        {
            dgvFacturas.OcultarColumnas("IdOrdenCompra", "IdFacturaProveedorEstado", "UsuarioNombre");

            dgvFacturas.RenombrarColumna("NumeroFactura", "Numero");
            dgvFacturas.RenombrarColumna("FechaEmision", "Fecha Emision");
            dgvFacturas.RenombrarColumna("ProveedorNombre", "Proveedor");
            dgvFacturas.RenombrarColumna("MetodoPago", "Metodo de Pago");
            dgvFacturas.RenombrarColumna("EstadoFactura", "Estado");
            dgvFacturas.RenombrarColumna("NumeroFactura", "Numero");
        }

        private void btnAnular_Click(object sender, EventArgs e)
        {
            try
            {
                var factura = (FacturaProveedorGetListFilterModel)dgvFacturas.ElementoSeleccionado;
                if (factura is not null)
                    new FacturaProveedorBusiness().AnularFactura(factura);

                Actualizar();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);    
            }
        }

        public void Actualizar()
        {
            BusquedaFiltrada();
        }

        private void ListarFacturas()
        {
            var lista = new FacturaProveedorBusiness().GetListFacturas(new ObjectQuery());
            dgvFacturas.CargarDatos(lista);
        }

        private void btnGenerarPdf_Click(object sender, EventArgs e)
        {
            try
            {
                // validamos la factura seleccionada
                var factura = (FacturaProveedorGetListFilterModel)dgvFacturas.ElementoSeleccionado;

                if (factura is null || factura.IdFacturaProveedor <= 0)
                    throw new Exception("Debe seleccionar una factura válida.");

                // Obtenemos la factura completa con detalles
                var facturaPdf = new FacturaProveedorBusiness()
                    .GetFacturaWithDetallesById(factura.IdFacturaProveedor);

                if (facturaPdf?.Detalles == null || facturaPdf.Detalles.Count <= 0)
                    throw new Exception("No se puede generar un PDF de una factura sin detalles.");

                // Generamos el PDF
                var path = facturaPdf.GenerarPdf();

                // Mostramos pantalla con la ruta (igual que OC)
                var form = new FormMensajeConCopia(path);
                form.ShowDialog();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
