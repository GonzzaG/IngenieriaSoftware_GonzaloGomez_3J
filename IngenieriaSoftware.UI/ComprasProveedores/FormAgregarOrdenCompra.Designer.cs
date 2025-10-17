namespace IngenieriaSoftware.UI.ComprasProveedores
{
    partial class FormAgregarOrdenCompra
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
            this.btnGenerarOrdenCompra = new System.Windows.Forms.Button();
            this.btnSeleccionarProductos = new System.Windows.Forms.Button();
            this.txtAreaObservaciones = new System.Windows.Forms.TextBox();
            this.txtCondicionesPago = new System.Windows.Forms.TextBox();
            this.lblCondicionesPago = new System.Windows.Forms.Label();
            this.gbPagoMoneda = new System.Windows.Forms.GroupBox();
            this.txtNumericTipoCambio = new IngenieriaSoftware.UI.ControlesPersonalizados.Inputs.InputNumericTextBox();
            this.txtNumericTotalEsperado = new IngenieriaSoftware.UI.ControlesPersonalizados.Inputs.InputNumericTextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lblMoneda = new System.Windows.Forms.Label();
            this.txtMoneda = new System.Windows.Forms.TextBox();
            this.lblTipoCambio = new System.Windows.Forms.Label();
            this.lblTotalEsperado = new System.Windows.Forms.Label();
            this.gBDatosGenerales = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.lblObligatorio = new System.Windows.Forms.Label();
            this.dtpFechaEntregaEsperada = new System.Windows.Forms.DateTimePicker();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.dtpFechaEmision = new System.Windows.Forms.DateTimePicker();
            this.txtNumeroOrdenCompra = new System.Windows.Forms.TextBox();
            this.lblFechaEmision = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.cbProveedor = new System.Windows.Forms.ComboBox();
            this.lblProveedor = new System.Windows.Forms.Label();
            this.lblOrdenCompra = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnRechazarOrden = new System.Windows.Forms.Button();
            this.btnAceptarOrden = new System.Windows.Forms.Button();
            this.dgvProductosOrdenCompra = new IngenieriaSoftware.UI.ControlesPersonalizados.DataGridViewConFiltros();
            this.gbPagoMoneda.SuspendLayout();
            this.gBDatosGenerales.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGenerarOrdenCompra
            // 
            this.btnGenerarOrdenCompra.BackColor = System.Drawing.Color.DarkGreen;
            this.btnGenerarOrdenCompra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerarOrdenCompra.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerarOrdenCompra.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnGenerarOrdenCompra.Location = new System.Drawing.Point(730, 1038);
            this.btnGenerarOrdenCompra.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGenerarOrdenCompra.Name = "btnGenerarOrdenCompra";
            this.btnGenerarOrdenCompra.Size = new System.Drawing.Size(376, 64);
            this.btnGenerarOrdenCompra.TabIndex = 39;
            this.btnGenerarOrdenCompra.Tag = "56";
            this.btnGenerarOrdenCompra.Text = "Generar Orden";
            this.btnGenerarOrdenCompra.UseVisualStyleBackColor = false;
            this.btnGenerarOrdenCompra.Click += new System.EventHandler(this.btnGenerarOrdenCompra_Click);
            // 
            // btnSeleccionarProductos
            // 
            this.btnSeleccionarProductos.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnSeleccionarProductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSeleccionarProductos.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeleccionarProductos.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnSeleccionarProductos.Location = new System.Drawing.Point(1032, 343);
            this.btnSeleccionarProductos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSeleccionarProductos.Name = "btnSeleccionarProductos";
            this.btnSeleccionarProductos.Size = new System.Drawing.Size(313, 64);
            this.btnSeleccionarProductos.TabIndex = 97;
            this.btnSeleccionarProductos.Text = "Seleccionar productos";
            this.btnSeleccionarProductos.UseVisualStyleBackColor = false;
            this.btnSeleccionarProductos.Click += new System.EventHandler(this.btnSeleccionarProductos_Click);
            // 
            // txtAreaObservaciones
            // 
            this.txtAreaObservaciones.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtAreaObservaciones.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAreaObservaciones.ForeColor = System.Drawing.Color.DimGray;
            this.txtAreaObservaciones.Location = new System.Drawing.Point(1032, 570);
            this.txtAreaObservaciones.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtAreaObservaciones.Multiline = true;
            this.txtAreaObservaciones.Name = "txtAreaObservaciones";
            this.txtAreaObservaciones.Size = new System.Drawing.Size(309, 146);
            this.txtAreaObservaciones.TabIndex = 102;
            this.txtAreaObservaciones.Tag = "117";
            // 
            // txtCondicionesPago
            // 
            this.txtCondicionesPago.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtCondicionesPago.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCondicionesPago.ForeColor = System.Drawing.Color.DimGray;
            this.txtCondicionesPago.Location = new System.Drawing.Point(1076, 97);
            this.txtCondicionesPago.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCondicionesPago.Name = "txtCondicionesPago";
            this.txtCondicionesPago.Size = new System.Drawing.Size(201, 29);
            this.txtCondicionesPago.TabIndex = 100;
            this.txtCondicionesPago.Tag = "117";
            // 
            // lblCondicionesPago
            // 
            this.lblCondicionesPago.AutoSize = true;
            this.lblCondicionesPago.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblCondicionesPago.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCondicionesPago.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblCondicionesPago.Location = new System.Drawing.Point(1070, 67);
            this.lblCondicionesPago.Name = "lblCondicionesPago";
            this.lblCondicionesPago.Size = new System.Drawing.Size(121, 21);
            this.lblCondicionesPago.TabIndex = 101;
            this.lblCondicionesPago.Tag = "116";
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
            this.gbPagoMoneda.Location = new System.Drawing.Point(61, 821);
            this.gbPagoMoneda.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbPagoMoneda.Name = "gbPagoMoneda";
            this.gbPagoMoneda.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbPagoMoneda.Size = new System.Drawing.Size(1289, 170);
            this.gbPagoMoneda.TabIndex = 98;
            this.gbPagoMoneda.TabStop = false;
            this.gbPagoMoneda.Text = "Pago y moneda";
            // 
            // txtNumericTipoCambio
            // 
            this.txtNumericTipoCambio.Font = new System.Drawing.Font("Segoe UI Symbol", 12F);
            this.txtNumericTipoCambio.Location = new System.Drawing.Point(743, 97);
            this.txtNumericTipoCambio.Name = "txtNumericTipoCambio";
            this.txtNumericTipoCambio.Size = new System.Drawing.Size(201, 29);
            this.txtNumericTipoCambio.TabIndex = 111;
            this.txtNumericTipoCambio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtNumericTotalEsperado
            // 
            this.txtNumericTotalEsperado.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtNumericTotalEsperado.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.RecentlyUsedList;
            this.txtNumericTotalEsperado.Location = new System.Drawing.Point(84, 97);
            this.txtNumericTotalEsperado.Name = "txtNumericTotalEsperado";
            this.txtNumericTotalEsperado.Size = new System.Drawing.Size(201, 28);
            this.txtNumericTotalEsperado.TabIndex = 111;
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
            this.label13.Size = new System.Drawing.Size(17, 21);
            this.label13.TabIndex = 89;
            this.label13.Tag = "116";
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
            this.label12.Size = new System.Drawing.Size(17, 21);
            this.label12.TabIndex = 89;
            this.label12.Tag = "116";
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
            this.lblMoneda.Size = new System.Drawing.Size(67, 21);
            this.lblMoneda.TabIndex = 77;
            this.lblMoneda.Tag = "116";
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
            this.txtMoneda.Size = new System.Drawing.Size(201, 29);
            this.txtMoneda.TabIndex = 76;
            this.txtMoneda.Tag = "117";
            // 
            // lblTipoCambio
            // 
            this.lblTipoCambio.AutoSize = true;
            this.lblTipoCambio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblTipoCambio.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoCambio.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblTipoCambio.Location = new System.Drawing.Point(738, 68);
            this.lblTipoCambio.Name = "lblTipoCambio";
            this.lblTipoCambio.Size = new System.Drawing.Size(116, 21);
            this.lblTipoCambio.TabIndex = 79;
            this.lblTipoCambio.Tag = "116";
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
            this.lblTotalEsperado.Size = new System.Drawing.Size(112, 21);
            this.lblTotalEsperado.TabIndex = 81;
            this.lblTotalEsperado.Tag = "116";
            this.lblTotalEsperado.Text = "Total esperado";
            // 
            // gBDatosGenerales
            // 
            this.gBDatosGenerales.AutoSize = true;
            this.gBDatosGenerales.Controls.Add(this.label8);
            this.gBDatosGenerales.Controls.Add(this.lblObligatorio);
            this.gBDatosGenerales.Controls.Add(this.dtpFechaEntregaEsperada);
            this.gBDatosGenerales.Controls.Add(this.lblCodigo);
            this.gBDatosGenerales.Controls.Add(this.dtpFechaEmision);
            this.gBDatosGenerales.Controls.Add(this.txtNumeroOrdenCompra);
            this.gBDatosGenerales.Controls.Add(this.lblFechaEmision);
            this.gBDatosGenerales.Controls.Add(this.label4);
            this.gBDatosGenerales.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gBDatosGenerales.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.gBDatosGenerales.Location = new System.Drawing.Point(82, 129);
            this.gBDatosGenerales.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gBDatosGenerales.Name = "gBDatosGenerales";
            this.gBDatosGenerales.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gBDatosGenerales.Size = new System.Drawing.Size(1271, 156);
            this.gBDatosGenerales.TabIndex = 106;
            this.gBDatosGenerales.TabStop = false;
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
            this.label8.Tag = "116";
            this.label8.Text = "*";
            // 
            // lblObligatorio
            // 
            this.lblObligatorio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblObligatorio.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblObligatorio.ForeColor = System.Drawing.Color.Red;
            this.lblObligatorio.Location = new System.Drawing.Point(291, 59);
            this.lblObligatorio.Name = "lblObligatorio";
            this.lblObligatorio.Size = new System.Drawing.Size(20, 28);
            this.lblObligatorio.TabIndex = 86;
            this.lblObligatorio.Tag = "116";
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
            this.dtpFechaEntregaEsperada.Size = new System.Drawing.Size(251, 29);
            this.dtpFechaEntregaEsperada.TabIndex = 85;
            this.dtpFechaEntregaEsperada.Value = new System.DateTime(2025, 9, 25, 0, 0, 0, 0);
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblCodigo.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigo.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblCodigo.Location = new System.Drawing.Point(55, 59);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(192, 21);
            this.lblCodigo.TabIndex = 68;
            this.lblCodigo.Tag = "116";
            this.lblCodigo.Text = "Núm. de orden de compra";
            // 
            // dtpFechaEmision
            // 
            this.dtpFechaEmision.Font = new System.Drawing.Font("Segoe UI Symbol", 12F);
            this.dtpFechaEmision.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaEmision.Location = new System.Drawing.Point(557, 89);
            this.dtpFechaEmision.Margin = new System.Windows.Forms.Padding(4);
            this.dtpFechaEmision.Name = "dtpFechaEmision";
            this.dtpFechaEmision.Size = new System.Drawing.Size(251, 29);
            this.dtpFechaEmision.TabIndex = 84;
            // 
            // txtNumeroOrdenCompra
            // 
            this.txtNumeroOrdenCompra.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtNumeroOrdenCompra.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumeroOrdenCompra.ForeColor = System.Drawing.Color.DimGray;
            this.txtNumeroOrdenCompra.Location = new System.Drawing.Point(60, 89);
            this.txtNumeroOrdenCompra.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNumeroOrdenCompra.Name = "txtNumeroOrdenCompra";
            this.txtNumeroOrdenCompra.Size = new System.Drawing.Size(251, 29);
            this.txtNumeroOrdenCompra.TabIndex = 67;
            this.txtNumeroOrdenCompra.Tag = "117";
            // 
            // lblFechaEmision
            // 
            this.lblFechaEmision.AutoSize = true;
            this.lblFechaEmision.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblFechaEmision.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaEmision.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblFechaEmision.Location = new System.Drawing.Point(551, 59);
            this.lblFechaEmision.Name = "lblFechaEmision";
            this.lblFechaEmision.Size = new System.Drawing.Size(109, 21);
            this.lblFechaEmision.TabIndex = 70;
            this.lblFechaEmision.Tag = "116";
            this.lblFechaEmision.Text = "Fecha emisión";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label4.Location = new System.Drawing.Point(1008, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(174, 21);
            this.label4.TabIndex = 73;
            this.label4.Tag = "116";
            this.label4.Text = "Fecha entrega esperada";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label11.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Red;
            this.label11.Location = new System.Drawing.Point(1103, 448);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(17, 21);
            this.label11.TabIndex = 109;
            this.label11.Tag = "116";
            this.label11.Text = "*";
            // 
            // cbProveedor
            // 
            this.cbProveedor.Font = new System.Drawing.Font("Segoe UI Symbol", 12F);
            this.cbProveedor.FormattingEnabled = true;
            this.cbProveedor.Location = new System.Drawing.Point(1036, 472);
            this.cbProveedor.Margin = new System.Windows.Forms.Padding(4);
            this.cbProveedor.Name = "cbProveedor";
            this.cbProveedor.Size = new System.Drawing.Size(309, 29);
            this.cbProveedor.TabIndex = 108;
            // 
            // lblProveedor
            // 
            this.lblProveedor.AutoSize = true;
            this.lblProveedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblProveedor.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProveedor.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblProveedor.Location = new System.Drawing.Point(1028, 448);
            this.lblProveedor.Name = "lblProveedor";
            this.lblProveedor.Size = new System.Drawing.Size(82, 21);
            this.lblProveedor.TabIndex = 107;
            this.lblProveedor.Tag = "116";
            this.lblProveedor.Text = "Proveedor";
            // 
            // lblOrdenCompra
            // 
            this.lblOrdenCompra.AutoSize = true;
            this.lblOrdenCompra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblOrdenCompra.Font = new System.Drawing.Font("Segoe UI Symbol", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrdenCompra.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblOrdenCompra.Location = new System.Drawing.Point(75, 66);
            this.lblOrdenCompra.Name = "lblOrdenCompra";
            this.lblOrdenCompra.Size = new System.Drawing.Size(346, 37);
            this.lblOrdenCompra.TabIndex = 89;
            this.lblOrdenCompra.Tag = "116";
            this.lblOrdenCompra.Text = "Agregar orden de compra";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(1029, 547);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 21);
            this.label1.TabIndex = 111;
            this.label1.Tag = "116";
            this.label1.Text = "Observaciones";
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.SystemColors.WindowText;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnBuscar.Location = new System.Drawing.Point(1149, 1038);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(2);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(193, 64);
            this.btnBuscar.TabIndex = 112;
            this.btnBuscar.Text = "Cancelar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnRechazarOrden
            // 
            this.btnRechazarOrden.BackColor = System.Drawing.Color.Maroon;
            this.btnRechazarOrden.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRechazarOrden.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRechazarOrden.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnRechazarOrden.Location = new System.Drawing.Point(455, 1038);
            this.btnRechazarOrden.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRechazarOrden.Name = "btnRechazarOrden";
            this.btnRechazarOrden.Size = new System.Drawing.Size(201, 64);
            this.btnRechazarOrden.TabIndex = 113;
            this.btnRechazarOrden.Tag = "56";
            this.btnRechazarOrden.Text = "Rechazar Orden";
            this.btnRechazarOrden.UseVisualStyleBackColor = false;
            this.btnRechazarOrden.Click += new System.EventHandler(this.btnRechazarOrden_Click);
            // 
            // btnAceptarOrden
            // 
            this.btnAceptarOrden.BackColor = System.Drawing.Color.DarkGreen;
            this.btnAceptarOrden.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAceptarOrden.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptarOrden.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnAceptarOrden.Location = new System.Drawing.Point(224, 1038);
            this.btnAceptarOrden.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAceptarOrden.Name = "btnAceptarOrden";
            this.btnAceptarOrden.Size = new System.Drawing.Size(201, 64);
            this.btnAceptarOrden.TabIndex = 114;
            this.btnAceptarOrden.Tag = "56";
            this.btnAceptarOrden.Text = "Aceptar Orden";
            this.btnAceptarOrden.UseVisualStyleBackColor = false;
            this.btnAceptarOrden.Click += new System.EventHandler(this.btnAceptarOrden_Click);
            // 
            // dgvProductosOrdenCompra
            // 
            this.dgvProductosOrdenCompra.BackColor = System.Drawing.Color.Transparent;
            this.dgvProductosOrdenCompra.Location = new System.Drawing.Point(82, 326);
            this.dgvProductosOrdenCompra.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvProductosOrdenCompra.Name = "dgvProductosOrdenCompra";
            this.dgvProductosOrdenCompra.Size = new System.Drawing.Size(906, 487);
            this.dgvProductosOrdenCompra.TabIndex = 110;
            // 
            // FormAgregarOrdenCompra
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.AutoScrollMinSize = new System.Drawing.Size(0, 1500);
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1311, 736);
            this.Controls.Add(this.btnAceptarOrden);
            this.Controls.Add(this.btnRechazarOrden);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvProductosOrdenCompra);
            this.Controls.Add(this.lblOrdenCompra);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.cbProveedor);
            this.Controls.Add(this.lblProveedor);
            this.Controls.Add(this.txtAreaObservaciones);
            this.Controls.Add(this.gbPagoMoneda);
            this.Controls.Add(this.btnSeleccionarProductos);
            this.Controls.Add(this.btnGenerarOrdenCompra);
            this.Controls.Add(this.gBDatosGenerales);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormAgregarOrdenCompra";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Generar";
            this.Load += new System.EventHandler(this.FormAgregarOrdenCompra_Load);
            this.gbPagoMoneda.ResumeLayout(false);
            this.gbPagoMoneda.PerformLayout();
            this.gBDatosGenerales.ResumeLayout(false);
            this.gBDatosGenerales.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnGenerarOrdenCompra;
        private System.Windows.Forms.Button btnSeleccionarProductos;
        private System.Windows.Forms.TextBox txtAreaObservaciones;
        private System.Windows.Forms.TextBox txtCondicionesPago;
        private System.Windows.Forms.Label lblCondicionesPago;
        private System.Windows.Forms.GroupBox gbPagoMoneda;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblMoneda;
        private System.Windows.Forms.TextBox txtMoneda;
        private System.Windows.Forms.Label lblTipoCambio;
        private System.Windows.Forms.Label lblTotalEsperado;
        private System.Windows.Forms.GroupBox gBDatosGenerales;
        private System.Windows.Forms.Label lblObligatorio;
        private System.Windows.Forms.DateTimePicker dtpFechaEntregaEsperada;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.DateTimePicker dtpFechaEmision;
        private System.Windows.Forms.TextBox txtNumeroOrdenCompra;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cbProveedor;
        private System.Windows.Forms.Label lblProveedor;
        private System.Windows.Forms.Label lblOrdenCompra;
        private ControlesPersonalizados.DataGridViewConFiltros dgvProductosOrdenCompra;
        private ControlesPersonalizados.Inputs.InputNumericTextBox txtNumericTotalEsperado;
        private ControlesPersonalizados.Inputs.InputNumericTextBox txtNumericTipoCambio;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblFechaEmision;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnRechazarOrden;
        private System.Windows.Forms.Button btnAceptarOrden;
    }
}