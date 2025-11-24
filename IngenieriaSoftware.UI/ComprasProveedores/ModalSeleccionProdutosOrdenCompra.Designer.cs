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
            this.timerProductoAgregado = new System.Windows.Forms.Timer(this.components);
            this.dgvConFiltroProductos = new IngenieriaSoftware.UI.ControlesPersonalizados.DataGridViewConFiltros();
            this.btnAgregarProducto = new System.Windows.Forms.Button();
            this.lblProductoAgregadoTimer = new System.Windows.Forms.Label();
            this.inputNombreFiltroOrdenCompra = new IngenieriaSoftware.UI.ControlesPersonalizados.InputNombreFiltro();
            this.SuspendLayout();
            // 
            // lblNumeroOrdenCompra
            // 
            this.lblNumeroOrdenCompra.AutoSize = true;
            this.lblNumeroOrdenCompra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblNumeroOrdenCompra.Font = new System.Drawing.Font("Segoe UI Symbol", 16F);
            this.lblNumeroOrdenCompra.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblNumeroOrdenCompra.Location = new System.Drawing.Point(69, 31);
            this.lblNumeroOrdenCompra.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNumeroOrdenCompra.Name = "lblNumeroOrdenCompra";
            this.lblNumeroOrdenCompra.Size = new System.Drawing.Size(271, 30);
            this.lblNumeroOrdenCompra.TabIndex = 69;
            this.lblNumeroOrdenCompra.Tag = "1296";
            this.lblNumeroOrdenCompra.Text = "Núm. de orden de compra";
            // 
            // timerProductoAgregado
            // 
            this.timerProductoAgregado.Tick += new System.EventHandler(this.timerProductoAgregado_Tick);
            // 
            // dgvConFiltroProductos
            // 
            this.dgvConFiltroProductos.BackColor = System.Drawing.Color.Transparent;
            this.dgvConFiltroProductos.Location = new System.Drawing.Point(51, 107);
            this.dgvConFiltroProductos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvConFiltroProductos.Name = "dgvConFiltroProductos";
            this.dgvConFiltroProductos.Size = new System.Drawing.Size(1016, 282);
            this.dgvConFiltroProductos.TabIndex = 79;
            this.dgvConFiltroProductos.Tag = "1298";
            this.dgvConFiltroProductos.TamanoGrilla = IngenieriaSoftware.UI.ControlesPersonalizados.grillaCustom.ModoTamanoGrilla.Grande;
            // 
            // btnAgregarProducto
            // 
            this.btnAgregarProducto.BackColor = System.Drawing.Color.Teal;
            this.btnAgregarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarProducto.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarProducto.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnAgregarProducto.Location = new System.Drawing.Point(74, 566);
            this.btnAgregarProducto.Margin = new System.Windows.Forms.Padding(2);
            this.btnAgregarProducto.Name = "btnAgregarProducto";
            this.btnAgregarProducto.Size = new System.Drawing.Size(197, 37);
            this.btnAgregarProducto.TabIndex = 1;
            this.btnAgregarProducto.Tag = "1300";
            this.btnAgregarProducto.Text = "Agregar producto";
            this.btnAgregarProducto.UseVisualStyleBackColor = false;
            this.btnAgregarProducto.Click += new System.EventHandler(this.btnAgregarProducto_Click);
            // 
            // lblProductoAgregadoTimer
            // 
            this.lblProductoAgregadoTimer.AutoSize = true;
            this.lblProductoAgregadoTimer.Font = new System.Drawing.Font("Segoe UI Symbol", 14F);
            this.lblProductoAgregadoTimer.ForeColor = System.Drawing.Color.MediumSpringGreen;
            this.lblProductoAgregadoTimer.Location = new System.Drawing.Point(288, 119);
            this.lblProductoAgregadoTimer.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblProductoAgregadoTimer.Name = "lblProductoAgregadoTimer";
            this.lblProductoAgregadoTimer.Size = new System.Drawing.Size(180, 25);
            this.lblProductoAgregadoTimer.TabIndex = 81;
            this.lblProductoAgregadoTimer.Tag = "1295";
            this.lblProductoAgregadoTimer.Text = "Producto agregado!";
            this.lblProductoAgregadoTimer.Visible = false;
            // 
            // inputNombreFiltroOrdenCompra
            // 
            this.inputNombreFiltroOrdenCompra.BackColor = System.Drawing.Color.Transparent;
            this.inputNombreFiltroOrdenCompra.Location = new System.Drawing.Point(554, 49);
            this.inputNombreFiltroOrdenCompra.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.inputNombreFiltroOrdenCompra.Name = "inputNombreFiltroOrdenCompra";
            this.inputNombreFiltroOrdenCompra.Size = new System.Drawing.Size(194, 55);
            this.inputNombreFiltroOrdenCompra.TabIndex = 0;
            this.inputNombreFiltroOrdenCompra.Tag = "1297";
            this.inputNombreFiltroOrdenCompra.Texto = "";
            // 
            // ModalSeleccionProdutosOrdenCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(938, 683);
            this.Controls.Add(this.inputNombreFiltroOrdenCompra);
            this.Controls.Add(this.lblProductoAgregadoTimer);
            this.Controls.Add(this.btnAgregarProducto);
            this.Controls.Add(this.dgvConFiltroProductos);
            this.Controls.Add(this.lblNumeroOrdenCompra);
            this.Name = "ModalSeleccionProdutosOrdenCompra";
            this.Tag = "1299";
            this.Text = "FormSeleccionProdutosOrdenCompra";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblNumeroOrdenCompra;
        private System.Windows.Forms.Timer timerProductoAgregado;
        private ControlesPersonalizados.DataGridViewConFiltros dgvConFiltroProductos;
        private System.Windows.Forms.Button btnAgregarProducto;
        private System.Windows.Forms.Label lblProductoAgregadoTimer;
        private ControlesPersonalizados.InputNombreFiltro inputNombreFiltroOrdenCompra;
    }
}