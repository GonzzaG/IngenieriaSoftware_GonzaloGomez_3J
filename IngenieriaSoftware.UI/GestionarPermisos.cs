using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IngenieriaSoftware.BEL;
using IngenieriaSoftware.BLL;
namespace IngenieriaSoftware.UI
{
    public partial class GestionarPermisos : Form
    {
  
        public GestionarPermisos()
        {
            InitializeComponent();
            CargarTreeView();   
        }

        private void GestionarPermisos_Load(object sender, EventArgs e)
        {
          
        }

        private void CargarTreeView()
        { 
            var permisos = PermisoBLL.ObtenerPermisosEnMemoria();
            FillTreeView(permisos);
        }

        private void FillTreeView(DataTable dt)
        {
            treeViewPermisos.Nodes.Clear();

            // Diccionario para rastrear nodos por ID
            Dictionary<int, TreeNode> nodeLookup = new Dictionary<int, TreeNode>();

            foreach (var permiso in permisos)
            {
                TreeNode nuevoNodo = new TreeNode(permiso.Nombre)
                {
                    Tag = permiso.Id
                };

                nodeLookup[permiso.Id] = nuevoNodo;

                if (permiso.CodPermiso == null) // Nodo raíz
                {
                    treeViewPermisos.Nodes.Add(nuevoNodo);
                }
                else if (int.TryParse(permiso.CodPermiso, out int idPermisoPadre) && nodeLookup.TryGetValue(idPermisoPadre, out TreeNode parentNode))
                {
                    parentNode.Nodes.Add(nuevoNodo); // Nodo hijo
                }
            }

            treeViewPermisos.ExpandAll();
        }
    }
}
