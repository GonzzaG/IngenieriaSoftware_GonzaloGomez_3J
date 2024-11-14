using IngenieriaSoftware.BEL;
using IngenieriaSoftware.BLL;
using IngenieriaSoftware.BLL.Mesas;
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
    public partial class FormFacturaAEntregar : Form, IActualizable
    {
        private readonly FacturaBLL _facturaBLL = new FacturaBLL();
        private readonly MesaBLL _mesaBLL = new MesaBLL();
       
        private int MesaId;
        private int ComandaId;
        public FormFacturaAEntregar(int mesaId, int comandaId)
        {
            InitializeComponent();
            VerificarNotificaciones();
            MesaId = mesaId;
            ComandaId = comandaId;
        }

        public NotificacionService _notificacionService => new NotificacionService();

        public void Actualizar()
        {
            var factura = _facturaBLL.ObtenerFacturaPorMesaYComanda(MesaId, ComandaId);
            if(factura == null)
            {
                MessageBox.Show("No tiene facturas en estado 'Pagadas' de esta mesa para entregar");
                return;
            }
            

            var detalleFactura = _facturaBLL.ObtenerProductosPorFacturaId(factura.FacturaId);
            if(detalleFactura == null) { return; }

            List<Factura> facturaList = new List<Factura>() { factura};

            dataGridViewDetalleFactura.DataSource = null;
            dataGridViewDetalleFactura.DataSource = detalleFactura;

            dataGridViewFacturaMesa.DataSource = null;
            dataGridViewFacturaMesa.DataSource = facturaList;

    


            lblNumeroFactura.Text = factura.NumeroFactura;
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

        private void FormFacturaAEntregar_Load(object sender, EventArgs e)
        {
            Actualizar();
        }

        private void btnFacturaEntregada_Click(object sender, EventArgs e)
        {
            
            var facturaId = (int)dataGridViewFacturaMesa.SelectedRows[0].Cells[0].Value;
            _facturaBLL.CambiarEstadoFacturaEntregada(facturaId);
            _mesaBLL.CambiarEstadoMesaDesocupada(MesaId);

            MessageBox.Show("Factura Entregada con exito. Mesa desocupada");
            this.Close();
        }
    }
}
