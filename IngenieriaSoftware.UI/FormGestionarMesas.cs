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
            _mesasBLL = new MesaBLL();
            Actualizar();
        }
        public void Actualizar()
        {
            dataGridViewMesas.DataSource = null;
            dataGridViewMesas.DataSource = _mesasBLL.ObtenerMesasDisponibles();

            dataGridViewMesas.Columns[0].HeaderText = "Numero de mesa";
            dataGridViewMesas.Columns[1].HeaderText = "Capacidad maxima";
            dataGridViewMesas.Columns[2].HeaderText = "Fecha de reserva";
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


               Actualizar(); //sacar cuando implemente 
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
            try
            {
                int mesaId = (int)dataGridViewMesas.SelectedRows[0].Cells[0].Value;
                if (_mesasBLL.MesaOcupada(mesaId))
                {
                    var mesa = _mesasBLL.Mesas().Find(m => m.MesaId == mesaId);
                    var padre = this.MdiParent as FormMDI;

                    FormRealizarComanda formRealizarComanda = new FormRealizarComanda(mesa);
                    //formRealizarComanda.MdiParent = padre;
                    padre.AbrirFormHijo(formRealizarComanda);

                    Actualizar();
                }
                else
                {
                    //aca se podria agregar una excepcion de que se necesita asignar la mesa
                    MessageBox.Show("Debe asignar la mesa antes de realizar una comanda");
                }

            }
            catch (Exception ex)
            {
                //excepcion personalizada por si la mesa no esta ocupada, por lo tanto hace falta asignarla
            }

            

        }
    }
}
