using IngenieriaSoftware.BEL;
using IngenieriaSoftware.BLL.Mesas;
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

        public FormNuevaMesa()
        {
            InitializeComponent();
     

        }
        private void btnGuardarMesa_Click(object sender, EventArgs e)
        {
            try
            {
                if(txtNumMesa.Text.Length == 0)
                {
                    //aca lanzo la excepcionpersonalizada
                    return;
                }
                var mesa = new Mesa
                {
                    MesaId = int.Parse(txtNumMesa.Text),
                    CapacidadMaxima = (int)numericUpDownCapacidadMaxima.Value,
                    FechaReserva = null 
                    //la reserva es null ya que eso se guardara cuando se asigne una mesa
                    //Cuando la mesa se desocupe, se tendra que sacar el estado de la mesa
                };
                _mesaBLL.GuardarMesa(mesa);

                this.Close();
            }
            catch (Exception ex)
            {
                //Excepcion 1
                //excepcion personalizada por si no se completaron los campos correctamente
                //Excepcion 2
                //excepcion personalizada por si se pudo guardar la mesa
                //Excepcion 3
                //excepcion personalizada por si no se pudo guardar la mesa

            }

        }

        private void Inicializar(TipoForm tipoForm)
        {
       
        }

        public void Actualizar()
        {
            throw new NotImplementedException();
        }

        private void FormNuevaMesa_Load(object sender, EventArgs e)
        {

        }
    }
}
