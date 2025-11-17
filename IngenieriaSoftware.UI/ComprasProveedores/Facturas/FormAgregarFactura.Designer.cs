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
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lblAgregarFactura = new System.Windows.Forms.Label();
            this.gBDatosGenerales = new System.Windows.Forms.GroupBox();
            this.dtpFechaEntregaEsperada = new System.Windows.Forms.DateTimePicker();
            this.lblNumFactura = new System.Windows.Forms.Label();
            this.dtpFechaEmision = new System.Windows.Forms.DateTimePicker();
            this.txtNumFactura = new System.Windows.Forms.TextBox();
            this.lblFechaEmision = new System.Windows.Forms.Label();
            this.lblFechaEntrega = new System.Windows.Forms.Label();
            this.lblTipoCambio = new System.Windows.Forms.Label();
            this.lblTotalEsperado = new System.Windows.Forms.Label();
            this.btnSeleccionarProductos = new System.Windows.Forms.Button();
            this.btnAvanzar = new System.Windows.Forms.Button();
            this.txtCondicionesPago = new System.Windows.Forms.TextBox();
            this.lblCondicionesPago = new System.Windows.Forms.Label();
            this.gbPagoMoneda = new System.Windows.Forms.GroupBox();
            this.lblMoneda = new System.Windows.Forms.Label();
            this.txtMoneda = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblNumeroOrden = new System.Windows.Forms.Label();
            this.lblProductosOrden = new System.Windows.Forms.Label();
            this.lblProductosFactura = new System.Windows.Forms.Label();
            this.btnSeleccionarTodos = new System.Windows.Forms.Button();
            this.dgvProductosFactura = new IngenieriaSoftware.UI.ControlesPersonalizados.DataGridViewConFiltros();
            this.dgvProductosOrdenCompra = new IngenieriaSoftware.UI.ControlesPersonalizados.DataGridViewConFiltros();
            this.txtNumericTipoCambio = new IngenieriaSoftware.UI.ControlesPersonalizados.Inputs.InputNumericTextBox();
            this.txtNumericTotalEsperado = new IngenieriaSoftware.UI.ControlesPersonalizados.Inputs.InputNumericTextBox();
            this.gBDatosGenerales.SuspendLayout();
            this.gbPagoMoneda.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.SystemColors.WindowText;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnCancelar.Location = new System.Drawing.Point(1553, 1174);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(161, 64);
            this.btnCancelar.TabIndex = 126;
            this.btnCancelar.Tag = "";
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lblAgregarFactura
            // 
            this.lblAgregarFactura.AutoSize = true;
            this.lblAgregarFactura.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblAgregarFactura.Font = new System.Drawing.Font("Segoe UI Symbol", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAgregarFactura.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblAgregarFactura.Location = new System.Drawing.Point(240, 208);
            this.lblAgregarFactura.Name = "lblAgregarFactura";
            this.lblAgregarFactura.Size = new System.Drawing.Size(275, 46);
            this.lblAgregarFactura.TabIndex = 116;
            this.lblAgregarFactura.Tag = "";
            this.lblAgregarFactura.Text = "Agregar Factura";
            // 
            // gBDatosGenerales
            // 
            this.gBDatosGenerales.AutoSize = true;
            this.gBDatosGenerales.Controls.Add(this.dtpFechaEntregaEsperada);
            this.gBDatosGenerales.Controls.Add(this.lblNumFactura);
            this.gBDatosGenerales.Controls.Add(this.dtpFechaEmision);
            this.gBDatosGenerales.Controls.Add(this.txtNumFactura);
            this.gBDatosGenerales.Controls.Add(this.lblFechaEmision);
            this.gBDatosGenerales.Controls.Add(this.lblFechaEntrega);
            this.gBDatosGenerales.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gBDatosGenerales.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.gBDatosGenerales.Location = new System.Drawing.Point(236, 314);
            this.gBDatosGenerales.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gBDatosGenerales.Name = "gBDatosGenerales";
            this.gBDatosGenerales.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gBDatosGenerales.Size = new System.Drawing.Size(1508, 156);
            this.gBDatosGenerales.TabIndex = 120;
            this.gBDatosGenerales.TabStop = false;
            this.gBDatosGenerales.Tag = "";
            this.gBDatosGenerales.Text = "Datos generales";
            // 
            // dtpFechaEntregaEsperada
            // 
            this.dtpFechaEntregaEsperada.Checked = false;
            this.dtpFechaEntregaEsperada.CustomFormat = " ";
            this.dtpFechaEntregaEsperada.Font = new System.Drawing.Font("Segoe UI Symbol", 12F);
            this.dtpFechaEntregaEsperada.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaEntregaEsperada.Location = new System.Drawing.Point(1227, 89);
            this.dtpFechaEntregaEsperada.Margin = new System.Windows.Forms.Padding(4);
            this.dtpFechaEntregaEsperada.Name = "dtpFechaEntregaEsperada";
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
            this.dtpFechaEmision.Location = new System.Drawing.Point(636, 89);
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
            this.lblFechaEmision.Location = new System.Drawing.Point(629, 59);
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
            this.lblFechaEntrega.Location = new System.Drawing.Point(1221, 57);
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
            this.lblTipoCambio.Location = new System.Drawing.Point(875, 66);
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
            this.lblTotalEsperado.Location = new System.Drawing.Point(77, 65);
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
            this.btnSeleccionarProductos.Location = new System.Drawing.Point(560, 1019);
            this.btnSeleccionarProductos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSeleccionarProductos.Name = "btnSeleccionarProductos";
            this.btnSeleccionarProductos.Size = new System.Drawing.Size(313, 64);
            this.btnSeleccionarProductos.TabIndex = 117;
            this.btnSeleccionarProductos.Tag = "";
            this.btnSeleccionarProductos.Text = "Seleccionar productos";
            this.btnSeleccionarProductos.UseVisualStyleBackColor = false;
            this.btnSeleccionarProductos.Click += new System.EventHandler(this.btnSeleccionarProductos_Click);
            // 
            // btnAvanzar
            // 
            this.btnAvanzar.BackColor = System.Drawing.Color.DarkGreen;
            this.btnAvanzar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAvanzar.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAvanzar.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnAvanzar.Location = new System.Drawing.Point(1329, 1174);
            this.btnAvanzar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAvanzar.Name = "btnAvanzar";
            this.btnAvanzar.Size = new System.Drawing.Size(201, 64);
            this.btnAvanzar.TabIndex = 115;
            this.btnAvanzar.Tag = "";
            this.btnAvanzar.Text = "Avanzar";
            this.btnAvanzar.UseVisualStyleBackColor = false;
            this.btnAvanzar.Click += new System.EventHandler(this.btnGenerarOrdenCompra_Click);
            // 
            // txtCondicionesPago
            // 
            this.txtCondicionesPago.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtCondicionesPago.Enabled = false;
            this.txtCondicionesPago.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCondicionesPago.ForeColor = System.Drawing.Color.DimGray;
            this.txtCondicionesPago.Location = new System.Drawing.Point(1276, 96);
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
            this.lblCondicionesPago.Location = new System.Drawing.Point(1269, 65);
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
            this.gbPagoMoneda.Controls.Add(this.lblMoneda);
            this.gbPagoMoneda.Controls.Add(this.txtMoneda);
            this.gbPagoMoneda.Controls.Add(this.lblTipoCambio);
            this.gbPagoMoneda.Controls.Add(this.txtCondicionesPago);
            this.gbPagoMoneda.Controls.Add(this.lblCondicionesPago);
            this.gbPagoMoneda.Controls.Add(this.lblTotalEsperado);
            this.gbPagoMoneda.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbPagoMoneda.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.gbPagoMoneda.Location = new System.Drawing.Point(236, 488);
            this.gbPagoMoneda.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbPagoMoneda.Name = "gbPagoMoneda";
            this.gbPagoMoneda.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbPagoMoneda.Size = new System.Drawing.Size(1508, 170);
            this.gbPagoMoneda.TabIndex = 118;
            this.gbPagoMoneda.TabStop = false;
            this.gbPagoMoneda.Tag = "";
            this.gbPagoMoneda.Text = "Pago y moneda";
            // 
            // lblMoneda
            // 
            this.lblMoneda.AutoSize = true;
            this.lblMoneda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblMoneda.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMoneda.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblMoneda.Location = new System.Drawing.Point(472, 65);
            this.lblMoneda.Name = "lblMoneda";
            this.lblMoneda.Size = new System.Drawing.Size(85, 28);
            this.lblMoneda.TabIndex = 77;
            this.lblMoneda.Tag = "";
            this.lblMoneda.Text = "Moneda";
            // 
            // txtMoneda
            // 
            this.txtMoneda.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtMoneda.Enabled = false;
            this.txtMoneda.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMoneda.ForeColor = System.Drawing.Color.DimGray;
            this.txtMoneda.Location = new System.Drawing.Point(473, 96);
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
            this.label2.Location = new System.Drawing.Point(1138, 253);
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
            this.lblNumeroOrden.Location = new System.Drawing.Point(1374, 253);
            this.lblNumeroOrden.Name = "lblNumeroOrden";
            this.lblNumeroOrden.Size = new System.Drawing.Size(0, 46);
            this.lblNumeroOrden.TabIndex = 130;
            this.lblNumeroOrden.Tag = "";
            // 
            // lblProductosOrden
            // 
            this.lblProductosOrden.AutoSize = true;
            this.lblProductosOrden.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblProductosOrden.Font = new System.Drawing.Font("Segoe UI Symbol", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductosOrden.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblProductosOrden.Location = new System.Drawing.Point(628, 683);
            this.lblProductosOrden.Name = "lblProductosOrden";
            this.lblProductosOrden.Size = new System.Drawing.Size(285, 46);
            this.lblProductosOrden.TabIndex = 132;
            this.lblProductosOrden.Tag = "";
            this.lblProductosOrden.Text = "Productos orden";
            // 
            // lblProductosFactura
            // 
            this.lblProductosFactura.AutoSize = true;
            this.lblProductosFactura.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblProductosFactura.Font = new System.Drawing.Font("Segoe UI Symbol", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductosFactura.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblProductosFactura.Location = new System.Drawing.Point(1503, 683);
            this.lblProductosFactura.Name = "lblProductosFactura";
            this.lblProductosFactura.Size = new System.Drawing.Size(302, 46);
            this.lblProductosFactura.TabIndex = 133;
            this.lblProductosFactura.Tag = "";
            this.lblProductosFactura.Text = "Productos factura";
            // 
            // btnSeleccionarTodos
            // 
            this.btnSeleccionarTodos.BackColor = System.Drawing.Color.Orange;
            this.btnSeleccionarTodos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSeleccionarTodos.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeleccionarTodos.ForeColor = System.Drawing.Color.Black;
            this.btnSeleccionarTodos.Location = new System.Drawing.Point(232, 1019);
            this.btnSeleccionarTodos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSeleccionarTodos.Name = "btnSeleccionarTodos";
            this.btnSeleccionarTodos.Size = new System.Drawing.Size(313, 64);
            this.btnSeleccionarTodos.TabIndex = 134;
            this.btnSeleccionarTodos.Tag = "";
            this.btnSeleccionarTodos.Text = "Seleccionar todos";
            this.btnSeleccionarTodos.UseVisualStyleBackColor = false;
            this.btnSeleccionarTodos.Click += new System.EventHandler(this.btnSeleccionarTodos_Click);
            // 
            // dgvProductosFactura
            // 
            this.dgvProductosFactura.BackColor = System.Drawing.Color.Transparent;
            this.dgvProductosFactura.Location = new System.Drawing.Point(1147, 683);
            this.dgvProductosFactura.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvProductosFactura.Name = "dgvProductosFactura";
            this.dgvProductosFactura.Size = new System.Drawing.Size(678, 282);
            this.dgvProductosFactura.TabIndex = 131;
            this.dgvProductosFactura.Tag = "";
            this.dgvProductosFactura.TamanoGrilla = IngenieriaSoftware.UI.ControlesPersonalizados.grillaCustom.ModoTamanoGrilla.Pequeño;
            // 
            // dgvProductosOrdenCompra
            // 
            this.dgvProductosOrdenCompra.BackColor = System.Drawing.Color.Transparent;
            this.dgvProductosOrdenCompra.Location = new System.Drawing.Point(235, 683);
            this.dgvProductosOrdenCompra.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvProductosOrdenCompra.Name = "dgvProductosOrdenCompra";
            this.dgvProductosOrdenCompra.Size = new System.Drawing.Size(678, 282);
            this.dgvProductosOrdenCompra.TabIndex = 124;
            this.dgvProductosOrdenCompra.Tag = "";
            this.dgvProductosOrdenCompra.TamanoGrilla = IngenieriaSoftware.UI.ControlesPersonalizados.grillaCustom.ModoTamanoGrilla.Pequeño;
            // 
            // txtNumericTipoCambio
            // 
            this.txtNumericTipoCambio.Enabled = false;
            this.txtNumericTipoCambio.Font = new System.Drawing.Font("Segoe UI Symbol", 12F);
            this.txtNumericTipoCambio.Location = new System.Drawing.Point(879, 96);
            this.txtNumericTipoCambio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
            this.txtNumericTotalEsperado.Enabled = false;
            this.txtNumericTotalEsperado.Location = new System.Drawing.Point(83, 96);
            this.txtNumericTotalEsperado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNumericTotalEsperado.Name = "txtNumericTotalEsperado";
            this.txtNumericTotalEsperado.Size = new System.Drawing.Size(201, 34);
            this.txtNumericTotalEsperado.TabIndex = 111;
            this.txtNumericTotalEsperado.Tag = "";
            this.txtNumericTotalEsperado.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // FormAgregarFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoScrollMinSize = new System.Drawing.Size(0, 1500);
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1924, 938);
            this.Controls.Add(this.btnSeleccionarTodos);
            this.Controls.Add(this.lblProductosFactura);
            this.Controls.Add(this.lblProductosOrden);
            this.Controls.Add(this.dgvProductosFactura);
            this.Controls.Add(this.lblNumeroOrden);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.dgvProductosOrdenCompra);
            this.Controls.Add(this.lblAgregarFactura);
            this.Controls.Add(this.gBDatosGenerales);
            this.Controls.Add(this.btnSeleccionarProductos);
            this.Controls.Add(this.btnAvanzar);
            this.Controls.Add(this.gbPagoMoneda);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormAgregarFactura";
            this.Text = "FormAgregarFactura";
            this.Load += new System.EventHandler(this.FormAgregarFactura_Load);
            this.gBDatosGenerales.ResumeLayout(false);
            this.gBDatosGenerales.PerformLayout();
            this.gbPagoMoneda.ResumeLayout(false);
            this.gbPagoMoneda.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnCancelar;
        private ControlesPersonalizados.DataGridViewConFiltros dgvProductosOrdenCompra;
        private System.Windows.Forms.Label lblAgregarFactura;
        private System.Windows.Forms.GroupBox gBDatosGenerales;
        private System.Windows.Forms.DateTimePicker dtpFechaEntregaEsperada;
        private System.Windows.Forms.Label lblNumFactura;
        private System.Windows.Forms.DateTimePicker dtpFechaEmision;
        private System.Windows.Forms.TextBox txtNumFactura;
        private System.Windows.Forms.Label lblFechaEmision;
        private System.Windows.Forms.Label lblFechaEntrega;
        private System.Windows.Forms.Label lblTipoCambio;
        private System.Windows.Forms.Label lblTotalEsperado;
        private System.Windows.Forms.Button btnSeleccionarProductos;
        private System.Windows.Forms.Button btnAvanzar;
        private System.Windows.Forms.TextBox txtCondicionesPago;
        private System.Windows.Forms.Label lblCondicionesPago;
        private System.Windows.Forms.GroupBox gbPagoMoneda;
        private ControlesPersonalizados.Inputs.InputNumericTextBox txtNumericTipoCambio;
        private ControlesPersonalizados.Inputs.InputNumericTextBox txtNumericTotalEsperado;
        private System.Windows.Forms.Label lblMoneda;
        private System.Windows.Forms.TextBox txtMoneda;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblNumeroOrden;
        private ControlesPersonalizados.DataGridViewConFiltros dgvProductosFactura;
        private System.Windows.Forms.Label lblProductosOrden;
        private System.Windows.Forms.Label lblProductosFactura;
        private System.Windows.Forms.Button btnSeleccionarTodos;
    }
}