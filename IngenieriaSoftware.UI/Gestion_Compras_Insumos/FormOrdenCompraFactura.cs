using IngenieriaSoftware.BEL;
using IngenieriaSoftware.BEL.Proveedor;
using IngenieriaSoftware.BLL;
using IngenieriaSoftware.BLL.Gestion_Compras_Insumos;
using IngenieriaSoftware.Servicios.Tools;
using IngenieriaSoftware.UI.Properties;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Media;

namespace IngenieriaSoftware.UI.Gestion_Compras_Insumos
{
    public partial class FormOrdenCompraFactura : Form, IVerificoNotificaciones
    {
        internal Proveedor Proveedor { get; set; }
        private List<Producto> CarritoProductos { get; set; }
        private decimal CarritoTotal { get; set; }

        public NotificacionService _notificacionService => new NotificacionService();

        public FormOrdenCompraFactura()
        {
            InitializeComponent();
            Inicializar();
        }
        private void Inicializar()
        {
            Actualizar();
            CarritoProductos = new List<Producto>();
            InicializarDataGridViews();
        }
        private void InicializarDataGridViews()
        {
            InicializarProductos();
            InicializarCarrito();


        }
        private void InicializarCarrito()
        {
            CarritoProductos = new List<Producto>();
            CarritoTotal = 0;

            dgvCarrito.PersonalizarEstiloPredeterminado();
            OcultarColumnasCarrito();

            CambiarVisibilidadGroupBox(gBCarrito, false);

        }

        private void InicializarProductos()
        {
            dgvProductos.PersonalizarEstiloPredeterminado();
            OcultarColumnasProductos();

            CambiarVisibilidadGroupBox(gBListaProductos, false);
        }
      
        public void Actualizar()
        {
            dgvProductos.DataSource = null;
        }
        private void iBBuscarProveedores_Click(object sender, System.EventArgs e)
        {
            try
            {
                var _formBusquedaProveedores = new FormBusquedaProveedores();
                _formBusquedaProveedores.StartPosition = FormStartPosition.CenterScreen;
                _formBusquedaProveedores.esProveedorSeleccionado += OnProveedorSeleccionado;
                _formBusquedaProveedores.ShowDialog(this);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void OnProveedorSeleccionado(Proveedor proveedor)
        {
            proveedor.ValidarObjetoNoNulo();

            MostrarDatosProveedorSeleccionado(proveedor);

            ActualizarListaDeProductos(proveedor);

            MostrarGroupBox();

        }
        private void MostrarGroupBox()
        {
            CambiarVisibilidadGroupBox(gBListaProductos, true);
            CambiarVisibilidadGroupBox(gBCarrito, true);
        }
        private void MostrarDatosProveedorSeleccionado(Proveedor proveedor)
        {

            txtTelefono.Text = proveedor.Telefono.HasValue() ? proveedor.Telefono : Resources.CAMPO_VACIO;
            txtCorreo.Text = proveedor.Correo.HasValue() ? proveedor.Correo : Resources.CAMPO_VACIO;
            txtRazonSocial.Text = proveedor.RazonSocial.HasValue() ? proveedor.RazonSocial : Resources.CAMPO_VACIO;
        }

        private void ActualizarListaDeProductos(Proveedor proveedor)
        {
            dgvProductos.ActualizarDataSource(new ProductoProveedorBussiness().GetByIdDelProveedor(proveedor.IdProveedor));


            OcultarColumnasProductos();
        }
        private void OcultarColumnasProductos()
        {
            try
            {
                var properties = typeof(Producto).GetProperties();

                for (int i = 0; i < properties.Length; i++)
                {
                    if (properties[i].Name != "Nombre"
                        && properties[i].Name != "Descripcion"
                        && properties[i].Name != "Precio"
                        && properties[i].Name != "Tipo"
                        && properties[i].Name != "Cantidad")
                    {
                        dgvProductos.Columns[i].Visible = false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void OcultarColumnasCarrito()
        {
            try
            {
                var properties = typeof(Producto).GetProperties();
                for (int i = 0; i < properties.Length; i++)
                {
                    if (properties[i].Name != "Nombre"
                        && properties[i].Name != "Precio")
                    {
                        dgvCarrito.Columns[i].Visible = false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnAgregarAlCarrito_Click(object sender, EventArgs e)
        {
            try
            {
                ValidarFilaSeleccionada(dgvProductos);
                AgregarProductoAlCarrito(dgvProductos.SelectedRows[0].DataBoundItem as Producto);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void AgregarProductoAlCarrito(Producto productoSeleccionado)
        {
            productoSeleccionado.ValidarObjetoNoNulo();
            CarritoProductos.Add(productoSeleccionado);

            ActualizarCarrito();
            ActualizarTotal(productoSeleccionado.Precio);
        }

        private void ActualizarTotal(decimal precioProducto)
        {
            CarritoTotal += precioProducto;
            
            MostrarEnLabelTotal(CarritoTotal);
        }
        private void MostrarEnLabelTotal(decimal total)
        {
            lblTotal.Text = total.HasPositiveValue()
                ? total.FormatearCadenaPrecioDecimal()
                : string.Empty;
        }

        private void ValidarFilaSeleccionada(DataGridView dgv)
        {
            if (dgv.SelectedRows.Count == 0)
                throw new Exception("Debe seleccionar una fila.");
            if (dgv.SelectedRows.Count > 1)
                throw new Exception("Debe seleccionar solo una fila.");
            if (!(dgv.SelectedRows[0].DataBoundItem is Producto productoSeleccionado))
                throw new Exception("Debe seleccionar un producto válido.");
            if (productoSeleccionado is null)
                throw new Exception("El producto seleccionado es nulo.");

        }
        private void ActualizarCarrito()
        {
            dgvCarrito.ActualizarDataSource(CarritoProductos);
            OcultarColumnasCarrito();
        }


        private void btnRealizarPedido_Click(object sender, EventArgs e)
        {
            try
            {

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void VerificarNotificaciones()
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            
            (this.Parent as FormMDI).WindowState = FormWindowState.Maximized;
        }

        private void btnQuitarDelCarrito_Click(object sender, EventArgs e)
        {
            try
            {
                ValidarFilaSeleccionada(dgvProductos);
                QuitarProductoDelCarrito(dgvCarrito.SelectedRows[0].DataBoundItem as Producto);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void QuitarProductoDelCarrito(Producto productoSeleccionado)
        {
            productoSeleccionado.ValidarObjetoNoNulo();
            CarritoProductos.Remove(productoSeleccionado);

            ActualizarCarrito();
            ActualizarTotal(-productoSeleccionado.Precio);
        }

        private void CambiarVisibilidadGroupBox(GroupBox gB, bool mostrar)
        {
            gB.SetGroupBoxVisibilidad(mostrar);

            if(mostrar)
                gB.BringToFront();
                gB.Focus();
        }

        private void txtTelefono_Enter(object sender, EventArgs e)
        {
            this.ActiveControl = null;
        }

        private void txtRazonSocial_Enter(object sender, EventArgs e)
        {
            this.ActiveControl = null;
        }

        private void txtCorreo_Enter(object sender, EventArgs e)
        {
            this.ActiveControl = null;
        }

        //private void MostarLabelsDeGridVacias()
        //{
        //    MostrarLabelsDeProductosVacios();
        //    MostrarLabelsDeCarritoVacio();
        //}
        //private void MostrarLabelsDeProductosVacios()
        //{
        //    var label = new Label();
        //    if (dgvProductos.Rows.Count.Equals(0))
        //    {
        //        label.BackColor = this.BackColor;
        //        label.ForeColor = System.Drawing.Color.WhiteSmoke;
        //        label.Font = new System.Drawing.Font("Segoe UI Symbol", 22);
        //        label.Text = Resources.SELECCIONE_PROVEEDOR;
        //        label.Location = new System.Drawing.Point((gBListaProductos.Location.X + dgvProductos.Location.X), (gBListaProductos.Location.Y + dgvProductos.Location.Y));// + (dgvProductos.Height / 2));
        //        label.Visible = true;

        //    }
        //    else
        //    {
        //        label.Visible = false;
        //    }
        //}
        //private void MostrarLabelsDeCarritoVacio()
        //{
        //    var label = new Label();
        //    if (dgvCarrito.Rows.Count.Equals(0))
        //    {
        //        label.BackColor = this.BackColor;
        //        label.ForeColor = System.Drawing.Color.WhiteSmoke;
        //        label.Font = new System.Drawing.Font("Segoe UI Symbol", 22);
        //        label.Text = Resources.NO_HAY_PRODUCTOS_EN_CARRITO;
        //        label.Location = new System.Drawing.Point((gBCarrito.Location.X + dgvCarrito.Location.X), (gBCarrito.Location.Y + dgvCarrito.Location.Y));// + (dgvCarrito.Height / 2));
        //        label.Visible = true;
        //    }
        //    else
        //    {
        //        label.Visible = false;
        //    }
        //}




        //TODO: Agregar un campo Tipo varchar, que por defecto sea 'Restaurante', para diferenciar productos del negocio con productos
        //como packaging, limpieza, etc.
        //cambiar los procedures de producto para obtener los que son Restaurante, y cuando se inserta, sean de resturante.
        //- Orden de compra (OC)
        //        Se emite desde el área de compras al proveedor, detallando productos, cantidades, precios y condiciones.
        //        - Recepción de mercadería
        //        El encargado de depósito verifica que lo recibido coincida con la OC.Si todo está correcto, registra la recepción conforme en el sistema.
        //        - Factura del proveedor
        //        El proveedor emite la factura, generalmente después de despachar la mercadería. En algunos casos, la factura puede llegar junto con los productos o incluso antes, como anticipo.
        //        - Carga y validación de la factura
        //        El área administrativa o de cuentas a pagar registra la factura en el sistema, y la compara contra la OC y la recepción.Si todo coincide, se aprueba para pago.
        //        - Pago al proveedor
        //        Se realiza según los términos acordados (por ejemplo, a 30 días de la fecha de factura o de recepción).


    }
}
