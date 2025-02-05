namespace IngenieriaSoftware.UI
{
    partial class FormInicioSesion
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
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.lblContrasena = new System.Windows.Forms.Label();
            this.txtContrasena = new System.Windows.Forms.TextBox();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.flowLayoutPanel1.SetFlowBreak(this.lblUsuario, true);
            this.lblUsuario.Font = new System.Drawing.Font("Segoe UI Symbol", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.Location = new System.Drawing.Point(10, 8);
            this.lblUsuario.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(81, 25);
            this.lblUsuario.TabIndex = 3;
            this.lblUsuario.Tag = "16";
            this.lblUsuario.Text = "Usuario:";
            // 
            // txtUsuario
            // 
            this.flowLayoutPanel1.SetFlowBreak(this.txtUsuario, true);
            this.txtUsuario.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.Location = new System.Drawing.Point(10, 43);
            this.txtUsuario.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(204, 29);
            this.txtUsuario.TabIndex = 0;
            this.txtUsuario.Tag = "17";
            // 
            // lblContrasena
            // 
            this.lblContrasena.AutoSize = true;
            this.flowLayoutPanel1.SetFlowBreak(this.lblContrasena, true);
            this.lblContrasena.Font = new System.Drawing.Font("Segoe UI Symbol", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContrasena.Location = new System.Drawing.Point(10, 74);
            this.lblContrasena.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblContrasena.Name = "lblContrasena";
            this.lblContrasena.Size = new System.Drawing.Size(112, 25);
            this.lblContrasena.TabIndex = 4;
            this.lblContrasena.Tag = "18";
            this.lblContrasena.Text = "Contrasena:";
            // 
            // txtContrasena
            // 
            this.flowLayoutPanel1.SetFlowBreak(this.txtContrasena, true);
            this.txtContrasena.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContrasena.Location = new System.Drawing.Point(10, 109);
            this.txtContrasena.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtContrasena.Name = "txtContrasena";
            this.txtContrasena.Size = new System.Drawing.Size(204, 29);
            this.txtContrasena.TabIndex = 5;
            this.txtContrasena.Tag = "19";
            // 
            // btnIngresar
            // 
            this.btnIngresar.BackColor = System.Drawing.Color.Teal;
            this.flowLayoutPanel1.SetFlowBreak(this.btnIngresar, true);
            this.btnIngresar.Font = new System.Drawing.Font("Segoe UI Symbol", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIngresar.Location = new System.Drawing.Point(10, 183);
            this.btnIngresar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(151, 70);
            this.btnIngresar.TabIndex = 2;
            this.btnIngresar.Tag = "20";
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.UseVisualStyleBackColor = false;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.flowLayoutPanel1.Controls.Add(this.lblUsuario);
            this.flowLayoutPanel1.Controls.Add(this.txtUsuario);
            this.flowLayoutPanel1.Controls.Add(this.lblContrasena);
            this.flowLayoutPanel1.Controls.Add(this.txtContrasena);
            this.flowLayoutPanel1.Controls.Add(this.btnIngresar);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.flowLayoutPanel1.ImeMode = System.Windows.Forms.ImeMode.On;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(982, 280);
            this.flowLayoutPanel1.TabIndex = 8;
            // 
            // FormInicioSesion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(982, 687);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Location = new System.Drawing.Point(20, 0);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormInicioSesion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Tag = "15";
            this.Text = "Inicio";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Inicio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label lblContrasena;
        private System.Windows.Forms.TextBox txtContrasena;
        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}

