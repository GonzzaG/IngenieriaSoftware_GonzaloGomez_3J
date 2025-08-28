using IngenieriaSoftware.BEL.Proveedor;
using IngenieriaSoftware.BLL;
using IngenieriaSoftware.BLL.Proveedores;
using IngenieriaSoftware.Servicios.Tools;
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
    public partial class FormBusquedaProveedores : Form, IVerificoNotificaciones
    {
        internal event Action<Proveedor> esProveedorSeleccionado;
        public FormBusquedaProveedores()
        {
            InitializeComponent();
            Inicializar();

        }

        public NotificacionService _notificacionService => new NotificacionService();

        private void Inicializar()
        {
            Actualizar();   
            dgvProveedores.PersonalizarEstiloPredeterminado();
        }
        public void Actualizar()
        {
            ObtenerProveedores();  
        }
        
        private void ObtenerProveedores()
        {
            ListarProveedores(new ProveedorBussiness().GetAll());
        }

        private void ListarProveedores(IEnumerable<Proveedor> proveedores)
        {
            if (proveedores is null || !proveedores.Any())
                throw new Exception("No se encontraron proveedores.");

            dgvProveedores.ActualizarDataSource(proveedores);
        }

        public void VerificarNotificaciones()
        {
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            try
            {
                ValidarSeleccionProveedorDataGrid();
                var proveedorSeleccionado = (Proveedor)dgvProveedores.SelectedRows[0].DataBoundItem;
                ValidarProveedor(proveedorSeleccionado);
                    
                esProveedorSeleccionado.Invoke(proveedorSeleccionado);

                this.Close();   

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);   
            }
        }

        private void ValidarSeleccionProveedorDataGrid()
        {
            if (dgvProveedores.SelectedRows.Count.Equals(0))
                throw new Exception("Debe seleccionar un proveedor.");
            
        }

        private void ValidarProveedor(Proveedor proveedor)
        {
            proveedor.ValidarObjetoNoNulo();
        }
    }
}
