namespace IngenieriaSoftware.UI
{
    partial class FormGestionarFacturas
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
            this.lblFacturas = new System.Windows.Forms.Label();
            this.dataGridViewFacturas = new System.Windows.Forms.DataGridView();
            this.comboBoxFiltroEstado = new System.Windows.Forms.ComboBox();
            this.lblFiltrar = new System.Windows.Forms.Label();
            this.btnMarcarComoPagado = new System.Windows.Forms.Button();
            this.btnPendienteDePago = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFacturas)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFacturas
            // 
            this.lblFacturas.AutoSize = true;
            this.lblFacturas.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblFacturas.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFacturas.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblFacturas.Location = new System.Drawing.Point(51, 31);
            this.lblFacturas.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFacturas.Name = "lblFacturas";
            this.lblFacturas.Size = new System.Drawing.Size(104, 26);
            this.lblFacturas.TabIndex = 26;
            this.lblFacturas.Tag = "70";
            this.lblFacturas.Text = "Facturas";
            // 
            // dataGridViewFacturas
            // 
            this.dataGridViewFacturas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFacturas.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridViewFacturas.Location = new System.Drawing.Point(44, 73);
            this.dataGridViewFacturas.MultiSelect = false;
            this.dataGridViewFacturas.Name = "dataGridViewFacturas";
            this.dataGridViewFacturas.RowHeadersVisible = false;
            this.dataGridViewFacturas.RowHeadersWidth = 51;
            this.dataGridViewFacturas.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridViewFacturas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewFacturas.Size = new System.Drawing.Size(822, 314);
            this.dataGridViewFacturas.TabIndex = 25;
            this.dataGridViewFacturas.Tag = "71";
            // 
            // comboBoxFiltroEstado
            // 
            this.comboBoxFiltroEstado.FormattingEnabled = true;
            this.comboBoxFiltroEstado.Location = new System.Drawing.Point(659, 38);
            this.comboBoxFiltroEstado.Name = "comboBoxFiltroEstado";
            this.comboBoxFiltroEstado.Size = new System.Drawing.Size(207, 21);
            this.comboBoxFiltroEstado.TabIndex = 28;
            this.comboBoxFiltroEstado.SelectedIndexChanged += new System.EventHandler(this.comboBoxFiltroEstado_SelectedIndexChanged);
            // 
            // lblFiltrar
            // 
            this.lblFiltrar.AutoSize = true;
            this.lblFiltrar.Location = new System.Drawing.Point(817, 22);
            this.lblFiltrar.Name = "lblFiltrar";
            this.lblFiltrar.Size = new System.Drawing.Size(32, 13);
            this.lblFiltrar.TabIndex = 30;
            this.lblFiltrar.Text = "Filtrar";
            // 
            // btnMarcarComoPagado
            // 
            this.btnMarcarComoPagado.Location = new System.Drawing.Point(248, 437);
            this.btnMarcarComoPagado.Margin = new System.Windows.Forms.Padding(2);
            this.btnMarcarComoPagado.Name = "btnMarcarComoPagado";
            this.btnMarcarComoPagado.Size = new System.Drawing.Size(162, 45);
            this.btnMarcarComoPagado.TabIndex = 31;
            this.btnMarcarComoPagado.Tag = "72";
            this.btnMarcarComoPagado.Text = "Marcar como pagado";
            this.btnMarcarComoPagado.UseVisualStyleBackColor = true;
            this.btnMarcarComoPagado.Click += new System.EventHandler(this.btnMarcarComoPagado_Click);
            // 
            // btnPendienteDePago
            // 
            this.btnPendienteDePago.Location = new System.Drawing.Point(44, 437);
            this.btnPendienteDePago.Margin = new System.Windows.Forms.Padding(2);
            this.btnPendienteDePago.Name = "btnPendienteDePago";
            this.btnPendienteDePago.Size = new System.Drawing.Size(162, 45);
            this.btnPendienteDePago.TabIndex = 32;
            this.btnPendienteDePago.Tag = "72";
            this.btnPendienteDePago.Text = "Marcar como pendiente de pago";
            this.btnPendienteDePago.UseVisualStyleBackColor = true;
            this.btnPendienteDePago.Click += new System.EventHandler(this.btnPendienteDePago_Click_1);
            // 
            // FormGestionarFacturas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1056, 567);
            this.Controls.Add(this.btnPendienteDePago);
            this.Controls.Add(this.btnMarcarComoPagado);
            this.Controls.Add(this.lblFiltrar);
            this.Controls.Add(this.comboBoxFiltroEstado);
            this.Controls.Add(this.lblFacturas);
            this.Controls.Add(this.dataGridViewFacturas);
            this.Name = "FormGestionarFacturas";
            this.Text = "FormGestionarFacturas";
            this.Load += new System.EventHandler(this.FormGestionarFacturas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFacturas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblFacturas;
        private System.Windows.Forms.DataGridView dataGridViewFacturas;
        private System.Windows.Forms.ComboBox comboBoxFiltroEstado;
        private System.Windows.Forms.Label lblFiltrar;
        private System.Windows.Forms.Button btnMarcarComoPagado;
        private System.Windows.Forms.Button btnPendienteDePago;
    }
}