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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsuarios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRoles)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAsignarRol
            // 
            this.lblAsignarRol.AutoSize = true;
            this.lblAsignarRol.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAsignarRol.Location = new System.Drawing.Point(492, 30);
            this.lblAsignarRol.Name = "lblAsignarRol";
            this.lblAsignarRol.Size = new System.Drawing.Size(161, 32);
            this.lblAsignarRol.TabIndex = 40;
            this.lblAsignarRol.Tag = "";
            this.lblAsignarRol.Text = "Asignar rol";
            // 
            // btnAsignarRol
            // 
            this.btnAsignarRol.Location = new System.Drawing.Point(427, 544);
            this.btnAsignarRol.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAsignarRol.Name = "btnAsignarRol";
            this.btnAsignarRol.Size = new System.Drawing.Size(296, 86);
            this.btnAsignarRol.TabIndex = 38;
            this.btnAsignarRol.Tag = "";
            this.btnAsignarRol.Text = "Asignar Rol";
            this.btnAsignarRol.UseVisualStyleBackColor = true;
            this.btnAsignarRol.Click += new System.EventHandler(this.btnAsignarRol_Click);
            // 
            // lblNombreNuevoRol
            // 
            this.lblNombreNuevoRol.AutoSize = true;
            this.lblNombreNuevoRol.Location = new System.Drawing.Point(435, 118);
            this.lblNombreNuevoRol.Name = "lblNombreNuevoRol";
            this.lblNombreNuevoRol.Size = new System.Drawing.Size(166, 16);
            this.lblNombreNuevoRol.TabIndex = 37;
            this.lblNombreNuevoRol.Tag = "";
            this.lblNombreNuevoRol.Text = "Rol y permisos del usuario";
            // 
            // dataGridViewUsuarios
            // 
            this.dataGridViewUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUsuarios.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridViewUsuarios.Location = new System.Drawing.Point(162, 163);
            this.dataGridViewUsuarios.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewUsuarios.MultiSelect = false;
            this.dataGridViewUsuarios.Name = "dataGridViewUsuarios";
            this.dataGridViewUsuarios.ReadOnly = true;
            this.dataGridViewUsuarios.RowHeadersVisible = false;
            this.dataGridViewUsuarios.RowHeadersWidth = 51;
            this.dataGridViewUsuarios.RowTemplate.Height = 24;
            this.dataGridViewUsuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewUsuarios.Size = new System.Drawing.Size(177, 340);
            this.dataGridViewUsuarios.TabIndex = 44;
            this.dataGridViewUsuarios.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewUsuarios_CellEnter);
            this.dataGridViewUsuarios.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewUsuarios_RowEnter);
            this.dataGridViewUsuarios.SelectionChanged += new System.EventHandler(this.dataGridViewUsuarios_SelectionChanged);
            // 
            // dataGridViewRoles
            // 
            this.dataGridViewRoles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRoles.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridViewRoles.Location = new System.Drawing.Point(818, 163);
            this.dataGridViewRoles.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewRoles.MultiSelect = false;
            this.dataGridViewRoles.Name = "dataGridViewRoles";
            this.dataGridViewRoles.ReadOnly = true;
            this.dataGridViewRoles.RowHeadersVisible = false;
            this.dataGridViewRoles.RowHeadersWidth = 51;
            this.dataGridViewRoles.RowTemplate.Height = 24;
            this.dataGridViewRoles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewRoles.Size = new System.Drawing.Size(177, 340);
            this.dataGridViewRoles.TabIndex = 43;
            // 
            // lblTodosLosRoles
            // 
            this.lblTodosLosRoles.AutoSize = true;
            this.lblTodosLosRoles.Location = new System.Drawing.Point(815, 118);
            this.lblTodosLosRoles.Name = "lblTodosLosRoles";
            this.lblTodosLosRoles.Size = new System.Drawing.Size(101, 16);
            this.lblTodosLosRoles.TabIndex = 42;
            this.lblTodosLosRoles.Tag = "";
            this.lblTodosLosRoles.Text = "Todos los roles";
            // 
            // lblTodosLosUsuarios
            // 
            this.lblTodosLosUsuarios.AutoSize = true;
            this.lblTodosLosUsuarios.Location = new System.Drawing.Point(159, 118);
            this.lblTodosLosUsuarios.Name = "lblTodosLosUsuarios";
            this.lblTodosLosUsuarios.Size = new System.Drawing.Size(122, 16);
            this.lblTodosLosUsuarios.TabIndex = 41;
            this.lblTodosLosUsuarios.Tag = "";
            this.lblTodosLosUsuarios.Text = "Todos los usuarios";
            // 
            // treeViewPermisoRol
            // 
            this.treeViewPermisoRol.Location = new System.Drawing.Point(427, 163);
            this.treeViewPermisoRol.Margin = new System.Windows.Forms.Padding(4);
            this.treeViewPermisoRol.Name = "treeViewPermisoRol";
            this.treeViewPermisoRol.Size = new System.Drawing.Size(296, 339);
            this.treeViewPermisoRol.TabIndex = 45;
            this.treeViewPermisoRol.Tag = "";
            // 
            // btnVerPermisos
            // 
            this.btnVerPermisos.Location = new System.Drawing.Point(162, 526);
            this.btnVerPermisos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnVerPermisos.Name = "btnVerPermisos";
            this.btnVerPermisos.Size = new System.Drawing.Size(177, 58);
            this.btnVerPermisos.TabIndex = 46;
            this.btnVerPermisos.Tag = "";
            this.btnVerPermisos.Text = "Ver Permisos";
            this.btnVerPermisos.UseVisualStyleBackColor = true;
            this.btnVerPermisos.Click += new System.EventHandler(this.btnVerPermisos_Click);
            // 
            // FormAsignarRolAUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1236, 698);
            this.Controls.Add(this.btnVerPermisos);
            this.Controls.Add(this.treeViewPermisoRol);
            this.Controls.Add(this.dataGridViewUsuarios);
            this.Controls.Add(this.dataGridViewRoles);
            this.Controls.Add(this.lblTodosLosRoles);
            this.Controls.Add(this.lblTodosLosUsuarios);
            this.Controls.Add(this.lblAsignarRol);
            this.Controls.Add(this.btnAsignarRol);
            this.Controls.Add(this.lblNombreNuevoRol);
            this.Name = "FormAsignarRolAUsuario";
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
    }
}