namespace IngenieriaSoftware.UI.ComprasProveedores.Facturas
{
    partial class FormAgregarFactura
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
            this.btnAceptarOrden = new System.Windows.Forms.Button();
            this.btnRechazarOrden = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.dgvProductosOrdenCompra = new IngenieriaSoftware.UI.ControlesPersonalizados.DataGridViewConFiltros();
            this.lblAgregarFactura = new System.Windows.Forms.Label();
            this.gBDatosGenerales = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.lblObligatorio = new System.Windows.Forms.Label();
            this.dtpFechaEntregaEsperada = new System.Windows.Forms.DateTimePicker();
            this.lblNumFactura = new System.Windows.Forms.Label();
            this.dtpFechaEmision = new System.Windows.Forms.DateTimePicker();
            this.txtNumFactura = new System.Windows.Forms.TextBox();
            this.lblFechaEmision = new System.Windows.Forms.Label();
            this.lblFechaEntrega = new System.Windows.Forms.Label();
            this.lblTipoCambio = new System.Windows.Forms.Label();
            this.lblTotalEsperado = new System.Windows.Forms.Label();
            this.btnSeleccionarProductos = new System.Windows.Forms.Button();
            this.btnGenerarOrdenCompra = new System.Windows.Forms.Button();
            this.txtCondicionesPago = new System.Windows.Forms.TextBox();
            this.lblCondicionesPago = new System.Windows.Forms.Label();
            this.gbPagoMoneda = new System.Windows.Forms.GroupBox();
            this.txtNumericTipoCambio = new IngenieriaSoftware.UI.ControlesPersonalizados.Inputs.InputNumericTextBox();
            this.txtNumericTotalEsperado = new IngenieriaSoftware.UI.ControlesPersonalizados.Inputs.InputNumericTextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lblMoneda = new System.Windows.Forms.Label();
            this.txtMoneda = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblNumeroOrden = new System.Windows.Forms.Label();
            this.dgvProductosFactura = new IngenieriaSoftware.UI.ControlesPersonalizados.DataGridViewConFiltros();
            this.gBDatosGenerales.SuspendLayout();
            this.gbPagoMoneda.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAceptarOrden
            // 
            this.btnAceptarOrden.BackColor = System.Drawing.Color.DarkGreen;
            this.btnAceptarOrden.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAceptarOrden.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptarOrden.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnAceptarOrden.Location = new System.Drawing.Point(218, 1029);
            this.btnAceptarOrden.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAceptarOrden.Name = "btnAceptarOrden";
            this.btnAceptarOrden.Size = new System.Drawing.Size(201, 64);
            this.btnAceptarOrden.TabIndex = 128;
            this.btnAceptarOrden.Tag = "";
            this.btnAceptarOrden.Text = "Aceptar Orden";
            this.btnAceptarOrden.UseVisualStyleBackColor = false;
            // 
            // btnRechazarOrden
            // 
            this.btnRechazarOrden.BackColor = System.Drawing.Color.Maroon;
            this.btnRechazarOrden.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRechazarOrden.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRechazarOrden.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnRechazarOrden.Location = new System.Drawing.Point(449, 1029);
            this.btnRechazarOrden.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRechazarOrden.Name = "btnRechazarOrden";
            this.btnRechazarOrden.Size = new System.Drawing.Size(201, 64);
            this.btnRechazarOrden.TabIndex = 127;
            this.btnRechazarOrden.Tag = "";
            this.btnRechazarOrden.Text = "Rechazar Orden";
            this.btnRechazarOrden.UseVisualStyleBackColor = false;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.SystemColors.WindowText;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnBuscar.Location = new System.Drawing.Point(1143, 1029);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(2);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(193, 64);
            this.btnBuscar.TabIndex = 126;
            this.btnBuscar.Tag = "";
            this.btnBuscar.Text = "Cancelar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            // 
            // dgvProductosOrdenCompra
            // 
            this.dgvProductosOrdenCompra.BackColor = System.Drawing.Color.Transparent;
            this.dgvProductosOrdenCompra.Location = new System.Drawing.Point(35, 321);
            this.dgvProductosOrdenCompra.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvProductosOrdenCompra.Name = "dgvProductosOrdenCompra";
            this.dgvProductosOrdenCompra.Size = new System.Drawing.Size(906, 487);
            this.dgvProductosOrdenCompra.TabIndex = 124;
            this.dgvProductosOrdenCompra.Tag = "";
            // 
            // lblAgregarFactura
            // 
            this.lblAgregarFactura.AutoSize = true;
            this.lblAgregarFactura.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblAgregarFactura.Font = new System.Drawing.Font("Segoe UI Symbol", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAgregarFactura.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblAgregarFactura.Location = new System.Drawing.Point(69, 57);
            this.lblAgregarFactura.Name = "lblAgregarFactura";
            this.lblAgregarFactura.Size = new System.Drawing.Size(275, 46);
            this.lblAgregarFactura.TabIndex = 116;
            this.lblAgregarFactura.Tag = "";
            this.lblAgregarFactura.Text = "Agregar Factura";
            // 
            // gBDatosGenerales
            // 
            this.gBDatosGenerales.AutoSize = true;
            this.gBDatosGenerales.Controls.Add(this.label8);
            this.gBDatosGenerales.Controls.Add(this.lblObligatorio);
            this.gBDatosGenerales.Controls.Add(this.dtpFechaEntregaEsperada);
            this.gBDatosGenerales.Controls.Add(this.lblNumFactura);
            this.gBDatosGenerales.Controls.Add(this.dtpFechaEmision);
            this.gBDatosGenerales.Controls.Add(this.txtNumFactura);
            this.gBDatosGenerales.Controls.Add(this.lblFechaEmision);
            this.gBDatosGenerales.Controls.Add(this.lblFechaEntrega);
            this.gBDatosGenerales.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gBDatosGenerales.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.gBDatosGenerales.Location = new System.Drawing.Point(76, 120);
            this.gBDatosGenerales.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gBDatosGenerales.Name = "gBDatosGenerales";
            this.gBDatosGenerales.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gBDatosGenerales.Size = new System.Drawing.Size(1271, 156);
            this.gBDatosGenerales.TabIndex = 120;
            this.gBDatosGenerales.TabStop = false;
            this.gBDatosGenerales.Tag = "";
            this.gBDatosGenerales.Text = "Datos generales";
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label8.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(680, 59);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(20, 28);
            this.label8.TabIndex = 89;
            this.label8.Tag = "1259";
            this.label8.Text = "*";
            // 
            // lblObligatorio
            // 
            this.lblObligatorio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblObligatorio.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblObligatorio.ForeColor = System.Drawing.Color.Red;
            this.lblObligatorio.Location = new System.Drawing.Point(205, 57);
            this.lblObligatorio.Name = "lblObligatorio";
            this.lblObligatorio.Size = new System.Drawing.Size(20, 28);
            this.lblObligatorio.TabIndex = 86;
            this.lblObligatorio.Tag = "";
            this.lblObligatorio.Text = "*";
            // 
            // dtpFechaEntregaEsperada
            // 
            this.dtpFechaEntregaEsperada.Checked = false;
            this.dtpFechaEntregaEsperada.CustomFormat = " ";
            this.dtpFechaEntregaEsperada.Font = new System.Drawing.Font("Segoe UI Symbol", 12F);
            this.dtpFechaEntregaEsperada.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaEntregaEsperada.Location = new System.Drawing.Point(1013, 89);
            this.dtpFechaEntregaEsperada.Margin = new System.Windows.Forms.Padding(4);
            this.dtpFechaEntregaEsperada.Name = "dtpFechaEntregaEsperada";
            this.dtpFechaEntregaEsperada.ShowCheckBox = true;
            this.dtpFechaEntregaEsperada.Size = new System.Drawing.Size(251, 34);
            this.dtpFechaEntregaEsperada.TabIndex = 85;
            this.dtpFechaEntregaEsperada.Tag = "";
            this.dtpFechaEntregaEsperada.Value = new System.DateTime(2025, 9, 25, 0, 0, 0, 0);
            // 
            // lblNumFactura
            // 
            this.lblNumFactura.AutoSize = true;
            this.lblNumFactura.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblNumFactura.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumFactura.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblNumFactura.Location = new System.Drawing.Point(55, 59);
            this.lblNumFactura.Name = "lblNumFactura";
            this.lblNumFactura.Size = new System.Drawing.Size(155, 28);
            this.lblNumFactura.TabIndex = 68;
            this.lblNumFactura.Tag = "";
            this.lblNumFactura.Text = "Núm. de Factura";
            // 
            // dtpFechaEmision
            // 
            this.dtpFechaEmision.Font = new System.Drawing.Font("Segoe UI Symbol", 12F);
            this.dtpFechaEmision.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaEmision.Location = new System.Drawing.Point(557, 89);
            this.dtpFechaEmision.Margin = new System.Windows.Forms.Padding(4);
            this.dtpFechaEmision.Name = "dtpFechaEmision";
            this.dtpFechaEmision.Size = new System.Drawing.Size(251, 34);
            this.dtpFechaEmision.TabIndex = 84;
            this.dtpFechaEmision.Tag = "";
            // 
            // txtNumFactura
            // 
            this.txtNumFactura.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtNumFactura.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumFactura.ForeColor = System.Drawing.Color.DimGray;
            this.txtNumFactura.Location = new System.Drawing.Point(60, 89);
            this.txtNumFactura.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNumFactura.Name = "txtNumFactura";
            this.txtNumFactura.Size = new System.Drawing.Size(251, 34);
            this.txtNumFactura.TabIndex = 67;
            this.txtNumFactura.Tag = "";
            // 
            // lblFechaEmision
            // 
            this.lblFechaEmision.AutoSize = true;
            this.lblFechaEmision.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblFechaEmision.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaEmision.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblFechaEmision.Location = new System.Drawing.Point(551, 59);
            this.lblFechaEmision.Name = "lblFechaEmision";
            this.lblFechaEmision.Size = new System.Drawing.Size(135, 28);
            this.lblFechaEmision.TabIndex = 70;
            this.lblFechaEmision.Tag = "";
            this.lblFechaEmision.Text = "Fecha emisión";
            // 
            // lblFechaEntrega
            // 
            this.lblFechaEntrega.AutoSize = true;
            this.lblFechaEntrega.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblFechaEntrega.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaEntrega.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblFechaEntrega.Location = new System.Drawing.Point(1008, 57);
            this.lblFechaEntrega.Name = "lblFechaEntrega";
            this.lblFechaEntrega.Size = new System.Drawing.Size(139, 28);
            this.lblFechaEntrega.TabIndex = 73;
            this.lblFechaEntrega.Tag = "";
            this.lblFechaEntrega.Text = "Fecha entrega ";
            // 
            // lblTipoCambio
            // 
            this.lblTipoCambio.AutoSize = true;
            this.lblTipoCambio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblTipoCambio.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoCambio.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblTipoCambio.Location = new System.Drawing.Point(738, 68);
            this.lblTipoCambio.Name = "lblTipoCambio";
            this.lblTipoCambio.Size = new System.Drawing.Size(148, 28);
            this.lblTipoCambio.TabIndex = 79;
            this.lblTipoCambio.Tag = "";
            this.lblTipoCambio.Text = "Tipo de cambio";
            // 
            // lblTotalEsperado
            // 
            this.lblTotalEsperado.AutoSize = true;
            this.lblTotalEsperado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblTotalEsperado.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalEsperado.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblTotalEsperado.Location = new System.Drawing.Point(79, 66);
            this.lblTotalEsperado.Name = "lblTotalEsperado";
            this.lblTotalEsperado.Size = new System.Drawing.Size(142, 28);
            this.lblTotalEsperado.TabIndex = 81;
            this.lblTotalEsperado.Tag = "";
            this.lblTotalEsperado.Text = "Total esperado";
            // 
            // btnSeleccionarProductos
            // 
            this.btnSeleccionarProductos.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnSeleccionarProductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSeleccionarProductos.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeleccionarProductos.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnSeleccionarProductos.Location = new System.Drawing.Point(1385, 177);
            this.btnSeleccionarProductos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSeleccionarProductos.Name = "btnSeleccionarProductos";
            this.btnSeleccionarProductos.Size = new System.Drawing.Size(313, 64);
            this.btnSeleccionarProductos.TabIndex = 117;
            this.btnSeleccionarProductos.Tag = "";
            this.btnSeleccionarProductos.Text = "Seleccionar productos";
            this.btnSeleccionarProductos.UseVisualStyleBackColor = false;
            // 
            // btnGenerarOrdenCompra
            // 
            this.btnGenerarOrdenCompra.BackColor = System.Drawing.Color.DarkGreen;
            this.btnGenerarOrdenCompra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerarOrdenCompra.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerarOrdenCompra.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnGenerarOrdenCompra.Location = new System.Drawing.Point(724, 1029);
            this.btnGenerarOrdenCompra.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGenerarOrdenCompra.Name = "btnGenerarOrdenCompra";
            this.btnGenerarOrdenCompra.Size = new System.Drawing.Size(376, 64);
            this.btnGenerarOrdenCompra.TabIndex = 115;
            this.btnGenerarOrdenCompra.Tag = "";
            this.btnGenerarOrdenCompra.Text = "Generar Orden";
            this.btnGenerarOrdenCompra.UseVisualStyleBackColor = false;
            // 
            // txtCondicionesPago
            // 
            this.txtCondicionesPago.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtCondicionesPago.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCondicionesPago.ForeColor = System.Drawing.Color.DimGray;
            this.txtCondicionesPago.Location = new System.Drawing.Point(1076, 97);
            this.txtCondicionesPago.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCondicionesPago.Name = "txtCondicionesPago";
            this.txtCondicionesPago.Size = new System.Drawing.Size(201, 34);
            this.txtCondicionesPago.TabIndex = 100;
            this.txtCondicionesPago.Tag = "";
            // 
            // lblCondicionesPago
            // 
            this.lblCondicionesPago.AutoSize = true;
            this.lblCondicionesPago.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblCondicionesPago.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCondicionesPago.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblCondicionesPago.Location = new System.Drawing.Point(1070, 67);
            this.lblCondicionesPago.Name = "lblCondicionesPago";
            this.lblCondicionesPago.Size = new System.Drawing.Size(155, 28);
            this.lblCondicionesPago.TabIndex = 101;
            this.lblCondicionesPago.Tag = "";
            this.lblCondicionesPago.Text = "Condic. de pago";
            // 
            // gbPagoMoneda
            // 
            this.gbPagoMoneda.AutoSize = true;
            this.gbPagoMoneda.Controls.Add(this.txtNumericTipoCambio);
            this.gbPagoMoneda.Controls.Add(this.txtNumericTotalEsperado);
            this.gbPagoMoneda.Controls.Add(this.label13);
            this.gbPagoMoneda.Controls.Add(this.label12);
            this.gbPagoMoneda.Controls.Add(this.lblMoneda);
            this.gbPagoMoneda.Controls.Add(this.txtMoneda);
            this.gbPagoMoneda.Controls.Add(this.lblTipoCambio);
            this.gbPagoMoneda.Controls.Add(this.txtCondicionesPago);
            this.gbPagoMoneda.Controls.Add(this.lblCondicionesPago);
            this.gbPagoMoneda.Controls.Add(this.lblTotalEsperado);
            this.gbPagoMoneda.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbPagoMoneda.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.gbPagoMoneda.Location = new System.Drawing.Point(55, 812);
            this.gbPagoMoneda.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbPagoMoneda.Name = "gbPagoMoneda";
            this.gbPagoMoneda.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbPagoMoneda.Size = new System.Drawing.Size(1289, 170);
            this.gbPagoMoneda.TabIndex = 118;
            this.gbPagoMoneda.TabStop = false;
            this.gbPagoMoneda.Tag = "";
            this.gbPagoMoneda.Text = "Pago y moneda";
            // 
            // txtNumericTipoCambio
            // 
            this.txtNumericTipoCambio.Font = new System.Drawing.Font("Segoe UI Symbol", 12F);
            this.txtNumericTipoCambio.Location = new System.Drawing.Point(743, 97);
            this.txtNumericTipoCambio.Name = "txtNumericTipoCambio";
            this.txtNumericTipoCambio.Size = new System.Drawing.Size(201, 34);
            this.txtNumericTipoCambio.TabIndex = 111;
            this.txtNumericTipoCambio.Tag = "";
            this.txtNumericTipoCambio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtNumericTotalEsperado
            // 
            this.txtNumericTotalEsperado.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtNumericTotalEsperado.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.RecentlyUsedList;
            this.txtNumericTotalEsperado.Location = new System.Drawing.Point(84, 97);
            this.txtNumericTotalEsperado.Name = "txtNumericTotalEsperado";
            this.txtNumericTotalEsperado.Size = new System.Drawing.Size(201, 34);
            this.txtNumericTotalEsperado.TabIndex = 111;
            this.txtNumericTotalEsperado.Tag = "";
            this.txtNumericTotalEsperado.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label13.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Red;
            this.label13.Location = new System.Drawing.Point(216, 65);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(20, 28);
            this.label13.TabIndex = 89;
            this.label13.Tag = "";
            this.label13.Text = "*";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label12.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Red;
            this.label12.Location = new System.Drawing.Point(464, 66);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(20, 28);
            this.label12.TabIndex = 89;
            this.label12.Tag = "";
            this.label12.Text = "*";
            // 
            // lblMoneda
            // 
            this.lblMoneda.AutoSize = true;
            this.lblMoneda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblMoneda.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMoneda.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblMoneda.Location = new System.Drawing.Point(385, 67);
            this.lblMoneda.Name = "lblMoneda";
            this.lblMoneda.Size = new System.Drawing.Size(85, 28);
            this.lblMoneda.TabIndex = 77;
            this.lblMoneda.Tag = "";
            this.lblMoneda.Text = "Moneda";
            // 
            // txtMoneda
            // 
            this.txtMoneda.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtMoneda.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMoneda.ForeColor = System.Drawing.Color.DimGray;
            this.txtMoneda.Location = new System.Drawing.Point(387, 97);
            this.txtMoneda.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMoneda.Name = "txtMoneda";
            this.txtMoneda.Size = new System.Drawing.Size(201, 34);
            this.txtMoneda.TabIndex = 76;
            this.txtMoneda.Tag = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Font = new System.Drawing.Font("Segoe UI Symbol", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(852, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(214, 46);
            this.label2.TabIndex = 129;
            this.label2.Tag = "";
            this.label2.Text = "Num Orden:";
            // 
            // lblNumeroOrden
            // 
            this.lblNumeroOrden.AutoSize = true;
            this.lblNumeroOrden.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblNumeroOrden.Font = new System.Drawing.Font("Segoe UI Symbol", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumeroOrden.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblNumeroOrden.Location = new System.Drawing.Point(1081, 57);
            this.lblNumeroOrden.Name = "lblNumeroOrden";
            this.lblNumeroOrden.Size = new System.Drawing.Size(0, 46);
            this.lblNumeroOrden.TabIndex = 130;
            this.lblNumeroOrden.Tag = "";
            // 
            // dgvProductosFactura
            // 
            this.dgvProductosFactura.BackColor = System.Drawing.Color.Transparent;
            this.dgvProductosFactura.Location = new System.Drawing.Point(947, 321);
            this.dgvProductosFactura.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvProductosFactura.Name = "dgvProductosFactura";
            this.dgvProductosFactura.Size = new System.Drawing.Size(906, 487);
            this.dgvProductosFactura.TabIndex = 131;
            this.dgvProductosFactura.Tag = "";
            // 
            // FormAgregarFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoScrollMinSize = new System.Drawing.Size(0, 1500);
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1924, 938);
            this.Controls.Add(this.dgvProductosFactura);
            this.Controls.Add(this.lblNumeroOrden);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnAceptarOrden);
            this.Controls.Add(this.btnRechazarOrden);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.dgvProductosOrdenCompra);
            this.Controls.Add(this.lblAgregarFactura);
            this.Controls.Add(this.gBDatosGenerales);
            this.Controls.Add(this.btnSeleccionarProductos);
            this.Controls.Add(this.btnGenerarOrdenCompra);
            this.Controls.Add(this.gbPagoMoneda);
            this.Name = "FormAgregarFactura";
            this.Text = "FormAgregarFactura";
            this.gBDatosGenerales.ResumeLayout(false);
            this.gBDatosGenerales.PerformLayout();
            this.gbPagoMoneda.ResumeLayout(false);
            this.gbPagoMoneda.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAceptarOrden;
        private System.Windows.Forms.Button btnRechazarOrden;
        private System.Windows.Forms.Button btnBuscar;
        private ControlesPersonalizados.DataGridViewConFiltros dgvProductosOrdenCompra;
        private System.Windows.Forms.Label lblAgregarFactura;
        private System.Windows.Forms.GroupBox gBDatosGenerales;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblObligatorio;
        private System.Windows.Forms.DateTimePicker dtpFechaEntregaEsperada;
        private System.Windows.Forms.Label lblNumFactura;
        private System.Windows.Forms.DateTimePicker dtpFechaEmision;
        private System.Windows.Forms.TextBox txtNumFactura;
        private System.Windows.Forms.Label lblFechaEmision;
        private System.Windows.Forms.Label lblFechaEntrega;
        private System.Windows.Forms.Label lblTipoCambio;
        private System.Windows.Forms.Label lblTotalEsperado;
        private System.Windows.Forms.Button btnSeleccionarProductos;
        private System.Windows.Forms.Button btnGenerarOrdenCompra;
        private System.Windows.Forms.TextBox txtCondicionesPago;
        private System.Windows.Forms.Label lblCondicionesPago;
        private System.Windows.Forms.GroupBox gbPagoMoneda;
        private ControlesPersonalizados.Inputs.InputNumericTextBox txtNumericTipoCambio;
        private ControlesPersonalizados.Inputs.InputNumericTextBox txtNumericTotalEsperado;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblMoneda;
        private System.Windows.Forms.TextBox txtMoneda;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblNumeroOrden;
        private ControlesPersonalizados.DataGridViewConFiltros dgvProductosFactura;
    }
}