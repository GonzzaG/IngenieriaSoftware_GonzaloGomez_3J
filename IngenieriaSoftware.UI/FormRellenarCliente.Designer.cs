namespace IngenieriaSoftware.UI
{
    partial class FormRellenarCliente
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
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtBancoEmisor = new System.Windows.Forms.TextBox();
            this.lblBancoEmisor = new System.Windows.Forms.Label();
            this.lblTipoTarjeta = new System.Windows.Forms.Label();
            this.lblNumeroTarjeta = new System.Windows.Forms.Label();
            this.txtNumeroTarjeta = new System.Windows.Forms.TextBox();
            this.txtTipoTarjeta = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Location = new System.Drawing.Point(251, 316);
            this.btnConfirmar.Margin = new System.Windows.Forms.Padding(2);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(151, 70);
            this.btnConfirmar.TabIndex = 14;
            this.btnConfirmar.Tag = "28";
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Location = new System.Drawing.Point(92, 164);
            this.lblDireccion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(52, 13);
            this.lblDireccion.TabIndex = 13;
            this.lblDireccion.Tag = "26";
            this.lblDireccion.Text = "Direccion";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(102, 114);
            this.lblApellido.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(44, 13);
            this.lblApellido.TabIndex = 12;
            this.lblApellido.Tag = "24";
            this.lblApellido.Text = "Apellido";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(102, 60);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 11;
            this.lblNombre.Tag = "22";
            this.lblNombre.Text = "Nombre";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(95, 74);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(2);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(189, 20);
            this.txtNombre.TabIndex = 10;
            this.txtNombre.Tag = "23";
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(95, 130);
            this.txtApellido.Margin = new System.Windows.Forms.Padding(2);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(189, 20);
            this.txtApellido.TabIndex = 9;
            this.txtApellido.Tag = "25";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(411, 114);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 18;
            this.label1.Tag = "24";
            this.label1.Text = "Telefono";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(411, 60);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(32, 13);
            this.lblEmail.TabIndex = 17;
            this.lblEmail.Tag = "22";
            this.lblEmail.Text = "Email";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(404, 74);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(2);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(189, 20);
            this.txtEmail.TabIndex = 16;
            this.txtEmail.Tag = "23";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(404, 130);
            this.txtTelefono.Margin = new System.Windows.Forms.Padding(2);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(189, 20);
            this.txtTelefono.TabIndex = 15;
            this.txtTelefono.Tag = "25";
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(95, 179);
            this.txtDireccion.Margin = new System.Windows.Forms.Padding(2);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(189, 20);
            this.txtDireccion.TabIndex = 19;
            this.txtDireccion.Tag = "25";
            // 
            // txtBancoEmisor
            // 
            this.txtBancoEmisor.Location = new System.Drawing.Point(404, 233);
            this.txtBancoEmisor.Margin = new System.Windows.Forms.Padding(2);
            this.txtBancoEmisor.Name = "txtBancoEmisor";
            this.txtBancoEmisor.Size = new System.Drawing.Size(189, 20);
            this.txtBancoEmisor.TabIndex = 25;
            this.txtBancoEmisor.Tag = "25";
            // 
            // lblBancoEmisor
            // 
            this.lblBancoEmisor.AutoSize = true;
            this.lblBancoEmisor.BackColor = System.Drawing.SystemColors.Control;
            this.lblBancoEmisor.Location = new System.Drawing.Point(401, 218);
            this.lblBancoEmisor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBancoEmisor.Name = "lblBancoEmisor";
            this.lblBancoEmisor.Size = new System.Drawing.Size(71, 13);
            this.lblBancoEmisor.TabIndex = 24;
            this.lblBancoEmisor.Tag = "26";
            this.lblBancoEmisor.Text = "Banco emisor";
            // 
            // lblTipoTarjeta
            // 
            this.lblTipoTarjeta.AutoSize = true;
            this.lblTipoTarjeta.Location = new System.Drawing.Point(411, 163);
            this.lblTipoTarjeta.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTipoTarjeta.Name = "lblTipoTarjeta";
            this.lblTipoTarjeta.Size = new System.Drawing.Size(61, 13);
            this.lblTipoTarjeta.TabIndex = 23;
            this.lblTipoTarjeta.Tag = "24";
            this.lblTipoTarjeta.Text = "TipoTarjeta";
            // 
            // lblNumeroTarjeta
            // 
            this.lblNumeroTarjeta.AutoSize = true;
            this.lblNumeroTarjeta.Location = new System.Drawing.Point(92, 218);
            this.lblNumeroTarjeta.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNumeroTarjeta.Name = "lblNumeroTarjeta";
            this.lblNumeroTarjeta.Size = new System.Drawing.Size(83, 13);
            this.lblNumeroTarjeta.TabIndex = 22;
            this.lblNumeroTarjeta.Tag = "22";
            this.lblNumeroTarjeta.Text = "Numero Tarjeta ";
            // 
            // txtNumeroTarjeta
            // 
            this.txtNumeroTarjeta.Location = new System.Drawing.Point(95, 239);
            this.txtNumeroTarjeta.Margin = new System.Windows.Forms.Padding(2);
            this.txtNumeroTarjeta.Name = "txtNumeroTarjeta";
            this.txtNumeroTarjeta.Size = new System.Drawing.Size(189, 20);
            this.txtNumeroTarjeta.TabIndex = 21;
            this.txtNumeroTarjeta.Tag = "23";
            // 
            // txtTipoTarjeta
            // 
            this.txtTipoTarjeta.Location = new System.Drawing.Point(404, 179);
            this.txtTipoTarjeta.Margin = new System.Windows.Forms.Padding(2);
            this.txtTipoTarjeta.Name = "txtTipoTarjeta";
            this.txtTipoTarjeta.Size = new System.Drawing.Size(189, 20);
            this.txtTipoTarjeta.TabIndex = 20;
            this.txtTipoTarjeta.Tag = "25";
            // 
            // FormRellenarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 434);
            this.Controls.Add(this.txtBancoEmisor);
            this.Controls.Add(this.lblBancoEmisor);
            this.Controls.Add(this.lblTipoTarjeta);
            this.Controls.Add(this.lblNumeroTarjeta);
            this.Controls.Add(this.txtNumeroTarjeta);
            this.Controls.Add(this.txtTipoTarjeta);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.lblDireccion);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtApellido);
            this.Name = "FormRellenarCliente";
            this.Text = "FormRellenarCliente";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.TextBox txtBancoEmisor;
        private System.Windows.Forms.Label lblBancoEmisor;
        private System.Windows.Forms.Label lblTipoTarjeta;
        private System.Windows.Forms.Label lblNumeroTarjeta;
        private System.Windows.Forms.TextBox txtNumeroTarjeta;
        private System.Windows.Forms.TextBox txtTipoTarjeta;
    }
}