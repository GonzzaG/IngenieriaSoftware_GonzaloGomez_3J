using IngenieriaSoftware.BEL.Proveedor;
using IngenieriaSoftware.BLL;
using IngenieriaSoftware.BLL.Proveedores;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IngenieriaSoftware.UI.Gestion_Compras_Insumos
{
    public partial class FormGestionProveedores : Form, IActualizable
    {

        ProveedorBussiness _proveedorBussiness = new ProveedorBussiness();

        public NotificacionService _notificacionService => throw new NotImplementedException();

        private bool _formCargado = false;

        List<Proveedor> _Proveedores = new List<Proveedor>();

        public FormGestionProveedores()
        {
            InitializeComponent();
            Actualizar();
        }

        private void InicializarFormulario()
        {
            LimpiarCampos();
            _Proveedores = _proveedorBussiness.GetAll();
            MostrarProveedoresEnDataGrid();   
        }


        private void MostrarProveedoresEnDataGrid()
        {
            dgvProveedores.DataSource = null;
            dgvProveedores.DataSource = _Proveedores;
        }

        private void LimpiarCampos()
        {

            foreach(TextBox tb in this.Controls.OfType<TextBox>())
            {
                tb.Text = string.Empty;
            }
        }

        private void btnAgregarProveedor_Click(object sender, EventArgs e)
        {
            try
            {
                string documento = txtDocumento.Text;
                string razonSocial = txtRazonSocial.Text;
                string correo = txtCorreo.Text;
                string telefono = txtTelefono.Text;
                bool estado = checkBoxEsActivo.Checked;

                var nuevoProveedor = Proveedor.CrearNuevoProveedor(documento, razonSocial, correo, telefono, estado);

                _proveedorBussiness.Save(nuevoProveedor);

                Actualizar();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void PersonalizarEstiloDataGridView()
        {
            // Paleta de colores que combinan con DarkSlateGray
            Color colorBase = Color.FromArgb(0, 64, 64);        // fondo principal
            Color colorAlterno = Color.FromArgb(0, 80, 80);     // fila alterna
            Color colorEncabezado = Color.FromArgb(0, 90, 90);  // encabezado
            Color colorTexto = Color.WhiteSmoke;

            // General
            dgvProveedores.BackgroundColor = colorBase;
            dgvProveedores.BorderStyle = BorderStyle.None;
            dgvProveedores.EnableHeadersVisualStyles = false;
            dgvProveedores.GridColor = Color.FromArgb(20, 100, 100); // líneas suaves
            dgvProveedores.MultiSelect = false;
            dgvProveedores.EditMode = DataGridViewEditMode.EditProgrammatically;
            dgvProveedores.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            // Encabezado de columnas
            dgvProveedores.ColumnHeadersDefaultCellStyle.BackColor = colorEncabezado;
            dgvProveedores.ColumnHeadersDefaultCellStyle.ForeColor = colorTexto;
            dgvProveedores.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            dgvProveedores.ColumnHeadersHeight = 50;

            // Celdas normales
            dgvProveedores.DefaultCellStyle.BackColor = colorBase;
            dgvProveedores.DefaultCellStyle.ForeColor = colorTexto;
            dgvProveedores.DefaultCellStyle.SelectionBackColor = Color.FromArgb(0, 120, 120);
            dgvProveedores.DefaultCellStyle.SelectionForeColor = Color.White;
            dgvProveedores.DefaultCellStyle.Font = new Font("Segoe UI", 11F);

            // Celdas alternas
            dgvProveedores.AlternatingRowsDefaultCellStyle.BackColor = colorAlterno;
            dgvProveedores.AlternatingRowsDefaultCellStyle.ForeColor = colorTexto;
            dgvProveedores.AlternatingRowsDefaultCellStyle.SelectionBackColor = Color.FromArgb(0, 120, 120);
            dgvProveedores.AlternatingRowsDefaultCellStyle.SelectionForeColor = Color.White;
            dgvProveedores.AlternatingRowsDefaultCellStyle.Font = new Font("Segoe UI", 11F);

            // Quitar encabezado de filas
            dgvProveedores.RowHeadersVisible = false;

            // AutoSize
            dgvProveedores.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProveedores.RowTemplate.Height = 45; // Ajusta altura para que no se corte el texto
            dgvProveedores.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvProveedores.Width += 5;

        }



        private void AgregarNuevoProveedor(Proveedor proveedor)
        {

            _proveedorBussiness.Save(proveedor);
        }

        public void Actualizar()
        {
            InicializarFormulario();
        }

        public void VerificarNotificaciones()
        {
            throw new NotImplementedException();
        }

        private void FormGestionProveedores_Load(object sender, EventArgs e)
        {
            _formCargado = true;
            PersonalizarEstiloDataGridView();

        }

        private void btnEliminarProveedor_Click(object sender, EventArgs e)
        {
            try
            {
                if ((dgvProveedores.SelectedRows.Count).Equals(0))
                    new Exception("Seleccione un proveedor");

                int id = (int)dgvProveedores.SelectedRows[0].Cells[nameof(Proveedor.IdProveedor)].Value;
                _proveedorBussiness.DeleteById(id);

                MessageBox.Show("Proveedor eliminado con exito");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvProveedores_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (!_formCargado) return;

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvProveedores.SelectedRows.Count.Equals(0)) throw new Exception("Seleccione un proveedor para modificarlo");

                CargarProveedorEnTextos(_Proveedores.Find(p => p.IdProveedor == (int)dgvProveedores.SelectedRows[0].Cells[nameof(Proveedor.IdProveedor)].Value));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
        }

        private void CargarProveedorEnTextos(Proveedor proveedor)
        {
            txtDocumento.Text = proveedor.Documento;
            txtCorreo.Text = proveedor.Correo;
            txtRazonSocial.Text = proveedor.RazonSocial;
            txtTelefono.Text = proveedor.Telefono;
            checkBoxEsActivo.Checked = proveedor.Estado;
        }
    }
}
