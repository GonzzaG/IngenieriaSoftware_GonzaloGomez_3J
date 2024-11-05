﻿using IngenieriaSoftware.BLL;
using IngenieriaSoftware.Servicios;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace IngenieriaSoftware.UI
{
    public partial class FormEliminarUsuario : Form
    {
        private UsuarioBLL usuarioBLL;
        private List<UsuarioDTO> usuarios;

        public FormEliminarUsuario()
        {
            InitializeComponent();
            usuarioBLL = new UsuarioBLL();
            usuarios = new List<UsuarioDTO>();
        }

        private void EliminarUsuario_Load(object sender, EventArgs e)
        {
            try
            {
                usuarios = usuarioBLL.CargarUsuarios();
                listarUsuarios(usuarios);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void listarUsuarios(List<UsuarioDTO> pUsuarios)
        {
            comboBoxUsuarios.Items.Clear();
            foreach (UsuarioDTO usuario in pUsuarios)
            {
                comboBoxUsuarios.Items.Add(usuario.Username);
            }
        }

        private void btnEliminarUsuario_Click(object sender, EventArgs e)
        {
            if (comboBoxUsuarios.SelectedItem == null) { return; }
            DialogResult respuesta = MessageBox.Show("Está seguro que desea eliminar?", "Alerta de eliminacion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (respuesta == DialogResult.No) return;
            else if (respuesta == DialogResult.Yes)
            {
                usuarios = usuarioBLL.EliminarUsuario(usuarios, comboBoxUsuarios.SelectedItem.ToString());
                listarUsuarios(usuarios);
            }
        }

        private void comboBoxUsuarios_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
    }
}