using IngenieriaSoftware.BEL;
using IngenieriaSoftware.BEL.Negocio;
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
    public partial class FormVerComanda : Form
    {
        private readonly ComandaBLL _comandaBLL = new ComandaBLL();
        private List<ComandaProducto> _comandaProductos = new List<ComandaProducto>();

        public FormVerComanda(Mesa mesa, List<ComandaProducto> productos)
        {
            InitializeComponent();
            _comandaProductos = productos;
            Inicializar(mesa.MesaId);
        }

        private void Inicializar(int mesaId)
        {
            // En este boton debemos mostrar la lista de comandaProductos de la mesa actual. 
            var comandaGeneral= _comandaBLL.ObtenerComandaProducto(mesaId);

            dataGridViewComandaGeneral.DataSource = null;
            dataGridViewComandaGeneral.DataSource = comandaGeneral;

            //en la otra gridview tengo que listar los productos elegidos en la pantalla anterior
            dataGridViewComandaActual.DataSource = null;
            dataGridViewComandaActual.DataSource = _comandaProductos;


        }
        private void FormVerComanda_Load(object sender, EventArgs e)
        {

        }

        private void btnConfirmarComanda_Click(object sender, EventArgs e)
        {
            //vamos a enviar la comanda actual a cocina
            //vamos a insertar los productos de la comanda actual en la de comandageneral (comandaProducto)
            //se actualizara la gridview de la izquierda
            if(_comandaProductos.Count > 0)
            {
                _comandaBLL.InsertarComandaProductos(_comandaProductos);

            }

        }

        private void btnEliminarProducto_Click(object sender, EventArgs e)
        {
            //se podra eliminar un producto de la grid de comanda general solo si no se encuentre en estado 'En_Preparacion' en adelante
        }
    }
}
