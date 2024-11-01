namespace IngenieriaSoftware.UI
{
    partial class GestionarPermisos
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
            this.btnAsignarPermiso.Location = new System.Drawing.Point(79, 245);
            this.btnAsignarPermiso.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAsignarPermiso.Name = "btnAsignarPermiso";
            this.btnAsignarPermiso.Size = new System.Drawing.Size(201, 86);
            this.btnAsignarPermiso.TabIndex = 14;
            this.btnAsignarPermiso.Text = "Asignar permiso";
            this.btnAsignarPermiso.UseVisualStyleBackColor = true;
            this.btnAsignarPermiso.Click += new System.EventHandler(this.btnAsignarPermiso_Click);
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(62, 126);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(54, 16);
            this.lblUsuario.TabIndex = 13;
            this.lblUsuario.Text = "Usuario";
            // 
            // lblTodosLosPermisos
            // 
            this.lblTodosLosPermisos.AutoSize = true;
            this.lblTodosLosPermisos.Location = new System.Drawing.Point(760, 68);
            this.lblTodosLosPermisos.Name = "lblTodosLosPermisos";
            this.lblTodosLosPermisos.Size = new System.Drawing.Size(127, 16);
            this.lblTodosLosPermisos.TabIndex = 11;
            this.lblTodosLosPermisos.Text = "Todos los permisos";
            // 
            // comboBoxUsuario
            // 
            this.comboBoxUsuario.FormattingEnabled = true;
            this.comboBoxUsuario.Location = new System.Drawing.Point(54, 145);
            this.comboBoxUsuario.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxUsuario.Name = "comboBoxUsuario";
            this.comboBoxUsuario.Size = new System.Drawing.Size(251, 24);
            this.comboBoxUsuario.TabIndex = 8;
            this.comboBoxUsuario.SelectedIndexChanged += new System.EventHandler(this.comboBoxUsuario_SelectedIndexChanged);
            // 
            // treeViewPermisos
            // 
            this.treeViewPermisos.Location = new System.Drawing.Point(763, 98);
            this.treeViewPermisos.Margin = new System.Windows.Forms.Padding(4);
            this.treeViewPermisos.Name = "treeViewPermisos";
            this.treeViewPermisos.Size = new System.Drawing.Size(248, 312);
            this.treeViewPermisos.TabIndex = 18;
            // 
            // treeViewPermisoUsuario
            // 
            this.treeViewPermisoUsuario.Location = new System.Drawing.Point(435, 98);
            this.treeViewPermisoUsuario.Margin = new System.Windows.Forms.Padding(4);
            this.treeViewPermisoUsuario.Name = "treeViewPermisoUsuario";
            this.treeViewPermisoUsuario.Size = new System.Drawing.Size(248, 312);
            this.treeViewPermisoUsuario.TabIndex = 20;
            // 
            // lblPermisosUsuario
            // 
            this.lblPermisosUsuario.AutoSize = true;
            this.lblPermisosUsuario.Location = new System.Drawing.Point(432, 68);
            this.lblPermisosUsuario.Name = "lblPermisosUsuario";
            this.lblPermisosUsuario.Size = new System.Drawing.Size(133, 16);
            this.lblPermisosUsuario.TabIndex = 19;
            this.lblPermisosUsuario.Text = "Permisos del usuario";
            // 
            // btnDesasignarPermiso
            // 
            this.btnDesasignarPermiso.Location = new System.Drawing.Point(79, 350);
            this.btnDesasignarPermiso.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDesasignarPermiso.Name = "btnDesasignarPermiso";
            this.btnDesasignarPermiso.Size = new System.Drawing.Size(201, 86);
            this.btnDesasignarPermiso.TabIndex = 21;
            this.btnDesasignarPermiso.Text = "Desasignar permiso";
            this.btnDesasignarPermiso.UseVisualStyleBackColor = true;
            this.btnDesasignarPermiso.Click += new System.EventHandler(this.btnDesasignarPermiso_Click);
            // 
            // GestionarPermisos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1083, 577);
            this.Controls.Add(this.btnDesasignarPermiso);
            this.Controls.Add(this.treeViewPermisoUsuario);
            this.Controls.Add(this.lblPermisosUsuario);
            this.Controls.Add(this.treeViewPermisos);
            this.Controls.Add(this.btnAsignarPermiso);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.lblTodosLosPermisos);
            this.Controls.Add(this.comboBoxUsuario);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "GestionarPermisos";
            this.Text = "GestionarPermisos";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
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