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
        private readonly MesasBLL _mesasBLL;
        public FormGestionarMesas()
        {
            InitializeComponent();

            _mesasBLL = new MesasBLL();

            var mesas = _mesasBLL.ObtenerMesas();
            mesas.Add(new Mesa
            {
                MesaId = 1,
                NumMesa = 1,
                CantComensales = 4,
                EstadoMesa = EstadoMesa.Estado.Desocupada,
            });
            mesas.Add(new Mesa
            {
                MesaId = 2,
                NumMesa = 2,
                CantComensales = 2,
                EstadoMesa = EstadoMesa.Estado.Ocupada,
            });

            Actualizar();
        }
        public void Actualizar()
        {
            dataGridViewMesas.DataSource = null;
            dataGridViewMesas.DataSource = _mesasBLL.ObtenerMesas();
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
