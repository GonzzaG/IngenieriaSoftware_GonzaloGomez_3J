using IngenieriaSoftware.BLL;
using IngenieriaSoftware.Servicios;
using IngenieriaSoftware.Servicios.DTOs;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace IngenieriaSoftware.UI
{
    public partial class FormInicioSesion : Form
    {
        private readonly AuthService _authService = new AuthService();
        internal List<IdiomaDTO> _idiomas;

        public event Action InicioSesionExitoso;

        private IdiomaObserver _idiomaObserver;

        public FormInicioSesion() { InitializeComponent(); }
        public FormInicioSesion(IdiomaObserver idiomaObserver)
        {
            InitializeComponent();

            this.StartPosition = FormStartPosition.CenterScreen;
            this.DialogResult = DialogResult.No;
            _idiomas = new List<IdiomaDTO>();
            _idiomaObserver = idiomaObserver;

            // SuscribirControles();
        }

        private void Inicio_Load(object sender, EventArgs e)
        {
            _idiomas = CargarIdiomas();
            ListarIdiomas(_idiomas);
        }

        public List<IdiomaDTO> CargarIdiomas()
        {
            return new IdiomaBLL().ObtenerIdiomas();
        }

        public void ListarIdiomas(List<IdiomaDTO> idiomas)
        {
            comboBoxIdiomas.Items.Clear();
            foreach (IdiomaDTO idioma in idiomas)
            {
                comboBoxIdiomas.Items.Add(idioma.Nombre);
            }
        }

        #region LogIn LogOut

        private void LogIn(object sender, EventArgs e)
        {
            try
            {
                if (_authService.LogIn(txtUsuario.Text, txtContrasena.Text))
                {
                    InicioSesionExitoso?.Invoke();
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void LogOut(object sender, EventArgs e)
        {
            try
            {
                _authService.LogOut();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        #endregion LogIn LogOut

        private void comboBoxIdiomas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxIdiomas.SelectedItem == null) return;

            //Obtengo el idiomaId de la lista de idiomas, comparando el nombre del idioma con el del combo box, item seleccionado, y retorno el id
            var idiomaId = (_idiomas.Find(I => I.Nombre == comboBoxIdiomas.SelectedItem.ToString())).Id;

            _idiomaObserver.Notificar(idiomaId);
        }
    }
}