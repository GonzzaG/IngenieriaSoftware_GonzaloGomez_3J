namespace IngenieriaSoftware.UI.Gestion_Compras_Insumos
{
    partial class FormOrdenCompraFactura
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
            this.dgvProductos = new System.Windows.Forms.DataGridView();
            this.gBListaProductos = new System.Windows.Forms.GroupBox();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.btnAgregarAlCarrito = new System.Windows.Forms.Button();
            this.gBCarrito = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.btnQuitarDelCarrito = new System.Windows.Forms.Button();
            this.btnRealizarPedido = new System.Windows.Forms.Button();
            this.dgvCarrito = new System.Windows.Forms.DataGridView();
            this.lblTotalAPagar = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.gBSolicitarCotizacion = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtRazonSocial = new System.Windows.Forms.TextBox();
            this.iBBuscarProveedores = new FontAwesome.Sharp.IconButton();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).BeginInit();
            this.gBListaProductos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.gBCarrito.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarrito)).BeginInit();
            this.gBSolicitarCotizacion.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvProductos
            // 
            this.dgvProductos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductos.Location = new System.Drawing.Point(22, 50);
            this.dgvProductos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvProductos.Name = "dgvProductos";
            this.dgvProductos.RowHeadersWidth = 51;
            this.dgvProductos.RowTemplate.Height = 24;
            this.dgvProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProductos.Size = new System.Drawing.Size(769, 310);
            this.dgvProductos.TabIndex = 31;
            // 
            // gBListaProductos
            // 
            this.gBListaProductos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.gBListaProductos.AutoSize = true;
            this.gBListaProductos.Controls.Add(this.lblCantidad);
            this.gBListaProductos.Controls.Add(this.numericUpDown1);
            this.gBListaProductos.Controls.Add(this.dgvProductos);
            this.gBListaProductos.Controls.Add(this.btnAgregarAlCarrito);
            this.gBListaProductos.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gBListaProductos.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.gBListaProductos.Location = new System.Drawing.Point(101, 324);
            this.gBListaProductos.Name = "gBListaProductos";
            this.gBListaProductos.Size = new System.Drawing.Size(857, 487);
            this.gBListaProductos.TabIndex = 33;
            this.gBListaProductos.TabStop = false;
            this.gBListaProductos.Text = "Lista de Productos";
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblCantidad.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidad.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblCantidad.Location = new System.Drawing.Point(20, 374);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(91, 28);
            this.lblCantidad.TabIndex = 38;
            this.lblCantidad.Tag = "52";
            this.lblCantidad.Text = "Cantidad";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.numericUpDown1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numericUpDown1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.numericUpDown1.Location = new System.Drawing.Point(22, 405);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(105, 49);
            this.numericUpDown1.TabIndex = 35;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnAgregarAlCarrito
            // 
            this.btnAgregarAlCarrito.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAgregarAlCarrito.BackColor = System.Drawing.Color.Orange;
            this.btnAgregarAlCarrito.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarAlCarrito.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnAgregarAlCarrito.Location = new System.Drawing.Point(165, 405);
            this.btnAgregarAlCarrito.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAgregarAlCarrito.Name = "btnAgregarAlCarrito";
            this.btnAgregarAlCarrito.Size = new System.Drawing.Size(257, 49);
            this.btnAgregarAlCarrito.TabIndex = 34;
            this.btnAgregarAlCarrito.Tag = "56";
            this.btnAgregarAlCarrito.Text = "Agregar al Carrito";
            this.btnAgregarAlCarrito.UseVisualStyleBackColor = false;
            this.btnAgregarAlCarrito.Click += new System.EventHandler(this.btnAgregarAlCarrito_Click);
            // 
            // gBCarrito
            // 
            this.gBCarrito.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gBCarrito.AutoSize = true;
            this.gBCarrito.Controls.Add(this.label1);
            this.gBCarrito.Controls.Add(this.numericUpDown2);
            this.gBCarrito.Controls.Add(this.btnQuitarDelCarrito);
            this.gBCarrito.Controls.Add(this.btnRealizarPedido);
            this.gBCarrito.Controls.Add(this.dgvCarrito);
            this.gBCarrito.Controls.Add(this.lblTotalAPagar);
            this.gBCarrito.Controls.Add(this.lblTotal);
            this.gBCarrito.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gBCarrito.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.gBCarrito.Location = new System.Drawing.Point(1143, 325);
            this.gBCarrito.Name = "gBCarrito";
            this.gBCarrito.Size = new System.Drawing.Size(747, 479);
            this.gBCarrito.TabIndex = 34;
            this.gBCarrito.TabStop = false;
            this.gBCarrito.Text = "Carrito";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(257, 366);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 28);
            this.label1.TabIndex = 43;
            this.label1.Tag = "52";
            this.label1.Text = "Cantidad";
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.numericUpDown2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numericUpDown2.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.numericUpDown2.Location = new System.Drawing.Point(259, 397);
            this.numericUpDown2.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDown2.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(105, 49);
            this.numericUpDown2.TabIndex = 42;
            this.numericUpDown2.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnQuitarDelCarrito
            // 
            this.btnQuitarDelCarrito.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnQuitarDelCarrito.BackColor = System.Drawing.Color.DarkRed;
            this.btnQuitarDelCarrito.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuitarDelCarrito.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnQuitarDelCarrito.Location = new System.Drawing.Point(19, 397);
            this.btnQuitarDelCarrito.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnQuitarDelCarrito.Name = "btnQuitarDelCarrito";
            this.btnQuitarDelCarrito.Size = new System.Drawing.Size(204, 49);
            this.btnQuitarDelCarrito.TabIndex = 41;
            this.btnQuitarDelCarrito.Tag = "56";
            this.btnQuitarDelCarrito.Text = "Quitar";
            this.btnQuitarDelCarrito.UseVisualStyleBackColor = false;
            this.btnQuitarDelCarrito.Click += new System.EventHandler(this.btnQuitarDelCarrito_Click);
            // 
            // btnRealizarPedido
            // 
            this.btnRealizarPedido.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRealizarPedido.BackColor = System.Drawing.Color.DarkGreen;
            this.btnRealizarPedido.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRealizarPedido.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnRealizarPedido.Location = new System.Drawing.Point(409, 264);
            this.btnRealizarPedido.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRealizarPedido.Name = "btnRealizarPedido";
            this.btnRealizarPedido.Size = new System.Drawing.Size(296, 95);
            this.btnRealizarPedido.TabIndex = 35;
            this.btnRealizarPedido.Tag = "56";
            this.btnRealizarPedido.Text = "Realizar Pedido";
            this.btnRealizarPedido.UseVisualStyleBackColor = false;
            this.btnRealizarPedido.Click += new System.EventHandler(this.btnRealizarPedido_Click);
            // 
            // dgvCarrito
            // 
            this.dgvCarrito.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCarrito.Location = new System.Drawing.Point(19, 50);
            this.dgvCarrito.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvCarrito.Name = "dgvCarrito";
            this.dgvCarrito.RowHeadersWidth = 51;
            this.dgvCarrito.RowTemplate.Height = 24;
            this.dgvCarrito.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCarrito.Size = new System.Drawing.Size(358, 309);
            this.dgvCarrito.TabIndex = 32;
            // 
            // lblTotalAPagar
            // 
            this.lblTotalAPagar.AutoSize = true;
            this.lblTotalAPagar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblTotalAPagar.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalAPagar.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblTotalAPagar.Location = new System.Drawing.Point(494, 128);
            this.lblTotalAPagar.Name = "lblTotalAPagar";
            this.lblTotalAPagar.Size = new System.Drawing.Size(126, 28);
            this.lblTotalAPagar.TabIndex = 40;
            this.lblTotalAPagar.Tag = "52";
            this.lblTotalAPagar.Text = "Total a Pagar";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblTotal.Font = new System.Drawing.Font("Segoe UI Symbol", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblTotal.Location = new System.Drawing.Point(526, 169);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(67, 54);
            this.lblTotal.TabIndex = 39;
            this.lblTotal.Tag = "52";
            this.lblTotal.Text = "$0";
            // 
            // gBSolicitarCotizacion
            // 
            this.gBSolicitarCotizacion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gBSolicitarCotizacion.AutoSize = true;
            this.gBSolicitarCotizacion.Controls.Add(this.label2);
            this.gBSolicitarCotizacion.Controls.Add(this.label3);
            this.gBSolicitarCotizacion.Controls.Add(this.txtTelefono);
            this.gBSolicitarCotizacion.Controls.Add(this.txtRazonSocial);
            this.gBSolicitarCotizacion.Controls.Add(this.iBBuscarProveedores);
            this.gBSolicitarCotizacion.Controls.Add(this.label4);
            this.gBSolicitarCotizacion.Controls.Add(this.txtCorreo);
            this.gBSolicitarCotizacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gBSolicitarCotizacion.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.gBSolicitarCotizacion.Location = new System.Drawing.Point(101, 24);
            this.gBSolicitarCotizacion.Name = "gBSolicitarCotizacion";
            this.gBSolicitarCotizacion.Size = new System.Drawing.Size(1789, 257);
            this.gBSolicitarCotizacion.TabIndex = 45;
            this.gBSolicitarCotizacion.TabStop = false;
            this.gBSolicitarCotizacion.Text = "Solicitar Cotizaciones";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(652, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 28);
            this.label2.TabIndex = 51;
            this.label2.Tag = "52";
            this.label2.Text = "Correo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Location = new System.Drawing.Point(256, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 28);
            this.label3.TabIndex = 50;
            this.label3.Tag = "52";
            this.label3.Text = "Telefono";
            // 
            // txtTelefono
            // 
            this.txtTelefono.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtTelefono.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTelefono.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtTelefono.Font = new System.Drawing.Font("Segoe UI Symbol", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefono.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtTelefono.Location = new System.Drawing.Point(261, 172);
            this.txtTelefono.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.ReadOnly = true;
            this.txtTelefono.Size = new System.Drawing.Size(266, 47);
            this.txtTelefono.TabIndex = 45;
            this.txtTelefono.Tag = "55";
            // 
            // txtRazonSocial
            // 
            this.txtRazonSocial.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtRazonSocial.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRazonSocial.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtRazonSocial.Font = new System.Drawing.Font("Segoe UI Symbol", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRazonSocial.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtRazonSocial.Location = new System.Drawing.Point(261, 79);
            this.txtRazonSocial.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtRazonSocial.Name = "txtRazonSocial";
            this.txtRazonSocial.ReadOnly = true;
            this.txtRazonSocial.Size = new System.Drawing.Size(373, 47);
            this.txtRazonSocial.TabIndex = 46;
            this.txtRazonSocial.Tag = "55";
            // 
            // iBBuscarProveedores
            // 
            this.iBBuscarProveedores.BackColor = System.Drawing.Color.Orange;
            this.iBBuscarProveedores.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iBBuscarProveedores.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.iBBuscarProveedores.IconColor = System.Drawing.Color.WhiteSmoke;
            this.iBBuscarProveedores.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.iBBuscarProveedores.IconSize = 24;
            this.iBBuscarProveedores.Location = new System.Drawing.Point(38, 55);
            this.iBBuscarProveedores.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.iBBuscarProveedores.Name = "iBBuscarProveedores";
            this.iBBuscarProveedores.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.iBBuscarProveedores.Size = new System.Drawing.Size(119, 170);
            this.iBBuscarProveedores.TabIndex = 48;
            this.iBBuscarProveedores.UseVisualStyleBackColor = false;
            this.iBBuscarProveedores.Click += new System.EventHandler(this.iBBuscarProveedores_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label4.Location = new System.Drawing.Point(256, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 28);
            this.label4.TabIndex = 49;
            this.label4.Tag = "52";
            this.label4.Text = "Razon Social";
            // 
            // txtCorreo
            // 
            this.txtCorreo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtCorreo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCorreo.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtCorreo.Font = new System.Drawing.Font("Segoe UI Symbol", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCorreo.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtCorreo.Location = new System.Drawing.Point(657, 79);
            this.txtCorreo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.ReadOnly = true;
            this.txtCorreo.Size = new System.Drawing.Size(631, 47);
            this.txtCorreo.TabIndex = 47;
            this.txtCorreo.Tag = "55";
            // 
            // FormOrdenCompraFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1924, 959);
            this.ControlBox = false;
            this.Controls.Add(this.gBSolicitarCotizacion);
            this.Controls.Add(this.gBCarrito);
            this.Controls.Add(this.gBListaProductos);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1918, 977);
            this.Name = "FormOrdenCompraFactura";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormOrdenCompraFactura";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).EndInit();
            this.gBListaProductos.ResumeLayout(false);
            this.gBListaProductos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.gBCarrito.ResumeLayout(false);
            this.gBCarrito.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarrito)).EndInit();
            this.gBSolicitarCotizacion.ResumeLayout(false);
            this.gBSolicitarCotizacion.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvProductos;
        private System.Windows.Forms.GroupBox gBListaProductos;
        private System.Windows.Forms.Button btnAgregarAlCarrito;
        private System.Windows.Forms.GroupBox gBCarrito;
        private System.Windows.Forms.Button btnRealizarPedido;
        private System.Windows.Forms.Label lblTotalAPagar;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.DataGridView dgvCarrito;
        private System.Windows.Forms.Button btnQuitarDelCarrito;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox gBSolicitarCotizacion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtRazonSocial;
        private FontAwesome.Sharp.IconButton iBBuscarProveedores;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCorreo;
    }
}