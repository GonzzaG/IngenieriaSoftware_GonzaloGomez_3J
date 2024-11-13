using IngenieriaSoftware.BLL;
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
    public partial class FormGestionarComandas : Form, IActualizable
    {
        private readonly ComandaBLL _comadaBLL = new ComandaBLL();
        public FormGestionarComandas()
        {
            InitializeComponent();
            Actualizar();
        }

        public void Actualizar()
        {
            try
            {
                var comanda = _comadaBLL.ObtenerComandasPendientes();
                dataGridViewComandasPendientes.DataSource = null;
                dataGridViewComandasPendientes.DataSource = comanda;
            }
            catch(Exception ex)
            {

            }
        }

        private void MostrarComandaProductosPendientes()
        {
           // int mesaId =
            //vamos a obtener la comanda y los productos asociados a esa comanda qeu NO se encuentren listas o entregadas
           // var comandaProductos = _comadaBLL.ObtenerComandaProductosPendientes();

            //dataGridViewComandasPendientes.DataSource = null;
            //dataGridViewComandasPendientes.DataSource = comandaProductos;
        }

        private void dataGridViewComandasPendientes_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if(dataGridViewComandasPendientes.SelectedRows.Count == 0) { return; } 
                //mostramos los productos que no esten listos ni entregados mediante la mesa_id y comanda_id de la comanda seleccionada
                int comandaId = (int)dataGridViewComandasPendientes.SelectedRows[0].Cells[0].Value;
                int mesaId = (int)dataGridViewComandasPendientes.SelectedRows[0].Cells[1].Value;
                var productosComanda = _comadaBLL.ObtenerComandaProductosPendientes(mesaId, comandaId);

                dataGridViewComandaProductos.DataSource = null;
                dataGridViewComandaProductos.DataSource = productosComanda;

            }
            catch(Exception ex)
            {

            }
        }

        private void btnComandaEnPreparacion_Click(object sender, EventArgs e)
        {
            //cuando aprete este botonn marcare todos los productos en la lista de la derecha en preparacion en la base de datos
        }
    }
}
