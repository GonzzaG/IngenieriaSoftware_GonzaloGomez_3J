using IngenieriaSoftware.BEL;
using IngenieriaSoftware.BEL.OrdenDeCompra;
using IngenieriaSoftware.BLL.Gestion_Compras_Insumos;
using IngenieriaSoftware.UI.Common;
using IngenieriaSoftware.UI.Interfaces;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace IngenieriaSoftware.UI.ComprasProveedores
{
    public partial class FormAgregarOrdenCompra : Form, IActualizable
    {
        private List<Producto> _ProductosOrdenCompra { get; set; }


        public FormAgregarOrdenCompra()
        {
            InitializeComponent();
            Incializar();
        }

        public void Incializar()
        {
            _ProductosOrdenCompra = new List<Producto>();
            Actualizar();
        }   
        public void Actualizar()
        {
            ListarProductos();
        }
        private void ListarProductos()
        {
            //Aca se van a ir cargando los productos que se van agregando a la orden de compra
            dgvProductosOrdenCompra.CargarDatos(_ProductosOrdenCompra);
        }

        public void GuardarOrdenDeCompra()
        {
            new OrdenCompraBussiness().Guardar(new OrdenDeCompraModel()
            {
                NumOrdenCompra = "aa-121-aaa-11",
                IdProveedor = 1,
                Fecha = DateTime.Now,
                FechaEntregaEsperada = DateTime.Now.AddDays(7),
                CondicionesPago = "30 días",
                Moneda = "USD",
                TipoCambio = 1,
                TotalEsperado = 1000,
                Estado = "Pendiente",
                Observaciones = "Primera orden de compra",
                FechaCreacion = DateTime.Now,
                UsuarioCreacion = "admin",

               Detalles = new List<OrdenDeCompraDetalleModel>()
               {
                   new OrdenDeCompraDetalleModel()
                   {
                       IdProducto = 1,
                       Cantidad = 10,
                       PrecioUnitarioEsperado = 50,
                       DescuentoLinea = 0,
                       NotasLinea = "Producto A",
                       FechaCreacion = DateTime.Now,
                       UsuarioCreacion = "admin"
                   },
                   new OrdenDeCompraDetalleModel()
                   {
                       IdProducto = 2,
                       Cantidad = 5,
                       PrecioUnitarioEsperado = 100,
                       DescuentoLinea = 0,
                       NotasLinea = "Producto B",
                       FechaCreacion = DateTime.Now,
                       UsuarioCreacion = "admin"
                   }
               }
            });


        }

        private void btnAgregarCategoria_Click(object sender, EventArgs e)
        {
            try
            {
                GuardarOrdenDeCompra();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSeleccionarProductos_Click(object sender, EventArgs e)
        {
            var formMDI = this.MdiParent as FormMDI;
            new ModalSeleccionProdutosOrdenCompra(_ProductosOrdenCompra).AbrirFormModal();

            Actualizar();
        }
    }
}
