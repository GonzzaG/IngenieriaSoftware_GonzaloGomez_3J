using IngenieriaSoftware.Servicios;
using IngenieriaSoftware.Servicios.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace IngenieriaSoftware.UI
{
    public partial class AgregarIdioma : Form, IActualizable
    {
        private readonly IdiomaObserver _idiomaObserver;
        Dictionary<EtiquetaDTO, TraduccionDTO> etiquetasConTraduccion = new Dictionary<EtiquetaDTO, TraduccionDTO>();
        List<EtiquetaDTO> etiquetasSinTraduccion = new List<EtiquetaDTO>();

        public AgregarIdioma()
        {
            InitializeComponent();
        }

        #region Metodos de Interfaz

        public void Actualizar()
        {
            //tengo que cargar la grid view de etiquetas con y sin traduccion
            //debo poner que en cada textbox se etiqueten todas las etiquetas de los grid view (los 2)
            //deberia traer tanto la etiqueta, los idiomas, y las traducciones
            var formPadre = this.MdiParent as FormMDI;

            // Obtenemos diccionario con etiquetas y traducciones
            etiquetasConTraduccion = formPadre.idiomaBLL.ObtenerEtiquetasConTraduccion(IdiomaData.IdiomaActual.Id);

            // Obtenemos lista con etiquetas
            etiquetasSinTraduccion = formPadre.idiomaBLL.ObtenerEtiquetasSinTraduccion(IdiomaData.IdiomaActual.Id);

            dataGridViewEtiquetasConTraduccion.DataSource = etiquetasConTraduccion.Keys.OrderBy(e => e.Tag).ToList();
            dataGridViewEtiquetasSinTraduccion.DataSource = etiquetasSinTraduccion.OrderBy(e => e.Tag).ToList();

            IdiomaData.Idiomas = formPadre.idiomaBLL.ObtenerIdiomas();

            comboBoxIdiomas.DataSource = IdiomaData.Idiomas;
            comboBoxIdiomas.DisplayMember = "Nombre";
            comboBoxIdiomas.ValueMember = "Id";
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

        private void AgregarIdioma_Load(object sender, EventArgs e)
        {
            Actualizar();
        }

        private void dataGridViewEtiquetasConTraduccion_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewEtiquetasConTraduccion.SelectedRows.Count > 0)
            {
                int etiquetaId = (int)dataGridViewEtiquetasConTraduccion.SelectedRows[0].Cells["Tag"].Value;
                string etiquetaNombre = dataGridViewEtiquetasConTraduccion.SelectedRows[0].Cells["Nombre"].Value.ToString();

                // Buscamos en el diccionario, la etiqueta que fue seleciconada segun el nombre en la gridView
                TraduccionDTO traduccion = etiquetasConTraduccion.FirstOrDefault(t => t.Value.EtiquetaId == etiquetaId).Value;

                txtEtiqueta.Text = etiquetaNombre;
                txtTraduccion.Text = traduccion.Texto;
            }
        }

        private void dataGridViewEtiquetasSinTraduccion_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewEtiquetasSinTraduccion.SelectedRows.Count > 0)
            {
                var etiquetaNombre = dataGridViewEtiquetasSinTraduccion.SelectedRows[0].Cells["Nombre"].Value.ToString();
                txtEtiqueta.Text = etiquetaNombre;

                // Vaciamos el txtTraduccion ya que no tiene traduccion
                txtTraduccion.Text = "";
            }
        }

        private void btnAgregarTraduccion_Click(object sender, EventArgs e)
        {
            // Vamos a agregar una nueva traduccion, indicando idioma_id, etiqueta_id, texto(nuevatraduccion)
            // Tambien verificar si ya existia una traduccion, para saber si hacer un UPDATE o un INSERT
            //validacion para saber que se completaron los campos necesarios
            if (comboBoxIdiomas.Text.Length < 0 
                || (dataGridViewEtiquetasConTraduccion.SelectedRows == null && dataGridViewEtiquetasSinTraduccion.SelectedRows == null) 
                || txtTraduccion.Text.Length == 0) 
            {
                MessageBox.Show("Por favor, complete todos los campos");
                return;      
            }

            
        }
    }
}