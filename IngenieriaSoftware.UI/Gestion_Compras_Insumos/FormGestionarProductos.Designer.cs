namespace IngenieriaSoftware.UI.Gestion_Compras_Insumos
{
    partial class FormGestionarProductos
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
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminarProducto = new System.Windows.Forms.Button();
            this.lblListaProveedores = new System.Windows.Forms.Label();
            this.groupBoxProducto = new System.Windows.Forms.GroupBox();
            this.cbDisponible = new System.Windows.Forms.CheckBox();
            this.lblEstado = new System.Windows.Forms.Label();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.lblRazonSocial = new System.Windows.Forms.Label();
            this.lblCorreo = new System.Windows.Forms.Label();
            this.lblDetalleProveedor = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblDocumento = new System.Windows.Forms.Label();
            this.dgvProductos = new System.Windows.Forms.DataGridView();
            this.btnAgregarProducto = new System.Windows.Forms.Button();
            this.cbCategoria = new System.Windows.Forms.ComboBox();
            this.cbEsPostre = new System.Windows.Forms.CheckBox();
            this.nudTiempoPreparacion = new System.Windows.Forms.NumericUpDown();
            this.btnAgregarCategoria = new System.Windows.Forms.Button();
            this.nudPrecio = new System.Windows.Forms.NumericUpDown();
            this.lblMinutos = new System.Windows.Forms.Label();
            this.groupBoxProducto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTiempoPreparacion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrecio)).BeginInit();
            this.SuspendLayout();
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.Orange;
            this.btnModificar.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnModificar.Location = new System.Drawing.Point(1223, 616);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(183, 70);
            this.btnModificar.TabIndex = 37;
            this.btnModificar.Tag = "56";
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnEliminarProducto
            // 
            this.btnEliminarProducto.BackColor = System.Drawing.Color.Maroon;
            this.btnEliminarProducto.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarProducto.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnEliminarProducto.Location = new System.Drawing.Point(890, 616);
            this.btnEliminarProducto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEliminarProducto.Name = "btnEliminarProducto";
            this.btnEliminarProducto.Size = new System.Drawing.Size(183, 70);
            this.btnEliminarProducto.TabIndex = 36;
            this.btnEliminarProducto.Tag = "56";
            this.btnEliminarProducto.Text = "Eliminar";
            this.btnEliminarProducto.UseVisualStyleBackColor = false;
            this.btnEliminarProducto.Click += new System.EventHandler(this.btnEliminarProducto_Click);
            // 
            // lblListaProveedores
            // 
            this.lblListaProveedores.AutoSize = true;
            this.lblListaProveedores.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblListaProveedores.Font = new System.Drawing.Font("Segoe UI Symbol", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListaProveedores.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblListaProveedores.Location = new System.Drawing.Point(618, 115);
            this.lblListaProveedores.Name = "lblListaProveedores";
            this.lblListaProveedores.Size = new System.Drawing.Size(243, 38);
            this.lblListaProveedores.TabIndex = 35;
            this.lblListaProveedores.Tag = "52";
            this.lblListaProveedores.Text = "Lista de Productos";
            // 
            // groupBoxProducto
            // 
            this.groupBoxProducto.Controls.Add(this.lblMinutos);
            this.groupBoxProducto.Controls.Add(this.nudPrecio);
            this.groupBoxProducto.Controls.Add(this.nudTiempoPreparacion);
            this.groupBoxProducto.Controls.Add(this.cbEsPostre);
            this.groupBoxProducto.Controls.Add(this.cbCategoria);
            this.groupBoxProducto.Controls.Add(this.cbDisponible);
            this.groupBoxProducto.Controls.Add(this.lblEstado);
            this.groupBoxProducto.Controls.Add(this.lblTelefono);
            this.groupBoxProducto.Controls.Add(this.lblCorreo);
            this.groupBoxProducto.Controls.Add(this.txtDescripcion);
            this.groupBoxProducto.Controls.Add(this.lblRazonSocial);
            this.groupBoxProducto.Controls.Add(this.lblDetalleProveedor);
            this.groupBoxProducto.Controls.Add(this.txtNombre);
            this.groupBoxProducto.Controls.Add(this.lblDocumento);
            this.groupBoxProducto.Location = new System.Drawing.Point(89, 80);
            this.groupBoxProducto.Name = "groupBoxProducto";
            this.groupBoxProducto.Size = new System.Drawing.Size(327, 637);
            this.groupBoxProducto.TabIndex = 34;
            this.groupBoxProducto.TabStop = false;
            this.groupBoxProducto.Text = "gbDetalleProveedor";
            // 
            // cbDisponible
            // 
            this.cbDisponible.AutoSize = true;
            this.cbDisponible.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDisponible.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.cbDisponible.Location = new System.Drawing.Point(32, 506);
            this.cbDisponible.Name = "cbDisponible";
            this.cbDisponible.Size = new System.Drawing.Size(163, 33);
            this.cbDisponible.TabIndex = 28;
            this.cbDisponible.Text = "Disponible?";
            this.cbDisponible.UseVisualStyleBackColor = true;
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblEstado.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstado.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblEstado.Location = new System.Drawing.Point(27, 281);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(97, 28);
            this.lblEstado.TabIndex = 27;
            this.lblEstado.Tag = "52";
            this.lblEstado.Text = "IdCategoria";
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblTelefono.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefono.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblTelefono.Location = new System.Drawing.Point(27, 361);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(215, 28);
            this.lblTelefono.TabIndex = 25;
            this.lblTelefono.Tag = "52";
            this.lblTelefono.Text = "Tiempo de preparacion";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.BackColor = System.Drawing.Color.Teal;
            this.txtDescripcion.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcion.Location = new System.Drawing.Point(32, 233);
            this.txtDescripcion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(266, 34);
            this.txtDescripcion.TabIndex = 24;
            this.txtDescripcion.Tag = "55";
            // 
            // lblRazonSocial
            // 
            this.lblRazonSocial.AutoSize = true;
            this.lblRazonSocial.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblRazonSocial.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRazonSocial.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblRazonSocial.Location = new System.Drawing.Point(27, 203);
            this.lblRazonSocial.Name = "lblRazonSocial";
            this.lblRazonSocial.Size = new System.Drawing.Size(114, 28);
            this.lblRazonSocial.TabIndex = 23;
            this.lblRazonSocial.Tag = "52";
            this.lblRazonSocial.Text = "Descripcion";
            // 
            // lblCorreo
            // 
            this.lblCorreo.AutoSize = true;
            this.lblCorreo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblCorreo.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCorreo.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblCorreo.Location = new System.Drawing.Point(27, 425);
            this.lblCorreo.Name = "lblCorreo";
            this.lblCorreo.Size = new System.Drawing.Size(66, 28);
            this.lblCorreo.TabIndex = 19;
            this.lblCorreo.Tag = "52";
            this.lblCorreo.Text = "Precio";
            // 
            // lblDetalleProveedor
            // 
            this.lblDetalleProveedor.AutoSize = true;
            this.lblDetalleProveedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblDetalleProveedor.Font = new System.Drawing.Font("Segoe UI Symbol", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetalleProveedor.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblDetalleProveedor.Location = new System.Drawing.Point(25, 50);
            this.lblDetalleProveedor.Name = "lblDetalleProveedor";
            this.lblDetalleProveedor.Size = new System.Drawing.Size(224, 38);
            this.lblDetalleProveedor.TabIndex = 18;
            this.lblDetalleProveedor.Tag = "52";
            this.lblDetalleProveedor.Text = "Detalle Producto";
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.Color.Teal;
            this.txtNombre.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(32, 159);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(266, 34);
            this.txtNombre.TabIndex = 17;
            this.txtNombre.Tag = "55";
            // 
            // lblDocumento
            // 
            this.lblDocumento.AutoSize = true;
            this.lblDocumento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblDocumento.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDocumento.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblDocumento.Location = new System.Drawing.Point(27, 129);
            this.lblDocumento.Name = "lblDocumento";
            this.lblDocumento.Size = new System.Drawing.Size(85, 28);
            this.lblDocumento.TabIndex = 16;
            this.lblDocumento.Tag = "52";
            this.lblDocumento.Text = "Nombre";
            // 
            // dgvProductos
            // 
            this.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductos.Location = new System.Drawing.Point(613, 156);
            this.dgvProductos.Name = "dgvProductos";
            this.dgvProductos.RowHeadersWidth = 51;
            this.dgvProductos.RowTemplate.Height = 24;
            this.dgvProductos.Size = new System.Drawing.Size(946, 407);
            this.dgvProductos.TabIndex = 32;
            // 
            // btnAgregarProducto
            // 
            this.btnAgregarProducto.BackColor = System.Drawing.Color.Teal;
            this.btnAgregarProducto.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarProducto.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnAgregarProducto.Location = new System.Drawing.Point(569, 616);
            this.btnAgregarProducto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAgregarProducto.Name = "btnAgregarProducto";
            this.btnAgregarProducto.Size = new System.Drawing.Size(183, 70);
            this.btnAgregarProducto.TabIndex = 33;
            this.btnAgregarProducto.Tag = "56";
            this.btnAgregarProducto.Text = "Guardar";
            this.btnAgregarProducto.UseVisualStyleBackColor = false;
            this.btnAgregarProducto.Click += new System.EventHandler(this.btnAgregarProducto_Click);
            // 
            // cbCategoria
            // 
            this.cbCategoria.BackColor = System.Drawing.Color.Teal;
            this.cbCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCategoria.FormattingEnabled = true;
            this.cbCategoria.Location = new System.Drawing.Point(32, 312);
            this.cbCategoria.Name = "cbCategoria";
            this.cbCategoria.Size = new System.Drawing.Size(266, 37);
            this.cbCategoria.TabIndex = 29;
            // 
            // cbEsPostre
            // 
            this.cbEsPostre.AutoSize = true;
            this.cbEsPostre.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbEsPostre.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.cbEsPostre.Location = new System.Drawing.Point(32, 545);
            this.cbEsPostre.Name = "cbEsPostre";
            this.cbEsPostre.Size = new System.Drawing.Size(149, 33);
            this.cbEsPostre.TabIndex = 30;
            this.cbEsPostre.Text = "Es postre?";
            this.cbEsPostre.UseVisualStyleBackColor = true;
            // 
            // nudTiempoPreparacion
            // 
            this.nudTiempoPreparacion.BackColor = System.Drawing.Color.Teal;
            this.nudTiempoPreparacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudTiempoPreparacion.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.nudTiempoPreparacion.Location = new System.Drawing.Point(32, 392);
            this.nudTiempoPreparacion.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudTiempoPreparacion.Name = "nudTiempoPreparacion";
            this.nudTiempoPreparacion.Size = new System.Drawing.Size(109, 30);
            this.nudTiempoPreparacion.TabIndex = 38;
            // 
            // btnAgregarCategoria
            // 
            this.btnAgregarCategoria.BackColor = System.Drawing.Color.DarkGreen;
            this.btnAgregarCategoria.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarCategoria.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnAgregarCategoria.Location = new System.Drawing.Point(444, 392);
            this.btnAgregarCategoria.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAgregarCategoria.Name = "btnAgregarCategoria";
            this.btnAgregarCategoria.Size = new System.Drawing.Size(113, 37);
            this.btnAgregarCategoria.TabIndex = 38;
            this.btnAgregarCategoria.Tag = "56";
            this.btnAgregarCategoria.Text = "Agregar";
            this.btnAgregarCategoria.UseVisualStyleBackColor = false;
            this.btnAgregarCategoria.Click += new System.EventHandler(this.btnAgregarCategoria_Click);
            // 
            // nudPrecio
            // 
            this.nudPrecio.BackColor = System.Drawing.Color.Teal;
            this.nudPrecio.DecimalPlaces = 2;
            this.nudPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudPrecio.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.nudPrecio.Location = new System.Drawing.Point(32, 456);
            this.nudPrecio.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nudPrecio.Name = "nudPrecio";
            this.nudPrecio.Size = new System.Drawing.Size(109, 30);
            this.nudPrecio.TabIndex = 39;
            // 
            // lblMinutos
            // 
            this.lblMinutos.AutoSize = true;
            this.lblMinutos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblMinutos.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMinutos.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblMinutos.Location = new System.Drawing.Point(147, 391);
            this.lblMinutos.Name = "lblMinutos";
            this.lblMinutos.Size = new System.Drawing.Size(84, 28);
            this.lblMinutos.TabIndex = 40;
            this.lblMinutos.Tag = "52";
            this.lblMinutos.Text = "Minutos";
            // 
            // FormGestionarProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1770, 777);
            this.Controls.Add(this.btnAgregarCategoria);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnEliminarProducto);
            this.Controls.Add(this.lblListaProveedores);
            this.Controls.Add(this.groupBoxProducto);
            this.Controls.Add(this.dgvProductos);
            this.Controls.Add(this.btnAgregarProducto);
            this.Name = "FormGestionarProductos";
            this.Text = "FormGestionarProductos";
            this.groupBoxProducto.ResumeLayout(false);
            this.groupBoxProducto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTiempoPreparacion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrecio)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminarProducto;
        private System.Windows.Forms.Label lblListaProveedores;
        private System.Windows.Forms.GroupBox groupBoxProducto;
        private System.Windows.Forms.CheckBox cbDisponible;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label lblRazonSocial;
        private System.Windows.Forms.Label lblCorreo;
        private System.Windows.Forms.Label lblDetalleProveedor;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblDocumento;
        private System.Windows.Forms.DataGridView dgvProductos;
        private System.Windows.Forms.Button btnAgregarProducto;
        private System.Windows.Forms.ComboBox cbCategoria;
        private System.Windows.Forms.CheckBox cbEsPostre;
        private System.Windows.Forms.NumericUpDown nudTiempoPreparacion;
        private System.Windows.Forms.Button btnAgregarCategoria;
        private System.Windows.Forms.NumericUpDown nudPrecio;
        private System.Windows.Forms.Label lblMinutos;
    }
}