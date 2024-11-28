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
            this.btnFacturaEntregada = new System.Windows.Forms.Button();
            this.lblDetalleFactura = new System.Windows.Forms.Label();
            this.dataGridViewDetalleFactura = new System.Windows.Forms.DataGridView();
            this.lblNumeroFactura = new System.Windows.Forms.Label();
            this.dataGridViewFacturaMesa = new System.Windows.Forms.DataGridView();
            this.lblFacturas = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDetalleFactura)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFacturaMesa)).BeginInit();
            this.SuspendLayout();
            // 
            // btnFacturaEntregada
            // 
            this.btnFacturaEntregada.Location = new System.Drawing.Point(59, 503);
            this.btnFacturaEntregada.Margin = new System.Windows.Forms.Padding(2);
            this.btnFacturaEntregada.Name = "btnFacturaEntregada";
            this.btnFacturaEntregada.Size = new System.Drawing.Size(162, 45);
            this.btnFacturaEntregada.TabIndex = 35;
            this.btnFacturaEntregada.Tag = "192";
            this.btnFacturaEntregada.Text = "Entregada";
            this.btnFacturaEntregada.UseVisualStyleBackColor = true;
            this.btnFacturaEntregada.Click += new System.EventHandler(this.btnFacturaEntregada_Click);
            // 
            // lblDetalleFactura
            // 
            this.lblDetalleFactura.AutoSize = true;
            this.lblDetalleFactura.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblDetalleFactura.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetalleFactura.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblDetalleFactura.Location = new System.Drawing.Point(63, 170);
            this.lblDetalleFactura.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDetalleFactura.Name = "lblDetalleFactura";
            this.lblDetalleFactura.Size = new System.Drawing.Size(174, 26);
            this.lblDetalleFactura.TabIndex = 34;
            this.lblDetalleFactura.Tag = "190";
            this.lblDetalleFactura.Text = "Detalle Factura";
            // 
            // dataGridViewDetalleFactura
            // 
            this.dataGridViewDetalleFactura.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDetalleFactura.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridViewDetalleFactura.Location = new System.Drawing.Point(59, 199);
            this.dataGridViewDetalleFactura.MultiSelect = false;
            this.dataGridViewDetalleFactura.Name = "dataGridViewDetalleFactura";
            this.dataGridViewDetalleFactura.ReadOnly = true;
            this.dataGridViewDetalleFactura.RowHeadersVisible = false;
            this.dataGridViewDetalleFactura.RowHeadersWidth = 51;
            this.dataGridViewDetalleFactura.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridViewDetalleFactura.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewDetalleFactura.Size = new System.Drawing.Size(769, 271);
            this.dataGridViewDetalleFactura.TabIndex = 33;
            this.dataGridViewDetalleFactura.Tag = "191";
            // 
            // lblNumeroFactura
            // 
            this.lblNumeroFactura.AutoSize = true;
            this.lblNumeroFactura.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblNumeroFactura.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumeroFactura.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblNumeroFactura.Location = new System.Drawing.Point(437, 27);
            this.lblNumeroFactura.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNumeroFactura.Name = "lblNumeroFactura";
            this.lblNumeroFactura.Size = new System.Drawing.Size(25, 26);
            this.lblNumeroFactura.TabIndex = 36;
            this.lblNumeroFactura.Tag = "188";
            this.lblNumeroFactura.Text = "0";
            // 
            // dataGridViewFacturaMesa
            // 
            this.dataGridViewFacturaMesa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFacturaMesa.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridViewFacturaMesa.Location = new System.Drawing.Point(59, 72);
            this.dataGridViewFacturaMesa.Name = "dataGridViewFacturaMesa";
            this.dataGridViewFacturaMesa.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewFacturaMesa.Size = new System.Drawing.Size(503, 81);
            this.dataGridViewFacturaMesa.TabIndex = 37;
            this.dataGridViewFacturaMesa.Tag = "189";
            // 
            // lblFacturas
            // 
            this.lblFacturas.AutoSize = true;
            this.lblFacturas.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblFacturas.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFacturas.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblFacturas.Location = new System.Drawing.Point(63, 27);
            this.lblFacturas.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFacturas.Name = "lblFacturas";
            this.lblFacturas.Size = new System.Drawing.Size(92, 26);
            this.lblFacturas.TabIndex = 38;
            this.lblFacturas.Tag = "187";
            this.lblFacturas.Text = "Factura";
            // 
            // FormFacturaAEntregar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(967, 568);
            this.Controls.Add(this.lblFacturas);
            this.Controls.Add(this.dataGridViewFacturaMesa);
            this.Controls.Add(this.dataGridViewDetalleFactura);
            this.Controls.Add(this.lblNumeroFactura);
            this.Controls.Add(this.btnFacturaEntregada);
            this.Controls.Add(this.lblDetalleFactura);
            this.Name = "FormFacturaAEntregar";
            this.Tag = "193";
            this.Text = "FormFacturaAEntregar";
            this.Load += new System.EventHandler(this.FormFacturaAEntregar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDetalleFactura)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFacturaMesa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFacturaEntregada;
        private System.Windows.Forms.Label lblDetalleFactura;
        private System.Windows.Forms.DataGridView dataGridViewDetalleFactura;
        private System.Windows.Forms.Label lblNumeroFactura;
        private System.Windows.Forms.DataGridView dataGridViewFacturaMesa;
        private System.Windows.Forms.Label lblFacturas;
    }
}