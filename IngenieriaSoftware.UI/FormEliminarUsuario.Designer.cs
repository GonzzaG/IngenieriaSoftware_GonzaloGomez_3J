namespace IngenieriaSoftware.UI
{
    partial class FormEliminarUsuario
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
            this.btnEliminarUsuario = new System.Windows.Forms.Button();
            this.lblUsuarios = new System.Windows.Forms.Label();
            this.comboBoxUsuarios = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnEliminarUsuario
            // 
            this.btnEliminarUsuario.Location = new System.Drawing.Point(127, 129);
            this.btnEliminarUsuario.Margin = new System.Windows.Forms.Padding(2);
            this.btnEliminarUsuario.Name = "btnEliminarUsuario";
            this.btnEliminarUsuario.Size = new System.Drawing.Size(120, 32);
            this.btnEliminarUsuario.TabIndex = 11;
            this.btnEliminarUsuario.Tag = "40";
            this.btnEliminarUsuario.Text = "Eliminar usuario";
            this.btnEliminarUsuario.UseVisualStyleBackColor = true;
            this.btnEliminarUsuario.Click += new System.EventHandler(this.btnEliminarUsuario_Click);
            // 
            // lblUsuarios
            // 
            this.lblUsuarios.AutoSize = true;
            this.lblUsuarios.Location = new System.Drawing.Point(110, 39);
            this.lblUsuarios.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUsuarios.Name = "lblUsuarios";
            this.lblUsuarios.Size = new System.Drawing.Size(48, 13);
            this.lblUsuarios.TabIndex = 10;
            this.lblUsuarios.Tag = "38";
            this.lblUsuarios.Text = "Usuarios";
            // 
            // comboBoxUsuarios
            // 
            this.comboBoxUsuarios.FormattingEnabled = true;
            this.comboBoxUsuarios.Location = new System.Drawing.Point(102, 54);
            this.comboBoxUsuarios.Name = "comboBoxUsuarios";
            this.comboBoxUsuarios.Size = new System.Drawing.Size(189, 21);
            this.comboBoxUsuarios.TabIndex = 9;
            this.comboBoxUsuarios.Tag = "37";
            this.comboBoxUsuarios.SelectedIndexChanged += new System.EventHandler(this.comboBoxUsuarios_SelectedIndexChanged);
            // 
            // FormEliminarUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 241);
            this.Controls.Add(this.btnEliminarUsuario);
            this.Controls.Add(this.lblUsuarios);
            this.Controls.Add(this.comboBoxUsuarios);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormEliminarUsuario";
            this.Tag = "39";
            this.Text = "EliminarUsuario";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.EliminarUsuario_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEliminarUsuario;
        private System.Windows.Forms.Label lblUsuarios;
        private System.Windows.Forms.ComboBox comboBoxUsuarios;
    }
}