namespace IngenieriaSoftware.UI.ComprasProveedores.Facturas
{
    partial class FormListaFacturas
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
            this.btnAnular = new System.Windows.Forms.Button();
            this.btnGenerarPdf = new System.Windows.Forms.Button();
            this.dtpFechaDesde = new System.Windows.Forms.DateTimePicker();
            this.cbEstado = new System.Windows.Forms.ComboBox();
            this.Estado = new System.Windows.Forms.Label();
            this.lblFechaDesde = new System.Windows.Forms.Label();
            this.txtNumFactura = new System.Windows.Forms.TextBox();
            this.lblNumeroFactura = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.dgvFacturas = new IngenieriaSoftware.UI.ControlesPersonalizados.DataGridViewConFiltros();
            this.gBListaOrdenCompra.SuspendLayout();
            this.SuspendLayout();
            // 
            // gBListaOrdenCompra
            // 
            this.gBListaOrdenCompra.AutoSize = true;
            this.gBListaOrdenCompra.Controls.Add(this.btnAnular);
            this.gBListaOrdenCompra.Controls.Add(this.btnGenerarPdf);
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
            this.gBListaOrdenCompra.Location = new System.Drawing.Point(146, 32);
            this.gBListaOrdenCompra.Margin = new System.Windows.Forms.Padding(2);
            this.gBListaOrdenCompra.Name = "gBListaOrdenCompra";
            this.gBListaOrdenCompra.Padding = new System.Windows.Forms.Padding(2);
            this.gBListaOrdenCompra.Size = new System.Drawing.Size(1040, 228);
            this.gBListaOrdenCompra.TabIndex = 36;
            this.gBListaOrdenCompra.TabStop = false;
            this.gBListaOrdenCompra.Tag = "";
            this.gBListaOrdenCompra.Text = "Factura";
            // 
            // btnAnular
            // 
            this.btnAnular.BackColor = System.Drawing.Color.Maroon;
            this.btnAnular.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnular.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnular.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnAnular.Location = new System.Drawing.Point(612, 165);
            this.btnAnular.Margin = new System.Windows.Forms.Padding(2);
            this.btnAnular.Name = "btnAnular";
            this.btnAnular.Size = new System.Drawing.Size(132, 37);
            this.btnAnular.TabIndex = 6;
            this.btnAnular.Tag = "";
            this.btnAnular.Text = "Anular Factura";
            this.btnAnular.UseVisualStyleBackColor = false;
            this.btnAnular.Click += new System.EventHandler(this.btnAnular_Click);
            // 
            // btnGenerarPdf
            // 
            this.btnGenerarPdf.BackColor = System.Drawing.Color.Orange;
            this.btnGenerarPdf.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerarPdf.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerarPdf.ForeColor = System.Drawing.Color.Black;
            this.btnGenerarPdf.Location = new System.Drawing.Point(883, 50);
            this.btnGenerarPdf.Margin = new System.Windows.Forms.Padding(2);
            this.btnGenerarPdf.Name = "btnGenerarPdf";
            this.btnGenerarPdf.Size = new System.Drawing.Size(103, 97);
            this.btnGenerarPdf.TabIndex = 1247;
            this.btnGenerarPdf.Tag = "";
            this.btnGenerarPdf.Text = "Generar PDF";
            this.btnGenerarPdf.UseVisualStyleBackColor = false;
            this.btnGenerarPdf.Click += new System.EventHandler(this.btnGenerarPdf_Click);
            // 
            // dtpFechaDesde
            // 
            this.dtpFechaDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaDesde.Location = new System.Drawing.Point(300, 82);
            this.dtpFechaDesde.Name = "dtpFechaDesde";
            this.dtpFechaDesde.Size = new System.Drawing.Size(219, 28);
            this.dtpFechaDesde.TabIndex = 2;
            this.dtpFechaDesde.Tag = "";
            this.dtpFechaDesde.Value = new System.DateTime(2025, 9, 16, 23, 18, 0, 0);
            // 
            // cbEstado
            // 
            this.cbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEstado.FormattingEnabled = true;
            this.cbEstado.Location = new System.Drawing.Point(555, 82);
            this.cbEstado.Name = "cbEstado";
            this.cbEstado.Size = new System.Drawing.Size(189, 30);
            this.cbEstado.TabIndex = 3;
            this.cbEstado.Tag = "";
            // 
            // Estado
            // 
            this.Estado.AutoSize = true;
            this.Estado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Estado.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Estado.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Estado.Location = new System.Drawing.Point(551, 58);
            this.Estado.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Estado.Name = "Estado";
            this.Estado.Size = new System.Drawing.Size(56, 21);
            this.Estado.TabIndex = 41;
            this.Estado.Tag = "";
            this.Estado.Text = "Estado";
            // 
            // lblFechaDesde
            // 
            this.lblFechaDesde.AutoSize = true;
            this.lblFechaDesde.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblFechaDesde.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaDesde.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblFechaDesde.Location = new System.Drawing.Point(296, 58);
            this.lblFechaDesde.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFechaDesde.Name = "lblFechaDesde";
            this.lblFechaDesde.Size = new System.Drawing.Size(95, 21);
            this.lblFechaDesde.TabIndex = 39;
            this.lblFechaDesde.Tag = "";
            this.lblFechaDesde.Text = "Fecha desde";
            // 
            // txtNumFactura
            // 
            this.txtNumFactura.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtNumFactura.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumFactura.ForeColor = System.Drawing.Color.DimGray;
            this.txtNumFactura.Location = new System.Drawing.Point(80, 83);
            this.txtNumFactura.Margin = new System.Windows.Forms.Padding(2);
            this.txtNumFactura.Name = "txtNumFactura";
            this.txtNumFactura.Size = new System.Drawing.Size(189, 29);
            this.txtNumFactura.TabIndex = 1;
            this.txtNumFactura.Tag = "";
            // 
            // lblNumeroFactura
            // 
            this.lblNumeroFactura.AutoSize = true;
            this.lblNumeroFactura.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblNumeroFactura.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumeroFactura.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblNumeroFactura.Location = new System.Drawing.Point(76, 60);
            this.lblNumeroFactura.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNumeroFactura.Name = "lblNumeroFactura";
            this.lblNumeroFactura.Size = new System.Drawing.Size(103, 21);
            this.lblNumeroFactura.TabIndex = 36;
            this.lblNumeroFactura.Tag = "";
            this.lblNumeroFactura.Text = "Num. Factura";
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnBuscar.Location = new System.Drawing.Point(767, 165);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(2);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(103, 37);
            this.btnBuscar.TabIndex = 4;
            this.btnBuscar.Tag = "";
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnLimpiar.Location = new System.Drawing.Point(883, 165);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(2);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(103, 37);
            this.btnLimpiar.TabIndex = 5;
            this.btnLimpiar.Tag = "";
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            // 
            // dgvFacturas
            // 
            this.dgvFacturas.BackColor = System.Drawing.Color.Transparent;
            this.dgvFacturas.Location = new System.Drawing.Point(146, 338);
            this.dgvFacturas.Margin = new System.Windows.Forms.Padding(2);
            this.dgvFacturas.Name = "dgvFacturas";
            this.dgvFacturas.Size = new System.Drawing.Size(1016, 282);
            this.dgvFacturas.TabIndex = 38;
            this.dgvFacturas.Tag = "";
            this.dgvFacturas.TamanoGrilla = IngenieriaSoftware.UI.ControlesPersonalizados.grillaCustom.ModoTamanoGrilla.Grande;
            // 
            // FormListaFacturas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1342, 857);
            this.Controls.Add(this.dgvFacturas);
            this.Controls.Add(this.gBListaOrdenCompra);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormListaFacturas";
            this.Tag = "";
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
        private System.Windows.Forms.Button btnAnular;
        private System.Windows.Forms.Button btnGenerarPdf;
    }
}