﻿using IngenieriaSoftware.BEL;
using IngenieriaSoftware.BEL.Negocio;
using IngenieriaSoftware.BLL;
using IngenieriaSoftware.BLL.Mesas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IngenieriaSoftware.UI
{
    public partial class FormRealizarComanda : Form, IActualizable
    {
        private readonly ProductoBLL _productoBLL = new ProductoBLL();
        private readonly ComandaBLL _comandaBLL = new ComandaBLL();
        private Mesa _mesa;
        private int _comandaId;

        public FormRealizarComanda(Mesa mesa, int comandaId)
        {
            InitializeComponent();
            _mesa = mesa;
            _comandaId = comandaId;


            Inicializar();
        }

        private async Task CargarDatosAsync()
        {
            try
            {
                loadingIndicator.Visible = true;

                var datos = await Task.Run(() => CargarDatosDesdeBaseDeDatos());

                myDataGridView.DataSource = datos;
            }
            finally
            {
                // Ocultar el indicador de carga una vez que los datos se han cargado
                loadingIndicator.Visible = false;
            }
        }
        private void Inicializar()
        {
            try
            {
                //obtenemos todos los productos
                var productos = _productoBLL.ObtenerTodosLosProductos();
                if (productos != null)
                {
                    dataGridViewProductos.DataSource = null;
                    dataGridViewProductos.DataSource = productos;
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
            int indice = dataGridViewProductos.SelectedRows[0].Index;
            Producto producto = ((List<Producto>)dataGridViewProductos.DataSource)[indice];

            _comandaBLL.NuevoComandaProducto(producto, _comandaId, (int)numericUpDownCantidad.Value);
        }

        private void NuevoProducto()
        {
           

          
        }

        private void btnVerComanda_Click(object sender, EventArgs e)
        {
            // Mostramos el formulario ver comanda con la mesa actual como parametro
            
            var padre = this.MdiParent as FormMDI;

            FormVerComanda formVerComanda = new FormVerComanda(_mesa, _comandaBLL._comandaProductos);
            formVerComanda.StartPosition = FormStartPosition.CenterScreen;
            formVerComanda.ShowDialog();
          // padre.AbrirFormHijo(formVerComanda);

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
