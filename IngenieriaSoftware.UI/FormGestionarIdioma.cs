using System.Windows.Forms;

namespace IngenieriaSoftware.UI
{
    public partial class FormGestionarIdioma : Form, IActualizable
    {
        public FormGestionarIdioma()
        {
            InitializeComponent();
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
        private void FormGestionarIdioma_Load(object sender, System.EventArgs e)
        {

        }
    }
}