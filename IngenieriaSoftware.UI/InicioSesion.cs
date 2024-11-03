using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IngenieriaSoftware.BLL;
using IngenieriaSoftware.BEL;
using IngenieriaSoftware.Servicios.DTOs;


namespace IngenieriaSoftware.UI
{
    public partial class InicioSesion : Form
    {
        private readonly AuthService _authService = new AuthService();
        internal List<IdiomaDTO> _idiomas;

        public InicioSesion()
        {
            InitializeComponent();

            this.StartPosition = FormStartPosition.CenterScreen;
            this.DialogResult = DialogResult.No;
            _idiomas = new List<IdiomaDTO>();

        }
        private void Inicio_Load(object sender, EventArgs e)
        {
            //var formPadre = this.MdiParent as MDI;
           // formPadre.PruebaAsignarIdsAControles(this);
            _idiomas =CargarIdiomas();
            ListarIdiomas(_idiomas);
            //ControlesHelper.CargarTraducciones(this);
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
                
                if(_authService.LogIn(txtUsuario.Text, txtContrasena.Text))
                {               
                    this.DialogResult = DialogResult.OK;
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
        #endregion

        private void comboBoxIdiomas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxIdiomas.SelectedItem == null) return;
            var nombreIdioma = comboBoxIdiomas.SelectedItem.ToString();
            
        }

        //public List<IdiomaDTO> CambiarIdioma(string idiomaNombre)
        //{
        //    var nombreIdioma = _idiomas.Find(i => i.Nombre == idiomaNombre);
        //}
    }
}
