namespace IngenieriaSoftware.UI.Gestion_Compras_Insumos.Gestion_Inventario
{
    partial class ModalEscasez
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
            this.btnAlertaEscasez = new System.Windows.Forms.Button();
            this.nudCantidadRecomendada = new System.Windows.Forms.NumericUpDown();
            this.lblEscasezProducto = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidadRecomendada)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAlertaEscasez
            // 
            this.btnAlertaEscasez.BackColor = System.Drawing.Color.Orange;
            this.btnAlertaEscasez.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlertaEscasez.ForeColor = System.Drawing.Color.Black;
            this.btnAlertaEscasez.Location = new System.Drawing.Point(351, 211);
            this.btnAlertaEscasez.Margin = new System.Windows.Forms.Padding(2);
            this.btnAlertaEscasez.Name = "btnAlertaEscasez";
            this.btnAlertaEscasez.Size = new System.Drawing.Size(137, 57);
            this.btnAlertaEscasez.TabIndex = 53;
            this.btnAlertaEscasez.Tag = "";
            this.btnAlertaEscasez.Text = "Dar aviso";
            this.btnAlertaEscasez.UseVisualStyleBackColor = false;
            // 
            // nudCantidadRecomendada
            // 
            this.nudCantidadRecomendada.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.nudCantidadRecomendada.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nudCantidadRecomendada.Font = new System.Drawing.Font("Segoe UI Symbol", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudCantidadRecomendada.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.nudCantidadRecomendada.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.nudCantidadRecomendada.Location = new System.Drawing.Point(506, 118);
            this.nudCantidadRecomendada.Margin = new System.Windows.Forms.Padding(0);
            this.nudCantidadRecomendada.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudCantidadRecomendada.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudCantidadRecomendada.Name = "nudCantidadRecomendada";
            this.nudCantidadRecomendada.Size = new System.Drawing.Size(123, 50);
            this.nudCantidadRecomendada.TabIndex = 54;
            this.nudCantidadRecomendada.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblEscasezProducto
            // 
            this.lblEscasezProducto.AutoSize = true;
            this.lblEscasezProducto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblEscasezProducto.Font = new System.Drawing.Font("Segoe UI Symbol", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEscasezProducto.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblEscasezProducto.Location = new System.Drawing.Point(35, 37);
            this.lblEscasezProducto.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEscasezProducto.Name = "lblEscasezProducto";
            this.lblEscasezProducto.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblEscasezProducto.Size = new System.Drawing.Size(503, 37);
            this.lblEscasezProducto.TabIndex = 55;
            this.lblEscasezProducto.Tag = "";
            this.lblEscasezProducto.Text = "Ingrese cantidad recomendada a solicitar";
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Black;
            this.btnCancelar.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnCancelar.Location = new System.Drawing.Point(492, 211);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(137, 57);
            this.btnCancelar.TabIndex = 56;
            this.btnCancelar.Tag = "";
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // ModalEscasez
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(689, 320);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.lblEscasezProducto);
            this.Controls.Add(this.nudCantidadRecomendada);
            this.Controls.Add(this.btnAlertaEscasez);
            this.Name = "ModalEscasez";
            this.Text = "ModalEscasez";
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidadRecomendada)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAlertaEscasez;
        private System.Windows.Forms.NumericUpDown nudCantidadRecomendada;
        private System.Windows.Forms.Label lblEscasezProducto;
        private System.Windows.Forms.Button btnCancelar;
    }
}