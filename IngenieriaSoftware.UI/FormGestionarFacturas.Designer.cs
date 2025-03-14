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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblFacturas = new System.Windows.Forms.Label();
            this.comboBoxFiltroEstado = new System.Windows.Forms.ComboBox();
            this.lblFiltrar = new System.Windows.Forms.Label();
            this.btnMarcarComoPagado = new System.Windows.Forms.Button();
            this.btnPendienteDePago = new System.Windows.Forms.Button();
            this.btnEntregarFactura = new System.Windows.Forms.Button();
            this.dataGridViewFacturas = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFacturas)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFacturas
            // 
            this.lblFacturas.AutoSize = true;
            this.lblFacturas.BackColor = System.Drawing.Color.DarkSlateGray;
            this.lblFacturas.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFacturas.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblFacturas.Location = new System.Drawing.Point(53, 53);
            this.lblFacturas.Name = "lblFacturas";
            this.lblFacturas.Size = new System.Drawing.Size(138, 36);
            this.lblFacturas.TabIndex = 26;
            this.lblFacturas.Tag = "173";
            this.lblFacturas.Text = "Facturas";
            // 
            // comboBoxFiltroEstado
            // 
            this.comboBoxFiltroEstado.BackColor = System.Drawing.Color.Teal;
            this.comboBoxFiltroEstado.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxFiltroEstado.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.comboBoxFiltroEstado.FormattingEnabled = true;
            this.comboBoxFiltroEstado.Location = new System.Drawing.Point(879, 56);
            this.comboBoxFiltroEstado.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxFiltroEstado.Name = "comboBoxFiltroEstado";
            this.comboBoxFiltroEstado.Size = new System.Drawing.Size(275, 36);
            this.comboBoxFiltroEstado.TabIndex = 28;
            this.comboBoxFiltroEstado.Tag = "176";
            this.comboBoxFiltroEstado.SelectedIndexChanged += new System.EventHandler(this.comboBoxFiltroEstado_SelectedIndexChanged);
            // 
            // lblFiltrar
            // 
            this.lblFiltrar.AutoSize = true;
            this.lblFiltrar.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFiltrar.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblFiltrar.Location = new System.Drawing.Point(1092, 24);
            this.lblFiltrar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFiltrar.Name = "lblFiltrar";
            this.lblFiltrar.Size = new System.Drawing.Size(63, 28);
            this.lblFiltrar.TabIndex = 30;
            this.lblFiltrar.Tag = "175";
            this.lblFiltrar.Text = "Filtrar";
            // 
            // btnMarcarComoPagado
            // 
            this.btnMarcarComoPagado.BackColor = System.Drawing.Color.Teal;
            this.btnMarcarComoPagado.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btnMarcarComoPagado.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnMarcarComoPagado.Location = new System.Drawing.Point(314, 538);
            this.btnMarcarComoPagado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMarcarComoPagado.Name = "btnMarcarComoPagado";
            this.btnMarcarComoPagado.Size = new System.Drawing.Size(229, 73);
            this.btnMarcarComoPagado.TabIndex = 31;
            this.btnMarcarComoPagado.Tag = "178";
            this.btnMarcarComoPagado.Text = "Marcar como pagado";
            this.btnMarcarComoPagado.UseVisualStyleBackColor = false;
            this.btnMarcarComoPagado.Click += new System.EventHandler(this.btnMarcarComoPagado_Click);
            // 
            // btnPendienteDePago
            // 
            this.btnPendienteDePago.BackColor = System.Drawing.Color.Teal;
            this.btnPendienteDePago.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btnPendienteDePago.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnPendienteDePago.Location = new System.Drawing.Point(59, 538);
            this.btnPendienteDePago.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPendienteDePago.Name = "btnPendienteDePago";
            this.btnPendienteDePago.Size = new System.Drawing.Size(229, 73);
            this.btnPendienteDePago.TabIndex = 32;
            this.btnPendienteDePago.Tag = "177";
            this.btnPendienteDePago.Text = "Marcar como pendiente de pago";
            this.btnPendienteDePago.UseVisualStyleBackColor = false;
            this.btnPendienteDePago.Click += new System.EventHandler(this.btnPendienteDePago_Click_1);
            // 
            // btnEntregarFactura
            // 
            this.btnEntregarFactura.BackColor = System.Drawing.Color.MediumAquamarine;
            this.btnEntregarFactura.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btnEntregarFactura.ForeColor = System.Drawing.Color.Black;
            this.btnEntregarFactura.Location = new System.Drawing.Point(926, 538);
            this.btnEntregarFactura.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEntregarFactura.Name = "btnEntregarFactura";
            this.btnEntregarFactura.Size = new System.Drawing.Size(229, 73);
            this.btnEntregarFactura.TabIndex = 33;
            this.btnEntregarFactura.Tag = "171";
            this.btnEntregarFactura.Text = "Entregar Factura";
            this.btnEntregarFactura.UseVisualStyleBackColor = false;
            this.btnEntregarFactura.Click += new System.EventHandler(this.btnEntregarFactura_Click);
            // 
            // dataGridViewFacturas
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightSeaGreen;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Symbol", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Orange;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridViewFacturas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewFacturas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dataGridViewFacturas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridViewFacturas.BackgroundColor = System.Drawing.Color.DarkSlateGray;
            this.dataGridViewFacturas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dataGridViewFacturas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.LightSeaGreen;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Symbol", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Orange;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewFacturas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewFacturas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.LightSeaGreen;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Symbol", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Orange;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewFacturas.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewFacturas.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridViewFacturas.EnableHeadersVisualStyles = false;
            this.dataGridViewFacturas.GridColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridViewFacturas.Location = new System.Drawing.Point(59, 117);
            this.dataGridViewFacturas.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewFacturas.MultiSelect = false;
            this.dataGridViewFacturas.Name = "dataGridViewFacturas";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.LightSeaGreen;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Orange;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewFacturas.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewFacturas.RowHeadersVisible = false;
            this.dataGridViewFacturas.RowHeadersWidth = 51;
            this.dataGridViewFacturas.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.LightSeaGreen;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI Symbol", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Orange;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridViewFacturas.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewFacturas.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.LightSeaGreen;
            this.dataGridViewFacturas.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI Symbol", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridViewFacturas.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridViewFacturas.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Orange;
            this.dataGridViewFacturas.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridViewFacturas.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewFacturas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewFacturas.Size = new System.Drawing.Size(1283, 386);
            this.dataGridViewFacturas.TabIndex = 51;
            this.dataGridViewFacturas.Tag = "166";
            // 
            // FormGestionarFacturas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(1408, 698);
            this.Controls.Add(this.dataGridViewFacturas);
            this.Controls.Add(this.btnEntregarFactura);
            this.Controls.Add(this.btnPendienteDePago);
            this.Controls.Add(this.btnMarcarComoPagado);
            this.Controls.Add(this.lblFiltrar);
            this.Controls.Add(this.comboBoxFiltroEstado);
            this.Controls.Add(this.lblFacturas);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormGestionarFacturas";
            this.Tag = "179";
            this.Text = "FormGestionarFacturas";
            this.Load += new System.EventHandler(this.FormGestionarFacturas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFacturas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblFacturas;
        private System.Windows.Forms.ComboBox comboBoxFiltroEstado;
        private System.Windows.Forms.Label lblFiltrar;
        private System.Windows.Forms.Button btnMarcarComoPagado;
        private System.Windows.Forms.Button btnPendienteDePago;
        private System.Windows.Forms.Button btnEntregarFactura;
        private System.Windows.Forms.DataGridView dataGridViewFacturas;
    }
}