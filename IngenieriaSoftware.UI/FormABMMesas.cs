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
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IngenieriaSoftware.UI
{
    //Primero traigo todas las mesas de la bd
    

    public partial class FormABMMesas : Form, IActualizable
    {
        private readonly MesaBLL _mesaBLL = new MesaBLL();


        public FormABMMesas()
        {
            InitializeComponent();
            Actualizar();

        }

        private void FormABMMesas_Load(object sender, EventArgs e)
        {
            VerificarNotificaciones();
        }

        private void btnGuardarMesa_Click(object sender, EventArgs e)
        {
            try
            {
                FormNuevaMesa formNuevaMesa = new FormNuevaMesa();
                formNuevaMesa.StartPosition = FormStartPosition.CenterScreen;
                formNuevaMesa.ShowDialog();

                Actualizar();
            }
            catch(Exception ex)
            {
                //aca muestro mensaje box de que se asigno correctamente
                //actualizo las mesas


                // muestro mensaje box que no se asigno
                // actualizo mesas por las dudas
            }


        }

        public void Actualizar()
        {
            var estadoFueraDeServicio = 
            dataGridViewMesas.DataSource = null;
            dataGridViewMesas.DataSource = _mesaBLL.ObtenerMesasDisponibles();
        }

        private void btnEliminarMesa_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridViewMesas.SelectedRows.Count == 0)
                {
                    //Excepcion para completar los campos correctamente
                    return;
                }
                int mesaId = (int)dataGridViewMesas.SelectedRows[0].Cells[0].Value;
                _mesaBLL.EliminarMesa(mesaId);
              

            }
            catch (Exception ex)
            {
                //aca muestro mensaje box de que se asigno correctamente
                //actualizo las mesas


                // muestro mensaje box que no se asigno
                // actualizo mesas por las dudas
            }
        }

        private void btnModificarMesa_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridViewMesas.SelectedRows.Count == 0)
                {
                    //Excepcion para completar los campos correctamente
                    return;
                }
                var mesaId = (int)dataGridViewMesas.SelectedRows[0].Cells[0].Value;
                var mesa = _mesaBLL.Mesas().Find(m => m.MesaId == mesaId);

                FormNuevaMesa formNuevaMesa = new FormNuevaMesa(mesa);
                formNuevaMesa.StartPosition = FormStartPosition.CenterScreen;
                formNuevaMesa.ShowDialog();

                Actualizar();
            }
            catch (Exception ex)
            {
                //aca muestro mensaje box de que se asigno correctamente
                //actualizo las mesas


                // muestro mensaje box que no se asigno
                // actualizo mesas por las dudas
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
        public NotificacionService _notificacionService => new NotificacionService();



    }
}
