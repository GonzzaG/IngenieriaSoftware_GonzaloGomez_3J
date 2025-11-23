using IngenieriaSoftware.BEL.FacturaProveedor;
using IngenieriaSoftware.BEL.OrdenDeCompra;
using IngenieriaSoftware.BEL.OrdenDeCompra.ViewModels;
using IngenieriaSoftware.BLL;
using IngenieriaSoftware.BLL.Facturas;
using IngenieriaSoftware.BLL.Gestion_Compras_Insumos;
using IngenieriaSoftware.Servicios;
using IngenieriaSoftware.Servicios.DTOs;
using IngenieriaSoftware.Servicios.Tools;
using IngenieriaSoftware.UI.Common;
using IngenieriaSoftware.UI.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IngenieriaSoftware.UI.ComprasProveedores.Facturas
{
    public partial class FormAgregarFactura : Form, IActualizable
    {
        private OrdenCompraWithDetalles _OrdenCompra;
        private FacturaProveedor _FacturaProveedor;
        private List<ProductoSelectionModel> _ProductosFactura;
        private List<ProductoSelectionModel> _ProductosOrdenCompra;
        public FormAgregarFactura(int idOrdenCompra)
        {
            _ProductosFactura = new List<ProductoSelectionModel>();
            InitializeComponent();

            if (idOrdenCompra == 0)
                throw new Exception("Debe seleccionar una orden de compra");

            Inicializar(idOrdenCompra);
        }

        private void Inicializar(int idOrdenCompra)
        {
            try
            {
                //  Obtenemos la factura asociada a la orden de compra
                //var tareaFactura = GetFacturaByIdOrdenCompra(idOrdenCompra);
                //  Obtenemos la orden de compra
                _OrdenCompra = GetOrdenCompraById(idOrdenCompra);

                if (_OrdenCompra == null)
                    throw new Exception("No se pudo obtener la factura");

                GetProductosOrdenCompra();
                //  Listamos los datos de la orden de compra en los controles.
                CargarOrdenCompra();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo obtener los datos de la orden de compra: " + ex.Message);
                BitacoraHelper.RegistrarError("Inicializacion Factura", ex, "Factura", SessionManager.GetInstance.Usuario.ToString());
            }

        }

        private void GetProductosOrdenCompra()
        {
            _ProductosOrdenCompra = (from detalle in _OrdenCompra.Detalles
                                     select new ProductoSelectionModel()
                                     {
                                         IdProducto = detalle.IdProducto,
                                         Cantidad = detalle.Cantidad,
                                         PrecioUnitarioEsperado = detalle.PrecioUnitarioEsperado,
                                         Nombre = detalle.NombreProducto,

                                     }).ToList();
        }

        private void CargarOrdenCompra()
        {
            lblNumeroOrden.Text = _OrdenCompra.NumOrdenCompra;
            dgvProductosOrdenCompra.CargarDatos(_ProductosOrdenCompra);
            ConfigurarColumnasOrdenCompra();

            txtNumericTotalEsperado.Text = _OrdenCompra.TotalEsperado.ToString("N2");
            txtMoneda.Text = _OrdenCompra.Moneda;
            txtNumericTipoCambio.Text = _OrdenCompra.TipoCambio == null ? string.Empty : _OrdenCompra.TipoCambio.ToString();
            txtCondicionesPago.Text = _OrdenCompra.CondicionesPago;
        }

        private void ListarProductos()
        {
            dgvProductosFactura.CargarDatos(_ProductosFactura);

            if (_ProductosFactura is null || _ProductosFactura.Count == 0)
                return;

            ConfigurarGrillas();
        }

        private void ConfigurarGrillas()
        {
            dgvProductosFactura.OcultarColumnas("Cantidad");
            dgvProductosFactura.OcultarColumnas("IdProducto");
            AgregarColumnaCantidad();
            AgregarColumnaPrecioUnitarioEsperado();
            dgvProductosFactura.PermitirEdicionSoloEn("Cantidad", "PrecioUnitarioEsperado");
            // Cambiar color de fondo y fuente solo a la columna "Cantidad"
            dgvProductosFactura.AddButtonQuitarColumna(QuitarProductoSeleccionado);

            RenombrarColumnaGrillas();
        }

        private void RenombrarColumnaGrillas()
        {
            dgvProductosFactura.RenombrarColumna("PrecioUnitarioEsperado", "P.U Final");
            dgvProductosOrdenCompra.RenombrarColumna("PrecioUnitarioEsperado", "P.U Esperado");
        }

        private void QuitarProductoSeleccionado()
        {
            var productoAEliminar = (ProductoSelectionModel)dgvProductosFactura.ElementoSeleccionado;
            if (productoAEliminar != null)
            {
                _ProductosFactura.Remove(productoAEliminar);
                Actualizar();
            }
        }

        private void AgregarColumnaCantidad()
        {
            dgvProductosFactura.AddNumericCantidadColumna((elemento) =>
            {
                var prod = elemento as ProductoSelectionModel;
                if (prod != null && int.TryParse(prod.Cantidad.ToString(), out int nuevoValor))
                    prod.Cantidad = nuevoValor;

            });

        }

        private void AgregarColumnaPrecioUnitarioEsperado()
        {
            dgvProductosFactura.AddNumericPrecioUnitarioColumna((elemento) =>
            {
                var prod = elemento as ProductoSelectionModel;
                if (prod != null && int.TryParse(prod.PrecioUnitarioEsperado.ToString(), out int nuevoValor))
                    prod.PrecioUnitarioEsperado = nuevoValor;

            });

        }

        private void ConfigurarColumnasOrdenCompra()
        {
            dgvProductosOrdenCompra.OcultarColumnas("IdDetalle", "IdOrdenCompra", "IdProducto", "NotasLinea");
            dgvProductosOrdenCompra.RenombrarColumna("PrecioUnitarioEsperado", "P.U Esperado");

        }

        private OrdenCompraWithDetalles GetOrdenCompraById(int IdOrdenCompra)
        {

            if (IdOrdenCompra <= 0)
                throw new Exception("El Id de la orden de compra no puede ser menor o igual a cero.");

            return new OrdenCompraBussiness().GetOrdenCompraById(IdOrdenCompra);
        }


        /// <summary>
        /// Obtenemos la factura con el id de la orden de compra
        /// </summary>
        /// <param name="IdOrdenCompra"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentException"></exception>
        private FacturaProveedor GetFacturaByIdOrdenCompra(int IdOrdenCompra)
        {
            if (IdOrdenCompra <= 0)
                throw new Exception("El Id de la orden de compra no puede ser menor o igual a cero.");

            return new FacturaProveedorBusiness().GetFacturaProveedorByIdOrdenCompra(IdOrdenCompra);
        }

        private void FormAgregarFactura_Load(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Redireccionar(new FormListaOrdenCompra());
        }

        private void btnSeleccionarProductos_Click(object sender, EventArgs e)
        {
            var formMDI = this.MdiParent as FormMDI;
            new ModalSeleccionProdutosOrdenCompra(_ProductosFactura).AbrirFormModal(new Size(1050, 900));

            Actualizar();
        }

        public void Actualizar()
        {
            ListarProductos();
        }

        private void btnSeleccionarTodos_Click(object sender, EventArgs e)
        {
            try
            {
                ValidarProductosOrden();

                //  Obtenemos los productos de la orden que no han sido agregados aún
                var productosOrdenSinAgregar = GetProductosOrdenSinAgregar();

                bool hayProductos = ValidateProductosOrdenSinAgregar(productosOrdenSinAgregar);
                if (!hayProductos)
                    return;

                //  Agregamos los productos faltantes a la lista de productos de la factura
                _ProductosFactura.AddRange(productosOrdenSinAgregar);

                Actualizar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo seleccionar los productos: " + ex.Message);
                BitacoraHelper.RegistrarError("Seleccionar todos los productos", ex, "Factura", SessionManager.GetInstance.Usuario.ToString());
            }
        }

        private static bool ValidateProductosOrdenSinAgregar(List<ProductoSelectionModel> productosOrdenSinAgregar)
        {
            if (productosOrdenSinAgregar is null || productosOrdenSinAgregar.Count == 0)
                return false;
            return true;
        }

        private List<ProductoSelectionModel> GetProductosOrdenSinAgregar()
        {
            //  Obtenemos los productos de la orden los cuales no se encuentren en la lista de productos de la factura
            var productosSinAgregar = _ProductosOrdenCompra.Except(_ProductosFactura).ToList();

            return productosSinAgregar != null ? productosSinAgregar : new List<ProductoSelectionModel>();
        }

        private void ValidarProductosOrden()
        {
            if (_OrdenCompra.Detalles is null || _OrdenCompra.Detalles.Count == 0)
                throw new Exception("La orden de compra no tiene productos para agregar");
        }

        private void btnGenerarOrdenCompra_Click(object sender, EventArgs e)
        {
            try
            {
                ValidarDatosFactura();

                var factura = new FacturaProveedor()
                {
                    IdOrdenCompra = _OrdenCompra.IdOrdenCompra,
                    NumeroFactura = txtNumFactura.Text,
                    FechaPago = dtpFechaEmision.Value,
                    FechaEmision = dtpFechaEmision.Value,
                    Subtotal = GetSubTotal(),
                    IdProveedor = _OrdenCompra.IdProveedor,
                    Detalles = (from detalle in _ProductosFactura
                                select new FacturaProveedorDetalle()
                                {
                                    Cantidad = detalle.Cantidad,
                                    //Descripcion = txtDescripcion.text,
                                    //Descuento = txtDescuento.text,
                                    IdProducto = detalle.IdProducto,
                                    PrecioUnitario = (decimal)detalle.PrecioUnitarioEsperado
                                    //Impuesto = txtImpuesto.text,
                                }).ToList(),
                };

                //  Abrimos un pequeño modal donde calcularemos el Total antes de generarla
                var dialog = new FormModalFacturaTotalFinal(factura).AbrirFormModal(new Size(1600, 670));

                if (dialog.Equals(DialogResult.OK))
                    //TODO Seguir aca lo que quiero hacer despues de guardar la factura
                    this.Redireccionar(new FormListaOrdenCompra());

            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo generar la factura: " + ex.Message);
                BitacoraHelper.RegistrarError("Generar factura", ex, "Factura", SessionManager.GetInstance.Usuario.ToString());
            }
        }

        private decimal GetSubTotal()
        {
            if (_ProductosFactura is null || _ProductosFactura.Count == 0)
            {
                return 0;
            }

            var subtotal = (decimal)_ProductosFactura.Sum(p => p.Cantidad * p.PrecioUnitarioEsperado);

            return subtotal;
        }

        private void ValidarDatosFactura()
        {
            if (_ProductosFactura is null || _ProductosFactura.Count == 0)
                throw new Exception("Debe seleccionar al menos un producto para generar la factura");

            for (int i = 0; i < _ProductosFactura.Count; i++)
            {
                if (_ProductosFactura[i].PrecioUnitarioEsperado == null)
                    throw new Exception("Todos los productos deben tener un precio unitario");

                if (_ProductosFactura[i].Cantidad <= 0)
                    throw new Exception("Todos los productos deben tener una cantidad mayor a cero");

            }

            if (string.IsNullOrWhiteSpace(txtNumFactura.Text))
                throw new Exception("El número de factura es obligatorio");

            if (string.IsNullOrWhiteSpace(dtpFechaEmision.Text))
                throw new Exception("La fecha de la factura es obligatoria");
        }

        private void FormAgregarFactura_Shown(object sender, EventArgs e)
        {
            this.AutoScrollPosition = new Point(0, 0);
        }
    }
}
