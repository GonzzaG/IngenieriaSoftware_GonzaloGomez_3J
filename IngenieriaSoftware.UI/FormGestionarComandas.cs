using IngenieriaSoftware.BEL.Negocio;
using IngenieriaSoftware.BLL;
using IngenieriaSoftware.Servicios;
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

        public NotificacionService _notificacionService => new NotificacionService();

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
                int comandaId;
                int mesaId;
                List<ComandaProducto> productosComanda;

                if(dataGridViewComandasPendientes.RowCount > 0 )
                {       
                    comandaId = (int)dataGridViewComandasPendientes.Rows[0].Cells[0].Value;
                    mesaId = (int)dataGridViewComandasPendientes.Rows[0].Cells[1].Value;
                    productosComanda = _comadaBLL.ObtenerComandaProductosPendientes(mesaId, comandaId);

                    dataGridViewComandaProductos.DataSource = null;
                    dataGridViewComandaProductos.DataSource = productosComanda;           
                }
                else
                {
                    dataGridViewComandaProductos.DataSource = null;
                }

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

      
        

        private void btnComandaEnPreparacion_Click(object sender, EventArgs e)
        {
            try
            {
                //cuando aprete este botonn marcare todos los productos en la lista de la derecha en preparacion en la base de datos
                var comandaProductos = (List<ComandaProducto>)dataGridViewComandaProductos.DataSource;
                _comadaBLL.MarcarProductosEnPreparacion(comandaProductos);

                Actualizar();
            }
            catch(Exception ex)
            {
                MessageBox.Show("La comanda tiene que estar en estado 'pendiente' para marcarlo como listos");
            }
        }

        private void btnComandaLista_Click(object sender, EventArgs e)
        {
            try
            {
                var comandaProductos = (List<ComandaProducto>)dataGridViewComandaProductos.DataSource;
                var comanda = dataGridViewComandasPendientes.SelectedRows[0].DataBoundItem as Comanda;
                _comadaBLL.MarcarProductoslistos(comandaProductos);
                _comadaBLL.NotificarComandaLista(comanda);


                Actualizar();
            }
            catch(Exception ex)
            {
                MessageBox.Show("La comanda tiene que estar 'en preparacion' para marcarlo como listos");
            }
        }

        public void VerificarNotificaciones()
        {
            if (PermisosData.PermisosString.Contains("Mesero"))
            {
                var notificaciones = _notificacionService.ObtenerNotificaciones();
                if (notificaciones.Count > 0)
                {
                    HelperForms.MostrarNotificacion(notificaciones, this);
                }
            }
        }

        private void FormGestionarComandas_Load(object sender, EventArgs e)
        {
            VerificarNotificaciones();
        }

        private void dataGridViewComandasPendientes_RowEnter_1(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dataGridViewComandasPendientes.SelectedRows.Count == 0)
                {
                    dataGridViewComandaProductos.ClearSelection();

                    return;
                }
                //mostramos los productos que no esten listos ni entregados mediante la mesa_id y comanda_id de la comanda seleccionada
                int comandaId = (int)dataGridViewComandasPendientes.SelectedRows[0].Cells[0].Value;
                int mesaId = (int)dataGridViewComandasPendientes.SelectedRows[0].Cells[1].Value;
                var productosComanda = _comadaBLL.ObtenerComandaProductosPendientes(mesaId, comandaId);

                dataGridViewComandaProductos.DataSource = null;
                dataGridViewComandaProductos.DataSource = productosComanda;

            }
            catch (Exception ex)
            {

            }
        }
    }
}
