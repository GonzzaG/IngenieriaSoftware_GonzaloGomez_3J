namespace IngenieriaSoftware.UI
{
    partial class FormNuevaMesa
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
            this.txtNumMesa = new System.Windows.Forms.TextBox();
            this.lblNumMesa = new System.Windows.Forms.Label();
            this.lblCapacidadMaxima = new System.Windows.Forms.Label();
            this.numericUpDownCapacidadMaxima = new System.Windows.Forms.NumericUpDown();
            this.btnGuardarMesa = new System.Windows.Forms.Button();
            this.lblNuevaMesa = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCapacidadMaxima)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNumMesa
            // 
            this.txtNumMesa.Location = new System.Drawing.Point(82, 110);
            this.txtNumMesa.Name = "txtNumMesa";
            this.txtNumMesa.Size = new System.Drawing.Size(197, 22);
            this.txtNumMesa.TabIndex = 0;
            // 
            // lblNumMesa
            // 
            this.lblNumMesa.AutoSize = true;
            this.lblNumMesa.Location = new System.Drawing.Point(79, 91);
            this.lblNumMesa.Name = "lblNumMesa";
            this.lblNumMesa.Size = new System.Drawing.Size(111, 16);
            this.lblNumMesa.TabIndex = 1;
            this.lblNumMesa.Text = "Numero de mesa";
            // 
            // lblCapacidadMaxima
            // 
            this.lblCapacidadMaxima.AutoSize = true;
            this.lblCapacidadMaxima.Location = new System.Drawing.Point(79, 148);
            this.lblCapacidadMaxima.Name = "lblCapacidadMaxima";
            this.lblCapacidadMaxima.Size = new System.Drawing.Size(124, 16);
            this.lblCapacidadMaxima.TabIndex = 3;
            this.lblCapacidadMaxima.Text = "Capacidad maxima";
            // 
            // numericUpDownCapacidadMaxima
            // 
            this.numericUpDownCapacidadMaxima.Location = new System.Drawing.Point(82, 167);
            this.numericUpDownCapacidadMaxima.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownCapacidadMaxima.Name = "numericUpDownCapacidadMaxima";
            this.numericUpDownCapacidadMaxima.Size = new System.Drawing.Size(97, 22);
            this.numericUpDownCapacidadMaxima.TabIndex = 6;
            this.numericUpDownCapacidadMaxima.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnGuardarMesa
            // 
            this.btnGuardarMesa.Location = new System.Drawing.Point(319, 204);
            this.btnGuardarMesa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGuardarMesa.Name = "btnGuardarMesa";
            this.btnGuardarMesa.Size = new System.Drawing.Size(216, 55);
            this.btnGuardarMesa.TabIndex = 19;
            this.btnGuardarMesa.Tag = "79";
            this.btnGuardarMesa.Text = "Guardar Mesa";
            this.btnGuardarMesa.UseVisualStyleBackColor = true;
            this.btnGuardarMesa.Click += new System.EventHandler(this.btnGuardarMesa_Click);
            // 
            // lblNuevaMesa
            // 
            this.lblNuevaMesa.AutoSize = true;
            this.lblNuevaMesa.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNuevaMesa.Location = new System.Drawing.Point(77, 22);
            this.lblNuevaMesa.Name = "lblNuevaMesa";
            this.lblNuevaMesa.Size = new System.Drawing.Size(109, 40);
            this.lblNuevaMesa.TabIndex = 20;
            this.lblNuevaMesa.Tag = "77";
            this.lblNuevaMesa.Text = "Mesa";
            // 
            // FormNuevaMesa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(577, 310);
            this.Controls.Add(this.lblNuevaMesa);
            this.Controls.Add(this.btnGuardarMesa);
            this.Controls.Add(this.numericUpDownCapacidadMaxima);
            this.Controls.Add(this.lblCapacidadMaxima);
            this.Controls.Add(this.lblNumMesa);
            this.Controls.Add(this.txtNumMesa);
            this.Name = "FormNuevaMesa";
            this.Text = "FormNuevaMesa";
            this.Load += new System.EventHandler(this.FormNuevaMesa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCapacidadMaxima)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNumMesa;
        private System.Windows.Forms.Label lblNumMesa;
        private System.Windows.Forms.Label lblCapacidadMaxima;
        private System.Windows.Forms.NumericUpDown numericUpDownCapacidadMaxima;
        private System.Windows.Forms.Button btnGuardarMesa;
        private System.Windows.Forms.Label lblNuevaMesa;
    }
}