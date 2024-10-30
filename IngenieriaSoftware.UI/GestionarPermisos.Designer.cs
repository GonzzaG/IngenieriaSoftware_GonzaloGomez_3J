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
            this.label1 = new System.Windows.Forms.Label();
            this.lblTotalPermisos = new System.Windows.Forms.Label();
            this.comboBoxUsuario = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxRol = new System.Windows.Forms.ComboBox();
            this.treeViewPermisos = new System.Windows.Forms.TreeView();
            this.treeViewPermisoUsuario = new System.Windows.Forms.TreeView();
            this.lblUsuarioPermisos = new System.Windows.Forms.Label();
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(76, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 16);
            this.label1.TabIndex = 13;
            this.label1.Text = "Usuario";
            // 
            // lblTotalPermisos
            // 
            this.lblTotalPermisos.AutoSize = true;
            this.lblTotalPermisos.Location = new System.Drawing.Point(760, 68);
            this.lblTotalPermisos.Name = "lblTotalPermisos";
            this.lblTotalPermisos.Size = new System.Drawing.Size(127, 16);
            this.lblTotalPermisos.TabIndex = 11;
            this.lblTotalPermisos.Text = "Todos los permisos";
            // 
            // comboBoxUsuario
            // 
            this.comboBoxUsuario.FormattingEnabled = true;
            this.comboBoxUsuario.Location = new System.Drawing.Point(68, 98);
            this.comboBoxUsuario.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxUsuario.Name = "comboBoxUsuario";
            this.comboBoxUsuario.Size = new System.Drawing.Size(251, 24);
            this.comboBoxUsuario.TabIndex = 8;
            this.comboBoxUsuario.SelectedIndexChanged += new System.EventHandler(this.comboBoxUsuario_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(76, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 16);
            this.label2.TabIndex = 16;
            this.label2.Text = "Rol:";
            // 
            // comboBoxRol
            // 
            this.comboBoxRol.FormattingEnabled = true;
            this.comboBoxRol.Location = new System.Drawing.Point(68, 172);
            this.comboBoxRol.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxRol.Name = "comboBoxRol";
            this.comboBoxRol.Size = new System.Drawing.Size(251, 24);
            this.comboBoxRol.TabIndex = 17;
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
            // lblUsuarioPermisos
            // 
            this.lblUsuarioPermisos.AutoSize = true;
            this.lblUsuarioPermisos.Location = new System.Drawing.Point(432, 68);
            this.lblUsuarioPermisos.Name = "lblUsuarioPermisos";
            this.lblUsuarioPermisos.Size = new System.Drawing.Size(133, 16);
            this.lblUsuarioPermisos.TabIndex = 19;
            this.lblUsuarioPermisos.Text = "Permisos del usuario";
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
            this.Controls.Add(this.lblUsuarioPermisos);
            this.Controls.Add(this.treeViewPermisos);
            this.Controls.Add(this.comboBoxRol);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnAsignarPermiso);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTotalPermisos);
            this.Controls.Add(this.comboBoxUsuario);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "GestionarPermisos";
            this.Text = "GestionarPermisos";
            this.Load += new System.EventHandler(this.GestionarPermisos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAsignarPermiso;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTotalPermisos;
        private System.Windows.Forms.ComboBox comboBoxUsuario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxRol;
        private System.Windows.Forms.TreeView treeViewPermisos;
        private System.Windows.Forms.TreeView treeViewPermisoUsuario;
        private System.Windows.Forms.Label lblUsuarioPermisos;
        private System.Windows.Forms.Button btnDesasignarPermiso;
    }
}