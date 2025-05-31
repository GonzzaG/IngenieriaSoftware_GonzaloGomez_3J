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
            this.lblPermisosUsuario = new System.Windows.Forms.Label();
            this.btnDesasignarPermiso = new System.Windows.Forms.Button();
            this.treeViewPermisoUsuario = new System.Windows.Forms.TreeView();
            this.treeViewPermisos = new System.Windows.Forms.TreeView();
            this.SuspendLayout();
            // 
            // btnAsignarPermiso
            // 
            this.btnAsignarPermiso.BackColor = System.Drawing.Color.Teal;
            this.btnAsignarPermiso.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAsignarPermiso.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnAsignarPermiso.Location = new System.Drawing.Point(79, 247);
            this.btnAsignarPermiso.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAsignarPermiso.Name = "btnAsignarPermiso";
            this.btnAsignarPermiso.Size = new System.Drawing.Size(201, 86);
            this.btnAsignarPermiso.TabIndex = 14;
            this.btnAsignarPermiso.Tag = "32";
            this.btnAsignarPermiso.Text = "Asignar permiso";
            this.btnAsignarPermiso.UseVisualStyleBackColor = false;
            this.btnAsignarPermiso.Click += new System.EventHandler(this.btnAsignarPermiso_Click);
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.BackColor = System.Drawing.Color.DarkSlateGray;
            this.lblUsuario.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblUsuario.Location = new System.Drawing.Point(48, 112);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(79, 28);
            this.lblUsuario.TabIndex = 13;
            this.lblUsuario.Tag = "30";
            this.lblUsuario.Text = "Usuario";
            // 
            // lblTodosLosPermisos
            // 
            this.lblTodosLosPermisos.AutoSize = true;
            this.lblTodosLosPermisos.BackColor = System.Drawing.Color.DarkSlateGray;
            this.lblTodosLosPermisos.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTodosLosPermisos.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblTodosLosPermisos.Location = new System.Drawing.Point(897, 68);
            this.lblTodosLosPermisos.Name = "lblTodosLosPermisos";
            this.lblTodosLosPermisos.Size = new System.Drawing.Size(180, 28);
            this.lblTodosLosPermisos.TabIndex = 11;
            this.lblTodosLosPermisos.Tag = "36";
            this.lblTodosLosPermisos.Text = "Todos los permisos";
            // 
            // comboBoxUsuario
            // 
            this.comboBoxUsuario.BackColor = System.Drawing.Color.Teal;
            this.comboBoxUsuario.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxUsuario.FormattingEnabled = true;
            this.comboBoxUsuario.Location = new System.Drawing.Point(53, 145);
            this.comboBoxUsuario.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBoxUsuario.Name = "comboBoxUsuario";
            this.comboBoxUsuario.Size = new System.Drawing.Size(251, 36);
            this.comboBoxUsuario.TabIndex = 8;
            this.comboBoxUsuario.Tag = "31";
            this.comboBoxUsuario.SelectedIndexChanged += new System.EventHandler(this.comboBoxUsuario_SelectedIndexChanged);
            // 
            // lblPermisosUsuario
            // 
            this.lblPermisosUsuario.AutoSize = true;
            this.lblPermisosUsuario.BackColor = System.Drawing.Color.DarkSlateGray;
            this.lblPermisosUsuario.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPermisosUsuario.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblPermisosUsuario.Location = new System.Drawing.Point(432, 68);
            this.lblPermisosUsuario.Name = "lblPermisosUsuario";
            this.lblPermisosUsuario.Size = new System.Drawing.Size(191, 28);
            this.lblPermisosUsuario.TabIndex = 19;
            this.lblPermisosUsuario.Tag = "34";
            this.lblPermisosUsuario.Text = "Permisos del usuario";
            // 
            // btnDesasignarPermiso
            // 
            this.btnDesasignarPermiso.BackColor = System.Drawing.Color.Sienna;
            this.btnDesasignarPermiso.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDesasignarPermiso.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnDesasignarPermiso.Location = new System.Drawing.Point(79, 350);
            this.btnDesasignarPermiso.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDesasignarPermiso.Name = "btnDesasignarPermiso";
            this.btnDesasignarPermiso.Size = new System.Drawing.Size(201, 86);
            this.btnDesasignarPermiso.TabIndex = 21;
            this.btnDesasignarPermiso.Tag = "33";
            this.btnDesasignarPermiso.Text = "Desasignar permiso";
            this.btnDesasignarPermiso.UseVisualStyleBackColor = false;
            this.btnDesasignarPermiso.Click += new System.EventHandler(this.btnDesasignarPermiso_Click);
            // 
            // treeViewPermisoUsuario
            // 
            this.treeViewPermisoUsuario.BackColor = System.Drawing.Color.Teal;
            this.treeViewPermisoUsuario.Location = new System.Drawing.Point(435, 112);
            this.treeViewPermisoUsuario.Margin = new System.Windows.Forms.Padding(4);
            this.treeViewPermisoUsuario.Name = "treeViewPermisoUsuario";
            this.treeViewPermisoUsuario.Size = new System.Drawing.Size(379, 386);
            this.treeViewPermisoUsuario.TabIndex = 46;
            this.treeViewPermisoUsuario.Tag = "804";
            // 
            // treeViewPermisos
            // 
            this.treeViewPermisos.BackColor = System.Drawing.Color.Teal;
            this.treeViewPermisos.Location = new System.Drawing.Point(900, 112);
            this.treeViewPermisos.Margin = new System.Windows.Forms.Padding(4);
            this.treeViewPermisos.Name = "treeViewPermisos";
            this.treeViewPermisos.Size = new System.Drawing.Size(379, 386);
            this.treeViewPermisos.TabIndex = 47;
            this.treeViewPermisos.Tag = "804";
            // 
            // FormGestionarPermisos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(1541, 672);
            this.Controls.Add(this.treeViewPermisos);
            this.Controls.Add(this.treeViewPermisoUsuario);
            this.Controls.Add(this.btnDesasignarPermiso);
            this.Controls.Add(this.lblPermisosUsuario);
            this.Controls.Add(this.btnAsignarPermiso);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.lblTodosLosPermisos);
            this.Controls.Add(this.comboBoxUsuario);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
        private System.Windows.Forms.Label lblPermisosUsuario;
        private System.Windows.Forms.Button btnDesasignarPermiso;
        private System.Windows.Forms.TreeView treeViewPermisoUsuario;
        private System.Windows.Forms.TreeView treeViewPermisos;
    }
}