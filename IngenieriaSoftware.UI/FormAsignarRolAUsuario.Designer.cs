namespace IngenieriaSoftware.UI
{
    partial class FormAsignarRolAUsuario
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
            this.lblAsignarRol = new System.Windows.Forms.Label();
            this.btnAsignarRol = new System.Windows.Forms.Button();
            this.lblNombreNuevoRol = new System.Windows.Forms.Label();
            this.dataGridViewUsuarios = new System.Windows.Forms.DataGridView();
            this.dataGridViewRoles = new System.Windows.Forms.DataGridView();
            this.lblTodosLosRoles = new System.Windows.Forms.Label();
            this.lblTodosLosUsuarios = new System.Windows.Forms.Label();
            this.treeViewPermisoRol = new System.Windows.Forms.TreeView();
            this.btnVerPermisos = new System.Windows.Forms.Button();
            this.btnDesasignarRol = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsuarios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRoles)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAsignarRol
            // 
            this.lblAsignarRol.AutoSize = true;
            this.lblAsignarRol.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAsignarRol.Location = new System.Drawing.Point(369, 24);
            this.lblAsignarRol.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAsignarRol.Name = "lblAsignarRol";
            this.lblAsignarRol.Size = new System.Drawing.Size(127, 26);
            this.lblAsignarRol.TabIndex = 40;
            this.lblAsignarRol.Tag = "800";
            this.lblAsignarRol.Text = "Asignar rol";
            // 
            // btnAsignarRol
            // 
            this.btnAsignarRol.Location = new System.Drawing.Point(321, 427);
            this.btnAsignarRol.Margin = new System.Windows.Forms.Padding(2);
            this.btnAsignarRol.Name = "btnAsignarRol";
            this.btnAsignarRol.Size = new System.Drawing.Size(222, 85);
            this.btnAsignarRol.TabIndex = 38;
            this.btnAsignarRol.Tag = "809";
            this.btnAsignarRol.Text = "Asignar Rol";
            this.btnAsignarRol.UseVisualStyleBackColor = true;
            this.btnAsignarRol.Click += new System.EventHandler(this.btnAsignarRol_Click);
            // 
            // lblNombreNuevoRol
            // 
            this.lblNombreNuevoRol.AutoSize = true;
            this.lblNombreNuevoRol.Location = new System.Drawing.Point(326, 96);
            this.lblNombreNuevoRol.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNombreNuevoRol.Name = "lblNombreNuevoRol";
            this.lblNombreNuevoRol.Size = new System.Drawing.Size(129, 13);
            this.lblNombreNuevoRol.TabIndex = 37;
            this.lblNombreNuevoRol.Tag = "803";
            this.lblNombreNuevoRol.Text = "Rol y permisos del usuario";
            // 
            // dataGridViewUsuarios
            // 
            this.dataGridViewUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUsuarios.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridViewUsuarios.Location = new System.Drawing.Point(122, 132);
            this.dataGridViewUsuarios.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewUsuarios.MultiSelect = false;
            this.dataGridViewUsuarios.Name = "dataGridViewUsuarios";
            this.dataGridViewUsuarios.ReadOnly = true;
            this.dataGridViewUsuarios.RowHeadersVisible = false;
            this.dataGridViewUsuarios.RowHeadersWidth = 51;
            this.dataGridViewUsuarios.RowTemplate.Height = 24;
            this.dataGridViewUsuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewUsuarios.Size = new System.Drawing.Size(133, 276);
            this.dataGridViewUsuarios.TabIndex = 44;
            this.dataGridViewUsuarios.Tag = "802";
            this.dataGridViewUsuarios.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewUsuarios_CellEnter);
            this.dataGridViewUsuarios.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewUsuarios_RowEnter);
            this.dataGridViewUsuarios.SelectionChanged += new System.EventHandler(this.dataGridViewUsuarios_SelectionChanged);
            // 
            // dataGridViewRoles
            // 
            this.dataGridViewRoles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRoles.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridViewRoles.Location = new System.Drawing.Point(614, 132);
            this.dataGridViewRoles.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewRoles.MultiSelect = false;
            this.dataGridViewRoles.Name = "dataGridViewRoles";
            this.dataGridViewRoles.ReadOnly = true;
            this.dataGridViewRoles.RowHeadersVisible = false;
            this.dataGridViewRoles.RowHeadersWidth = 51;
            this.dataGridViewRoles.RowTemplate.Height = 24;
            this.dataGridViewRoles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewRoles.Size = new System.Drawing.Size(133, 276);
            this.dataGridViewRoles.TabIndex = 43;
            this.dataGridViewRoles.Tag = "806";
            // 
            // lblTodosLosRoles
            // 
            this.lblTodosLosRoles.AutoSize = true;
            this.lblTodosLosRoles.Location = new System.Drawing.Point(611, 96);
            this.lblTodosLosRoles.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTodosLosRoles.Name = "lblTodosLosRoles";
            this.lblTodosLosRoles.Size = new System.Drawing.Size(78, 13);
            this.lblTodosLosRoles.TabIndex = 42;
            this.lblTodosLosRoles.Tag = "805";
            this.lblTodosLosRoles.Text = "Todos los roles";
            // 
            // lblTodosLosUsuarios
            // 
            this.lblTodosLosUsuarios.AutoSize = true;
            this.lblTodosLosUsuarios.Location = new System.Drawing.Point(119, 96);
            this.lblTodosLosUsuarios.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTodosLosUsuarios.Name = "lblTodosLosUsuarios";
            this.lblTodosLosUsuarios.Size = new System.Drawing.Size(95, 13);
            this.lblTodosLosUsuarios.TabIndex = 41;
            this.lblTodosLosUsuarios.Tag = "801";
            this.lblTodosLosUsuarios.Text = "Todos los usuarios";
            // 
            // treeViewPermisoRol
            // 
            this.treeViewPermisoRol.Location = new System.Drawing.Point(320, 132);
            this.treeViewPermisoRol.Name = "treeViewPermisoRol";
            this.treeViewPermisoRol.Size = new System.Drawing.Size(223, 276);
            this.treeViewPermisoRol.TabIndex = 45;
            this.treeViewPermisoRol.Tag = "804";
            // 
            // btnVerPermisos
            // 
            this.btnVerPermisos.Location = new System.Drawing.Point(122, 427);
            this.btnVerPermisos.Margin = new System.Windows.Forms.Padding(2);
            this.btnVerPermisos.Name = "btnVerPermisos";
            this.btnVerPermisos.Size = new System.Drawing.Size(133, 47);
            this.btnVerPermisos.TabIndex = 46;
            this.btnVerPermisos.Tag = "807";
            this.btnVerPermisos.Text = "Ver PermisosString";
            this.btnVerPermisos.UseVisualStyleBackColor = true;
            this.btnVerPermisos.Click += new System.EventHandler(this.btnVerPermisos_Click);
            // 
            // btnDesasignarRol
            // 
            this.btnDesasignarRol.BackColor = System.Drawing.Color.Firebrick;
            this.btnDesasignarRol.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnDesasignarRol.Location = new System.Drawing.Point(122, 478);
            this.btnDesasignarRol.Margin = new System.Windows.Forms.Padding(2);
            this.btnDesasignarRol.Name = "btnDesasignarRol";
            this.btnDesasignarRol.Size = new System.Drawing.Size(133, 34);
            this.btnDesasignarRol.TabIndex = 47;
            this.btnDesasignarRol.Tag = "808";
            this.btnDesasignarRol.Text = "Desasignar Rol";
            this.btnDesasignarRol.UseVisualStyleBackColor = false;
            this.btnDesasignarRol.Visible = false;
            this.btnDesasignarRol.Click += new System.EventHandler(this.btnDesasignarRol_Click);
            // 
            // FormAsignarRolAUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(927, 612);
            this.Controls.Add(this.btnDesasignarRol);
            this.Controls.Add(this.btnVerPermisos);
            this.Controls.Add(this.treeViewPermisoRol);
            this.Controls.Add(this.dataGridViewUsuarios);
            this.Controls.Add(this.dataGridViewRoles);
            this.Controls.Add(this.lblTodosLosRoles);
            this.Controls.Add(this.lblTodosLosUsuarios);
            this.Controls.Add(this.lblAsignarRol);
            this.Controls.Add(this.btnAsignarRol);
            this.Controls.Add(this.lblNombreNuevoRol);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormAsignarRolAUsuario";
            this.Tag = "810";
            this.Text = "FormAsignarRolAUsuario";
            this.Load += new System.EventHandler(this.FormAsignarRolAUsuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsuarios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRoles)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAsignarRol;
        private System.Windows.Forms.Button btnAsignarRol;
        private System.Windows.Forms.Label lblNombreNuevoRol;
        private System.Windows.Forms.DataGridView dataGridViewUsuarios;
        private System.Windows.Forms.DataGridView dataGridViewRoles;
        private System.Windows.Forms.Label lblTodosLosRoles;
        private System.Windows.Forms.Label lblTodosLosUsuarios;
        private System.Windows.Forms.TreeView treeViewPermisoRol;
        private System.Windows.Forms.Button btnVerPermisos;
        private System.Windows.Forms.Button btnDesasignarRol;
    }
}