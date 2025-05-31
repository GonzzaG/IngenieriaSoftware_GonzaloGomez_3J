namespace IngenieriaSoftware.UI
{
    partial class FormFacturaAEntregar
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnFacturaEntregada = new System.Windows.Forms.Button();
            this.lblDetalleFactura = new System.Windows.Forms.Label();
            this.lblNumeroFactura = new System.Windows.Forms.Label();
            this.lblFacturas = new System.Windows.Forms.Label();
            this.dataGridViewFacturaMesa = new System.Windows.Forms.DataGridView();
            this.dataGridViewDetalleFactura = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFacturaMesa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDetalleFactura)).BeginInit();
            this.SuspendLayout();
            // 
            // btnFacturaEntregada
            // 
            this.btnFacturaEntregada.BackColor = System.Drawing.Color.Teal;
            this.btnFacturaEntregada.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFacturaEntregada.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnFacturaEntregada.Location = new System.Drawing.Point(79, 679);
            this.btnFacturaEntregada.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnFacturaEntregada.Name = "btnFacturaEntregada";
            this.btnFacturaEntregada.Size = new System.Drawing.Size(244, 73);
            this.btnFacturaEntregada.TabIndex = 35;
            this.btnFacturaEntregada.Tag = "192";
            this.btnFacturaEntregada.Text = "Entregada";
            this.btnFacturaEntregada.UseVisualStyleBackColor = false;
            this.btnFacturaEntregada.Click += new System.EventHandler(this.btnFacturaEntregada_Click);
            // 
            // lblDetalleFactura
            // 
            this.lblDetalleFactura.AutoSize = true;
            this.lblDetalleFactura.BackColor = System.Drawing.Color.DarkSlateGray;
            this.lblDetalleFactura.Font = new System.Drawing.Font("Segoe UI Symbol", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetalleFactura.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblDetalleFactura.Location = new System.Drawing.Point(78, 281);
            this.lblDetalleFactura.Name = "lblDetalleFactura";
            this.lblDetalleFactura.Size = new System.Drawing.Size(217, 38);
            this.lblDetalleFactura.TabIndex = 34;
            this.lblDetalleFactura.Tag = "190";
            this.lblDetalleFactura.Text = "Detalle Factura";
            // 
            // lblNumeroFactura
            // 
            this.lblNumeroFactura.AutoSize = true;
            this.lblNumeroFactura.BackColor = System.Drawing.Color.DarkSlateGray;
            this.lblNumeroFactura.Font = new System.Drawing.Font("Segoe UI Symbol", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumeroFactura.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblNumeroFactura.Location = new System.Drawing.Point(577, 27);
            this.lblNumeroFactura.Name = "lblNumeroFactura";
            this.lblNumeroFactura.Size = new System.Drawing.Size(33, 38);
            this.lblNumeroFactura.TabIndex = 36;
            this.lblNumeroFactura.Tag = "188";
            this.lblNumeroFactura.Text = "0";
            // 
            // lblFacturas
            // 
            this.lblFacturas.AutoSize = true;
            this.lblFacturas.BackColor = System.Drawing.Color.DarkSlateGray;
            this.lblFacturas.Font = new System.Drawing.Font("Segoe UI Symbol", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFacturas.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblFacturas.Location = new System.Drawing.Point(78, 27);
            this.lblFacturas.Name = "lblFacturas";
            this.lblFacturas.Size = new System.Drawing.Size(114, 38);
            this.lblFacturas.TabIndex = 38;
            this.lblFacturas.Tag = "187";
            this.lblFacturas.Text = "Factura";
            // 
            // dataGridViewFacturaMesa
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightSeaGreen;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Symbol", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Orange;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridViewFacturaMesa.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewFacturaMesa.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dataGridViewFacturaMesa.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridViewFacturaMesa.BackgroundColor = System.Drawing.Color.DarkSlateGray;
            this.dataGridViewFacturaMesa.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dataGridViewFacturaMesa.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.LightSeaGreen;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Symbol", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Orange;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewFacturaMesa.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewFacturaMesa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.LightSeaGreen;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Symbol", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Orange;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewFacturaMesa.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewFacturaMesa.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridViewFacturaMesa.EnableHeadersVisualStyles = false;
            this.dataGridViewFacturaMesa.GridColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridViewFacturaMesa.Location = new System.Drawing.Point(79, 81);
            this.dataGridViewFacturaMesa.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewFacturaMesa.MultiSelect = false;
            this.dataGridViewFacturaMesa.Name = "dataGridViewFacturaMesa";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.LightSeaGreen;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Orange;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewFacturaMesa.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewFacturaMesa.RowHeadersVisible = false;
            this.dataGridViewFacturaMesa.RowHeadersWidth = 51;
            this.dataGridViewFacturaMesa.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.LightSeaGreen;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI Symbol", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Orange;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridViewFacturaMesa.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewFacturaMesa.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.LightSeaGreen;
            this.dataGridViewFacturaMesa.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI Symbol", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridViewFacturaMesa.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridViewFacturaMesa.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Orange;
            this.dataGridViewFacturaMesa.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridViewFacturaMesa.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewFacturaMesa.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewFacturaMesa.Size = new System.Drawing.Size(1025, 146);
            this.dataGridViewFacturaMesa.TabIndex = 50;
            this.dataGridViewFacturaMesa.Tag = "166";
            // 
            // dataGridViewDetalleFactura
            // 
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.LightSeaGreen;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI Symbol", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Orange;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridViewDetalleFactura.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridViewDetalleFactura.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewDetalleFactura.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridViewDetalleFactura.BackgroundColor = System.Drawing.Color.DarkSlateGray;
            this.dataGridViewDetalleFactura.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dataGridViewDetalleFactura.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.LightSeaGreen;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI Symbol", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.Orange;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewDetalleFactura.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridViewDetalleFactura.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.LightSeaGreen;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI Symbol", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.Orange;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewDetalleFactura.DefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridViewDetalleFactura.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridViewDetalleFactura.EnableHeadersVisualStyles = false;
            this.dataGridViewDetalleFactura.GridColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridViewDetalleFactura.Location = new System.Drawing.Point(79, 323);
            this.dataGridViewDetalleFactura.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewDetalleFactura.MultiSelect = false;
            this.dataGridViewDetalleFactura.Name = "dataGridViewDetalleFactura";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.LightSeaGreen;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.Orange;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewDetalleFactura.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dataGridViewDetalleFactura.RowHeadersVisible = false;
            this.dataGridViewDetalleFactura.RowHeadersWidth = 51;
            this.dataGridViewDetalleFactura.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.LightSeaGreen;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Segoe UI Symbol", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.Orange;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridViewDetalleFactura.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.dataGridViewDetalleFactura.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.LightSeaGreen;
            this.dataGridViewDetalleFactura.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI Symbol", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridViewDetalleFactura.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridViewDetalleFactura.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Orange;
            this.dataGridViewDetalleFactura.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridViewDetalleFactura.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewDetalleFactura.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewDetalleFactura.Size = new System.Drawing.Size(1025, 334);
            this.dataGridViewDetalleFactura.TabIndex = 51;
            this.dataGridViewDetalleFactura.Tag = "166";
            // 
            // FormFacturaAEntregar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(1289, 776);
            this.Controls.Add(this.dataGridViewDetalleFactura);
            this.Controls.Add(this.dataGridViewFacturaMesa);
            this.Controls.Add(this.lblFacturas);
            this.Controls.Add(this.lblNumeroFactura);
            this.Controls.Add(this.btnFacturaEntregada);
            this.Controls.Add(this.lblDetalleFactura);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormFacturaAEntregar";
            this.Tag = "193";
            this.Text = "FormFacturaAEntregar";
            this.Load += new System.EventHandler(this.FormFacturaAEntregar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFacturaMesa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDetalleFactura)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFacturaEntregada;
        private System.Windows.Forms.Label lblDetalleFactura;
        private System.Windows.Forms.Label lblNumeroFactura;
        private System.Windows.Forms.Label lblFacturas;
        private System.Windows.Forms.DataGridView dataGridViewFacturaMesa;
        private System.Windows.Forms.DataGridView dataGridViewDetalleFactura;
    }
}