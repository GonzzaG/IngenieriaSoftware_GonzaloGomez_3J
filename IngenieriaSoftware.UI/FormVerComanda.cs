using IngenieriaSoftware.BEL;
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
        public FormVerComanda(Mesa mesa)
        {
            InitializeComponent();
            Inicializar();
        }

        private void Inicializar()
        {
            // En este boton debemos mostrar la lista de comandaProductos de la mesa actual. 
        }
        private void FormVerComanda_Load(object sender, EventArgs e)
        {

        }

        private void btnConfirmarComanda_Click(object sender, EventArgs e)
        {
            //vamos a enviar la comanda actual a cocina
            //vamos a insertar los productos de la comanda actual en la de comandageneral (comandaProducto)
            //se actualizara la gridview de la izquierda

        }

        private void btnEliminarProducto_Click(object sender, EventArgs e)
        {
            //se podra eliminar un producto de la grid de comanda general solo si no se encuentre en estado 'En_Preparacion' en adelante
        }
    }
}
