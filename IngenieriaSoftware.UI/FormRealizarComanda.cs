using IngenieriaSoftware.BEL;
using IngenieriaSoftware.BLL;
using IngenieriaSoftware.BLL.Mesas;
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
    public partial class FormRealizarComanda : Form, IActualizable
    {
        private readonly ProductoBLL _productoBLL = new ProductoBLL();
        private Mesa _mesa;
        public FormRealizarComanda(Mesa mesa)
        {
            InitializeComponent();
            _mesa = mesa;
            Inicializar();
        }

        private void Inicializar()
        {
            try
            {
                //obtenemos todos los productos
                var mesas = _productoBLL.ObtenerTodasLasMesas();
                if (mesas != null)
                {
                    dataGridViewProductos.DataSource = null;
                    dataGridViewProductos.DataSource = mesas;
                }

                lblNumeroMesa.Text = _mesa.MesaId.ToString();
            }
            catch (Exception ex)
            {

            }
        }
        private void FormRealizarComanda_Load(object sender, EventArgs e)
        {

        }

        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            //en este boton se agregara el producto seleccionado a la comanda de la mesa actual seleccionada
            //se tiene que guardar en comandaProducto la relacion que va a existir entre ese producto y la comanda de la mesa
        }

        private void btnVerComanda_Click(object sender, EventArgs e)
        {
            // Mostramos el formulario ver comanda con la mesa actual como parametro
            
            var padre = this.MdiParent as FormMDI;

            FormVerComanda formVerComanda = new FormVerComanda(_mesa);
            padre.AbrirFormHijo(formVerComanda);

            Actualizar();
        }

        public void Actualizar()
        {
            // aca voy a mostrar todos los productos que tiene la mesa en su comanda hasta el momento (general)
            // tambien voy a mostrar la lista de productos seleccionados en la pantalla anterior (derecha)
            //esta pantalla de la derecha es la que luego se enviara a cocina
        }
    }
}
