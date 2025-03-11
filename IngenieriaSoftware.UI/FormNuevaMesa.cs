using IngenieriaSoftware.BEL;
using IngenieriaSoftware.BLL;
using IngenieriaSoftware.BLL.Mesas;
using IngenieriaSoftware.Servicios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IngenieriaSoftware.UI
{
    public partial class FormNuevaMesa : Form, IActualizable
    {
        private readonly MesaBLL _mesaBLL = new MesaBLL();

        public NotificacionService _notificacionService => new NotificacionService();

        public FormNuevaMesa()
        {
            InitializeComponent();
            Inicializar();
        }
        public FormNuevaMesa(Mesa mesa)
        {
            InitializeComponent();
            Inicializar(mesa);
        }

        private void btnGuardarMesa_Click(object sender, EventArgs e)
        {
            try
            {
                if(numericUpDownNumMesa.Value == 0)
                {
                    //aca lanzo la excepcionpersonalizada
                    return;
                }

                var mesa = new Mesa
                {
                    MesaId = (int)numericUpDownNumMesa.Value,
                    CapacidadMaxima = (int)numericUpDownCapacidadMaxima.Value
                    //la reserva es null ya que eso se guardara cuando se asigne una mesa
                    //Cuando la mesa se desocupe, se tendra que sacar el estado de la mesa
                };
                _mesaBLL.GuardarMesa(mesa);
               
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("La mesa se creo con exito");
           
                //Excepcion 1
                //excepcion personalizada por si no se completaron los campos correctamente
                //Excepcion 2
                //excepcion personalizada por si se pudo guardar la mesa
                //Excepcion 3
                //excepcion personalizada por si no se pudo guardar la mesa
            }

        }


        //Inicializar para Alta
        private void Inicializar()
        {
            lblModificarMesa.Visible = false; 
            lblNuevaMesa.Visible = true;
            lblNuevaMesa.Visible = true;
            //numericUpDownNumMesa.Visible = true;
            //numericUpDownNumMesa.Enabled = true;
        }

        //Inicializar Para modificacion
        private void Inicializar(Mesa mesa)
        {
            numericUpDownCapacidadMaxima.Value = mesa.CapacidadMaxima;
            numericUpDownNumMesa.Value = mesa.MesaId;
            lblModificarMesa.Visible = true;
            lblModificarMesa.Location = new Point(47, 22);
            lblNuevaMesa.Visible = false;
            lblNuevaMesa.Visible = false;
            //numericUpDownNumMesa.Visible = true;
            //numericUpDownNumMesa.Enabled = false;
        }
        public void Actualizar()
        {
            
        }

        private void FormNuevaMesa_Load(object sender, EventArgs e)
        {
            VerificarNotificaciones();
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
    }
}
