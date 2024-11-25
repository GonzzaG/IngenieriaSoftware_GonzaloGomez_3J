using IngenieriaSoftware.BEL;
using IngenieriaSoftware.BLL;
using IngenieriaSoftware.Servicios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IngenieriaSoftware.UI
{
    public partial class FormAsignarRolAUsuario : Form, IActualizable
    {
        PermisoBLL _permisoBLL = new PermisoBLL();
        UsuarioBLL _usuarioBLL = new UsuarioBLL();
        List<PermisoDTO> _roles = new List<PermisoDTO>();
        List<UsuarioDTO> _usuarios = new List<UsuarioDTO>();

        bool _verPermisos = false;
        public NotificacionService _notificacionService => new NotificacionService();

        public FormAsignarRolAUsuario()
        {
            InitializeComponent();
            Actualizar();
        }

        public void Actualizar()
        {
            try
            {
                var usuarios = _usuarioBLL.CargarUsuarios();
                var roles = _permisoBLL.ObtenerTodosLosRoles();

                _roles = roles.ToList();
                _usuarios = usuarios.ToList();  
                if (usuarios != null)
                {
                    dataGridViewUsuarios.DataSource = null;
                    dataGridViewUsuarios.DataSource = usuarios;

                    OcultarColumnasDataGrid(dataGridViewUsuarios);
                }

                if (roles != null)
                {
                    dataGridViewRoles.DataSource = null;
                    dataGridViewRoles.DataSource = roles;


                    OcultarColumnasDataGrid(dataGridViewRoles);

                }

                foreach (DataGridViewRow row in dataGridViewUsuarios.Rows)
                {
                    row.Selected = false;
                }

                foreach (DataGridViewRow row in dataGridViewRoles.Rows)
                {
                    row.Selected = false;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("s" + ex.Message);
            }

        }
        private void OcultarColumnasDataGrid(DataGridView dgv)
        {
            foreach (DataGridViewColumn dc in dgv.Columns)
            {
                if (dc.HeaderText != "Nombre" && dc.HeaderText != "Username")
                {
                    dgv.Columns[dc.HeaderText].Visible = false;
                }
            }
        }

        public void VerificarNotificaciones()
        {
           
        }

        private void FormAsignarRolAUsuario_Load(object sender, EventArgs e)
        {  
          
        }

        private void dataGridViewUsuarios_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
           
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

        private void dataGridViewUsuarios_SelectionChanged(object sender, EventArgs e)
        {
            //if(treeViewPermisoRol.Nodes.Count > 0)
            //{
            //    treeViewPermisoRol.Nodes.Clear();
            //}
        }

        private void dataGridViewUsuarios_DataSourceChanged(object sender, EventArgs e)
        {
            
        }

        private void btnVerPermisos_Click(object sender, EventArgs e)
        {
            if(btnVerPermisos.Text == "Ver Permisos")
            {
                if (dataGridViewUsuarios.SelectedRows.Count > 0 &&
                    dataGridViewUsuarios.SelectedRows[0] != null)
                {
                    var usuario = (UsuarioDTO)dataGridViewUsuarios.SelectedRows[0].DataBoundItem;
                    if (usuario.id_rol == 0) { return; }

                    int rolId = usuario.id_rol;
                    var permisosUsuario = _permisoBLL.ObtenerPermisosDelRolPorId(rolId);

                    FillTreeView(permisosUsuario, treeViewPermisoRol);
                }
                _verPermisos = true;
                foreach(Control c in this.Controls)
                {
                    if(c.Name != dataGridViewUsuarios.Name && c.Name != treeViewPermisoRol.Name && c.Name != btnVerPermisos.Name)
                        c.Enabled = false;
                    this.BackColor = SystemColors.ControlDark;

                }

                btnVerPermisos.Text = "Dejar de Ver";
            }
            else
            {
                _verPermisos = false;
                foreach (Control c in this.Controls)
                {
                    if (c.Name != dataGridViewUsuarios.Name)
                        c.Enabled = true;
                    this.BackColor = SystemColors.Control;

                }

                btnVerPermisos.Text = "Ver Permisos";
                treeViewPermisoRol.Nodes.Clear();
            }
        }

        private void btnAsignarRol_Click(object sender, EventArgs e)
        {
            if (dataGridViewRoles.SelectedRows[0] == null ||
                dataGridViewUsuarios.SelectedRows[0] == null ||
                treeViewPermisoRol.Nodes.Count > 0) { return; }
            try
            {
                int usuarioId = (int)dataGridViewUsuarios.SelectedRows[0].Cells[0].Value;
                int rolId = (int)dataGridViewRoles.SelectedRows[0].Cells[0].Value;
                //asignamos el rol al usuario
                MessageBox.Show(_permisoBLL.AsignarRolAUsuario(usuarioId, rolId));

                //var permisosUsuario = _permisoBLL.ObtenerPermisosDelRolPorId(rolId);
                //FillTreeView(permisosUsuario, treeViewPermisoRol);
                Actualizar();

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void dataGridViewUsuarios_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (!_verPermisos) { return; }
            if (dataGridViewUsuarios.Rows.Count == 0) { return; }
            if (dataGridViewUsuarios.SelectedRows == null) { return; }

            var usuario = (UsuarioDTO)dataGridViewUsuarios.SelectedRows[0].DataBoundItem;

            if (usuario == null) { return; }
            if (usuario.id_rol == 0)
            {
                treeViewPermisoRol.Nodes.Clear();
                //MessageBox.Show("El usuario seleccionado no tiene asignado un rol");
                return;
            }

            int rolId = usuario.id_rol;
            var permisosUsuario = _permisoBLL.ObtenerPermisosDelRolPorId(rolId);

            FillTreeView(permisosUsuario, treeViewPermisoRol);
        }
    }
}
