using IngenieriaSoftware.BEL.FacturaProveedor;
using IngenieriaSoftware.BEL.OrdenDeCompra;
using IngenieriaSoftware.BEL.OrdenDeCompra.ViewModels;
using IngenieriaSoftware.BLL.Facturas;
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

namespace IngenieriaSoftware.UI.ComprasProveedores.Facturas
{
    public partial class FormAgregarFactura : Form
    {
        private OrdenCompraWithDetalles _OrdenCompra;
        private FacturaProveedor _FacturaProveedor;
        public FormAgregarFactura(int idOrdenCompra)
        {
            InitializeComponent();

            if (idOrdenCompra == 0)
                throw new Exception("Debe seleccionar una orden de compra");
            
            Inicializar(idOrdenCompra);
        }

        private async void Inicializar(int idOrdenCompra)
        {
            //  Obtenemos la factura asociada a la orden de compra
            var tareaFactura = GetFacturaByIdOrdenCompra(idOrdenCompra);
            //  Obtenemos la orden de compra
            var tareaOrdenCompra = GetOrdenCompraById(idOrdenCompra);

            await Task.WhenAll(tareaFactura, tareaOrdenCompra);

            //  Esperamos a que lleguen los resultados
            _FacturaProveedor = await tareaFactura;
            _OrdenCompra = await tareaOrdenCompra;

            //  Listamos los datos de la orden de compra en los controles.
            lblNumeroOrden.Text = _OrdenCompra.NumOrdenCompra;
        

            //  Listamos los datos de la factura en los controles.
        }

        private async Task<OrdenCompraWithDetalles> GetOrdenCompraById(int IdOrdenCompra)
        {
            if (IdOrdenCompra <= 0)
                throw new Exception("El Id de la orden de compra no puede ser menor o igual a cero.");

            return await Task.Run(() => new OrdenCompraBussiness().GetOrdenCompraById(IdOrdenCompra));
        }


        /// <summary>
        /// Obtenemos la factura con el id de la orden de compra
        /// </summary>
        /// <param name="IdOrdenCompra"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentException"></exception>
        private async Task<FacturaProveedor> GetFacturaByIdOrdenCompra(int IdOrdenCompra)
        {
            if(IdOrdenCompra <= 0)
                throw new Exception("El Id de la orden de compra no puede ser menor o igual a cero.");

            return await Task.Run(() => new FacturaProveedorBusiness().GetFacturaProveedorByIdOrdenCompra(IdOrdenCompra));
        }

        private void GuardarFactura(FacturaProveedor facturaProveedor)
        {
            var result = new FacturaProveedorBusiness().CrearFacturaProveedor(facturaProveedor);

            MessageBox.Show("Factura de proveedor guardada exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private FacturaProveedor GetFactura(int idFactura)
        {
            if(idFactura <= 0)
                throw new ArgumentException("El Id de la factura no puede ser menor o igual a cero.", nameof(idFactura));

            return new FacturaProveedorBusiness().GetFacturaProveedorById(idFactura); 
        }
    }
}
