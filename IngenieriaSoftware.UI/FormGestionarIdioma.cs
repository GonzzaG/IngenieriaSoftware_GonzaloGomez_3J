using IngenieriaSoftware.BLL;
using IngenieriaSoftware.Servicios;
using System;
using System.Windows.Forms;

namespace IngenieriaSoftware.UI
{
    public partial class FormGestionarIdioma : Form, IActualizable
    {
        IdiomaBLL _idiomaBLL = new IdiomaBLL();
        public FormGestionarIdioma()
        {
            InitializeComponent();
        }

        public NotificacionService _notificacionService => new NotificacionService();

        #region Metodos de Interfaz
        public void Actualizar()
        {
            try
            {
                var idiomas = _idiomaBLL.ObtenerIdiomas();

                if (idiomas != null)
                {
                    dataGridViewIdiomas.DataSource = null;
                    dataGridViewIdiomas.DataSource = idiomas;
                    OcultarCampos();
                }
            }
            catch(Exception ex) 
            {
                MessageBox.Show("No se pudo obtener los idiomas: " + ex.Message);
               
            }
        }

        private void OcultarCampos()
        {
            dataGridViewIdiomas.Columns[0].Visible = false;
            dataGridViewIdiomas.Columns[2].Visible = false;
            dataGridViewIdiomas.Columns[3].Visible = false;
            dataGridViewIdiomas.Columns[4].Visible = false;
        }
        public void VerificarNotificaciones()
        {
            if (PermisosData.PermisosString.Contains("Mesero"))
            {
                var notificaciones = _notificacionService.ObtenerNotificaciones();
                if (notificaciones.Count > 0)
                {
                    HelperForms.MostrarNotificacion(notificaciones, this);
                }
            }
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
        private void FormGestionarIdioma_Load(object sender, System.EventArgs e)
        {
            VerificarNotificaciones();
            Actualizar();
        }

        private void btnAgregarIdioma_Click(object sender, EventArgs e)
        {
            try
            {
                if(txtIdioma.Text != null)
                {
                    var texto = txtIdioma.Text;
                    _idiomaBLL.InsertarIdioma(texto);

                    MessageBox.Show("Idioma guardado con exito.");

                    FormMDI formMDI = this.MdiParent as FormMDI;
                    formMDI.ActualizarIdiomasCombo();
                    Actualizar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnEliminarIdioma_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridViewIdiomas.SelectedRows != null)
                {
                    int idiomaId = (int)dataGridViewIdiomas.SelectedRows[0].Cells[0].Value;
                    _idiomaBLL.EliminarIdioma(idiomaId);

                    MessageBox.Show("Idioma eliminado con exito.");


                    //deberia actualizar el combobox del form padre
                    FormMDI formMDI = this.MdiParent as FormMDI;
                    formMDI.ActualizarIdiomasCombo();
                    Actualizar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}