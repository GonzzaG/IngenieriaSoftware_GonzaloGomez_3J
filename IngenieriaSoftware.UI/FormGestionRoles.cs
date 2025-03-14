using IngenieriaSoftware.BEL;
using IngenieriaSoftware.BLL;
using IngenieriaSoftware.Servicios;
using IngenieriaSoftware.Servicios.DTOs;
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
    public partial class FormGestionRoles : Form, IActualizable
    {
        PermisoBLL _permisoBLL = new PermisoBLL();
        List<PermisoDTO> _permisos = new List<PermisoDTO> ();
        PermisoDTO _permisoSeleccionado = new PermisoDTO ();
        public FormGestionRoles()
        {
            InitializeComponent();
            Actualizar();
        }

        public NotificacionService _notificacionService => new NotificacionService();

        public void Actualizar()
        {
            try
            {
                var permisos = _permisoBLL.ObtenerTodosLosPermisos();
                var roles = _permisoBLL.ObtenerTodosLosRoles();
                
                _permisos = roles.ToList(); 
               // _permisos.AddRange(roles);
                _permisos.AddRange(permisos);

                if (permisos != null)
                {
                    dataGridViewPermisos.DataSource = null;
                    dataGridViewPermisos.DataSource = permisos;

                    
                    OcultarColumnasDataGrid(dataGridViewPermisos);
                }

                if (roles != null)
                {
                    dataGridViewRoles.DataSource = null;
                    dataGridViewRoles.DataSource = roles;
                    

                    OcultarColumnasDataGrid(dataGridViewRoles);
                    
                }

                foreach (DataGridViewRow row in dataGridViewPermisos.Rows)
                {
                    row.Selected = false;
                }

                foreach (DataGridViewRow row in dataGridViewRoles.Rows)
                {
                    row.Selected = false;
                }

                ListarRoles();

            }
            catch
            {
                MessageBox.Show("s");
            }
        }

        private void OcultarColumnasDataGrid(DataGridView dgv)
        {
            foreach(DataGridViewColumn dc in dgv.Columns)
            {
                if(dc.HeaderText != "Nombre")
                {
                    dgv.Columns[dc.HeaderText].Visible = false;
                }
            }
        }

        public void VerificarNotificaciones()
        {
        }

        private void btnCrearRol_Click(object sender, EventArgs e)
        {
            try
            {
                if(txtNombreRol.Text.Length > 0)
                {
                    string nombreRol = txtNombreRol.Text;
                    _permisoBLL.CrearRol(nombreRol);
                    txtNombreRol.Text = string.Empty;
                    Actualizar();
                }


            }
            catch(Exception ex)
            {

            }
        }

        private void btnAsignarPermiso_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridViewRoles.SelectedRows.Count != 1)
                {
                    //MessageBox.Show("Por favor, seleccione un permiso o rol para asignar");
                    //return;
                }
                if (dataGridViewPermisos.SelectedRows.Count != 1)
                    MessageBox.Show("Debe seleccionar al menos un rol para asignarle un rol o permiso");
                else
                {
                    int permisoPadreId = _permisos.Find(p => p.Nombre == comboBoxRoles.Text).Id;
                    if(btnAsignarPermiso.Text == "Asignar Rol")
                    {
                        int rolHijo = _permisos.Find(r => r.Id == (int)dataGridViewRoles.SelectedRows[0].Cells[0].Value).Id;
                        _permisoBLL.AsignarRolARol(permisoPadreId, rolHijo);
                    }
                    else
                    {
                        int permisoHijoId = _permisos.Find(p => p.Id == (int)dataGridViewPermisos.SelectedRows[0].Cells[0].Value).Id;
                        _permisoBLL.AsignarPermisoARol(permisoPadreId, permisoHijoId);
                    }
                }

                Actualizar();

                if (comboBoxRoles.Items.Count == 0) { return; }
                if (comboBoxRoles.Text == string.Empty) { return; }
                string nombreRol = comboBoxRoles.Text.ToString();
                var permisosRol = _permisoBLL.ObtenerPermisosDelRol(nombreRol);

                FillTreeView(permisosRol, treeViewPermisoRol);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FormGestionRoles_Load(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridViewPermisos.Rows)
            {
                row.Selected = false;
            }

            foreach (DataGridViewRow row in dataGridViewRoles.Rows)
            {
                row.Selected = false;
            }

            ListarRoles(); 
        }

        private void ListarRoles()
        {
            comboBoxRoles.Items.Clear();
            var permisos = _permisos
                .Where(p => p.EsRol == true)
                .ToList();
            foreach (PermisoDTO permiso in permisos)
            {
                comboBoxRoles.Items.Add(permiso.Nombre);
            }
            
        }
         
        private void comboBoxRoles_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (comboBoxRoles.Items.Count == 0) { return; }
                if (comboBoxRoles.SelectedItem == null) { return; }
                string nombreRol = comboBoxRoles.Text.ToString();
                var permisosRol = _permisoBLL.ObtenerPermisosDelRol(nombreRol);

                FillTreeView(permisosRol, treeViewPermisoRol);
            }
            catch
            {
                MessageBox.Show("Error al buscar permisos del rol seleccionado");
            }
        }
        private void FillTreeView(List<PermisoDTO> permisosJerarquizados, TreeView treeViewPermisos)
        {
            try
            {
                treeViewPermisos.Nodes.Clear();
                foreach (PermisoDTO permiso in permisosJerarquizados)
                {
                    TreeNode nodoRaiz = CrearNodoRecursivo(permiso);
                    treeViewPermisos.Nodes.Add(nodoRaiz);
                }
                treeViewPermisos.ExpandAll();
            }
            catch
            {
                MessageBox.Show("Error al cargar jerarquia de permisos");
            }
        }

        private TreeNode CrearNodoRecursivo(PermisoDTO permiso)
        {
            TreeNode nodo = new TreeNode(permiso.Nombre)
            {
                Tag = permiso.Id
            };
            foreach (PermisoDTO hijo in permiso.permisosHijos)
            {
                TreeNode nodoHijo = CrearNodoRecursivo(hijo);
                nodo.Nodes.Add(nodoHijo);
            }

            return nodo;
        }

        private void comboBoxRoles_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void btnEliminarRol_Click(object sender, EventArgs e)
        {
            if(comboBoxRoles.SelectedItem == null ||
                comboBoxRoles.Text == string.Empty) 
             return;
            try
            {
                int rolId = _permisos.Find(p => p.Nombre == comboBoxRoles.Text).Id;
                _permisoBLL.EliminarRol(rolId);
                Actualizar();
                MessageBox.Show("Rol eliminado correctamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                comboBoxRoles.SelectedItem = null;
                comboBoxRoles.Text = string.Empty;  
                treeViewPermisoRol.Nodes.Clear();   
            }
        }

        private void btnDesasignar_Click(object sender, EventArgs e)
        {
            if(comboBoxRoles.Text == string.Empty||
               treeViewPermisoRol.SelectedNode == null)
            {
                MessageBox.Show("Seleccione un rol o permiso de la jerarquia para desasignarlo.");
                return;
            }
            try
            {
                string nombrePermisoPadre = comboBoxRoles.Text;
                var permisoPadre = _permisos.Find(p => p.Nombre == nombrePermisoPadre);

                string nombrePermisoNodo = treeViewPermisoRol.SelectedNode.Text;
                var permisoHijo = _permisos.Find(p => p.Nombre == nombrePermisoNodo);
                if (permisoHijo.EsRol)
                {
                    string mensaje = _permisoBLL.DesasignarRolARol(permisoPadre.Id, permisoHijo.Id);
                    Actualizar();


                    if (comboBoxRoles.Items.Count == 0) { return; }
                    if (comboBoxRoles.Text == string.Empty) { return; }
                    string nombreRol = comboBoxRoles.Text.ToString();
                    var permisosRol = _permisoBLL.ObtenerPermisosDelRol(nombreRol);

                    FillTreeView(permisosRol, treeViewPermisoRol);
                }
                else
                {

                    _permisoBLL.DesasignarPermisoDeRol(permisoPadre.Id, permisoHijo.Id);
                    Actualizar();

                    if (comboBoxRoles.Items.Count == 0) { return; }
                    if (comboBoxRoles.Text == string.Empty) { return; }
                    string nombreRol = comboBoxRoles.Text.ToString();
                    var permisosRol = _permisoBLL.ObtenerPermisosDelRol(nombreRol);

                    FillTreeView(permisosRol, treeViewPermisoRol);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridViewRoles_RowEnter_1(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewRoles.SelectedRows.Count > 0)
            {
                string nombre = dataGridViewRoles.SelectedRows[0].Cells["Nombre"].Value.ToString();
                _permisoSeleccionado = _permisos.First(rol => rol.Nombre == nombre);
                txtPermisoSeleccionado.Text = nombre;
                btnAsignarPermiso.Text = "Asignar Rol";
                foreach (DataGridViewRow row in dataGridViewPermisos.Rows)
                {
                    row.Selected = false;
                }
            }

        }

        private void dataGridViewPermisos_RowEnter_1(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewPermisos.SelectedRows.Count > 0)
            {
                string nombre = dataGridViewPermisos.SelectedRows[0].Cells["Nombre"].Value.ToString();
                _permisoSeleccionado = _permisos.First(rol => rol.Nombre == nombre);
                txtPermisoSeleccionado.Text = nombre;
                btnAsignarPermiso.Text = "Asignar Permiso";
                foreach (DataGridViewRow row in dataGridViewRoles.Rows)
                {
                    row.Selected = false;
                }

            }
        }
    }
}
