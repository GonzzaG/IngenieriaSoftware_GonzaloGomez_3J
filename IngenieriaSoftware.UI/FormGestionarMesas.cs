using IngenieriaSoftware.BEL;
using IngenieriaSoftware.BLL.Mesas;
using IngenieriaSoftware.Servicios;
using IngenieriaSoftware.UI.Adaptadores;
using System;
using System.CodeDom;
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
    public partial class FormGestionarMesas : Form, IActualizable
    {
        private readonly MesaBLL _mesasBLL;
        public FormGestionarMesas()
        {
            InitializeComponent();
            Actualizar();
        }
        public void Actualizar()
        {
            dataGridViewMesas.DataSource = null;
            dataGridViewMesas.DataSource = _mesasBLL.ObtenerMesasDisponibles();
        }

        private void FormGestionarMesas_Load(object sender, EventArgs e)
        {
            
        }

        private void btnAsignarMesa_Click(object sender, EventArgs e)
        {
            try
            {
                if(dataGridViewMesas.SelectedRows.Count == 0) { return; }

                // Asignamos comensales a la mesa seleccionada
                var mesaId = (int)dataGridViewMesas.SelectedRows[0].Cells[0].Value;
                _mesasBLL.AsignarMesa(mesaId);


                Actualizar();
            }
            catch (MesaNoDisponibleException ex)
            {
                var adaptador = new ExcepcionesIdiomaAdaptador(ex.Tag, ex.Name);
                MessageBox.Show(adaptador.ObtenerMensajeTraducido());
                Actualizar();

            }
            catch(MesaAsignadaException ex)
            {
                var adaptador = new ExcepcionesIdiomaAdaptador(ex.Tag, ex.Name);
                MessageBox.Show(adaptador.ObtenerMensajeTraducido());
                Actualizar();
            }
        }

        private void btnRealizarComanda_Click(object sender, EventArgs e)
        {

        }
    }
}
