namespace IngenieriaSoftware.UI.Gestion_Compras_Insumos.Gestion_Inventario
{
    partial class ModalMerma
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
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lblMerma = new System.Windows.Forms.Label();
            this.nudMerma = new System.Windows.Forms.NumericUpDown();
            this.btnGuardarMerma = new System.Windows.Forms.Button();
            this.lblObservaciones = new System.Windows.Forms.Label();
            this.txtObservaciones = new System.Windows.Forms.TextBox();
            this.lblProducto = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudMerma)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Black;
            this.btnCancelar.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnCancelar.Location = new System.Drawing.Point(489, 389);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(137, 57);
            this.btnCancelar.TabIndex = 60;
            this.btnCancelar.Tag = "";
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lblMerma
            // 
            this.lblMerma.AutoSize = true;
            this.lblMerma.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblMerma.Font = new System.Drawing.Font("Segoe UI Symbol", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMerma.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblMerma.Location = new System.Drawing.Point(45, 43);
            this.lblMerma.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMerma.Name = "lblMerma";
            this.lblMerma.Size = new System.Drawing.Size(346, 37);
            this.lblMerma.TabIndex = 59;
            this.lblMerma.Tag = "";
            this.lblMerma.Text = "Ingrese merma de producto";
            // 
            // nudMerma
            // 
            this.nudMerma.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.nudMerma.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nudMerma.Font = new System.Drawing.Font("Segoe UI Symbol", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudMerma.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.nudMerma.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.nudMerma.Location = new System.Drawing.Point(505, 140);
            this.nudMerma.Margin = new System.Windows.Forms.Padding(0);
            this.nudMerma.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudMerma.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudMerma.Name = "nudMerma";
            this.nudMerma.Size = new System.Drawing.Size(121, 50);
            this.nudMerma.TabIndex = 58;
            this.nudMerma.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnGuardarMerma
            // 
            this.btnGuardarMerma.BackColor = System.Drawing.Color.Maroon;
            this.btnGuardarMerma.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarMerma.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnGuardarMerma.Location = new System.Drawing.Point(348, 389);
            this.btnGuardarMerma.Margin = new System.Windows.Forms.Padding(2);
            this.btnGuardarMerma.Name = "btnGuardarMerma";
            this.btnGuardarMerma.Size = new System.Drawing.Size(137, 57);
            this.btnGuardarMerma.TabIndex = 57;
            this.btnGuardarMerma.Tag = "";
            this.btnGuardarMerma.Text = "Guardar";
            this.btnGuardarMerma.UseVisualStyleBackColor = false;
            this.btnGuardarMerma.Click += new System.EventHandler(this.btnGuardarMerma_Click);
            // 
            // lblObservaciones
            // 
            this.lblObservaciones.AutoSize = true;
            this.lblObservaciones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblObservaciones.Font = new System.Drawing.Font("Segoe UI Symbol", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblObservaciones.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblObservaciones.Location = new System.Drawing.Point(491, 209);
            this.lblObservaciones.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblObservaciones.Name = "lblObservaciones";
            this.lblObservaciones.Size = new System.Drawing.Size(135, 25);
            this.lblObservaciones.TabIndex = 62;
            this.lblObservaciones.Tag = "";
            this.lblObservaciones.Text = "Observaciones";
            // 
            // txtObservaciones
            // 
            this.txtObservaciones.Location = new System.Drawing.Point(285, 237);
            this.txtObservaciones.Multiline = true;
            this.txtObservaciones.Name = "txtObservaciones";
            this.txtObservaciones.Size = new System.Drawing.Size(341, 103);
            this.txtObservaciones.TabIndex = 61;
            // 
            // lblProducto
            // 
            this.lblProducto.AutoSize = true;
            this.lblProducto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblProducto.Font = new System.Drawing.Font("Segoe UI Symbol", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProducto.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblProducto.Location = new System.Drawing.Point(52, 90);
            this.lblProducto.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblProducto.Name = "lblProducto";
            this.lblProducto.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblProducto.Size = new System.Drawing.Size(0, 37);
            this.lblProducto.TabIndex = 63;
            this.lblProducto.Tag = "";
            // 
            // ModalMerma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(689, 493);
            this.Controls.Add(this.lblProducto);
            this.Controls.Add(this.lblObservaciones);
            this.Controls.Add(this.txtObservaciones);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.lblMerma);
            this.Controls.Add(this.nudMerma);
            this.Controls.Add(this.btnGuardarMerma);
            this.Name = "ModalMerma";
            this.Text = "ModalMerma";
            ((System.ComponentModel.ISupportInitialize)(this.nudMerma)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lblMerma;
        private System.Windows.Forms.NumericUpDown nudMerma;
        private System.Windows.Forms.Button btnGuardarMerma;
        private System.Windows.Forms.Label lblObservaciones;
        private System.Windows.Forms.TextBox txtObservaciones;
        private System.Windows.Forms.Label lblProducto;
    }
}