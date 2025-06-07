using IngenieriaSoftware.BEL;
using IngenieriaSoftware.BEL.Auditoria;
using IngenieriaSoftware.BLL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace IngenieriaSoftware.UI
{
    public partial class FormBusquedaAuditoria : Form, IActualizable
    {
        private AuditoriaManager _auditoriaManager = new AuditoriaManager();
        private List<IAuditableModel> _registros;
        private bool formCargado = false;
        private bool tablasCargadas = false;

        public FormBusquedaAuditoria()
        {
            InitializeComponent();
            Actualizar();
        }

        public NotificacionService _notificacionService => new NotificacionService();

        public void Actualizar()
        {
            try
            {
                ListarTablasAuditadas();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar: " + ex.Message);
            }
        }

        public void VerificarNotificaciones()
        {
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                int registroSeleccionado;
                if (comboBoxRegistros.SelectedIndex < 0)
                {
                    MessageBox.Show("Seleccione un numero de registro");
                    return;
                }
                if (int.TryParse(comboBoxRegistros.SelectedItem.ToString(), out int registro))
                {
                    registroSeleccionado = registro;
                }
                else
                {
                    MessageBox.Show("Seleccione un registro válido.");
                    return;
                }
                FormMDI formMDI = (FormMDI)this.MdiParent;
                formMDI.AbrirFormHijo(new FormAuditoria(_auditoriaManager, _registros.FindAll(r => r.Entidad.Id == registroSeleccionado).ToList()));
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar auditoria: " + ex.Message);
            }
        }

        public void ListarTablasAuditadas()
        {
            try
            {
                List<string> tablas = _auditoriaManager.ObtenerTablasAuditadas();

                foreach (string tabla in tablas)
                {
                    comboBoxTablasAuditadas.Items.Add(tabla);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener las tablas: " + ex.Message);
            }
        }

        private void comboBoxTablasAuditadas_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (comboBoxTablasAuditadas.SelectedIndex >= 0 && formCargado)
                {
                    if (comboBoxRegistros.Items.Count > 0)
                    {
                        comboBoxRegistros.Items.Clear();
                    }

                    // Fix: Use LINQ to cast each item in the list to IAuditableModel
                    var registrosUsuario = _auditoriaManager.ObtenerRegistroDeTabla(comboBoxTablasAuditadas.Text);
                    _registros = registrosUsuario.Cast<IAuditableModel>().ToList();

                    comboBoxRegistros.Items.Clear();

                    _registros = _registros
                        .OrderByDescending(x => x.Entidad.Id)
                        .ToList();

                    if (_registros.Count > 0)
                    {
                        comboBoxRegistros.Items
                            .AddRange(_registros
                            .Select(x => x.Entidad.Id.ToString())
                            .Distinct()
                            .ToArray());
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al seleccionar tabla: " + ex.Message);
            }
        }

        private void FormBusquedaAuditoria_Load(object sender, EventArgs e)
        {
            formCargado = true;
        }
    }
}