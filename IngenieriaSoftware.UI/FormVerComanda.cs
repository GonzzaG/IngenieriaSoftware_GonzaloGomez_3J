﻿using IngenieriaSoftware.BEL.Constantes;
using IngenieriaSoftware.BEL.Negocio;
using IngenieriaSoftware.BLL;
using IngenieriaSoftware.Servicios;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace IngenieriaSoftware.UI
{
    public partial class FormVerComanda : Form
    {
        private readonly ComandaBLL _comandaBLL;
        private readonly int _comandaId;
        // private List<ComandaProducto> _comandaProductos = new List<ComandaProducto>();

        public FormVerComanda(ComandaBLL comandaBLL, int comandaId)
        {
            InitializeComponent();
            // _comandaProductos = productos;
            _comandaBLL = comandaBLL;
            _comandaId = comandaId;
            Inicializar();
        }

        private void Inicializar()
        {
            // En este boton debemos mostrar la lista de comandaProductos de la mesa actual.
            var comandaGeneral = _comandaBLL.ObtenerComandaProductoPorComandaId(_comandaId);

            dataGridViewComandaGeneral.DataSource = null;
            dataGridViewComandaGeneral.DataSource = comandaGeneral;

            //en la otra gridview tengo que listar los productos elegidos en la pantalla anterior
            dataGridViewComandaActual.DataSource = null;
            dataGridViewComandaActual.DataSource = _comandaBLL._comandaProductos;

            if (comandaGeneral != null)
            {
                OcultarColumnasComandaGeneral();
            }

            if (_comandaBLL._comandaProductos != null)
            {
                OcultarColumnasComandaActual();
            }
        }

        private void OcultarColumnasComandaGeneral()
        {
            dataGridViewComandaGeneral.Columns["ComandaId"].Visible = false;
            dataGridViewComandaGeneral.Columns["ProductoId"].Visible = false;
            dataGridViewComandaGeneral.Columns["Producto"].Visible = false;
            dataGridViewComandaGeneral.Columns["Disponible"].Visible = false;
            dataGridViewComandaGeneral.Columns["TiempoPreparacion"].Visible = false;
            dataGridViewComandaGeneral.Columns["Precio"].Visible = false;
        }

        private void OcultarColumnasComandaActual()
        {
            dataGridViewComandaActual.Columns["ComandaId"].Visible = false;
            dataGridViewComandaActual.Columns["ProductoId"].Visible = false;
            dataGridViewComandaActual.Columns["Producto"].Visible = false;
            dataGridViewComandaActual.Columns["Disponible"].Visible = false;
            dataGridViewComandaActual.Columns["TiempoPreparacion"].Visible = false;
            dataGridViewComandaActual.Columns["Precio"].Visible = false;
        }

        private void FormVerComanda_Load(object sender, EventArgs e)
        {
        }

        private void btnConfirmarComanda_Click(object sender, EventArgs e)
        {
            try
            {
                //vamos a enviar la comanda actual a cocina
                //vamos a insertar los productos de la comanda actual en la de comandageneral (comandaProducto)
                //se actualizara la gridview de la izquierda
                if (_comandaBLL._comandaProductos == null) { MessageBox.Show("No tiene productos que enviar a cocina"); }
                if (_comandaBLL._comandaProductos.Count > 0)
                {
                    //   _comandaBLL.InsertarComandaProductos(_comandaProductos);
                    _comandaBLL.InsertarComandaProductos(_comandaBLL._comandaProductos);
                    _comandaBLL._comandaProductos = null;
                    MessageBox.Show("La comanda fue enviada a la cocina con exito.");
                }

                BitacoraHelper.RegistrarActividad(SessionManager.GetInstance.Usuario.ToString(), "Enviar Comanda a Cocina", DateTime.Now, "Se envio la comanda a cocina", this.Name, AppDomain.CurrentDomain.BaseDirectory, "Mesas");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al enviar la comanda a cocina");
                BitacoraHelper.RegistrarError(this.Name, ex, "Mesas", SessionManager.GetInstance.Usuario.Username);
            }
        }

        private void btnEliminarProducto_Click(object sender, EventArgs e)
        {
            //se podra eliminar un producto de la grid de comanda general solo si no se encuentre en estado 'En_Preparacion' en adelante
            try
            {
                int comandaId = (int)dataGridViewComandaActual.SelectedRows[0].Cells[0].Value;
                var ComandaProductos = (List<ComandaProducto>)dataGridViewComandaActual.DataSource;
                ComandaProducto ComandaProducto = ComandaProductos
                    .Where(m => m.ComandaId == comandaId)
                    .First(m => m.EstadoProducto != EstadoComandaProductos.Estado.En_Preparacion);

                if (ComandaProducto == null) { return; }

                _comandaBLL.EliminarComandaProducto(ComandaProducto);

                dataGridViewComandaActual.DataSource = null;
                dataGridViewComandaActual.DataSource = _comandaBLL._comandaProductos;
                if (_comandaBLL._comandaProductos != null)
                {
                    OcultarColumnasComandaActual();
                }

                BitacoraHelper.RegistrarActividad(SessionManager.GetInstance.Usuario.ToString(), "Eliminar Comanda Producto", DateTime.Now, "Se elimino un producto de la comanda", this.Name, AppDomain.CurrentDomain.BaseDirectory, "Mesas");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Seleccione un producto de la comanda actual para eliminarlo");

                BitacoraHelper.RegistrarError(this.Name, ex, "Mesas", SessionManager.GetInstance.Usuario.Username);
            }
        }
    }
}