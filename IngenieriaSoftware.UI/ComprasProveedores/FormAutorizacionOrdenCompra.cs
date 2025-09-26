using IngenieriaSoftware.BEL.Constantes;
using IngenieriaSoftware.BEL.OrdenDeCompra.Models;
using IngenieriaSoftware.BLL.Gestion_Compras_Insumos;
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
    public partial class FormAutorizacionOrdenCompra : Form
    {
        public FormAutorizacionOrdenCompra()
        {
            InitializeComponent();
            Inicializar();
        }

        private void Inicializar()
        {
            var filtro = new OrdenCompraQuery
            {
                IdEstado = (int)OrdenCompraEstadoEnum.Pendiente,
            };

            grillaConFiltros.CargarDatos(new OrdenCompraBussiness().GetOrdenesCompra(filtro));
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
    }
}
