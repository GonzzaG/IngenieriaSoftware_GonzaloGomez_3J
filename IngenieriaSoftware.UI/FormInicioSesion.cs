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
using IngenieriaSoftware.Servicios;


namespace IngenieriaSoftware.UI
{
    public partial class FormInicioSesion : Form
    {
        private readonly AuthService _authService = new AuthService();
        internal List<IdiomaDTO> _idiomas;


        public event Action InicioSesionExitoso;
        private IdiomaObserver _idiomaObserver;

        public FormInicioSesion(IdiomaObserver idiomaObserver)
        {
            InitializeComponent();

            this.StartPosition = FormStartPosition.CenterScreen;
            this.DialogResult = DialogResult.No;
            _idiomas = new List<IdiomaDTO>();
            _idiomaObserver = idiomaObserver;

            Inicializar();
        }

        private void Inicializar()
        {
            //listo los controles del formulario
            var controlesForm = FormHelper.ListarControles(this);


            //guardamos las etiquetas en base de datos, comparandolas con las que ya existen para no repetir
            new IdiomaBLL().GuardarEtiquetas(controlesForm);

            foreach (var control in controlesForm)
            {
                // Crear un IdiomaSuscriptorDTO para cada etiqueta y suscribirlo al observador
                var suscriptorDTO = new IdiomaSuscriptorDTO { Tag = control.Key, Traduccion = control.Value};
                _idiomaObserver.Suscribir(suscriptorDTO);
            }
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
        #endregion

        private void comboBoxIdiomas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxIdiomas.SelectedItem == null) return;
            
            //Obtengo el idiomaId de la lista de idiomas, comparando el nombre del idioma con el del combo box, item seleccionado, y retorno el id
            var idiomaId = (_idiomas.Find(I => I.Nombre == comboBoxIdiomas.SelectedItem.ToString())).Id;   
            
            _idiomaObserver.Notificar(idiomaId);
            


        }

        //public List<IdiomaDTO> CambiarIdioma(string idiomaNombre)
        //{
        //    var nombreIdioma = _idiomas.Find(i => i.Nombre == idiomaNombre);
        //}
    }
}
