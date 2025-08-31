using IngenieriaSoftware.BEL.Gestion_Compras_Insumos;
using IngenieriaSoftware.BEL.Proveedor;
using IngenieriaSoftware.BLL;
using IngenieriaSoftware.BLL.Proveedores;
using IngenieriaSoftware.Servicios.Tools;
using IngenieriaSoftware.UI.Interfaces;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Linq;

namespace IngenieriaSoftware.UI.Gestion_Compras_Insumos
{
    public partial class FormGestionProveedores : Form, IActualizable
    {

        ProveedorBussiness _proveedorBussiness = new ProveedorBussiness();

        public NotificacionService _notificacionService => throw new NotImplementedException();


        public FormGestionProveedores()
        {
            InitializeComponent();

            InicializarFormulario();
            
        }

        private void InicializarFormulario()
        {
            LimpiarCampos();

            inputNombreFiltroNombre.InicializarFiltro(ListarProductos);
            Actualizar();
        }
        private void ListarProductos()
        {
            try
            {
                if (inputNombreFiltroNombre.Texto == string.Empty)
                    dgvFiltrosProveedores.CargarDatos(new ProveedorBussiness().GetAll());
                else
                    dgvFiltrosProveedores.CargarDatos(new ProveedorBussiness().GetByRazonSocial(inputNombreFiltroNombre.Texto));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                ex.RegistrarError("Gestion de Productos");
            }
        }

        private void LimpiarCampos()
        {

            foreach (TextBox tb in groupBoxProveedor.Controls.OfType<TextBox>())
            {
                tb.Text = string.Empty;
            }

            Actualizar();
        }

        private void btnAgregarProveedor_Click(object sender, EventArgs e)
        {
            try
            {
                VerificarCamposGuardar();

                if (btnAgregarProveedor.Text.Equals("Guardar"))
                    Guardar();
                else
                    Modificar();

                Actualizar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Guardar()
        {
            _proveedorBussiness.SaveOrUpdate(new Proveedor
            {
                Documento = txtDocumento.Text,
                RazonSocial = txtRazonSocial.Text,
                Correo = txtCorreo.Text,
                Telefono = txtTelefono.Text,
                Estado = checkBoxEsActivo.Checked
            });
        }

        private void Modificar()
        {
            var proveedor = (Proveedor)dgvFiltrosProveedores.ElementoSeleccionado;
            if (proveedor is null) throw new Exception("No se ha seleccionado ningun proveedor para modificar");
            _proveedorBussiness.SaveOrUpdate(new Proveedor
            {
                IdProveedor = proveedor.IdProveedor,
                Documento = txtDocumento.Text,
                RazonSocial = txtRazonSocial.Text,
                Correo = txtCorreo.Text,
                Telefono = txtTelefono.Text,
                Estado = checkBoxEsActivo.Checked
            });
            LimpiarCampos();
            PrepararAgregar();
        }

        private void VerificarCamposGuardar()
        {
            if (txtCorreo.Text == string.Empty
               || txtDocumento.Text == string.Empty
               || txtRazonSocial.Text is null
               || int.Parse(txtTelefono.Text) < 1)

                throw new Exception("Verificar los datos ingresados");
        }

        public void Actualizar()
        {
            ListarProductos();
        }

        private void btnEliminarProveedor_Click(object sender, EventArgs e)
        {
            try
            {
                if(btnEliminarProveedor.Text.Equals("Eliminar"))
                    EliminarProveedor();
                else
                    PrepararAgregar();
                    
                Actualizar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void EliminarProveedor()
        {
            if (dgvFiltrosProveedores.CantidadElementos.Equals(0))
                throw new Exception("Debe seleccionar un proveedor");

            var proveedorId = ((Proveedor)dgvFiltrosProveedores.ElementoSeleccionado).IdProveedor;

            new ProveedorBussiness().DeleteById(proveedorId);
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {

                if (dgvFiltrosProveedores.CantidadElementos.Equals(0)) throw new Exception("Seleccione un proveedor para modificarlo");

                CargarProveedorEnTextos((Proveedor)dgvFiltrosProveedores.ElementoSeleccionado);

                PrepararModificacion();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void PrepararModificacion()
        {
            btnAgregarProveedor.Text = "Guardar Cambios";
            btnModificar.Enabled = false;
            btnEliminarProveedor.Text = "Cancelar";
            btnModificar.BackColor = Color.Gray;
            dgvFiltrosProveedores.Deshabilitar();
        }

        private void PrepararAgregar()
        {
            btnAgregarProveedor.Text = "Registrar";
            btnModificar.Enabled = true;
            btnEliminarProveedor.Text = "Eliminar";
            dgvFiltrosProveedores.Habilitar();
            btnModificar.BackColor = Color.Orange;
            LimpiarCampos();
        }   

        private void CargarProveedorEnTextos(Proveedor proveedor)
        {
            txtDocumento.Text = proveedor.Documento;
            txtCorreo.Text = proveedor.Correo;
            txtRazonSocial.Text = proveedor.RazonSocial;
            txtTelefono.Text = proveedor.Telefono;
            checkBoxEsActivo.Checked = proveedor.Estado;
        }

        private void FormGestionProveedores_Load(object sender, EventArgs e)
        {

        }
    }
}
