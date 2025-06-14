using IngenieriaSoftware.BLL;
using IngenieriaSoftware.Servicios;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace IngenieriaSoftware.UI
{
    public partial class FormGestionarBackup : Form, IActualizable
    {
        public BackupManager BackupManager = new BackupManager();

        public NotificacionService _notificacionService => new NotificacionService();
        private UsuarioBLL _usuarioBLL;

        public FormGestionarBackup()
        {
            InitializeComponent();
            _usuarioBLL = new UsuarioBLL();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void btnReestablecerBackUp_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBoxBackUps.SelectedItem == null)
                {
                    MessageBox.Show("Seleccione una copia de seguridad para restaurar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                //BackupManager.RestaurarBackup(comboBoxBackUps.SelectedItem.ToString());

                string nombreBackup = comboBoxBackUps.SelectedItem.ToString();

                BackupManager.Restore(nombreBackup);

                BitacoraHelper.RegistrarActividad(ToString(), "Restauración de base de datos", DateTime.Now, $"Nombre de la copia de seguridad: {comboBoxBackUps.SelectedItem.ToString()}", this.Name, AppDomain.CurrentDomain.BaseDirectory, "BackUp");
                Actualizar();

                MessageBox.Show("Restauracion de la base de datos realizada con exito", "Restauracion", MessageBoxButtons.OK, MessageBoxIcon.Information);

                VerificarUsuario();
            }
            catch (Exception ex)
            {
                BitacoraHelper.RegistrarError(this.Name, ex, "BackUp", SessionManager.GetInstance.Usuario.Username);
                MessageBox.Show(ex.Message, "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private bool VerificarUsuario()
        {
            try
            {
                if (_usuarioBLL.ObtenerUsuarioDTOPorId(SessionManager.GetInstance.Usuario.Id) != null)
                    return true;
                else
                    return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al verificar el usuario" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                _usuarioBLL.LogOut();
                FormMDI _menu = (FormMDI)this.MdiParent;
                _menu.AbrirIniciarSesion();
                return false;
            }
        }

        private void btnCopiaDeSeguridad_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("¿Está seguro de que desea realizar una copia de seguridad?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    //BackupManager.RealizarBackup();
                    BackupManager.Backup();
                    MessageBox.Show("Copia de seguridad realizada con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    BitacoraHelper.RegistrarActividad(SessionManager.GetInstance.Usuario.Username, "Copia de seguridad realizada con éxito.", DateTime.Now, $"Nombre de la copia de seguridad: {comboBoxBackUps.Text}", this.Name, AppDomain.CurrentDomain.BaseDirectory, "BackUp");
                }

                Actualizar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al realizar la copia de seguridad: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                BitacoraHelper.RegistrarError(this.Name, ex, "BackUp", SessionManager.GetInstance.Usuario.Username);
            }
        }

        private void FormGestionarBackup_Load(object sender, EventArgs e)
        {
            Actualizar();
        }

        private void ListarBackups()
        {
            try
            {
                comboBoxBackUps.Items.Clear();

                List<string> backups = BackupManager.GetBackUps();
                foreach (var copia in backups)
                {
                    comboBoxBackUps.Items.Add(copia);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al listar los backups: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminarBackup_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("¿Está seguro de que desea eliminar la copia de seguridad seleccionada?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
              
                if (result == DialogResult.Yes)
                {
                    var nombreBackup = comboBoxBackUps.SelectedItem.ToString();

                    BackupManager.DeleteBackup(nombreBackup);

                    BitacoraHelper.RegistrarActividad(ToString(), "Eliminación de copia de seguridad", DateTime.Now, $"Nombre de la copia de seguridad: {comboBoxBackUps.SelectedItem.ToString()}", this.Name, AppDomain.CurrentDomain.BaseDirectory, "BackUp");

                    MessageBox.Show("Copia de seguridad eliminada con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                Actualizar();
            }
            catch (Exception ex)
            {
                BitacoraHelper.RegistrarError(this.Name, ex, "BackUp", SessionManager.GetInstance.Usuario.Username);
                MessageBox.Show("Error al eliminar la copia de seguridad: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void Actualizar()
        {
            comboBoxBackUps.Items.Clear();
            comboBoxBackUps.Text = string.Empty;
            ListarBackups();
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