using IngenieriaSoftware.BLL;
using IngenieriaSoftware.Servicios;
using System;
using System.Windows.Forms;

namespace IngenieriaSoftware.UI
{
    public partial class FormRegistrarUsuario : Form
    {
        private readonly AuthService _authService = new AuthService();
        private readonly UsuarioBLL _usuarioBLL;

        public FormRegistrarUsuario()
        {
            InitializeComponent();
            _usuarioBLL = new UsuarioBLL();
        }

        #region Metodos de Interfaz
        public void Actualizar()
        {
            
        }
        #endregion

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            if (this.MdiParent is FormMDI formPrincipal && this is IActualizable actualizableForm)
            {
                formPrincipal.ActualizarFormsHijos -= actualizableForm.Actualizar;
            }
            base.OnFormClosed(e);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void GestionUsuarios_Load(object sender, EventArgs e)
        {
            comboBoxCategorias.Items.Add("Administrador");
            comboBoxCategorias.Items.Add("Mesero");
            comboBoxCategorias.Items.Add("Caja");
            comboBoxCategorias.Items.Add("Cocina");
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtUsername.Text.Length == 0 || txtPassword.Text.Length == 0 || comboBoxCategorias.SelectedItem == null) { return; }
                if (_authService.RegistrarUsuario(txtUsername.Text, txtPassword.Text))
                {
                    switch (comboBoxCategorias.Text)
                    {
                        case "Administrador":
                            _usuarioBLL.AsignarPermisoPorCod(txtUsername.Text, "PERM_ADMIN");
                            break;

                        case "Mesero":
                            _usuarioBLL.AsignarPermisoPorCod(txtUsername.Text, "PERM_MESERO");
                            break;

                        case "Caja":
                            _usuarioBLL.AsignarPermisoPorCod(txtUsername.Text, "PERM_CAJA");
                            break;

                        case "Cocina":
                            _usuarioBLL.AsignarPermisoPorCod(txtUsername.Text, "PERM_COCINA");
                            break;
                    }

                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void label1_Click_1(object sender, EventArgs e)
        {
        }
    }
}