using IngenieriaSoftware.BEL.Constantes;
using IngenieriaSoftware.BEL.OrdenDeCompra.Models;
using IngenieriaSoftware.BEL.OrdenDeCompra.ViewModels;
using IngenieriaSoftware.BLL.Gestion_Compras_Insumos;
using IngenieriaSoftware.UI.Common;
using IngenieriaSoftware.UI.Interfaces;
using System;
using System.Windows.Forms;

namespace IngenieriaSoftware.UI.ComprasProveedores
{
    public partial class FormAutorizacionOrdenCompra : Form, IActualizable
    {
        public FormAutorizacionOrdenCompra()
        {
            InitializeComponent();
            Inicializar();
        }

        private void Inicializar()
        {
            Actualizar();
        }

        private void AbrirModalAutorizacion()
        {
            var ordenSeleccionada = grillaConFiltros.ElementoSeleccionado != null
                ? grillaConFiltros.ElementoSeleccionado as OrdenCompraGetListaModel
                : null;

            if (ordenSeleccionada == null)
                return;

            using (var form = new FormAgregarOrdenCompra(ordenSeleccionada.NumOrdenCompra))
            {
                form.AbrirFormModal();
                btnBuscar_Click(null, null);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                var filtro = new OrdenCompraQuery
                {
                    NumOrdenCompra = txtCodigo.Text,
                    FechaDesde = dtpFechaDesde.Value,
                    IdEstado = (int)OrdenCompraEstadoEnum.Pendiente,
                };

                grillaConFiltros.CargarDatos(new OrdenCompraBussiness().GetOrdenesCompra(filtro));

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormAutorizacionOrdenCompra_Load(object sender, EventArgs e)
        {

        }

        private void btnDetalles_Click(object sender, EventArgs e)
        {
            AbrirModalAutorizacion();
            Actualizar();
        }

        public void Actualizar()
        {
            var filtro = new OrdenCompraQuery
            {
                IdEstado = (int)OrdenCompraEstadoEnum.Pendiente,
            };

            grillaConFiltros.CargarDatos(new OrdenCompraBussiness().GetOrdenesCompra(filtro));
        }
    }
}
