namespace IngenieriaSoftware.UI.Gestion_Compras_Insumos.Gestion_Inventario.Categorizar_productos
{
    partial class ModalIngresarCantidadReferencia
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
            this.lblProducto = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lblEscasezProducto = new System.Windows.Forms.Label();
            this.nudCantidad = new System.Windows.Forms.NumericUpDown();
            this.btnAlertaEscasez = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).BeginInit();
            this.SuspendLayout();
            // 
            // lblProducto
            // 
            this.lblProducto.AutoSize = true;
            this.lblProducto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblProducto.Font = new System.Drawing.Font("Segoe UI Symbol", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProducto.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblProducto.Location = new System.Drawing.Point(1, 25);
            this.lblProducto.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblProducto.Name = "lblProducto";
            this.lblProducto.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblProducto.Size = new System.Drawing.Size(0, 37);
            this.lblProducto.TabIndex = 66;
            this.lblProducto.Tag = "";
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Black;
            this.btnCancelar.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnCancelar.Location = new System.Drawing.Point(305, 253);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(137, 57);
            this.btnCancelar.TabIndex = 63;
            this.btnCancelar.Tag = "";
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lblEscasezProducto
            // 
            this.lblEscasezProducto.AutoSize = true;
            this.lblEscasezProducto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblEscasezProducto.Font = new System.Drawing.Font("Segoe UI Symbol", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEscasezProducto.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblEscasezProducto.Location = new System.Drawing.Point(52, 48);
            this.lblEscasezProducto.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEscasezProducto.Name = "lblEscasezProducto";
            this.lblEscasezProducto.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblEscasezProducto.Size = new System.Drawing.Size(397, 37);
            this.lblEscasezProducto.TabIndex = 62;
            this.lblEscasezProducto.Tag = "";
            this.lblEscasezProducto.Text = "Ingrese cantidad que representa";
            // 
            // nudCantidad
            // 
            this.nudCantidad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.nudCantidad.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nudCantidad.Font = new System.Drawing.Font("Segoe UI Symbol", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudCantidad.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.nudCantidad.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.nudCantidad.Location = new System.Drawing.Point(319, 138);
            this.nudCantidad.Margin = new System.Windows.Forms.Padding(0);
            this.nudCantidad.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudCantidad.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudCantidad.Name = "nudCantidad";
            this.nudCantidad.Size = new System.Drawing.Size(123, 50);
            this.nudCantidad.TabIndex = 61;
            this.nudCantidad.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnAlertaEscasez
            // 
            this.btnAlertaEscasez.BackColor = System.Drawing.Color.Orange;
            this.btnAlertaEscasez.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlertaEscasez.ForeColor = System.Drawing.Color.Black;
            this.btnAlertaEscasez.Location = new System.Drawing.Point(164, 253);
            this.btnAlertaEscasez.Margin = new System.Windows.Forms.Padding(2);
            this.btnAlertaEscasez.Name = "btnAlertaEscasez";
            this.btnAlertaEscasez.Size = new System.Drawing.Size(137, 57);
            this.btnAlertaEscasez.TabIndex = 60;
            this.btnAlertaEscasez.Tag = "";
            this.btnAlertaEscasez.Text = "Dar aviso";
            this.btnAlertaEscasez.UseVisualStyleBackColor = false;
            this.btnAlertaEscasez.Click += new System.EventHandler(this.btnAlertaEscasez_Click);
            // 
            // ModalIngresarCantidadReferencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(482, 348);
            this.Controls.Add(this.lblProducto);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.lblEscasezProducto);
            this.Controls.Add(this.nudCantidad);
            this.Controls.Add(this.btnAlertaEscasez);
            this.Name = "ModalIngresarCantidadReferencia";
            this.Text = "ModalIngresarCantidadReferencia";
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblProducto;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lblEscasezProducto;
        private System.Windows.Forms.NumericUpDown nudCantidad;
        private System.Windows.Forms.Button btnAlertaEscasez;
    }
}