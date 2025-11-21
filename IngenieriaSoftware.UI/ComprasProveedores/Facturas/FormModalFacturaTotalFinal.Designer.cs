namespace IngenieriaSoftware.UI.ComprasProveedores.Facturas
{
    partial class FormModalFacturaTotalFinal
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtNumSubtotal = new IngenieriaSoftware.UI.ControlesPersonalizados.Inputs.InputNumericTextBox();
            this.txtNumDescuento = new IngenieriaSoftware.UI.ControlesPersonalizados.Inputs.InputNumericTextBox();
            this.txtNumImpuestos = new IngenieriaSoftware.UI.ControlesPersonalizados.Inputs.InputNumericTextBox();
            this.txtNumTotalFinal = new IngenieriaSoftware.UI.ControlesPersonalizados.Inputs.InputNumericTextBox();
            this.lblSubtotal = new System.Windows.Forms.Label();
            this.lblImpuestos = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGenerarOrdenCompra = new System.Windows.Forms.Button();
            this.lblAgregarFactura = new System.Windows.Forms.Label();
            this.lblNumeroTotal = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSize = true;
            this.groupBox1.Controls.Add(this.txtNumSubtotal);
            this.groupBox1.Controls.Add(this.txtNumDescuento);
            this.groupBox1.Controls.Add(this.txtNumImpuestos);
            this.groupBox1.Controls.Add(this.txtNumTotalFinal);
            this.groupBox1.Controls.Add(this.lblSubtotal);
            this.groupBox1.Controls.Add(this.lblImpuestos);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.lblTotal);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox1.Location = new System.Drawing.Point(32, 101);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(1131, 138);
            this.groupBox1.TabIndex = 139;
            this.groupBox1.TabStop = false;
            this.groupBox1.Tag = "";
            this.groupBox1.Text = "Resumen final";
            // 
            // txtNumSubtotal
            // 
            this.txtNumSubtotal.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtNumSubtotal.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.RecentlyUsedList;
            this.txtNumSubtotal.Enabled = false;
            this.txtNumSubtotal.Location = new System.Drawing.Point(64, 78);
            this.txtNumSubtotal.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNumSubtotal.Name = "txtNumSubtotal";
            this.txtNumSubtotal.Size = new System.Drawing.Size(152, 28);
            this.txtNumSubtotal.TabIndex = 114;
            this.txtNumSubtotal.Tag = "";
            this.txtNumSubtotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtNumDescuento
            // 
            this.txtNumDescuento.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtNumDescuento.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.RecentlyUsedList;
            this.txtNumDescuento.Location = new System.Drawing.Point(355, 77);
            this.txtNumDescuento.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNumDescuento.Name = "txtNumDescuento";
            this.txtNumDescuento.Size = new System.Drawing.Size(152, 28);
            this.txtNumDescuento.TabIndex = 113;
            this.txtNumDescuento.Tag = "";
            this.txtNumDescuento.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtNumDescuento.TextChanged += new System.EventHandler(this.txtNumDescuento_TextChanged);
            // 
            // txtNumImpuestos
            // 
            this.txtNumImpuestos.Font = new System.Drawing.Font("Segoe UI Symbol", 12F);
            this.txtNumImpuestos.Location = new System.Drawing.Point(659, 78);
            this.txtNumImpuestos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNumImpuestos.Name = "txtNumImpuestos";
            this.txtNumImpuestos.Size = new System.Drawing.Size(152, 29);
            this.txtNumImpuestos.TabIndex = 111;
            this.txtNumImpuestos.Tag = "";
            this.txtNumImpuestos.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtNumImpuestos.TextChanged += new System.EventHandler(this.txtNumImpuestos_TextChanged);
            // 
            // txtNumTotalFinal
            // 
            this.txtNumTotalFinal.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtNumTotalFinal.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.RecentlyUsedList;
            this.txtNumTotalFinal.Enabled = false;
            this.txtNumTotalFinal.Location = new System.Drawing.Point(920, 77);
            this.txtNumTotalFinal.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNumTotalFinal.Name = "txtNumTotalFinal";
            this.txtNumTotalFinal.Size = new System.Drawing.Size(152, 28);
            this.txtNumTotalFinal.TabIndex = 111;
            this.txtNumTotalFinal.Tag = "";
            this.txtNumTotalFinal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblSubtotal
            // 
            this.lblSubtotal.AutoSize = true;
            this.lblSubtotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblSubtotal.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubtotal.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblSubtotal.Location = new System.Drawing.Point(61, 52);
            this.lblSubtotal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSubtotal.Name = "lblSubtotal";
            this.lblSubtotal.Size = new System.Drawing.Size(68, 21);
            this.lblSubtotal.TabIndex = 77;
            this.lblSubtotal.Tag = "";
            this.lblSubtotal.Text = "Subtotal";
            // 
            // lblImpuestos
            // 
            this.lblImpuestos.AutoSize = true;
            this.lblImpuestos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblImpuestos.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImpuestos.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblImpuestos.Location = new System.Drawing.Point(656, 54);
            this.lblImpuestos.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblImpuestos.Name = "lblImpuestos";
            this.lblImpuestos.Size = new System.Drawing.Size(82, 21);
            this.lblImpuestos.TabIndex = 79;
            this.lblImpuestos.Tag = "";
            this.lblImpuestos.Text = "Impuestos";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label4.Location = new System.Drawing.Point(354, 54);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 21);
            this.label4.TabIndex = 101;
            this.label4.Tag = "";
            this.label4.Text = "Descuento";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblTotal.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblTotal.Location = new System.Drawing.Point(916, 53);
            this.lblTotal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(78, 21);
            this.lblTotal.TabIndex = 81;
            this.lblTotal.Tag = "";
            this.lblTotal.Text = "Total final";
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.SystemColors.WindowText;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnCancelar.Location = new System.Drawing.Point(1042, 285);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(121, 52);
            this.btnCancelar.TabIndex = 141;
            this.btnCancelar.Tag = "";
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            // 
            // btnGenerarOrdenCompra
            // 
            this.btnGenerarOrdenCompra.BackColor = System.Drawing.Color.DarkGreen;
            this.btnGenerarOrdenCompra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerarOrdenCompra.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerarOrdenCompra.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnGenerarOrdenCompra.Location = new System.Drawing.Point(874, 285);
            this.btnGenerarOrdenCompra.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnGenerarOrdenCompra.Name = "btnGenerarOrdenCompra";
            this.btnGenerarOrdenCompra.Size = new System.Drawing.Size(151, 52);
            this.btnGenerarOrdenCompra.TabIndex = 140;
            this.btnGenerarOrdenCompra.Tag = "";
            this.btnGenerarOrdenCompra.Text = "Generar Factura";
            this.btnGenerarOrdenCompra.UseVisualStyleBackColor = false;
            this.btnGenerarOrdenCompra.Click += new System.EventHandler(this.btnGenerarOrdenCompra_Click);
            // 
            // lblAgregarFactura
            // 
            this.lblAgregarFactura.AutoSize = true;
            this.lblAgregarFactura.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblAgregarFactura.Font = new System.Drawing.Font("Segoe UI Symbol", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAgregarFactura.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblAgregarFactura.Location = new System.Drawing.Point(37, 33);
            this.lblAgregarFactura.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAgregarFactura.Name = "lblAgregarFactura";
            this.lblAgregarFactura.Size = new System.Drawing.Size(218, 37);
            this.lblAgregarFactura.TabIndex = 142;
            this.lblAgregarFactura.Tag = "";
            this.lblAgregarFactura.Text = "Total de factura";
            // 
            // lblNumeroTotal
            // 
            this.lblNumeroTotal.AutoSize = true;
            this.lblNumeroTotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblNumeroTotal.Font = new System.Drawing.Font("Trebuchet MS", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumeroTotal.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblNumeroTotal.Location = new System.Drawing.Point(810, 46);
            this.lblNumeroTotal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNumeroTotal.Name = "lblNumeroTotal";
            this.lblNumeroTotal.Size = new System.Drawing.Size(92, 37);
            this.lblNumeroTotal.TabIndex = 115;
            this.lblNumeroTotal.Tag = "";
            this.lblNumeroTotal.Text = "10000";
            // 
            // FormModalFacturaTotalFinal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1184, 366);
            this.Controls.Add(this.lblNumeroTotal);
            this.Controls.Add(this.lblAgregarFactura);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGenerarOrdenCompra);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormModalFacturaTotalFinal";
            this.Text = "FormModalFacturaTotalFinal";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private ControlesPersonalizados.Inputs.InputNumericTextBox txtNumSubtotal;
        private ControlesPersonalizados.Inputs.InputNumericTextBox txtNumDescuento;
        private ControlesPersonalizados.Inputs.InputNumericTextBox txtNumImpuestos;
        private ControlesPersonalizados.Inputs.InputNumericTextBox txtNumTotalFinal;
        private System.Windows.Forms.Label lblSubtotal;
        private System.Windows.Forms.Label lblImpuestos;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGenerarOrdenCompra;
        private System.Windows.Forms.Label lblAgregarFactura;
        private System.Windows.Forms.Label lblNumeroTotal;
    }
}