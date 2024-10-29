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
namespace IngenieriaSoftware.UI
{
    public partial class GestionarPermisos : Form
    {
        private readonly PermisoBLL _permisoBLL;
        private readonly UsuarioBLL _usuarioBLL;
        public GestionarPermisos()
        {
            InitializeComponent();
            _permisoBLL = new PermisoBLL();
            _usuarioBLL = new UsuarioBLL();
            CargarFormulario(); 
            
        }

        private void GestionarPermisos_Load(object sender, EventArgs e)
        {
           
        }

        private void CargarUsuariosPermisos()
        {
            List<Usuario> usuarios = _usuarioBLL.CargarUsuariosPermisos();
            listarUsuarios(usuarios);
        }

        public void listarUsuarios(List<Usuario> pUsuarios)
        {
            foreach(Usuario usuario in pUsuarios)
            {
                comboBoxUsuario.Items.Add(usuario.Username);
            }
        }

        public void CargarFormulario()
        {
            CargarUsuariosPermisos();
            ListarTreeView();
        }


        private void ListarTreeView()
        { 
            var permisos = _usuarioBLL.ObtenerPermisosGlobales();
           //permisos = _usuarioBLL.ConstruirJerarquiaPermisos(permisos);
            FillTreeView(permisos, treeViewPermisos);

        }
        private void FillTreeView(List<Permiso> permisosJerarquizados, TreeView treeViewPermisos)
        {
            // Limpiar el TreeView antes de llenarlo
            treeViewPermisos.Nodes.Clear();

            // Agregar cada permiso raíz y construir sus hijos recursivamente
            foreach (var permiso in permisosJerarquizados)
            {
                // Crear y añadir el nodo raíz
                TreeNode nodoRaiz = CrearNodoRecursivo(permiso);
                treeViewPermisos.Nodes.Add(nodoRaiz);
            }

            // Expandir todos los nodos para visualizarlos
            treeViewPermisos.ExpandAll();
        }

        // Método recursivo para construir nodos del TreeView con sus hijos
        private TreeNode CrearNodoRecursivo(Permiso permiso)
        {
            // Crear un nodo para el permiso actual
            TreeNode nodo = new TreeNode(permiso.Nombre)
            {
                Tag = permiso.Id // Asignar el ID del permiso al Tag del nodo
            };

            // Recorrer los permisos hijos del permiso actual y añadirlos como nodos hijos
            foreach (var hijo in permiso.permisosHijos)
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
            var permisosDelUsuario = _usuarioBLL.ObtenerPermisosDelUsuario(nombreUsuario);

            FillTreeView(permisosDelUsuario, treeViewPermisoUsuario);
        }

        private void btnAsignarPermiso_Click(object sender, EventArgs e)
        {
            if(treeViewPermisos.SelectedNode == null) return;
            Permiso permiso = _usuarioBLL.ObtenerPermisoPorId((int)treeViewPermisos.SelectedNode.Tag, comboBoxUsuario.SelectedItem.ToString());
        }
    }
}
