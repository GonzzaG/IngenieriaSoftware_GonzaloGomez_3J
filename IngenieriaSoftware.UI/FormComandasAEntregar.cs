using IngenieriaSoftware.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IngenieriaSoftware.UI
{
    public partial class FormComandasAEntregar : Form, IActualizable
    {
        private readonly ComandaBLL _comandaBLL = new ComandaBLL();
        public FormComandasAEntregar()
        {
            InitializeComponent();
            Actualizar();
        }

        public void Actualizar()
        {
            //vamos a mostrar las notificaciones que no hayan sido vistas
            var notificaciones = _comandaBLL.ObtenerNotificacionesNoVistas();
            dataGridViewComandasAEntregar.DataSource = null;
            dataGridViewComandasAEntregar.DataSource = notificaciones;
        }

        private void btnComandaEntregada_Click(object sender, EventArgs e)
        {
            //vamos a marcar los productos como entregados
            //vamos a marcar la notificacion como vista
            int comandaId = (int)dataGridViewComandasAEntregar.SelectedRows[0].Cells[1].Value;
            _comandaBLL.MarcarProductosEntregados(comandaId);

            Actualizar();
        }
    }
}
