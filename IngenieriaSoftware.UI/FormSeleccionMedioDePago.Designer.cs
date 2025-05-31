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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.lblSeleccioneMedioDePago = new System.Windows.Forms.Label();
            this.numericUpDownPropina = new System.Windows.Forms.NumericUpDown();
            this.lblPropina = new System.Windows.Forms.Label();
            this.numericUpDownDescuento = new System.Windows.Forms.NumericUpDown();
            this.lblPorcentajeDescuento = new System.Windows.Forms.Label();
            this.lblPorcentaje = new System.Windows.Forms.Label();
            this.dataGridViewMediosDePago = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPropina)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDescuento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMediosDePago)).BeginInit();
            this.SuspendLayout();
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnConfirmar.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmar.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnConfirmar.Location = new System.Drawing.Point(677, 280);
            this.btnConfirmar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(216, 63);
            this.btnConfirmar.TabIndex = 17;
            this.btnConfirmar.Tag = "114";
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = false;
            this.btnConfirmar.Click += new System.EventHandler(this.btnSeleccionarMedioDePago_Click);
            // 
            // lblSeleccioneMedioDePago
            // 
            this.lblSeleccioneMedioDePago.AutoSize = true;
            this.lblSeleccioneMedioDePago.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSeleccioneMedioDePago.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblSeleccioneMedioDePago.Location = new System.Drawing.Point(47, 50);
            this.lblSeleccioneMedioDePago.Name = "lblSeleccioneMedioDePago";
            this.lblSeleccioneMedioDePago.Size = new System.Drawing.Size(374, 32);
            this.lblSeleccioneMedioDePago.TabIndex = 16;
            this.lblSeleccioneMedioDePago.Tag = "107";
            this.lblSeleccioneMedioDePago.Text = "Seleccione medio de pago";
            // 
            // numericUpDownPropina
            // 
            this.numericUpDownPropina.BackColor = System.Drawing.Color.Teal;
            this.numericUpDownPropina.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.numericUpDownPropina.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownPropina.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.numericUpDownPropina.Location = new System.Drawing.Point(677, 130);
            this.numericUpDownPropina.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.numericUpDownPropina.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numericUpDownPropina.Name = "numericUpDownPropina";
            this.numericUpDownPropina.Size = new System.Drawing.Size(100, 30);
            this.numericUpDownPropina.TabIndex = 18;
            this.numericUpDownPropina.Tag = "110";
            // 
            // lblPropina
            // 
            this.lblPropina.AutoSize = true;
            this.lblPropina.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPropina.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblPropina.Location = new System.Drawing.Point(672, 100);
            this.lblPropina.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPropina.Name = "lblPropina";
            this.lblPropina.Size = new System.Drawing.Size(80, 28);
            this.lblPropina.TabIndex = 19;
            this.lblPropina.Tag = "109";
            this.lblPropina.Text = "Propina";
            // 
            // numericUpDownDescuento
            // 
            this.numericUpDownDescuento.BackColor = System.Drawing.Color.Teal;
            this.numericUpDownDescuento.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.numericUpDownDescuento.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownDescuento.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.numericUpDownDescuento.Location = new System.Drawing.Point(676, 200);
            this.numericUpDownDescuento.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.numericUpDownDescuento.Name = "numericUpDownDescuento";
            this.numericUpDownDescuento.Size = new System.Drawing.Size(100, 30);
            this.numericUpDownDescuento.TabIndex = 18;
            this.numericUpDownDescuento.Tag = "112";
            // 
            // lblPorcentajeDescuento
            // 
            this.lblPorcentajeDescuento.AutoSize = true;
            this.lblPorcentajeDescuento.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPorcentajeDescuento.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblPorcentajeDescuento.Location = new System.Drawing.Point(672, 168);
            this.lblPorcentajeDescuento.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPorcentajeDescuento.Name = "lblPorcentajeDescuento";
            this.lblPorcentajeDescuento.Size = new System.Drawing.Size(104, 28);
            this.lblPorcentajeDescuento.TabIndex = 19;
            this.lblPorcentajeDescuento.Tag = "111";
            this.lblPorcentajeDescuento.Text = "Descuento";
            // 
            // lblPorcentaje
            // 
            this.lblPorcentaje.AutoSize = true;
            this.lblPorcentaje.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPorcentaje.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblPorcentaje.Location = new System.Drawing.Point(784, 202);
            this.lblPorcentaje.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPorcentaje.Name = "lblPorcentaje";
            this.lblPorcentaje.Size = new System.Drawing.Size(28, 28);
            this.lblPorcentaje.TabIndex = 20;
            this.lblPorcentaje.Tag = "113";
            this.lblPorcentaje.Text = "%";
            // 
            // dataGridViewMediosDePago
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightSeaGreen;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Symbol", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Orange;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridViewMediosDePago.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewMediosDePago.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewMediosDePago.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridViewMediosDePago.BackgroundColor = System.Drawing.Color.DarkSlateGray;
            this.dataGridViewMediosDePago.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridViewMediosDePago.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.LightSeaGreen;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Symbol", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Orange;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewMediosDePago.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewMediosDePago.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.LightSeaGreen;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Symbol", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Orange;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewMediosDePago.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewMediosDePago.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridViewMediosDePago.EnableHeadersVisualStyles = false;
            this.dataGridViewMediosDePago.GridColor = System.Drawing.Color.DarkSlateGray;
            this.dataGridViewMediosDePago.Location = new System.Drawing.Point(41, 102);
            this.dataGridViewMediosDePago.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewMediosDePago.MultiSelect = false;
            this.dataGridViewMediosDePago.Name = "dataGridViewMediosDePago";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.LightSeaGreen;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Orange;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewMediosDePago.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewMediosDePago.RowHeadersVisible = false;
            this.dataGridViewMediosDePago.RowHeadersWidth = 51;
            this.dataGridViewMediosDePago.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.LightSeaGreen;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI Symbol", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Orange;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridViewMediosDePago.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewMediosDePago.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.LightSeaGreen;
            this.dataGridViewMediosDePago.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI Symbol", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridViewMediosDePago.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridViewMediosDePago.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Orange;
            this.dataGridViewMediosDePago.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridViewMediosDePago.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewMediosDePago.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewMediosDePago.Size = new System.Drawing.Size(591, 241);
            this.dataGridViewMediosDePago.TabIndex = 21;
            this.dataGridViewMediosDePago.Tag = "166";
            // 
            // FormSeleccionMedioDePago
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(947, 453);
            this.Controls.Add(this.dataGridViewMediosDePago);
            this.Controls.Add(this.lblPorcentaje);
            this.Controls.Add(this.lblPorcentajeDescuento);
            this.Controls.Add(this.lblPropina);
            this.Controls.Add(this.numericUpDownDescuento);
            this.Controls.Add(this.numericUpDownPropina);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.lblSeleccioneMedioDePago);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormSeleccionMedioDePago";
            this.Tag = "115";
            this.Text = "FormSeleccionMedioDePago";
            this.Load += new System.EventHandler(this.FormSeleccionMedioDePago_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPropina)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDescuento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMediosDePago)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.Label lblSeleccioneMedioDePago;
        private System.Windows.Forms.NumericUpDown numericUpDownPropina;
        private System.Windows.Forms.Label lblPropina;
        private System.Windows.Forms.NumericUpDown numericUpDownDescuento;
        private System.Windows.Forms.Label lblPorcentajeDescuento;
        private System.Windows.Forms.Label lblPorcentaje;
        private System.Windows.Forms.DataGridView dataGridViewMediosDePago;
    }
}