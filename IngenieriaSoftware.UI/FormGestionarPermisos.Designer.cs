namespace IngenieriaSoftware.UI
{
    partial class FormGestionarPermisos
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
            this.btnAsignarPermiso = new System.Windows.Forms.Button();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblTodosLosPermisos = new System.Windows.Forms.Label();
            this.comboBoxUsuario = new System.Windows.Forms.ComboBox();
            this.treeViewPermisos = new System.Windows.Forms.TreeView();
            this.treeViewPermisoUsuario = new System.Windows.Forms.TreeView();
            this.lblPermisosUsuario = new System.Windows.Forms.Label();
            this.btnDesasignarPermiso = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAsignarPermiso
            // 
            this.btnAsignarPermiso.Location = new System.Drawing.Point(59, 199);
            this.btnAsignarPermiso.Margin = new System.Windows.Forms.Padding(2);
            this.btnAsignarPermiso.Name = "btnAsignarPermiso";
            this.btnAsignarPermiso.Size = new System.Drawing.Size(151, 70);
            this.btnAsignarPermiso.TabIndex = 14;
            this.btnAsignarPermiso.Tag = "32";
            this.btnAsignarPermiso.Text = "Asignar permiso";
            this.btnAsignarPermiso.UseVisualStyleBackColor = true;
            this.btnAsignarPermiso.Click += new System.EventHandler(this.btnAsignarPermiso_Click);
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(46, 102);
            this.lblUsuario.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(43, 13);
            this.lblUsuario.TabIndex = 13;
            this.lblUsuario.Tag = "30";
            this.lblUsuario.Text = "Usuario";
            // 
            // lblTodosLosPermisos
            // 
            this.lblTodosLosPermisos.AutoSize = true;
            this.lblTodosLosPermisos.Location = new System.Drawing.Point(673, 55);
            this.lblTodosLosPermisos.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTodosLosPermisos.Name = "lblTodosLosPermisos";
            this.lblTodosLosPermisos.Size = new System.Drawing.Size(97, 13);
            this.lblTodosLosPermisos.TabIndex = 11;
            this.lblTodosLosPermisos.Tag = "36";
            this.lblTodosLosPermisos.Text = "Todos los permisos";
            // 
            // comboBoxUsuario
            // 
            this.comboBoxUsuario.FormattingEnabled = true;
            this.comboBoxUsuario.Location = new System.Drawing.Point(40, 118);
            this.comboBoxUsuario.Name = "comboBoxUsuario";
            this.comboBoxUsuario.Size = new System.Drawing.Size(189, 21);
            this.comboBoxUsuario.TabIndex = 8;
            this.comboBoxUsuario.Tag = "31";
            this.comboBoxUsuario.SelectedIndexChanged += new System.EventHandler(this.comboBoxUsuario_SelectedIndexChanged);
            // 
            // treeViewPermisos
            // 
            this.treeViewPermisos.Location = new System.Drawing.Point(663, 91);
            this.treeViewPermisos.Name = "treeViewPermisos";
            this.treeViewPermisos.Size = new System.Drawing.Size(285, 314);
            this.treeViewPermisos.TabIndex = 18;
            this.treeViewPermisos.Tag = "64";
            // 
            // treeViewPermisoUsuario
            // 
            this.treeViewPermisoUsuario.Location = new System.Drawing.Point(327, 91);
            this.treeViewPermisoUsuario.Name = "treeViewPermisoUsuario";
            this.treeViewPermisoUsuario.Size = new System.Drawing.Size(285, 314);
            this.treeViewPermisoUsuario.TabIndex = 20;
            this.treeViewPermisoUsuario.Tag = "35";
            // 
            // lblPermisosUsuario
            // 
            this.lblPermisosUsuario.AutoSize = true;
            this.lblPermisosUsuario.Location = new System.Drawing.Point(324, 55);
            this.lblPermisosUsuario.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPermisosUsuario.Name = "lblPermisosUsuario";
            this.lblPermisosUsuario.Size = new System.Drawing.Size(103, 13);
            this.lblPermisosUsuario.TabIndex = 19;
            this.lblPermisosUsuario.Tag = "34";
            this.lblPermisosUsuario.Text = "Permisos del usuario";
            // 
            // btnDesasignarPermiso
            // 
            this.btnDesasignarPermiso.Location = new System.Drawing.Point(59, 284);
            this.btnDesasignarPermiso.Margin = new System.Windows.Forms.Padding(2);
            this.btnDesasignarPermiso.Name = "btnDesasignarPermiso";
            this.btnDesasignarPermiso.Size = new System.Drawing.Size(151, 70);
            this.btnDesasignarPermiso.TabIndex = 21;
            this.btnDesasignarPermiso.Tag = "33";
            this.btnDesasignarPermiso.Text = "Desasignar permiso";
            this.btnDesasignarPermiso.UseVisualStyleBackColor = true;
            this.btnDesasignarPermiso.Click += new System.EventHandler(this.btnDesasignarPermiso_Click);
            // 
            // FormGestionarPermisos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1156, 546);
            this.Controls.Add(this.btnDesasignarPermiso);
            this.Controls.Add(this.treeViewPermisoUsuario);
            this.Controls.Add(this.lblPermisosUsuario);
            this.Controls.Add(this.treeViewPermisos);
            this.Controls.Add(this.btnAsignarPermiso);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.lblTodosLosPermisos);
            this.Controls.Add(this.comboBoxUsuario);
            this.Name = "FormGestionarPermisos";
            this.Tag = "29";
            this.Text = "GestionarPermisos";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.GestionarPermisos_FormClosed);
            this.Load += new System.EventHandler(this.GestionarPermisos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAsignarPermiso;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblTodosLosPermisos;
        private System.Windows.Forms.ComboBox comboBoxUsuario;
        private System.Windows.Forms.TreeView treeViewPermisos;
        private System.Windows.Forms.TreeView treeViewPermisoUsuario;
        private System.Windows.Forms.Label lblPermisosUsuario;
        private System.Windows.Forms.Button btnDesasignarPermiso;
    }
}