﻿using IngenieriaSoftware.BEL;
using IngenieriaSoftware.BLL;
using IngenieriaSoftware.Servicios;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace IngenieriaSoftware.UI
{
    public partial class FormAsignarRolAUsuario : Form, IActualizable
    {
        private PermisoBLL _permisoBLL = new PermisoBLL();
        private UsuarioBLL _usuarioBLL = new UsuarioBLL();
        private List<PermisoDTO> _roles = new List<PermisoDTO>();
        private List<UsuarioDTO> _usuarios = new List<UsuarioDTO>();

        private DigitoVerificadorManager _digitoVerificadorManager = new DigitoVerificadorManager();
        private bool _verPermisos = false;
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
            if (btnVerPermisos.Text == "Ver Permisos")
            {
                if (dataGridViewUsuarios.SelectedRows.Count > 0 &&
                    dataGridViewUsuarios.SelectedRows[0] != null)
                {
                    btnDesasignarRol.Visible = true;

                    var usuario = (UsuarioDTO)dataGridViewUsuarios.SelectedRows[0].DataBoundItem;
                    if (usuario.id_rol > 0)
                    {
                        int rolId = usuario.id_rol;
                        var permisosUsuario = _permisoBLL.ObtenerPermisosDelRolPorId(rolId);

                        FillTreeView(permisosUsuario, treeViewPermisoRol);
                    }
                }
                _verPermisos = true;
                foreach (Control c in this.Controls)
                {
                    if (c.Name != dataGridViewUsuarios.Name && c.Name != treeViewPermisoRol.Name && c.Name != btnVerPermisos.Name && c.Name != btnDesasignarRol.Name)
                        c.Enabled = false;
                    this.BackColor = SystemColors.GrayText;
                }

                dataGridViewUsuarios.Enabled = false;
                btnVerPermisos.Text = "Dejar de Ver";

                BitacoraHelper.RegistrarActividad(SessionManager.GetInstance.Usuario.Username, "Ver Permisos", DateTime.Now, "Ver permisos de usuario", this.Name, AppDomain.CurrentDomain.BaseDirectory, "Permisos");
            }
            else
            {
                btnDesasignarRol.Visible = false;
                _verPermisos = false;
                foreach (Control c in this.Controls)
                {
                    if (c.Name != dataGridViewUsuarios.Name)
                        c.Enabled = true;
                    this.BackColor = Color.DarkSlateGray;
                }

                dataGridViewUsuarios.Enabled = true;
                btnVerPermisos.Text = "Ver Permisos";
                treeViewPermisoRol.Nodes.Clear();
            }
        }
       
        private bool CalcularDigitoVerificador(Entity entidadVerificable)
        {
            try
            {
                string nombreTabla = entidadVerificable.getNombreTabla();
                if (_digitoVerificadorManager.ActualizarDVH_Y_DVV_DeRegistro(nombreTabla, entidadVerificable.Id))
                {
                    if (_digitoVerificadorManager.VerificarDigitoVerticalYHorizontal())
                        return true;
                }

                throw new Exception(nombreTabla + " no se actualizo correctamente el DVH");
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
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

                Entity usuarioVerificable = new Usuario
                {
                    Id = usuarioId,
                };

                if (CalcularDigitoVerificador(usuarioVerificable))
                {
                    MessageBox.Show($"El digito verificador del usuario fue calculado con exito");
                }

                BitacoraHelper.RegistrarActividad(SessionManager.GetInstance.Usuario.Username, "Asignar Rol", DateTime.Now, "Asignar rol a usuario", this.Name, AppDomain.CurrentDomain.BaseDirectory, "Permisos");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                BitacoraHelper.RegistrarError(this.Name, ex, "Permisos", SessionManager.GetInstance.Usuario.ToString());
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

        private void btnDesasignarRol_Click(object sender, EventArgs e)
        {
            if (dataGridViewUsuarios.SelectedRows[0] == null ||
                treeViewPermisoRol.Nodes.Count == 0 ||
                !_verPermisos) { return; }
            try
            {
                int usuarioId = (int)dataGridViewUsuarios.SelectedRows[0].Cells[0].Value;
                int rolId = (int)dataGridViewRoles.SelectedRows[0].Cells[0].Value;
                //asignamos el rol al usuario
                MessageBox.Show(_permisoBLL.DesasignarRolAUsuario(usuarioId));

                treeViewPermisoRol.Nodes.Clear();
                BitacoraHelper.RegistrarActividad(SessionManager.GetInstance.Usuario.Username, "Desasignar Rol", DateTime.Now, "Desasignar rol a usuario", this.Name, AppDomain.CurrentDomain.BaseDirectory, "Permisos");
                //Actualizar();
                Entity usuarioVerificable = new Usuario
                {
                    Id = usuarioId,
                };

                if (CalcularDigitoVerificador(usuarioVerificable))
                {
                    MessageBox.Show($"El digito verificador del usuario fue calculado con exito");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                BitacoraHelper.RegistrarError(this.Name, ex, "Permisos", SessionManager.GetInstance.Usuario.ToString());
            }
        }
    }
}