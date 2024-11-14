namespace IngenieriaSoftware.UI
{
    partial class FormSeleccionMedioDePago
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
            this.btnSeleccionarMedioDePago = new System.Windows.Forms.Button();
            this.lblSeleccioneMedioDePago = new System.Windows.Forms.Label();
            this.dataGridViewMediosDePago = new System.Windows.Forms.DataGridView();
            this.numericUpDownPropina = new System.Windows.Forms.NumericUpDown();
            this.lblPropina = new System.Windows.Forms.Label();
            this.numericUpDownDescuento = new System.Windows.Forms.NumericUpDown();
            this.lblPorcentajeDescuento = new System.Windows.Forms.Label();
            this.lblPorcentaje = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMediosDePago)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPropina)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDescuento)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSeleccionarMedioDePago
            // 
            this.btnSeleccionarMedioDePago.Location = new System.Drawing.Point(508, 234);
            this.btnSeleccionarMedioDePago.Margin = new System.Windows.Forms.Padding(2);
            this.btnSeleccionarMedioDePago.Name = "btnSeleccionarMedioDePago";
            this.btnSeleccionarMedioDePago.Size = new System.Drawing.Size(162, 45);
            this.btnSeleccionarMedioDePago.TabIndex = 17;
            this.btnSeleccionarMedioDePago.Tag = "72";
            this.btnSeleccionarMedioDePago.Text = "Seleccionar";
            this.btnSeleccionarMedioDePago.UseVisualStyleBackColor = true;
            this.btnSeleccionarMedioDePago.Click += new System.EventHandler(this.btnSeleccionarMedioDePago_Click);
            // 
            // lblSeleccioneMedioDePago
            // 
            this.lblSeleccioneMedioDePago.AutoSize = true;
            this.lblSeleccioneMedioDePago.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSeleccioneMedioDePago.Location = new System.Drawing.Point(35, 41);
            this.lblSeleccioneMedioDePago.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSeleccioneMedioDePago.Name = "lblSeleccioneMedioDePago";
            this.lblSeleccioneMedioDePago.Size = new System.Drawing.Size(293, 26);
            this.lblSeleccioneMedioDePago.TabIndex = 16;
            this.lblSeleccioneMedioDePago.Tag = "70";
            this.lblSeleccioneMedioDePago.Text = "Seleccione medio de pago";
            // 
            // dataGridViewMediosDePago
            // 
            this.dataGridViewMediosDePago.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMediosDePago.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridViewMediosDePago.Location = new System.Drawing.Point(40, 70);
            this.dataGridViewMediosDePago.MultiSelect = false;
            this.dataGridViewMediosDePago.Name = "dataGridViewMediosDePago";
            this.dataGridViewMediosDePago.RowHeadersVisible = false;
            this.dataGridViewMediosDePago.RowHeadersWidth = 51;
            this.dataGridViewMediosDePago.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridViewMediosDePago.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewMediosDePago.Size = new System.Drawing.Size(417, 240);
            this.dataGridViewMediosDePago.TabIndex = 15;
            this.dataGridViewMediosDePago.Tag = "71";
            // 
            // numericUpDownPropina
            // 
            this.numericUpDownPropina.Location = new System.Drawing.Point(508, 99);
            this.numericUpDownPropina.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numericUpDownPropina.Name = "numericUpDownPropina";
            this.numericUpDownPropina.Size = new System.Drawing.Size(75, 20);
            this.numericUpDownPropina.TabIndex = 18;
            // 
            // lblPropina
            // 
            this.lblPropina.AutoSize = true;
            this.lblPropina.Location = new System.Drawing.Point(505, 83);
            this.lblPropina.Name = "lblPropina";
            this.lblPropina.Size = new System.Drawing.Size(43, 13);
            this.lblPropina.TabIndex = 19;
            this.lblPropina.Text = "Propina";
            // 
            // numericUpDownDescuento
            // 
            this.numericUpDownDescuento.Location = new System.Drawing.Point(508, 154);
            this.numericUpDownDescuento.Name = "numericUpDownDescuento";
            this.numericUpDownDescuento.Size = new System.Drawing.Size(75, 20);
            this.numericUpDownDescuento.TabIndex = 18;
            // 
            // lblPorcentajeDescuento
            // 
            this.lblPorcentajeDescuento.AutoSize = true;
            this.lblPorcentajeDescuento.Location = new System.Drawing.Point(505, 138);
            this.lblPorcentajeDescuento.Name = "lblPorcentajeDescuento";
            this.lblPorcentajeDescuento.Size = new System.Drawing.Size(59, 13);
            this.lblPorcentajeDescuento.TabIndex = 19;
            this.lblPorcentajeDescuento.Text = "Descuento";
            // 
            // lblPorcentaje
            // 
            this.lblPorcentaje.AutoSize = true;
            this.lblPorcentaje.Location = new System.Drawing.Point(589, 159);
            this.lblPorcentaje.Name = "lblPorcentaje";
            this.lblPorcentaje.Size = new System.Drawing.Size(15, 13);
            this.lblPorcentaje.TabIndex = 20;
            this.lblPorcentaje.Text = "%";
            // 
            // FormSeleccionMedioDePago
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(710, 368);
            this.Controls.Add(this.lblPorcentaje);
            this.Controls.Add(this.lblPorcentajeDescuento);
            this.Controls.Add(this.lblPropina);
            this.Controls.Add(this.numericUpDownDescuento);
            this.Controls.Add(this.numericUpDownPropina);
            this.Controls.Add(this.btnSeleccionarMedioDePago);
            this.Controls.Add(this.lblSeleccioneMedioDePago);
            this.Controls.Add(this.dataGridViewMediosDePago);
            this.Name = "FormSeleccionMedioDePago";
            this.Text = "FormSeleccionMedioDePago";
            this.Load += new System.EventHandler(this.FormSeleccionMedioDePago_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMediosDePago)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPropina)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDescuento)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSeleccionarMedioDePago;
        private System.Windows.Forms.Label lblSeleccioneMedioDePago;
        private System.Windows.Forms.DataGridView dataGridViewMediosDePago;
        private System.Windows.Forms.NumericUpDown numericUpDownPropina;
        private System.Windows.Forms.Label lblPropina;
        private System.Windows.Forms.NumericUpDown numericUpDownDescuento;
        private System.Windows.Forms.Label lblPorcentajeDescuento;
        private System.Windows.Forms.Label lblPorcentaje;
    }
}