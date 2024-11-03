﻿using IngenieriaSoftware.BLL;
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
    public partial class RegistrarUsuario : Form
    {
        private readonly AuthService _authService = new AuthService();
        private readonly UsuarioBLL _usuarioBLL;
        public RegistrarUsuario()
        {
            InitializeComponent();
            _usuarioBLL = new UsuarioBLL();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void GestionUsuarios_Load(object sender, EventArgs e)
        {
            comboBoxCategorias.Items.Add("Administrador");
            comboBoxCategorias.Items.Add("Mesero");
            comboBoxCategorias.Items.Add("Caja");
            comboBoxCategorias.Items.Add("Cocina");

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            try
            {
                if(txtUsername.Text.Length == 0 || txtPassword.Text.Length == 0 || comboBoxCategorias.SelectedItem == null) { return; }
                if (_authService.RegistrarUsuario(txtUsername.Text, txtPassword.Text))
                {
                    switch (comboBoxCategorias.Text)
                    {
                        case "Administrador":
                            _usuarioBLL.AsignarPermisoPorCod(txtUsername.Text, "PERM_ADMIN");
                            break;
                        case "Mesero":
                            _usuarioBLL.AsignarPermisoPorCod(txtUsername.Text, "PERM_MESERO");
                            break;
                        case "Caja":
                            _usuarioBLL.AsignarPermisoPorCod(txtUsername.Text, "PERM_CAJA");
                            break;
                        case "Cocina":
                            _usuarioBLL.AsignarPermisoPorCod(txtUsername.Text, "PERM_COCINA");
                            break;
                    }
                   
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }
        private void label1_Click_1(object sender, EventArgs e)
        {

        }
    }
}