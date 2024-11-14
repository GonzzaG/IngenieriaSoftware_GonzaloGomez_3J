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
            this.lblNumMesa = new System.Windows.Forms.Label();
            this.lblCapacidadMaxima = new System.Windows.Forms.Label();
            this.numericUpDownCapacidadMaxima = new System.Windows.Forms.NumericUpDown();
            this.btnGuardarMesa = new System.Windows.Forms.Button();
            this.lblNuevaMesa = new System.Windows.Forms.Label();
            this.lblModificarMesa = new System.Windows.Forms.Label();
            this.numericUpDownNumMesa = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCapacidadMaxima)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNumMesa)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNumMesa
            // 
            this.lblNumMesa.AutoSize = true;
            this.lblNumMesa.Location = new System.Drawing.Point(47, 77);
            this.lblNumMesa.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNumMesa.Name = "lblNumMesa";
            this.lblNumMesa.Size = new System.Drawing.Size(87, 13);
            this.lblNumMesa.TabIndex = 1;
            this.lblNumMesa.Tag = "155";
            this.lblNumMesa.Text = "Numero de mesa";
            // 
            // lblCapacidadMaxima
            // 
            this.lblCapacidadMaxima.AutoSize = true;
            this.lblCapacidadMaxima.Location = new System.Drawing.Point(47, 123);
            this.lblCapacidadMaxima.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCapacidadMaxima.Name = "lblCapacidadMaxima";
            this.lblCapacidadMaxima.Size = new System.Drawing.Size(96, 13);
            this.lblCapacidadMaxima.TabIndex = 3;
            this.lblCapacidadMaxima.Tag = "157";
            this.lblCapacidadMaxima.Text = "Capacidad maxima";
            // 
            // numericUpDownCapacidadMaxima
            // 
            this.numericUpDownCapacidadMaxima.Location = new System.Drawing.Point(50, 139);
            this.numericUpDownCapacidadMaxima.Margin = new System.Windows.Forms.Padding(2);
            this.numericUpDownCapacidadMaxima.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownCapacidadMaxima.Name = "numericUpDownCapacidadMaxima";
            this.numericUpDownCapacidadMaxima.Size = new System.Drawing.Size(73, 20);
            this.numericUpDownCapacidadMaxima.TabIndex = 6;
            this.numericUpDownCapacidadMaxima.Tag = "158";
            this.numericUpDownCapacidadMaxima.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnGuardarMesa
            // 
            this.btnGuardarMesa.Location = new System.Drawing.Point(239, 175);
            this.btnGuardarMesa.Margin = new System.Windows.Forms.Padding(2);
            this.btnGuardarMesa.Name = "btnGuardarMesa";
            this.btnGuardarMesa.Size = new System.Drawing.Size(162, 42);
            this.btnGuardarMesa.TabIndex = 19;
            this.btnGuardarMesa.Tag = "159";
            this.btnGuardarMesa.Text = "Guardar Mesa";
            this.btnGuardarMesa.UseVisualStyleBackColor = true;
            this.btnGuardarMesa.Click += new System.EventHandler(this.btnGuardarMesa_Click);
            // 
            // lblNuevaMesa
            // 
            this.lblNuevaMesa.AutoSize = true;
            this.lblNuevaMesa.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNuevaMesa.Location = new System.Drawing.Point(45, 18);
            this.lblNuevaMesa.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNuevaMesa.Name = "lblNuevaMesa";
            this.lblNuevaMesa.Size = new System.Drawing.Size(144, 26);
            this.lblNuevaMesa.TabIndex = 20;
            this.lblNuevaMesa.Tag = "153";
            this.lblNuevaMesa.Text = "Nueva Mesa";
            // 
            // lblModificarMesa
            // 
            this.lblModificarMesa.AutoSize = true;
            this.lblModificarMesa.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModificarMesa.Location = new System.Drawing.Point(228, 18);
            this.lblModificarMesa.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblModificarMesa.Name = "lblModificarMesa";
            this.lblModificarMesa.Size = new System.Drawing.Size(173, 26);
            this.lblModificarMesa.TabIndex = 21;
            this.lblModificarMesa.Tag = "154";
            this.lblModificarMesa.Text = "Modificar Mesa";
            // 
            // numericUpDownNumMesa
            // 
            this.numericUpDownNumMesa.Location = new System.Drawing.Point(50, 92);
            this.numericUpDownNumMesa.Margin = new System.Windows.Forms.Padding(2);
            this.numericUpDownNumMesa.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownNumMesa.Name = "numericUpDownNumMesa";
            this.numericUpDownNumMesa.Size = new System.Drawing.Size(73, 20);
            this.numericUpDownNumMesa.TabIndex = 22;
            this.numericUpDownNumMesa.Tag = "156";
            this.numericUpDownNumMesa.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // FormNuevaMesa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 252);
            this.Controls.Add(this.numericUpDownNumMesa);
            this.Controls.Add(this.lblModificarMesa);
            this.Controls.Add(this.lblNuevaMesa);
            this.Controls.Add(this.btnGuardarMesa);
            this.Controls.Add(this.numericUpDownCapacidadMaxima);
            this.Controls.Add(this.lblCapacidadMaxima);
            this.Controls.Add(this.lblNumMesa);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormNuevaMesa";
            this.Tag = "160";
            this.Text = "FormNuevaMesa";
            this.Load += new System.EventHandler(this.FormNuevaMesa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCapacidadMaxima)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNumMesa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblNumMesa;
        private System.Windows.Forms.Label lblCapacidadMaxima;
        private System.Windows.Forms.NumericUpDown numericUpDownCapacidadMaxima;
        private System.Windows.Forms.Button btnGuardarMesa;
        private System.Windows.Forms.Label lblNuevaMesa;
        private System.Windows.Forms.Label lblModificarMesa;
        private System.Windows.Forms.NumericUpDown numericUpDownNumMesa;
    }
}