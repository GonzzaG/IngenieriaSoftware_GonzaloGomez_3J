using IngenieriaSoftware.BEL;
using IngenieriaSoftware.BEL.FacturaProveedor;
using IngenieriaSoftware.BLL;
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
        private List<MedioDePago> _MediosDePago;
        private decimal Total { get; set; }

        public FormModalFacturaTotalFinal(FacturaProveedor factura)
        {
            InitializeComponent();
            Inicializar(factura);

        }

        private void Inicializar(FacturaProveedor factura)
        {
            GetMediosPago();
            ValidarSubtotal(factura);
            CargarDatos(factura);
        }

        private void GetMediosPago()
        {
            cbMedioPago.DataSource = new MedioDePagoBLL().ObtenerMediosDePago();
            cbMedioPago.DisplayMember = "Nombre";
            cbMedioPago.ValueMember = "MedioDePagoId";
        }

        private void CargarDatos(FacturaProveedor factura)
        {
            _FacturaProveedor = factura;
            //  Inicialmente colocamos el subtotal como total
            Total = factura.Subtotal;
            lblNumeroTotal.Text = Total.ToString();
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
            if(decimal.TryParse(txtNumDescuento.ValorNumerico, out decimal descuento))
                Total = _FacturaProveedor.Subtotal - descuento;
            else
                Total = _FacturaProveedor.Subtotal;

            lblNumeroTotal.Text = Total.ToString();

        }

        private void txtNumImpuestos_TextChanged(object sender, EventArgs e)
        {
            if (decimal.TryParse(txtNumImpuestos.ValorNumerico, out decimal impuestos))
                Total = _FacturaProveedor.Subtotal + impuestos;
            else 
                Total = _FacturaProveedor.Subtotal;

            lblNumeroTotal.Text = Total.ToString();

        }

        private void btnGenerarFactura_Click(object sender, EventArgs e)
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
            if (string.IsNullOrEmpty(txtNumSubtotal.Text) || string.IsNullOrEmpty(lblNumeroTotal.Text))
                throw new Exception("Por favor, complete todos los campos requeridos.");

            if(_FacturaProveedor.Total < 0)
                throw new Exception("El total de la factura debe ser igual o mayor que cero.");

            if (cbMedioPago.SelectedItem == null)
                throw new Exception("Por favor, seleccione un medio de pago.");
        }

        private void GuardarFactura(FacturaProveedor facturaProveedor)
        {
            // Rellenar los campos adicionales de la factura
            HidratarFactura(facturaProveedor);

            // Guardar la factura utilizando la capa de negocio
            var result = new FacturaProveedorBusiness().CrearFacturaProveedor(facturaProveedor);

            // Notificar al usuario
            MessageBox.Show("Factura de proveedor guardada exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Cerrar el formulario modal
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void HidratarFactura(FacturaProveedor facturaProveedor)
        {
            if (decimal.TryParse(lblNumeroTotal.Text, out decimal total))
                facturaProveedor.Total = total;
            else
                throw new Exception("El total de la factura no es válido.");

            if (decimal.TryParse(txtNumImpuestos.ValorNumerico, out decimal impuestos))
                facturaProveedor.Impuestos = impuestos;
            else
                facturaProveedor.Impuestos = 0;

            if (decimal.TryParse(txtNumDescuento.ValorNumerico, out decimal descuento))
                facturaProveedor.Descuento = descuento;
            else
                facturaProveedor.Descuento = Convert.ToDecimal(txtNumDescuento.ValorNumerico);

            if (cbMedioPago.SelectedItem is MedioDePago medioDePago)
                facturaProveedor.MetodoPago = medioDePago.Nombre;
            else
                throw new Exception("El medio de pago seleccionado no es válido.");
        }

        private void lblNumeroTotal_TextChanged(object sender, EventArgs e)
        {
            if (_FacturaProveedor.Total < 0)
                lblNumeroTotal.ForeColor = Color.Red;
            else
                lblNumeroTotal.ForeColor = Color.WhiteSmoke;
        }
    }
}
