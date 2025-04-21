using IngenieriaSoftware.BEL;
using IngenieriaSoftware.BEL.Constantes;
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
using System.Drawing.Printing;
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
            if (dataGridViewMesas.Rows.Count == 0) { return; }
            dataGridViewMesas.Columns[0].HeaderText = "Numero de mesa";
            dataGridViewMesas.Columns[1].HeaderText = "Capacidad maxima";
            dataGridViewMesas.Columns[2].HeaderText = "Estado de la mesa";
            HeadersConfig();
        }

        private void HeadersConfig()
        {
            dataGridViewMesas.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;


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

                BitacoraHelper.RegistrarActividad(SessionManager.GetInstance.Usuario.Username, "Asignar mesa", DateTime.Now, "Mesa asignada", this.Name, AppDomain.CurrentDomain.BaseDirectory, "Mesas");


                Actualizar(); //sacar cuando implemente 
            }
            catch (MesaNoDisponibleException ex)
            {
                var adaptador = new ExcepcionesIdiomaAdaptador(ex.Tag, ex.Name);
                MessageBox.Show(adaptador.ObtenerMensajeTraducido());
                BitacoraHelper.RegistrarError(this.Name, ex, "Mesas", SessionManager.GetInstance.Usuario.Username);
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

                    var comandaId = _comandaBLL.VerificarComandaOcupada(mesaId);
                    if (comandaId == 0)
                    {
                         comandaId = _comandaBLL.InsertarComanda(mesaId);
                    }
                    //voy a crear la comanda de la mesa, me retorna el id de la comanda

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
            if (PermisosData.PermisosString.Contains("Mesero"))
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
                        string estado = dataGridViewMesas.SelectedRows[0].Cells[2].Value.ToString() ;
                        if(estado != EstadoMesa.Estado.Ocupada.ToString())
                        {
                            MessageBox.Show("La mesa tiene que encontrarse en estado 'Ocupada' para poder solicitar la cuenta");
                            return;
                        }

                        int mesaId = (int)dataGridViewMesas.SelectedRows[0].Cells[0].Value;
                        if (!_comandaBLL.ComandasProductosEntregados(mesaId))
                        {
                            MessageBox.Show("La mesa tiene productos en la comanda que no fueron entregadas aun");
                            return;
                        }


                        //voy a cerrar la mesa,  y luego desde otro formulario el cual un cajero pueda ver las mesas cerradas para poder seleccionar medios de pago                      
                        var comanda = _comandaBLL.ObtenerComandaPorMesaId(mesaId);
                        _mesasBLL.CambiarEstadoMesaCerrada(mesaId);
                        _comandaBLL.CambiarEstadoComandaCerrada(mesaId);    

                        BitacoraHelper.RegistrarActividad(SessionManager.GetInstance.Usuario.ToString(), "Cerrar mesa", DateTime.Now, "Mesa cerrada", this.Name, AppDomain.CurrentDomain.BaseDirectory, "Mesas");
                        Actualizar();

                    }
                    else
                    {
                        MessageBox.Show("La factura todavia no fue abonada, no se puede entregar.");
                    }

                    return;
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                BitacoraHelper.RegistrarError(this.Name, ex, "Mesas", SessionManager.GetInstance.Usuario.Username);
            }



        }

        private PrintDocument printDocument = new PrintDocument();
        private Bitmap memoryImage;

        private void btnCobrar_Click(object sender, EventArgs e)
        {
            try
            {
                int mesaId = (int)dataGridViewMesas.SelectedRows[0].Cells[0].Value;
                var mesas = (List<Mesa>)dataGridViewMesas.DataSource;
                Mesa mesa = mesas
                    .Where(m => m.MesaId == mesaId)
                    .First(m => m.EstadoMesa == EstadoMesa.Estado.Cerrada);

                if(mesa == null) { return; }
                //veo si puedo imprimir la factura y tabmien marcarla como entregada
                int comandaId = _comandaBLL.ObtenerComandaPorMesaId(mesa.MesaId).ComandaId;

                var padre = this.MdiParent as FormMDI;
                FormFacturaAEntregar formGestionarFacturas = new FormFacturaAEntregar(mesa.MesaId, comandaId);

                padre.AbrirFormHijo(formGestionarFacturas);
            }
            catch(Exception ex)
            {
                MessageBox.Show("La mesa tiene que estar cerrada para cobrar");
            }
        }

        private void CapturaDePantalla()
        {
            Graphics myGraphics = this.CreateGraphics();
            Size s = this.Size;
            memoryImage = new Bitmap(s.Width, s.Height, myGraphics);

            // Dibujar el formulario en el bitmap
            Graphics memoryGraphics = Graphics.FromImage(memoryImage);
            memoryGraphics.CopyFromScreen(this.Location.X, this.Location.Y, 0, 0, s);
        }
    }
}
