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
            this.lblNumMesa.BackColor = System.Drawing.Color.DarkSlateGray;
            this.lblNumMesa.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumMesa.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblNumMesa.Location = new System.Drawing.Point(64, 176);
            this.lblNumMesa.Name = "lblNumMesa";
            this.lblNumMesa.Size = new System.Drawing.Size(161, 28);
            this.lblNumMesa.TabIndex = 1;
            this.lblNumMesa.Tag = "155";
            this.lblNumMesa.Text = "Numero de mesa";
            this.lblNumMesa.Visible = false;
            // 
            // lblCapacidadMaxima
            // 
            this.lblCapacidadMaxima.AutoSize = true;
            this.lblCapacidadMaxima.BackColor = System.Drawing.Color.DarkSlateGray;
            this.lblCapacidadMaxima.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCapacidadMaxima.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblCapacidadMaxima.Location = new System.Drawing.Point(63, 87);
            this.lblCapacidadMaxima.Name = "lblCapacidadMaxima";
            this.lblCapacidadMaxima.Size = new System.Drawing.Size(177, 28);
            this.lblCapacidadMaxima.TabIndex = 3;
            this.lblCapacidadMaxima.Tag = "157";
            this.lblCapacidadMaxima.Text = "Capacidad maxima";
            // 
            // numericUpDownCapacidadMaxima
            // 
            this.numericUpDownCapacidadMaxima.BackColor = System.Drawing.Color.Teal;
            this.numericUpDownCapacidadMaxima.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownCapacidadMaxima.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.numericUpDownCapacidadMaxima.Location = new System.Drawing.Point(66, 117);
            this.numericUpDownCapacidadMaxima.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numericUpDownCapacidadMaxima.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownCapacidadMaxima.Name = "numericUpDownCapacidadMaxima";
            this.numericUpDownCapacidadMaxima.Size = new System.Drawing.Size(97, 34);
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
            this.btnGuardarMesa.BackColor = System.Drawing.Color.Teal;
            this.btnGuardarMesa.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarMesa.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnGuardarMesa.Location = new System.Drawing.Point(317, 196);
            this.btnGuardarMesa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGuardarMesa.Name = "btnGuardarMesa";
            this.btnGuardarMesa.Size = new System.Drawing.Size(216, 52);
            this.btnGuardarMesa.TabIndex = 19;
            this.btnGuardarMesa.Tag = "159";
            this.btnGuardarMesa.Text = "Guardar Mesa";
            this.btnGuardarMesa.UseVisualStyleBackColor = false;
            this.btnGuardarMesa.Click += new System.EventHandler(this.btnGuardarMesa_Click);
            // 
            // lblNuevaMesa
            // 
            this.lblNuevaMesa.AutoSize = true;
            this.lblNuevaMesa.BackColor = System.Drawing.Color.DarkSlateGray;
            this.lblNuevaMesa.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNuevaMesa.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblNuevaMesa.Location = new System.Drawing.Point(60, 22);
            this.lblNuevaMesa.Name = "lblNuevaMesa";
            this.lblNuevaMesa.Size = new System.Drawing.Size(182, 32);
            this.lblNuevaMesa.TabIndex = 20;
            this.lblNuevaMesa.Tag = "153";
            this.lblNuevaMesa.Text = "Nueva Mesa";
            // 
            // lblModificarMesa
            // 
            this.lblModificarMesa.AutoSize = true;
            this.lblModificarMesa.BackColor = System.Drawing.Color.DarkSlateGray;
            this.lblModificarMesa.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModificarMesa.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblModificarMesa.Location = new System.Drawing.Point(313, 22);
            this.lblModificarMesa.Name = "lblModificarMesa";
            this.lblModificarMesa.Size = new System.Drawing.Size(220, 32);
            this.lblModificarMesa.TabIndex = 21;
            this.lblModificarMesa.Tag = "154";
            this.lblModificarMesa.Text = "Modificar Mesa";
            // 
            // numericUpDownNumMesa
            // 
            this.numericUpDownNumMesa.BackColor = System.Drawing.Color.Teal;
            this.numericUpDownNumMesa.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownNumMesa.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.numericUpDownNumMesa.Location = new System.Drawing.Point(68, 206);
            this.numericUpDownNumMesa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numericUpDownNumMesa.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownNumMesa.Name = "numericUpDownNumMesa";
            this.numericUpDownNumMesa.Size = new System.Drawing.Size(97, 34);
            this.numericUpDownNumMesa.TabIndex = 22;
            this.numericUpDownNumMesa.Tag = "156";
            this.numericUpDownNumMesa.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownNumMesa.Visible = false;
            // 
            // FormNuevaMesa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(682, 307);
            this.Controls.Add(this.numericUpDownNumMesa);
            this.Controls.Add(this.lblModificarMesa);
            this.Controls.Add(this.lblNuevaMesa);
            this.Controls.Add(this.btnGuardarMesa);
            this.Controls.Add(this.numericUpDownCapacidadMaxima);
            this.Controls.Add(this.lblCapacidadMaxima);
            this.Controls.Add(this.lblNumMesa);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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