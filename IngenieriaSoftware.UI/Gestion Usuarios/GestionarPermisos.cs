using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IngenieriaSoftware.BEL;
using IngenieriaSoftware.BLL;
using IngenieriaSoftware.Servicios;
namespace IngenieriaSoftware.UI
{
    public partial class GestionarPermisos : Form
    {
        private readonly UsuarioBLL _usuarioBLL;
        public GestionarPermisos()
        {
            InitializeComponent();
            _usuarioBLL = new UsuarioBLL();
            
        }

        private void GestionarPermisos_Load(object sender, EventArgs e)
        {
            ActualizarFormulario(); 
           
        }

        private void CargarUsuariosPermisos()
        {
            List<UsuarioDTO> usuarios = _usuarioBLL.CargarUsuariosPermisos();
            listarUsuarios(usuarios);
        }

        public void listarUsuarios(List<UsuarioDTO> pUsuarios)
        {
            comboBoxUsuario.Items.Clear();
            foreach(UsuarioDTO usuario in pUsuarios)
            {
                comboBoxUsuario.Items.Add(usuario.Username);
            }
        }

        public void ActualizarFormulario()
        {
            CargarUsuariosPermisos();
            ListarTreeView();
        }


        private void ListarTreeView()
        { 
            var permisos = _usuarioBLL.ObtenerPermisosGlobales();
            FillTreeView(permisos, treeViewPermisos);

        }
        private void FillTreeView(List<PermisoDTO> permisosJerarquizados, TreeView treeViewPermisos)
        {
            // Limpiar el TreeView antes de llenarlo
            treeViewPermisos.Nodes.Clear();

            // Agregar cada permiso raíz y construir sus hijos recursivamente
            foreach (PermisoDTO permiso in permisosJerarquizados)
            {
                // Crear y añadir el nodo raíz
                TreeNode nodoRaiz = CrearNodoRecursivo(permiso);
                treeViewPermisos.Nodes.Add(nodoRaiz);
            }

            // Expandir todos los nodos para visualizarlos
            treeViewPermisos.ExpandAll();
        }

        // Método recursivo para construir nodos del TreeView con sus hijos
        private TreeNode CrearNodoRecursivo(PermisoDTO permiso)
        {
            // Crear un nodo para el permiso actual
            TreeNode nodo = new TreeNode(permiso.Nombre)
            {
                Tag = permiso.Id // Asignar el ID del permiso al Tag del nodo
            };

            // Recorrer los permisos hijos del permiso actual y añadirlos como nodos hijos
            foreach (PermisoDTO hijo in permiso.permisosHijos)
            {
                TreeNode nodoHijo = CrearNodoRecursivo(hijo);
                nodo.Nodes.Add(nodoHijo);
            }

            return nodo;
        }



        private void comboBoxUsuario_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxUsuario.SelectedItem == null) return;
            string nombreUsuario = comboBoxUsuario.SelectedItem.ToString();
            var permisosDelUsuario = _usuarioBLL.ObtenerPermisosDelUsuarioEnMemoria(nombreUsuario);

            FillTreeView(permisosDelUsuario, treeViewPermisoUsuario);
        }

        private void btnAsignarPermiso_Click(object sender, EventArgs e)
        {
            if (treeViewPermisos.SelectedNode == null) return;
            if (comboBoxUsuario.Text.Length == 0) return;
            try
            {
                string nombreUsuario = comboBoxUsuario.Text.ToString();
                List<PermisoDTO> permisosUsuario = _usuarioBLL.AsignarPermisoUsuario((int)treeViewPermisos.SelectedNode.Tag, nombreUsuario);

                ActualizarFormulario();
                permisosUsuario = _usuarioBLL.ObtenerPermisosDelUsuarioEnMemoria(nombreUsuario);
                
                FillTreeView(permisosUsuario, treeViewPermisoUsuario);

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnDesasignarPermiso_Click(object sender, EventArgs e)
        {
            if (treeViewPermisoUsuario.SelectedNode == null) return;
            if (comboBoxUsuario.Text.Length == 0) return;
            try
            {
                string nombreUsuario = comboBoxUsuario.Text.ToString();
                _usuarioBLL.DesasignarPermisoUsuario(nombreUsuario, (int)treeViewPermisoUsuario.SelectedNode.Tag);

                ActualizarFormulario();
                var permisosUsuario = _usuarioBLL.ObtenerPermisosDelUsuarioEnMemoria(nombreUsuario);

                FillTreeView(permisosUsuario, treeViewPermisoUsuario);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
