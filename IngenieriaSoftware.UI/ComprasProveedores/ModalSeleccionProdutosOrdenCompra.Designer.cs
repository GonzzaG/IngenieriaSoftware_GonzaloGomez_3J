namespace IngenieriaSoftware.UI.ComprasProveedores
{
    partial class ModalSeleccionProdutosOrdenCompra
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
            this.components = new System.ComponentModel.Container();
            this.lblNumeroOrdenCompra = new System.Windows.Forms.Label();
            this.btnAgregarProducto = new System.Windows.Forms.Button();
            this.lblCant = new System.Windows.Forms.Label();
            this.nudCantidad = new System.Windows.Forms.NumericUpDown();
            this.btnSeleccionar = new System.Windows.Forms.Button();
            this.timerProductoAgregado = new System.Windows.Forms.Timer(this.components);
            this.lblProductoAgregadoTimer = new System.Windows.Forms.Label();
            this.dgvConFiltroProductos = new IngenieriaSoftware.UI.ControlesPersonalizados.DataGridViewConFiltros();
            this.inputNombreFiltroOrdenCompra = new IngenieriaSoftware.UI.ControlesPersonalizados.InputNombreFiltro();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNumeroOrdenCompra
            // 
            this.lblNumeroOrdenCompra.AutoSize = true;
            this.lblNumeroOrdenCompra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblNumeroOrdenCompra.Font = new System.Drawing.Font("Segoe UI Symbol", 16F);
            this.lblNumeroOrdenCompra.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblNumeroOrdenCompra.Location = new System.Drawing.Point(92, 34);
            this.lblNumeroOrdenCompra.Name = "lblNumeroOrdenCompra";
            this.lblNumeroOrdenCompra.Size = new System.Drawing.Size(329, 37);
            this.lblNumeroOrdenCompra.TabIndex = 69;
            this.lblNumeroOrdenCompra.Tag = "116";
            this.lblNumeroOrdenCompra.Text = "Núm. de orden de compra";
            // 
            // btnAgregarProducto
            // 
            this.btnAgregarProducto.BackColor = System.Drawing.Color.Teal;
            this.btnAgregarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarProducto.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarProducto.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnAgregarProducto.Location = new System.Drawing.Point(99, 715);
            this.btnAgregarProducto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAgregarProducto.Name = "btnAgregarProducto";
            this.btnAgregarProducto.Size = new System.Drawing.Size(263, 46);
            this.btnAgregarProducto.TabIndex = 70;
            this.btnAgregarProducto.Text = "Agregar producto";
            this.btnAgregarProducto.UseVisualStyleBackColor = false;
            this.btnAgregarProducto.Click += new System.EventHandler(this.btnAgregarNuevo_Click);
            // 
            // lblCant
            // 
            this.lblCant.AutoSize = true;
            this.lblCant.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblCant.Font = new System.Drawing.Font("Segoe UI Symbol", 8F);
            this.lblCant.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblCant.Location = new System.Drawing.Point(494, 194);
            this.lblCant.Name = "lblCant";
            this.lblCant.Size = new System.Drawing.Size(41, 19);
            this.lblCant.TabIndex = 77;
            this.lblCant.Tag = "116";
            this.lblCant.Text = "Cant.";
            // 
            // nudCantidad
            // 
            this.nudCantidad.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.nudCantidad.Location = new System.Drawing.Point(498, 214);
            this.nudCantidad.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nudCantidad.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudCantidad.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudCantidad.Name = "nudCantidad";
            this.nudCantidad.Size = new System.Drawing.Size(102, 39);
            this.nudCantidad.TabIndex = 76;
            this.nudCantidad.ThousandsSeparator = true;
            this.nudCantidad.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnSeleccionar
            // 
            this.btnSeleccionar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(135)))), ((int)(((byte)(84)))));
            this.btnSeleccionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSeleccionar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeleccionar.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnSeleccionar.Location = new System.Drawing.Point(646, 209);
            this.btnSeleccionar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSeleccionar.Name = "btnSeleccionar";
            this.btnSeleccionar.Size = new System.Drawing.Size(295, 46);
            this.btnSeleccionar.TabIndex = 75;
            this.btnSeleccionar.Text = "Seleccionar";
            this.btnSeleccionar.UseVisualStyleBackColor = false;
            this.btnSeleccionar.Click += new System.EventHandler(this.btnSeleccionar_Click_1);
            // 
            // timerProductoAgregado
            // 
            this.timerProductoAgregado.Tick += new System.EventHandler(this.timerProductoAgregado_Tick);
            // 
            // lblProductoAgregadoTimer
            // 
            this.lblProductoAgregadoTimer.AutoSize = true;
            this.lblProductoAgregadoTimer.Font = new System.Drawing.Font("Segoe UI Symbol", 10F);
            this.lblProductoAgregadoTimer.ForeColor = System.Drawing.Color.MediumSpringGreen;
            this.lblProductoAgregadoTimer.Location = new System.Drawing.Point(778, 175);
            this.lblProductoAgregadoTimer.Name = "lblProductoAgregadoTimer";
            this.lblProductoAgregadoTimer.Size = new System.Drawing.Size(163, 23);
            this.lblProductoAgregadoTimer.TabIndex = 78;
            this.lblProductoAgregadoTimer.Text = "Producto agregado!";
            this.lblProductoAgregadoTimer.Visible = false;
            // 
            // dgvConFiltroProductos
            // 
            this.dgvConFiltroProductos.BackColor = System.Drawing.Color.Transparent;
            this.dgvConFiltroProductos.Location = new System.Drawing.Point(99, 215);
            this.dgvConFiltroProductos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvConFiltroProductos.Name = "dgvConFiltroProductos";
            this.dgvConFiltroProductos.Size = new System.Drawing.Size(847, 487);
            this.dgvConFiltroProductos.TabIndex = 74;
            // 
            // inputNombreFiltroOrdenCompra
            // 
            this.inputNombreFiltroOrdenCompra.BackColor = System.Drawing.Color.Transparent;
            this.inputNombreFiltroOrdenCompra.Location = new System.Drawing.Point(99, 106);
            this.inputNombreFiltroOrdenCompra.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.inputNombreFiltroOrdenCompra.Name = "inputNombreFiltroOrdenCompra";
            this.inputNombreFiltroOrdenCompra.Size = new System.Drawing.Size(259, 68);
            this.inputNombreFiltroOrdenCompra.TabIndex = 1;
            this.inputNombreFiltroOrdenCompra.Texto = "";
            // 
            // ModalSeleccionProdutosOrdenCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1016, 841);
            this.Controls.Add(this.lblProductoAgregadoTimer);
            this.Controls.Add(this.lblCant);
            this.Controls.Add(this.nudCantidad);
            this.Controls.Add(this.btnSeleccionar);
            this.Controls.Add(this.dgvConFiltroProductos);
            this.Controls.Add(this.btnAgregarProducto);
            this.Controls.Add(this.lblNumeroOrdenCompra);
            this.Controls.Add(this.inputNombreFiltroOrdenCompra);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ModalSeleccionProdutosOrdenCompra";
            this.Text = "FormSeleccionProdutosOrdenCompra";
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private ControlesPersonalizados.InputNombreFiltro inputNombreFiltroOrdenCompra;
        private System.Windows.Forms.Label lblNumeroOrdenCompra;
        private System.Windows.Forms.Button btnAgregarProducto;
        private ControlesPersonalizados.DataGridViewConFiltros dgvConFiltroProductos;
        private System.Windows.Forms.Label lblCant;
        private System.Windows.Forms.NumericUpDown nudCantidad;
        private System.Windows.Forms.Button btnSeleccionar;
        private System.Windows.Forms.Timer timerProductoAgregado;
        private System.Windows.Forms.Label lblProductoAgregadoTimer;
    }
}