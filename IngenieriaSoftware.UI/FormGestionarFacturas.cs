using IngenieriaSoftware.BEL;
using IngenieriaSoftware.BEL.Constantes;
using IngenieriaSoftware.BLL;
using IngenieriaSoftware.Servicios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IngenieriaSoftware.UI
{
    public partial class FormGestionarFacturas : Form, IActualizable
    {
        private readonly FacturaBLL _facturaBLL = new FacturaBLL();
        private readonly ComandaBLL _comandaBLL = new ComandaBLL(); 
        public FormGestionarFacturas()
        {
            InitializeComponent();

        }
    
        public NotificacionService _notificacionService =>  new NotificacionService();

        public void Actualizar()
        {
            comboBoxFiltroEstado.Items.Clear();

            var estados = _facturaBLL.ObtenerEstadosFactura();
            foreach(string e in estados)
            {
                comboBoxFiltroEstado.Items.Add(e);
            }

            //dataGridViewFacturas.DataSource = null;
        }

        public void VerificarNotificaciones()
        {
            if (PermisosData.Permisos.Contains("PERM_ADMIN") ||
                PermisosData.Permisos.Contains("PERM_MESERO"))
            {
                var notificaciones = _notificacionService.ObtenerNotificaciones();
                if (notificaciones.Count > 0)
                {
                    HelperForms.MostrarNotificacion(notificaciones, this);
                }
            }
        }

        private void FormGestionarFacturas_Load(object sender, EventArgs e)
        {
            Actualizar();   
        }

        private void comboBoxFiltroEstado_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBoxFiltroEstado.SelectedItem == null || comboBoxFiltroEstado.Text == string.Empty) { return; }

            var estadoNombre = comboBoxFiltroEstado.SelectedItem.ToString();

          //  dataGridViewFacturas.DataSource = null;

            ListarFacturas(estadoNombre);
        }

        private void ListarFacturas(string estadoNombre)
        {
            dataGridViewFacturas.DataSource = null;

            if (Enum.TryParse(estadoNombre, out EstadoFactura.Estado estado))
            {
                dataGridViewFacturas.DataSource = null;

                switch (estado)
                {
                    case EstadoFactura.Estado.Solicitada:
                        dataGridViewFacturas.DataSource = _facturaBLL.ObtenerFacturasSolicitadas();
                        break;

                    case EstadoFactura.Estado.PendienteDePago:
                        dataGridViewFacturas.DataSource = _facturaBLL.ObtenerFacturasPenditesDePago();
                        break;

                    case EstadoFactura.Estado.Pagada:
                        dataGridViewFacturas.DataSource = _facturaBLL.ObtenerFacturasPagadas();
                        break;

                    case EstadoFactura.Estado.Entregada:
                        dataGridViewFacturas.DataSource = _facturaBLL.ObtenerFacturasEntregadas();
                        break;

                    default:

                        break;
                }
            }
            else
            {
                MessageBox.Show("El estado seleccionado no es válido.");
            }
        }

        private void btnMarcarComoPagado_Click(object sender, EventArgs e)
        {
            if(dataGridViewFacturas.SelectedRows.Count == 0) { return; }

            var facturaId = (int)dataGridViewFacturas.SelectedRows[0].Cells[0].Value;
            CambiarEstadoFacturaPagada(facturaId);

            string estado = (comboBoxFiltroEstado.SelectedItem.ToString());
            ListarFacturas(estado);
        }

        private void CambiarEstadoFacturaPagada(int facturaId)
        {
            if (facturaId > 0)
            {
                var esPendienteDePago = _facturaBLL.FacturaPendienteDePago(facturaId);

                if (esPendienteDePago)
                {
                    _facturaBLL.CambiarEstadoFacturaPagada(facturaId);
                }
                else
                {
                    MessageBox.Show("La factura debe encontrarse 'Pendiente de pago' para marcarla como pagada");
                }
            }
        }

        private void CambiarEstadoFacturaPendienteDePago(int facturaId)
        {
            if (facturaId > 0)
            {
                var esSolicitada = _facturaBLL.FacturaSolicitada(facturaId);

                if (esSolicitada)
                {
                    _facturaBLL.CambiarEstadoFacturaPendienteDePago(facturaId);
                }
                else
                {
                    MessageBox.Show("La factura debe encontrarse 'Solicitada' para marcarla como pendiente de pago");
                }
            }
        }

        private void btnPendienteDePago_Click_1(object sender, EventArgs e)
        {
            if (dataGridViewFacturas.SelectedRows.Count == 0) { return; }

            var facturaId = (int)dataGridViewFacturas.SelectedRows[0].Cells[0].Value;

            CambiarEstadoFacturaPendienteDePago(facturaId);

            string estado = (comboBoxFiltroEstado.SelectedItem.ToString());
            ListarFacturas(estado);
        }

        private void btnEntregarFactura_Click(object sender, EventArgs e)
        {
            try
            {
                int mesaId = (int)dataGridViewFacturas.SelectedRows[0].Cells[3].Value;
                var facturas = (List<Factura>)dataGridViewFacturas.DataSource;
                Factura Factura = facturas
                    .Where(m => m.MesaId == mesaId)
                    .First(m => m.EstadoPago == EstadoFactura.Estado.Pagada);

                if (Factura == null) { return; }
                //veo si puedo imprimir la factura y tabmien marcarla como entregada
                var padre = this.MdiParent as FormMDI;
                FormFacturaAEntregar formGestionarFacturas = new FormFacturaAEntregar(Factura);

                padre.AbrirFormHijo(formGestionarFacturas);
            }
            catch (Exception ex)
            {
                MessageBox.Show("La factura tiene que estar ppagada para entregarla");
            }
        }
    }
}
