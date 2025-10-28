namespace IngenieriaSoftware.UI.ComprasProveedores.Facturas
{
    partial class Facturas
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
            this.gBListaOrdenCompra = new System.Windows.Forms.GroupBox();
            this.dtpFechaDesde = new System.Windows.Forms.DateTimePicker();
            this.cbEstado = new System.Windows.Forms.ComboBox();
            this.Estado = new System.Windows.Forms.Label();
            this.lblFechaDesde = new System.Windows.Forms.Label();
            this.txtNumFactura = new System.Windows.Forms.TextBox();
            this.lblNumeroFactura = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.dgvFacturas = new IngenieriaSoftware.UI.ControlesPersonalizados.DataGridViewConFiltros();
            this.btnDetalleFactura = new System.Windows.Forms.Button();
            this.btnRechazarOrden = new System.Windows.Forms.Button();
            this.gBListaOrdenCompra.SuspendLayout();
            this.SuspendLayout();
            // 
            // gBListaOrdenCompra
            // 
            this.gBListaOrdenCompra.AutoSize = true;
            this.gBListaOrdenCompra.Controls.Add(this.dtpFechaDesde);
            this.gBListaOrdenCompra.Controls.Add(this.cbEstado);
            this.gBListaOrdenCompra.Controls.Add(this.Estado);
            this.gBListaOrdenCompra.Controls.Add(this.lblFechaDesde);
            this.gBListaOrdenCompra.Controls.Add(this.txtNumFactura);
            this.gBListaOrdenCompra.Controls.Add(this.lblNumeroFactura);
            this.gBListaOrdenCompra.Controls.Add(this.btnBuscar);
            this.gBListaOrdenCompra.Controls.Add(this.btnLimpiar);
            this.gBListaOrdenCompra.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gBListaOrdenCompra.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.gBListaOrdenCompra.Location = new System.Drawing.Point(194, 40);
            this.gBListaOrdenCompra.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gBListaOrdenCompra.Name = "gBListaOrdenCompra";
            this.gBListaOrdenCompra.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gBListaOrdenCompra.Size = new System.Drawing.Size(1387, 281);
            this.gBListaOrdenCompra.TabIndex = 36;
            this.gBListaOrdenCompra.TabStop = false;
            this.gBListaOrdenCompra.Tag = "1301";
            this.gBListaOrdenCompra.Text = "Factura";
            // 
            // dtpFechaDesde
            // 
            this.dtpFechaDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaDesde.Location = new System.Drawing.Point(455, 102);
            this.dtpFechaDesde.Margin = new System.Windows.Forms.Padding(4);
            this.dtpFechaDesde.Name = "dtpFechaDesde";
            this.dtpFechaDesde.Size = new System.Drawing.Size(200, 34);
            this.dtpFechaDesde.TabIndex = 43;
            this.dtpFechaDesde.Tag = "1305";
            this.dtpFechaDesde.Value = new System.DateTime(2025, 9, 16, 23, 18, 0, 0);
            // 
            // cbEstado
            // 
            this.cbEstado.FormattingEnabled = true;
            this.cbEstado.Location = new System.Drawing.Point(740, 101);
            this.cbEstado.Margin = new System.Windows.Forms.Padding(4);
            this.cbEstado.Name = "cbEstado";
            this.cbEstado.Size = new System.Drawing.Size(251, 37);
            this.cbEstado.TabIndex = 42;
            this.cbEstado.Tag = "1307";
            // 
            // Estado
            // 
            this.Estado.AutoSize = true;
            this.Estado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Estado.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Estado.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Estado.Location = new System.Drawing.Point(735, 71);
            this.Estado.Name = "Estado";
            this.Estado.Size = new System.Drawing.Size(71, 28);
            this.Estado.TabIndex = 41;
            this.Estado.Tag = "1306";
            this.Estado.Text = "Estado";
            // 
            // lblFechaDesde
            // 
            this.lblFechaDesde.AutoSize = true;
            this.lblFechaDesde.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblFechaDesde.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaDesde.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblFechaDesde.Location = new System.Drawing.Point(449, 70);
            this.lblFechaDesde.Name = "lblFechaDesde";
            this.lblFechaDesde.Size = new System.Drawing.Size(119, 28);
            this.lblFechaDesde.TabIndex = 39;
            this.lblFechaDesde.Tag = "1304";
            this.lblFechaDesde.Text = "Fecha desde";
            // 
            // txtNumFactura
            // 
            this.txtNumFactura.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtNumFactura.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumFactura.ForeColor = System.Drawing.Color.DimGray;
            this.txtNumFactura.Location = new System.Drawing.Point(107, 102);
            this.txtNumFactura.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNumFactura.Name = "txtNumFactura";
            this.txtNumFactura.Size = new System.Drawing.Size(251, 34);
            this.txtNumFactura.TabIndex = 35;
            this.txtNumFactura.Tag = "1302";
            // 
            // lblNumeroFactura
            // 
            this.lblNumeroFactura.AutoSize = true;
            this.lblNumeroFactura.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblNumeroFactura.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumeroFactura.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblNumeroFactura.Location = new System.Drawing.Point(101, 74);
            this.lblNumeroFactura.Name = "lblNumeroFactura";
            this.lblNumeroFactura.Size = new System.Drawing.Size(128, 28);
            this.lblNumeroFactura.TabIndex = 36;
            this.lblNumeroFactura.Tag = "1303";
            this.lblNumeroFactura.Text = "Num. Factura";
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnBuscar.Location = new System.Drawing.Point(1023, 203);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(137, 46);
            this.btnBuscar.TabIndex = 35;
            this.btnBuscar.Tag = "1308";
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnLimpiar.Location = new System.Drawing.Point(1177, 203);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(137, 46);
            this.btnLimpiar.TabIndex = 37;
            this.btnLimpiar.Tag = "1310";
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            // 
            // dgvFacturas
            // 
            this.dgvFacturas.BackColor = System.Drawing.Color.Transparent;
            this.dgvFacturas.Location = new System.Drawing.Point(194, 416);
            this.dgvFacturas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvFacturas.Name = "dgvFacturas";
            this.dgvFacturas.Size = new System.Drawing.Size(1404, 600);
            this.dgvFacturas.TabIndex = 38;
            this.dgvFacturas.Tag = "1312";
            this.dgvFacturas.TamanoGrilla = IngenieriaSoftware.UI.ControlesPersonalizados.grillaCustom.ModoTamanoGrilla.Gigante;
            // 
            // btnDetalleFactura
            // 
            this.btnDetalleFactura.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnDetalleFactura.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDetalleFactura.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDetalleFactura.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnDetalleFactura.Location = new System.Drawing.Point(1444, 376);
            this.btnDetalleFactura.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDetalleFactura.Name = "btnDetalleFactura";
            this.btnDetalleFactura.Size = new System.Drawing.Size(137, 46);
            this.btnDetalleFactura.TabIndex = 44;
            this.btnDetalleFactura.Tag = "1309";
            this.btnDetalleFactura.Text = "Detalles";
            this.btnDetalleFactura.UseVisualStyleBackColor = false;
            // 
            // btnRechazarOrden
            // 
            this.btnRechazarOrden.BackColor = System.Drawing.Color.Maroon;
            this.btnRechazarOrden.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRechazarOrden.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRechazarOrden.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnRechazarOrden.Location = new System.Drawing.Point(1240, 376);
            this.btnRechazarOrden.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRechazarOrden.Name = "btnRechazarOrden";
            this.btnRechazarOrden.Size = new System.Drawing.Size(176, 46);
            this.btnRechazarOrden.TabIndex = 114;
            this.btnRechazarOrden.Tag = "1282";
            this.btnRechazarOrden.Text = "Anular Factura";
            this.btnRechazarOrden.UseVisualStyleBackColor = false;
            // 
            // Facturas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1790, 1055);
            this.Controls.Add(this.btnRechazarOrden);
            this.Controls.Add(this.btnDetalleFactura);
            this.Controls.Add(this.dgvFacturas);
            this.Controls.Add(this.gBListaOrdenCompra);
            this.Name = "Facturas";
            this.Tag = "1311";
            this.Text = "FormListaFacturas";
            this.gBListaOrdenCompra.ResumeLayout(false);
            this.gBListaOrdenCompra.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gBListaOrdenCompra;
        private System.Windows.Forms.DateTimePicker dtpFechaDesde;
        private System.Windows.Forms.ComboBox cbEstado;
        private System.Windows.Forms.Label Estado;
        private System.Windows.Forms.Label lblFechaDesde;
        private System.Windows.Forms.TextBox txtNumFactura;
        private System.Windows.Forms.Label lblNumeroFactura;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnLimpiar;
        private ControlesPersonalizados.DataGridViewConFiltros dgvFacturas;
        private System.Windows.Forms.Button btnDetalleFactura;
        private System.Windows.Forms.Button btnRechazarOrden;
    }
}