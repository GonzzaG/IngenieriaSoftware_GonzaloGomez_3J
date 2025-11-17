using IngenieriaSoftware.BEL;
using IngenieriaSoftware.BEL.FacturaProveedor;
using IngenieriaSoftware.BLL.Facturas;
using IngenieriaSoftware.UI.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IngenieriaSoftware.UI.ComprasProveedores.Facturas
{
    public partial class FormModalFacturaTotalFinal : Form, IActualizable
    {
        private FacturaProveedor _FacturaProveedor;

        private decimal Total { get; set; }

        public FormModalFacturaTotalFinal(FacturaProveedor factura)
        {
            InitializeComponent();

            

            Inicializar(factura);

        }

        private void Inicializar(FacturaProveedor factura)
        {
            ValidarSubtotal(factura);

            _FacturaProveedor = factura;

            //  Inicialmente colocamos el subtotal como total
            Total = factura.Subtotal;
            txtNumTotalFinal.Text = Total.ToString();   

            CargarDatos();

        }

        private void CargarDatos()
        {
            txtNumSubtotal.Text = _FacturaProveedor.Subtotal.ToString();
            txtNumSubtotal.Enabled = false;
        }

        private static void ValidarSubtotal(FacturaProveedor factura)
        {
            if (factura.Subtotal <= 0)
                throw new ArgumentException("El subtotal debe ser mayor que cero.", nameof(factura.Subtotal));
        }

        public void Actualizar()
        {

        }

        private void txtNumDescuento_TextChanged(object sender, EventArgs e)
        {
            if(decimal.TryParse(txtNumDescuento.ValorNumerico, out decimal result))
            {
                Total -= result;
                txtNumTotalFinal.Text = Total.ToString();
            }
        }

        private void txtNumImpuestos_TextChanged(object sender, EventArgs e)
        {
            if (decimal.TryParse(txtNumImpuestos.ValorNumerico, out decimal result))
            {
                Total += result;
                txtNumTotalFinal.Text = Total.ToString();
            }
        }

        private void btnGenerarOrdenCompra_Click(object sender, EventArgs e)
        {
            try
            {
                ValidarCampos();

                GuardarFactura(_FacturaProveedor);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ValidarCampos()
        {
            if (string.IsNullOrEmpty(txtNumSubtotal.Text) || string.IsNullOrEmpty(txtNumTotalFinal.Text))
                throw new Exception("Por favor, complete todos los campos requeridos.");

            if(_FacturaProveedor.Total <= 0)
                throw new Exception("El total de la factura debe ser mayor que cero.");
        }

        private void GuardarFactura(FacturaProveedor facturaProveedor)
        {
            var result = new FacturaProveedorBusiness().CrearFacturaProveedor(facturaProveedor);

            MessageBox.Show("Factura de proveedor guardada exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

    }
}
