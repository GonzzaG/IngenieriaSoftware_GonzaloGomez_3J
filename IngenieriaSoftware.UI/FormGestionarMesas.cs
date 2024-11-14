using IngenieriaSoftware.BEL;
using IngenieriaSoftware.BLL;
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
        private readonly ComandaBLL _comandaBLL;

        public NotificacionService _notificacionService => new NotificacionService();

        public FormGestionarMesas()
        {
            InitializeComponent();
            _mesasBLL = new MesaBLL();
            _comandaBLL = new ComandaBLL();
           
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

        private async void ActualizarAsync()
        {
            try
            {
                var mesas = await Task.Run(() => _mesasBLL.ObtenerMesasDisponibles());


                if (mesas != null)
                {
                    dataGridViewMesas.DataSource = null;
                    dataGridViewMesas.DataSource = mesas;
                }

                dataGridViewMesas.Columns[0].HeaderText = "Numero de mesa";
                dataGridViewMesas.Columns[1].HeaderText = "Capacidad maxima";
                dataGridViewMesas.Columns[2].HeaderText = "Fecha de reserva";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al cargar los productos: " + ex.Message);
            }
        }

        private void FormGestionarMesas_Load(object sender, EventArgs e)
        {
            VerificarNotificaciones();
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

                    //voy a crear la comanda de la mesa, me retorna el id de la comanda
                    int comandaId = _comandaBLL.InsertarComanda(mesaId);

                    FormRealizarComanda formRealizarComanda = new FormRealizarComanda(mesa, comandaId);
                    padre.AbrirFormHijo(formRealizarComanda);



                    //Actualizar();
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

        public void VerificarNotificaciones()
        {
            if (PermisosData.Permisos.Contains("PERM_ADMIN") ||
               PermisosData.Permisos.Contains("PERM_MESERO"))
            {
                var notificaciones = _notificacionService.ObtenerNotificaciones();
                if (notificaciones.Count > 0)
                {
                    HelperForms.MostrarNotificacion(notificaciones, this);
                }
            }
        }

        private void btnSolicitarCuenta_Click(object sender, EventArgs e)
        {
            try
            {
                if(dataGridViewMesas.SelectedRows.Count != 0)
                {
                    // Cerraremos la mesa, vamos a empezar a crear la factura.
                    // abriremos un formulario donde pondremos un resumen de los gastos hasta el momento.
                    // con botones de cerrar la mesa.

                    DialogResult result = MessageBox.Show("Esta seguro que desea cerrar la mesa?", "Cerrar mesa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if(result  == DialogResult.Yes)
                    {
                        int mesaId = (int)dataGridViewMesas.SelectedRows[0].Cells[0].Value;
                        var padre = this.MdiParent as FormMDI;
                        FormSeleccionMedioDePago formSeleccionMedioDePago = new FormSeleccionMedioDePago(mesaId);
                        padre.AbrirFormHijo(formSeleccionMedioDePago);

                    }
                    else
                    {
                        return;
                    }

                    return;
                }
                
            }
            catch (Exception ex)
            {

            }



        }
    }
}
