namespace IngenieriaSoftware.UI
{
    partial class FormGestionRoles
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnAsignarPermiso = new System.Windows.Forms.Button();
            this.lblTodosLosRoles = new System.Windows.Forms.Label();
            this.btnCrearRol = new System.Windows.Forms.Button();
            this.lblNombreNuevoRol = new System.Windows.Forms.Label();
            this.lblTodosLosPermisos = new System.Windows.Forms.Label();
            this.txtNombreRol = new System.Windows.Forms.TextBox();
            this.treeViewPermisoRol = new System.Windows.Forms.TreeView();
            this.comboBoxRoles = new System.Windows.Forms.ComboBox();
            this.lblNombreDelRol = new System.Windows.Forms.Label();
            this.lblNuevoRol = new System.Windows.Forms.Label();
            this.lblAsignarRol = new System.Windows.Forms.Label();
            this.txtPermisoSeleccionado = new System.Windows.Forms.TextBox();
            this.dataGridViewRoles = new System.Windows.Forms.DataGridView();
            this.dataGridViewPermisos = new System.Windows.Forms.DataGridView();
            this.btnEliminarRol = new System.Windows.Forms.Button();
            this.btnDesasignar = new System.Windows.Forms.Button();
            this.usuarioBLLBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRoles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPermisos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBLLBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAsignarPermiso
            // 
            this.btnAsignarPermiso.Location = new System.Drawing.Point(729, 479);
            this.btnAsignarPermiso.Margin = new System.Windows.Forms.Padding(2);
            this.btnAsignarPermiso.Name = "btnAsignarPermiso";
            this.btnAsignarPermiso.Size = new System.Drawing.Size(222, 59);
            this.btnAsignarPermiso.TabIndex = 29;
            this.btnAsignarPermiso.Tag = "826";
            this.btnAsignarPermiso.Text = "Asignar";
            this.btnAsignarPermiso.UseVisualStyleBackColor = true;
            this.btnAsignarPermiso.Click += new System.EventHandler(this.btnAsignarPermiso_Click);
            // 
            // lblTodosLosRoles
            // 
            this.lblTodosLosRoles.AutoSize = true;
            this.lblTodosLosRoles.Location = new System.Drawing.Point(641, 105);
            this.lblTodosLosRoles.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTodosLosRoles.Name = "lblTodosLosRoles";
            this.lblTodosLosRoles.Size = new System.Drawing.Size(78, 13);
            this.lblTodosLosRoles.TabIndex = 27;
            this.lblTodosLosRoles.Tag = "821";
            this.lblTodosLosRoles.Text = "Todos los roles";
            // 
            // btnCrearRol
            // 
            this.btnCrearRol.Location = new System.Drawing.Point(57, 145);
            this.btnCrearRol.Margin = new System.Windows.Forms.Padding(2);
            this.btnCrearRol.Name = "btnCrearRol";
            this.btnCrearRol.Size = new System.Drawing.Size(197, 70);
            this.btnCrearRol.TabIndex = 25;
            this.btnCrearRol.Tag = "814";
            this.btnCrearRol.Text = "Crear Rol";
            this.btnCrearRol.UseVisualStyleBackColor = true;
            this.btnCrearRol.Click += new System.EventHandler(this.btnCrearRol_Click);
            // 
            // lblNombreNuevoRol
            // 
            this.lblNombreNuevoRol.AutoSize = true;
            this.lblNombreNuevoRol.Location = new System.Drawing.Point(55, 85);
            this.lblNombreNuevoRol.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNombreNuevoRol.Name = "lblNombreNuevoRol";
            this.lblNombreNuevoRol.Size = new System.Drawing.Size(108, 13);
            this.lblNombreNuevoRol.TabIndex = 24;
            this.lblNombreNuevoRol.Tag = "812";
            this.lblNombreNuevoRol.Text = "Nombre del nuevo rol";
            // 
            // lblTodosLosPermisos
            // 
            this.lblTodosLosPermisos.AutoSize = true;
            this.lblTodosLosPermisos.Location = new System.Drawing.Point(891, 104);
            this.lblTodosLosPermisos.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTodosLosPermisos.Name = "lblTodosLosPermisos";
            this.lblTodosLosPermisos.Size = new System.Drawing.Size(97, 13);
            this.lblTodosLosPermisos.TabIndex = 23;
            this.lblTodosLosPermisos.Tag = "823";
            this.lblTodosLosPermisos.Text = "Todos los permisos";
            // 
            // txtNombreRol
            // 
            this.txtNombreRol.Location = new System.Drawing.Point(57, 112);
            this.txtNombreRol.Margin = new System.Windows.Forms.Padding(2);
            this.txtNombreRol.Name = "txtNombreRol";
            this.txtNombreRol.Size = new System.Drawing.Size(198, 20);
            this.txtNombreRol.TabIndex = 30;
            this.txtNombreRol.Tag = "813";
            // 
            // treeViewPermisoRol
            // 
            this.treeViewPermisoRol.Location = new System.Drawing.Point(346, 151);
            this.treeViewPermisoRol.Name = "treeViewPermisoRol";
            this.treeViewPermisoRol.Size = new System.Drawing.Size(223, 305);
            this.treeViewPermisoRol.TabIndex = 33;
            this.treeViewPermisoRol.Tag = "819";
            // 
            // comboBoxRoles
            // 
            this.comboBoxRoles.FormattingEnabled = true;
            this.comboBoxRoles.Location = new System.Drawing.Point(346, 114);
            this.comboBoxRoles.Name = "comboBoxRoles";
            this.comboBoxRoles.Size = new System.Drawing.Size(223, 21);
            this.comboBoxRoles.TabIndex = 34;
            this.comboBoxRoles.Tag = "818";
            this.comboBoxRoles.SelectedIndexChanged += new System.EventHandler(this.comboBoxRoles_SelectedIndexChanged);
            this.comboBoxRoles.TextChanged += new System.EventHandler(this.comboBoxRoles_TextChanged);
            // 
            // lblNombreDelRol
            // 
            this.lblNombreDelRol.AutoSize = true;
            this.lblNombreDelRol.Location = new System.Drawing.Point(344, 92);
            this.lblNombreDelRol.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNombreDelRol.Name = "lblNombreDelRol";
            this.lblNombreDelRol.Size = new System.Drawing.Size(75, 13);
            this.lblNombreDelRol.TabIndex = 35;
            this.lblNombreDelRol.Tag = "816";
            this.lblNombreDelRol.Text = "Nombre del rol";
            // 
            // lblNuevoRol
            // 
            this.lblNuevoRol.AutoSize = true;
            this.lblNuevoRol.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNuevoRol.Location = new System.Drawing.Point(52, 23);
            this.lblNuevoRol.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNuevoRol.Name = "lblNuevoRol";
            this.lblNuevoRol.Size = new System.Drawing.Size(123, 26);
            this.lblNuevoRol.TabIndex = 36;
            this.lblNuevoRol.Tag = "811";
            this.lblNuevoRol.Text = "Nuevo Rol";
            // 
            // lblAsignarRol
            // 
            this.lblAsignarRol.AutoSize = true;
            this.lblAsignarRol.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAsignarRol.Location = new System.Drawing.Point(348, 23);
            this.lblAsignarRol.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAsignarRol.Name = "lblAsignarRol";
            this.lblAsignarRol.Size = new System.Drawing.Size(136, 26);
            this.lblAsignarRol.TabIndex = 37;
            this.lblAsignarRol.Tag = "815";
            this.lblAsignarRol.Text = "Asignar Rol";
            // 
            // txtPermisoSeleccionado
            // 
            this.txtPermisoSeleccionado.Enabled = false;
            this.txtPermisoSeleccionado.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPermisoSeleccionado.Location = new System.Drawing.Point(728, 447);
            this.txtPermisoSeleccionado.Margin = new System.Windows.Forms.Padding(2);
            this.txtPermisoSeleccionado.Name = "txtPermisoSeleccionado";
            this.txtPermisoSeleccionado.Size = new System.Drawing.Size(223, 28);
            this.txtPermisoSeleccionado.TabIndex = 38;
            this.txtPermisoSeleccionado.Tag = "825";
            // 
            // dataGridViewRoles
            // 
            this.dataGridViewRoles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRoles.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridViewRoles.Location = new System.Drawing.Point(644, 151);
            this.dataGridViewRoles.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewRoles.MultiSelect = false;
            this.dataGridViewRoles.Name = "dataGridViewRoles";
            this.dataGridViewRoles.ReadOnly = true;
            this.dataGridViewRoles.RowHeadersVisible = false;
            this.dataGridViewRoles.RowHeadersWidth = 51;
            this.dataGridViewRoles.RowTemplate.Height = 24;
            this.dataGridViewRoles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewRoles.Size = new System.Drawing.Size(133, 276);
            this.dataGridViewRoles.TabIndex = 39;
            this.dataGridViewRoles.Tag = "822";
            this.dataGridViewRoles.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewRoles_RowEnter);
            // 
            // dataGridViewPermisos
            // 
            this.dataGridViewPermisos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPermisos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridViewPermisos.Location = new System.Drawing.Point(893, 151);
            this.dataGridViewPermisos.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewPermisos.MultiSelect = false;
            this.dataGridViewPermisos.Name = "dataGridViewPermisos";
            this.dataGridViewPermisos.ReadOnly = true;
            this.dataGridViewPermisos.RowHeadersVisible = false;
            this.dataGridViewPermisos.RowHeadersWidth = 51;
            this.dataGridViewPermisos.RowTemplate.Height = 24;
            this.dataGridViewPermisos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewPermisos.Size = new System.Drawing.Size(133, 276);
            this.dataGridViewPermisos.TabIndex = 40;
            this.dataGridViewPermisos.Tag = "824";
            this.dataGridViewPermisos.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewPermisos_RowEnter);
            // 
            // btnEliminarRol
            // 
            this.btnEliminarRol.BackColor = System.Drawing.Color.Firebrick;
            this.btnEliminarRol.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnEliminarRol.Location = new System.Drawing.Point(460, 85);
            this.btnEliminarRol.Margin = new System.Windows.Forms.Padding(2);
            this.btnEliminarRol.Name = "btnEliminarRol";
            this.btnEliminarRol.Size = new System.Drawing.Size(108, 24);
            this.btnEliminarRol.TabIndex = 41;
            this.btnEliminarRol.Tag = "817";
            this.btnEliminarRol.Text = "Eliminar Rol";
            this.btnEliminarRol.UseVisualStyleBackColor = false;
            this.btnEliminarRol.Click += new System.EventHandler(this.btnEliminarRol_Click);
            // 
            // btnDesasignar
            // 
            this.btnDesasignar.Location = new System.Drawing.Point(347, 479);
            this.btnDesasignar.Margin = new System.Windows.Forms.Padding(2);
            this.btnDesasignar.Name = "btnDesasignar";
            this.btnDesasignar.Size = new System.Drawing.Size(222, 33);
            this.btnDesasignar.TabIndex = 42;
            this.btnDesasignar.Tag = "820";
            this.btnDesasignar.Text = "Desasignar rol o permiso";
            this.btnDesasignar.UseVisualStyleBackColor = true;
            this.btnDesasignar.Click += new System.EventHandler(this.btnDesasignar_Click);
            // 
            // usuarioBLLBindingSource
            // 
            this.usuarioBLLBindingSource.DataSource = typeof(IngenieriaSoftware.BLL.UsuarioBLL);
            // 
            // FormGestionRoles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1322, 717);
            this.Controls.Add(this.btnDesasignar);
            this.Controls.Add(this.btnEliminarRol);
            this.Controls.Add(this.dataGridViewPermisos);
            this.Controls.Add(this.dataGridViewRoles);
            this.Controls.Add(this.txtPermisoSeleccionado);
            this.Controls.Add(this.lblAsignarRol);
            this.Controls.Add(this.lblNuevoRol);
            this.Controls.Add(this.lblNombreDelRol);
            this.Controls.Add(this.comboBoxRoles);
            this.Controls.Add(this.treeViewPermisoRol);
            this.Controls.Add(this.txtNombreRol);
            this.Controls.Add(this.btnAsignarPermiso);
            this.Controls.Add(this.lblTodosLosRoles);
            this.Controls.Add(this.btnCrearRol);
            this.Controls.Add(this.lblNombreNuevoRol);
            this.Controls.Add(this.lblTodosLosPermisos);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormGestionRoles";
            this.Tag = "827";
            this.Load += new System.EventHandler(this.FormGestionRoles_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRoles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPermisos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBLLBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAsignarPermiso;
        private System.Windows.Forms.Label lblTodosLosRoles;
        private System.Windows.Forms.Button btnCrearRol;
        private System.Windows.Forms.Label lblNombreNuevoRol;
        private System.Windows.Forms.Label lblTodosLosPermisos;
        private System.Windows.Forms.TextBox txtNombreRol;
        private System.Windows.Forms.BindingSource usuarioBLLBindingSource;
        private System.Windows.Forms.TreeView treeViewPermisoRol;
        private System.Windows.Forms.ComboBox comboBoxRoles;
        private System.Windows.Forms.Label lblNombreDelRol;
        private System.Windows.Forms.Label lblNuevoRol;
        private System.Windows.Forms.Label lblAsignarRol;
        private System.Windows.Forms.TextBox txtPermisoSeleccionado;
        private System.Windows.Forms.DataGridView dataGridViewRoles;
        private System.Windows.Forms.DataGridView dataGridViewPermisos;
        private System.Windows.Forms.Button btnEliminarRol;
        private System.Windows.Forms.Button btnDesasignar;
    }
}