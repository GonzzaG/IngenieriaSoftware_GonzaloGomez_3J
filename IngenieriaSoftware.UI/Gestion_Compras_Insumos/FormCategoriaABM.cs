using IngenieriaSoftware.BEL.Gestion_Compras_Insumos;
using IngenieriaSoftware.BLL.Gestion_Compras_Insumos;
using System;
using System.Windows.Forms;

namespace IngenieriaSoftware.UI.Gestion_Compras_Insumos
{
    public partial class FormCategoriaABM : Form
    {
        public FormCategoriaABM()
        {
            InitializeComponent();
        }

        private void btnAgregarCategoria_Click(object sender, EventArgs e)
        {
            try
            {
                var categoria = new Categoria
                {
                    Nombre = txtNombre.Text == string.Empty ? throw new Exception("Debe colocar un nombre a la categoria") : txtNombre.Text
                };

                new CategoriaBussines().Save(categoria);


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
